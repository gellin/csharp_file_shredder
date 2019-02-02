namespace csharp_File_Shredder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnShred = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblXPL0 = new System.Windows.Forms.Label();
            this.chkShowFullPath = new System.Windows.Forms.CheckBox();
            this.txtboxBufferSize = new System.Windows.Forms.TextBox();
            this.lblBufferSize = new System.Windows.Forms.Label();
            this.lblKB = new System.Windows.Forms.Label();
            this.lblAmountToShred = new System.Windows.Forms.Label();
            this.lbldynAmountShredded = new System.Windows.Forms.Label();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.lbldynTimeTaken = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblPasses = new System.Windows.Forms.Label();
            this.cboxPasses = new System.Windows.Forms.ComboBox();
            this.lbldynSpeed = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cboxMethod = new System.Windows.Forms.ComboBox();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblACCELA = new System.Windows.Forms.Label();
            this.lblAnd = new System.Windows.Forms.Label();
            this.pbarMain = new csharp_File_Shredder.CustomProgressBar();
            this.listViewFiles = new csharp_File_Shredder.ListViewEx();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProgressBar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShred
            // 
            this.btnShred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShred.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShred.Location = new System.Drawing.Point(381, 294);
            this.btnShred.Name = "btnShred";
            this.btnShred.Size = new System.Drawing.Size(96, 23);
            this.btnShred.TabIndex = 1;
            this.btnShred.Text = "Run";
            this.btnShred.UseVisualStyleBackColor = true;
            this.btnShred.Click += new System.EventHandler(this.btnShred_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(147, 203);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblXPL0
            // 
            this.lblXPL0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblXPL0.AutoSize = true;
            this.lblXPL0.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXPL0.Location = new System.Drawing.Point(221, 364);
            this.lblXPL0.Name = "lblXPL0";
            this.lblXPL0.Size = new System.Drawing.Size(33, 11);
            this.lblXPL0.TabIndex = 4;
            this.lblXPL0.Text = "XPL0";
            this.lblXPL0.MouseEnter += new System.EventHandler(this.lblXPL0_MouseEnter);
            this.lblXPL0.MouseLeave += new System.EventHandler(this.lblXPL0_MouseLeave);
            // 
            // chkShowFullPath
            // 
            this.chkShowFullPath.AutoSize = true;
            this.chkShowFullPath.Enabled = false;
            this.chkShowFullPath.Location = new System.Drawing.Point(606, 307);
            this.chkShowFullPath.Name = "chkShowFullPath";
            this.chkShowFullPath.Size = new System.Drawing.Size(97, 17);
            this.chkShowFullPath.TabIndex = 5;
            this.chkShowFullPath.Text = "Show Full Path";
            this.chkShowFullPath.UseVisualStyleBackColor = true;
            this.chkShowFullPath.Visible = false;
            // 
            // txtboxBufferSize
            // 
            this.txtboxBufferSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxBufferSize.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBufferSize.Location = new System.Drawing.Point(118, 241);
            this.txtboxBufferSize.Name = "txtboxBufferSize";
            this.txtboxBufferSize.Size = new System.Drawing.Size(58, 18);
            this.txtboxBufferSize.TabIndex = 6;
            this.txtboxBufferSize.Text = "65535";
            this.txtboxBufferSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxBufferSize_KeyPress);
            // 
            // lblBufferSize
            // 
            this.lblBufferSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBufferSize.AutoSize = true;
            this.lblBufferSize.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferSize.Location = new System.Drawing.Point(13, 244);
            this.lblBufferSize.Name = "lblBufferSize";
            this.lblBufferSize.Size = new System.Drawing.Size(89, 11);
            this.lblBufferSize.TabIndex = 7;
            this.lblBufferSize.Text = "Buffer Size:";
            // 
            // lblKB
            // 
            this.lblKB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKB.Location = new System.Drawing.Point(177, 244);
            this.lblKB.Name = "lblKB";
            this.lblKB.Size = new System.Drawing.Size(48, 11);
            this.lblKB.TabIndex = 8;
            this.lblKB.Text = "bytes";
            // 
            // lblAmountToShred
            // 
            this.lblAmountToShred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountToShred.AutoSize = true;
            this.lblAmountToShred.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToShred.Location = new System.Drawing.Point(309, 218);
            this.lblAmountToShred.Name = "lblAmountToShred";
            this.lblAmountToShred.Size = new System.Drawing.Size(117, 11);
            this.lblAmountToShred.TabIndex = 11;
            this.lblAmountToShred.Text = "Amount Shredded:";
            // 
            // lbldynAmountShredded
            // 
            this.lbldynAmountShredded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldynAmountShredded.AutoSize = true;
            this.lbldynAmountShredded.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldynAmountShredded.Location = new System.Drawing.Point(429, 218);
            this.lbldynAmountShredded.Name = "lbldynAmountShredded";
            this.lbldynAmountShredded.Size = new System.Drawing.Size(33, 11);
            this.lbldynAmountShredded.TabIndex = 12;
            this.lbldynAmountShredded.Text = "0 kB";
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTaken.Location = new System.Drawing.Point(344, 244);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(82, 11);
            this.lblTimeTaken.TabIndex = 13;
            this.lblTimeTaken.Text = "Time taken:";
            // 
            // lbldynTimeTaken
            // 
            this.lbldynTimeTaken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldynTimeTaken.AutoSize = true;
            this.lbldynTimeTaken.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldynTimeTaken.Location = new System.Drawing.Point(429, 244);
            this.lbldynTimeTaken.Name = "lbldynTimeTaken";
            this.lbldynTimeTaken.Size = new System.Drawing.Size(33, 11);
            this.lbldynTimeTaken.TabIndex = 14;
            this.lbldynTimeTaken.Text = "0 ms";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.pbarMain);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.lblPasses);
            this.groupBox1.Controls.Add(this.cboxPasses);
            this.groupBox1.Controls.Add(this.lbldynSpeed);
            this.groupBox1.Controls.Add(this.lblSpeed);
            this.groupBox1.Controls.Add(this.lblMethod);
            this.groupBox1.Controls.Add(this.cboxMethod);
            this.groupBox1.Controls.Add(this.lbldynTimeTaken);
            this.groupBox1.Controls.Add(this.lblTimeTaken);
            this.groupBox1.Controls.Add(this.lbldynAmountShredded);
            this.groupBox1.Controls.Add(this.lblAmountToShred);
            this.groupBox1.Controls.Add(this.lblKB);
            this.groupBox1.Controls.Add(this.lblBufferSize);
            this.groupBox1.Controls.Add(this.txtboxBufferSize);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnShred);
            this.groupBox1.Controls.Add(this.listViewFiles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 356);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(81, 203);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 23);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(15, 203);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(60, 23);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblPasses
            // 
            this.lblPasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPasses.AutoSize = true;
            this.lblPasses.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasses.Location = new System.Drawing.Point(13, 296);
            this.lblPasses.Name = "lblPasses";
            this.lblPasses.Size = new System.Drawing.Size(96, 11);
            this.lblPasses.TabIndex = 20;
            this.lblPasses.Text = "Total Passes:";
            // 
            // cboxPasses
            // 
            this.cboxPasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxPasses.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPasses.FormattingEnabled = true;
            this.cboxPasses.Items.AddRange(new object[] {
            "1 Pass",
            "DOD (3 Passes)",
            "NSA (7 Passes)",
            "Gutmann (35 Passes)"});
            this.cboxPasses.Location = new System.Drawing.Point(119, 294);
            this.cboxPasses.Name = "cboxPasses";
            this.cboxPasses.Size = new System.Drawing.Size(158, 19);
            this.cboxPasses.TabIndex = 16;
            this.cboxPasses.Text = "1 Pass";
            // 
            // lbldynSpeed
            // 
            this.lbldynSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldynSpeed.AutoSize = true;
            this.lbldynSpeed.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldynSpeed.Location = new System.Drawing.Point(430, 270);
            this.lbldynSpeed.Name = "lbldynSpeed";
            this.lbldynSpeed.Size = new System.Drawing.Size(47, 11);
            this.lbldynSpeed.TabIndex = 19;
            this.lbldynSpeed.Text = "0 MBps";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(379, 270);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(47, 11);
            this.lblSpeed.TabIndex = 18;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblMethod
            // 
            this.lblMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(13, 270);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(89, 11);
            this.lblMethod.TabIndex = 17;
            this.lblMethod.Text = "Buffer Data:";
            // 
            // cboxMethod
            // 
            this.cboxMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxMethod.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMethod.FormattingEnabled = true;
            this.cboxMethod.Items.AddRange(new object[] {
            "Random",
            "Zero"});
            this.cboxMethod.Location = new System.Drawing.Point(118, 267);
            this.cboxMethod.Name = "cboxMethod";
            this.cboxMethod.Size = new System.Drawing.Size(89, 19);
            this.cboxMethod.TabIndex = 1;
            this.cboxMethod.Text = "Random";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(118, 26);
            this.contextMenuStripMain.Text = "nigger";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Select a file to shred";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblACCELA
            // 
            this.lblACCELA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblACCELA.AutoSize = true;
            this.lblACCELA.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACCELA.Location = new System.Drawing.Point(273, 364);
            this.lblACCELA.Name = "lblACCELA";
            this.lblACCELA.Size = new System.Drawing.Size(47, 11);
            this.lblACCELA.TabIndex = 16;
            this.lblACCELA.Text = "Accela";
            this.lblACCELA.MouseEnter += new System.EventHandler(this.lblACCELA_MouseEnter);
            this.lblACCELA.MouseLeave += new System.EventHandler(this.lblACCELA_MouseLeave);
            // 
            // lblAnd
            // 
            this.lblAnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAnd.AutoSize = true;
            this.lblAnd.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnd.Location = new System.Drawing.Point(254, 364);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(19, 11);
            this.lblAnd.TabIndex = 17;
            this.lblAnd.Text = "&&&&";
            // 
            // pbarMain
            // 
            this.pbarMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbarMain.Location = new System.Drawing.Point(14, 328);
            this.pbarMain.Name = "pbarMain";
            this.pbarMain.Size = new System.Drawing.Size(489, 20);
            this.pbarMain.TabIndex = 21;
            // 
            // listViewFiles
            // 
            this.listViewFiles.AllowDrop = true;
            this.listViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFiles.AutoArrange = false;
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colFileSize,
            this.colProgressBar});
            this.listViewFiles.ContextMenuStrip = this.contextMenuStripMain;
            this.listViewFiles.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.Location = new System.Drawing.Point(14, 19);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(489, 177);
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listViewFiles_ColumnWidthChanged);
            this.listViewFiles.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewFiles_ColumnWidthChanging);
            this.listViewFiles.SizeChanged += new System.EventHandler(this.listViewFiles_SizeChanged);
            this.listViewFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewFiles_DragDrop);
            this.listViewFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewFiles_DragEnter);
            // 
            // colFileName
            // 
            this.colFileName.Text = "File Name";
            this.colFileName.Width = 275;
            // 
            // colFileSize
            // 
            this.colFileSize.Text = "FileSize";
            this.colFileSize.Width = 83;
            // 
            // colProgressBar
            // 
            this.colProgressBar.Text = "Progress";
            this.colProgressBar.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAnd);
            this.Controls.Add(this.lblACCELA);
            this.Controls.Add(this.lblXPL0);
            this.Controls.Add(this.chkShowFullPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(556, 415);
            this.Name = "MainForm";
            this.Text = "C# File Shredder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public csharp_File_Shredder.ListViewEx listViewFiles;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.Button btnShred;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblXPL0;
        private System.Windows.Forms.CheckBox chkShowFullPath;
        private System.Windows.Forms.TextBox txtboxBufferSize;
        private System.Windows.Forms.Label lblBufferSize;
        private System.Windows.Forms.Label lblKB;
        private System.Windows.Forms.Label lblAmountToShred;
        private System.Windows.Forms.Label lbldynAmountShredded;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Label lbldynTimeTaken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cboxMethod;
        private System.Windows.Forms.Label lbldynSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPasses;
        private System.Windows.Forms.ComboBox cboxPasses;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblACCELA;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.Button btnRemove;
        public csharp_File_Shredder.CustomProgressBar pbarMain;
        private System.Windows.Forms.ColumnHeader colProgressBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

