using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.Serialization;

namespace csharp_File_Shredder
{
    public partial class MainForm : Form
    {

        #region Header

        const int MAX_UNSIGNED_SHORT = 65535;

        int lastFileWipedIndex;

        //thread args struct/array lookup table
        [Flags]
        public enum ThreadArgs : int
        {
            FILES = 0, //array of strings that contain the full path to every file to delete
            MODE = 1, //0 = random data, 1 = zero'd
            BUFFER_SIZE = 2, //size of data to wipe per pass
            TOTAL_SIZE = 3, //total amount of data to wipe
            PASSES = 4,  //total number of passes
        }

        //Passes to id dropdown lookup table
        [Flags]
        public enum PassesIndex : int
        {
            DEFAULT = 0,
            DOD = 1,
            NSA = 2,
            GUTTMAN = 3,
        }

        //passes lookup table
        [Flags]
        public enum Passes : int
        {
            DEFAULT = 1,
            DOD = 3,
            NSA = 7,
            GUTTMAN = 35,
        }

        //Delegate prototypes for safe GUI / threading
        public delegate void RemoveCompletedItems(int index);
        public delegate void UpdateLVPBarDelegate(int index, int value);
        public delegate void UpdatePBarDelegate(int value);
        public delegate void CleaningCompleteDelegate(UInt64 total_bytes_shredded, DateTime StartTime);

        public MainForm()
        {
            InitializeComponent();

            lastFileWipedIndex = -1;

            cboxPasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxMethod.DropDownStyle = ComboBoxStyle.DropDownList;

            cboxPasses.Refresh();
            cboxMethod.Refresh();
        }
        #endregion

        #region User Functions

        /***********************************************************************
         * 
         * @method: ResetListviewFiles
         * @notes: resets and refreshes main listview
         * 
         ************************************************************************/

        private void ResetListviewFiles()
        {
            listViewFiles.RemoveAllControls(); //also removes listview items
            listViewFiles.Refresh();
        }

        /***********************************************************************
         * 
         * @method: RemoveCompletedItemsMethod
         * @param: index : int - the index/iteration of the file within the shredder loop
         * @notes: removes the first item in the listview, fires when an item is deleted
         * 
         ************************************************************************/

        private void RemoveCompletedItemsMethod(int index)
        {
            if (this.InvokeRequired) {
                this.Invoke(new RemoveCompletedItems(RemoveCompletedItemsMethod), new Object[] { index });
                return;
            }

            if (listViewFiles.Items.Count == 0) {
                return;
            }

            if (lastFileWipedIndex == index) {
                return;
            }

            lastFileWipedIndex = index;

            listViewFiles.RemoveFirst();
            listViewFiles.Refresh();
        }

        /***********************************************************************
         * 
         * @method: CleaningComplete
         * @param:  total_bytes_shredded : long - the total number of bytes deleted
         * @param: StartTime : DateTime - the time we started shredding
         * @notes: "event" to fire when we finish cleaning, to update texts and other stuff
         * 
         ************************************************************************/

        private void CleaningComplete(UInt64 total_bytes_shredded, DateTime StartTime)
        {
            if (this.InvokeRequired) {
                this.Invoke(new CleaningCompleteDelegate(CleaningComplete), new Object[] { total_bytes_shredded, StartTime });
                return;
            }

            TimeSpan TimeTaken = DateTime.Now - StartTime;
            double total_kilobytes = (total_bytes_shredded / 1024);
            double total_megabytes = (total_kilobytes / 1024);
            double MBps = total_megabytes / TimeTaken.TotalSeconds;

            lbldynAmountShredded.Text = Helper.FormatKiloBytes(total_kilobytes);
            lbldynTimeTaken.Text = Helper.FormatMiliseconds(TimeTaken.TotalMilliseconds);
            lbldynSpeed.Text = Helper.FormatMBps(MBps); //do a check for speeds

            UpdateMainPBar(0);
            ResetListviewFiles();
            btnShred.Enabled = true;
        }

        /***********************************************************************
         * 
         * @method: UpdateMainPBar
         * @param:  value : int - the value to set the main progress bar to
         * @notes:  sets main progress bar to specified value
         * 
         ************************************************************************/

        public void UpdateMainPBar(int value)
        {
            if (this.InvokeRequired) {
                this.Invoke(new UpdatePBarDelegate(UpdateMainPBar), new Object[] { value });
                return;
            }

            if (pbarMain == null) {
                return;
            }

            pbarMain.Value = (value > 100) ? 100 : value;
            pbarMain.Refresh();
        }

        /***********************************************************************
         * 
         * @method: UpdateLVPBar
         * @param:  index : int - row index of the embedded control within the listview
         * @param:  value : int - value to set the progress bar to
         * @notes:  updates a progress bar to a given value at a given index
         * 
         ************************************************************************/

        private void UpdateLVPBar(int index, int value)
        {
            if (this.InvokeRequired) {
                this.Invoke(new UpdateLVPBarDelegate(UpdateLVPBar), new Object[] { index, value });
                return;
            }

            try {
                if (listViewFiles.Items.Count < 0) {
                    return;
                }

                CustomProgressBar pb = (CustomProgressBar)listViewFiles.GetEmbeddedControl(2, index);

                if (pb == null) {
                    return;
                }

                pb.Value = (value > 100) ? 100 : value;
                pb.Refresh();
            } catch (System.Exception ex) {
                MessageBox.Show("UpdateLVPBar " + ex.Message);
            }
        }

        /***********************************************************************
         * 
         * @method: addItemToListviewEx
         * @param:  file : string - filename to put in listview
         * @notes:  puts listview item on listview, then progress bar on listview item
         * 
         ************************************************************************/

        private void addItemToListviewEx(string file)
        {
            //Add list view item
            listViewFiles.Items.Add(new ListViewItem(new string[] { file, Helper.FormatedFileSize(file) }));

            //Add progress bar to the list view
            addProgressBarToListviewEx(2, listViewFiles.Items.Count - 1);
        }

        /***********************************************************************
         * 
         * @method: addProgressBarToListviewEx
         * @param:  col : int - the column in the listview
         * @param:  row : int - the row in the listview
         * @notes:  adds a progress bar onto a listview at a specified col/row
         * 
         ************************************************************************/

        private void addProgressBarToListviewEx(int col, int row)
        {
            if (listViewFiles == null) {
                return;
            }

            listViewFiles.AddEmbeddedControl(new CustomProgressBar(false), col, row);
            colProgressBar.Width = 100;
        }

        /***********************************************************************
         * 
         * @method: RemoveSelectedListviewItems
         * @notes:  Removes items that are selected from our main listview
         * 
         ************************************************************************/

        private void RemoveSelectedListviewItems()
        {
            if (listViewFiles.SelectedItems.Count <= 0) {
                return;
            }

            foreach (ListViewItem lvi in listViewFiles.SelectedItems) {
                listViewFiles.RemoveItem(lvi.Index);
            }
        }

        #endregion

        #region Events

        private void btnShred_Click(object sender, EventArgs e)
        {
            ArrayList elements = Helper.GetListViewElements(listViewFiles, 0);

            if (elements.Count > 0) {
                btnShred.Enabled = false;

                //build the arguments to pass to the thread that shreds.
                ArrayList worker_args = new ArrayList();
                UInt64 mode = (UInt64)cboxMethod.SelectedIndex;

                worker_args.Add(elements);                  //elements
                worker_args.Add(mode);                      //mode

                //buffer size
                if (UInt64.TryParse(txtboxBufferSize.Text, out ulong iBuffersize)) {
                    worker_args.Add(iBuffersize);
                } else {
                    //default buffer
                    iBuffersize = MAX_UNSIGNED_SHORT;
                    worker_args.Add(iBuffersize);
                    txtboxBufferSize.Text = iBuffersize.ToString();
                }

                //total size
                worker_args.Add(Helper.GetFileSizeInBytesFromFileList(elements));

                //passes
                int passes = 1;
                if (cboxPasses.SelectedIndex.Equals(PassesIndex.DOD)) {
                    passes = (int)Passes.DOD;
                } else if (cboxPasses.SelectedIndex.Equals(PassesIndex.NSA)) {
                    passes = (int)Passes.NSA;
                } else if (cboxPasses.SelectedIndex.Equals(PassesIndex.GUTTMAN)) {
                    passes = (int)Passes.GUTTMAN;
                }

                worker_args.Add(passes);

                //Start the shredder thread and pass the data to it
                Thread threadFileShredder = new Thread(new ParameterizedThreadStart(FileShredderThread));
                threadFileShredder.Priority = ThreadPriority.Highest;
                threadFileShredder.Start(worker_args);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetListviewFiles();

            lbldynTimeTaken.Text = "0 ms";
            lbldynSpeed.Text = "0 MBps";
            lbldynAmountShredded.Text = "0 KB";

            UpdateMainPBar(0);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedListviewItems();
        }

        private void listViewFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files) {
                if (Helper.IsDirectory(file)) {
                    ArrayList sub_files = Helper.GetFileNamesInDirectory(file, true, true);
                    foreach (string s in sub_files) {
                        addItemToListviewEx(s);
                    }
                } else {
                    addItemToListviewEx(file);
                }
            }
        }

        private void listViewFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false)) {
                e.Effect = DragDropEffects.All;
            }
        }

        private void txtboxBufferSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void openFileDialog1_FileOk(object sender, EventArgs e)
        {
            string[] files = openFileDialog.FileNames;

            if (files.Count() > 0) {
                foreach (string file in files) {
                    addItemToListviewEx(file);
                }
            }
        }

        private void lblXPL0_MouseEnter(object sender, EventArgs e)
        {
            lblXPL0.ForeColor = Color.LimeGreen;
        }

        private void lblXPL0_MouseLeave(object sender, EventArgs e)
        {
            if (lblXPL0.ForeColor.Equals(Color.LimeGreen)) {
                lblXPL0.ForeColor = Color.FromName("ControlText");
            }
        }

        private void lblACCELA_MouseEnter(object sender, EventArgs e)
        {
            lblACCELA.ForeColor = Color.Fuchsia;
        }

        private void lblACCELA_MouseLeave(object sender, EventArgs e)
        {
            if (lblACCELA.ForeColor.Equals(Color.Fuchsia)) {
                lblACCELA.ForeColor = Color.FromName("ControlText");
            }
        }

        private void listViewFiles_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex.Equals(2)) {
                e.NewWidth = 100;
                e.Cancel = true;
            } else if (e.ColumnIndex.Equals(1)) {
                e.NewWidth = 83;
                e.Cancel = true;
            } else if (e.ColumnIndex.Equals(0)) {
                e.NewWidth = 275;
                e.Cancel = true;
            }
        }

        private void listViewFiles_SizeChanged(object sender, EventArgs e)
        {
            colFileSize.Width = 83;
            colProgressBar.Width = 100;
            colFileName.Width = (listViewFiles.Width - 25) - (colFileSize.Width + colProgressBar.Width);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedListviewItems();
        }

        #endregion

        #region Shredder

        /***********************************************************************
         * 
         * @method: FileShredderThread
         * @param: arg : object - Array / struct data passed to the thread containing everything it needs
         * @notes: The heart of the beast
         * 
         ************************************************************************/

        void FileShredderThread(object arg)
        {
            int file_index = 0;
            UInt64 total_data_written = 0;
            UInt64 total_bytes_shredded = 0;
            ArrayList arg_list = (ArrayList)arg;
            ArrayList files = (ArrayList)arg_list[(int)ThreadArgs.FILES];
            UInt64 mode = Convert.ToUInt64(arg_list[(int)ThreadArgs.MODE]);
            UInt64 passes = Convert.ToUInt64(arg_list[(int)ThreadArgs.PASSES]);
            UInt64 buf_size = Convert.ToUInt64(arg_list[(int)ThreadArgs.BUFFER_SIZE]);
            UInt64 total_data_to_write = Convert.ToUInt64(arg_list[(int)ThreadArgs.TOTAL_SIZE]);
            total_data_to_write *= passes;
            DateTime StartTime = DateTime.Now;

            foreach (string file in files) {
                UInt64 amount_written_to_current_element = 0;

                try {
                    FileInfo fi = new FileInfo(file);

                    if (fi.Exists) {
                        for (UInt32 i_pass = 1; i_pass <= passes; i_pass++) {
                            UInt64 file_length = (UInt64)fi.Length;
                            total_bytes_shredded += file_length;
                            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Write);

                            byte[] buff = new byte[buf_size];

                            if (file_length > buf_size) {
                                UInt64 total_iterations = file_length / buf_size;
                                UInt32 current_iteration = 0;
                                for (; current_iteration <= total_iterations; current_iteration++) {
                                    total_data_written += buf_size;
                                    amount_written_to_current_element += buf_size;

                                    if (current_iteration % 10 == 0) {
                                        UInt64 total_progress_percent = (total_data_written / total_data_to_write) * 100;
                                        UInt64 current_percent = (amount_written_to_current_element / ((UInt64)fi.Length * passes) * 100);
                                        UpdateMainPBar((int)total_progress_percent);
                                        UpdateLVPBar(file_index, (int)current_percent);
                                    }

                                    if (mode.Equals(0)) {
                                        RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
                                        rngCsp.GetBytes(buff);
                                    }
                                    fs.Write(buff, 0, (int)buf_size);
                                }
                            } else {
                                fs.Write(buff, 0, (int)buf_size);
                            }
                            fs.Flush();
                            fs.Close();

                            //UNCOMMENT THESE TO DELETE FILE
                            if (i_pass.Equals(passes)) {
                                fi.Delete();
                            }
                        }
                    }
                } catch (System.IO.IOException ioException) {
                    MessageBox.Show("FileShredderThread " + ioException.Message);
                } catch (Exception except) {
                    MessageBox.Show("FileShredderThread " + except.Message);
                }
                RemoveCompletedItemsMethod(file_index);
                file_index++;
            }
            CleaningComplete(total_bytes_shredded, StartTime);
        }
        #endregion
    }

    #region CustomProgressBar

    /***********************************************************************
    * 
    * @class: CustomProgressBar
    * @extends: ProgressBar
    * @notes: Extends Progress bar and adds a textual % onto the control
    * 
    ************************************************************************/

    public class CustomProgressBar : ProgressBar
    {
        private readonly bool bDrawText;

        private void SetStyle()
        {
            this.SetStyle(ControlStyles.DoubleBuffer
                        | ControlStyles.AllPaintingInWmPaint
                        | ControlStyles.UserPaint
                        | ControlStyles.OptimizedDoubleBuffer
                        | ControlStyles.ResizeRedraw
                        | ControlStyles.SupportsTransparentBackColor, true);
        }

        public CustomProgressBar()
        {
            SetStyle();
            bDrawText = true;
        }

        public CustomProgressBar(bool drawtext)
        {
            SetStyle();
            bDrawText = drawtext;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = this.ClientRectangle;
            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, bounds);

            if (this.Value > 0) {
                Rectangle clip = new Rectangle((int)bounds.X + 1, (int)bounds.Y + 1, (int)(((float)this.Value / (float)this.Maximum) * (float)bounds.Width - 2), (int)bounds.Height - 2);
                ProgressBarRenderer.DrawHorizontalChunks(e.Graphics, clip);

                if (bDrawText) {
                    e.Graphics.DrawString(this.Value.ToString("F00") + "%", new Font("Lucida Console", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(Width / 2 - 13, Height / 2 - 6));
                }
            }
        }
    }
    #endregion
}

