using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace csharp_File_Shredder
{
    static class Helper
    {
        public static ArrayList GetListViewElements(ListView lv, int i)
        {
            ArrayList ret = new ArrayList();

            foreach (ListViewItem lvi in lv.Items) {
                if (i < lvi.SubItems.Count) {
                    ret.Add(lvi.SubItems[i].Text);
                }
            }
            return ret;
        }

        public static double GetFileSizeInBytesFromFileList(ArrayList files)
        {
            double return_value = 0;

            if (files.Count > 0) {
                foreach (string file in files) {
                    FileInfo fileInfo = new FileInfo(file);
                    return_value += fileInfo.Length;
                }
            }
            return return_value;
        }

        public static string FormatedFileSize(string fileName)
        {
            try {
                FileInfo fileInfo = new FileInfo(fileName);
                double fileSize = (fileInfo.Length / 1024.0);

                if (fileSize < 1024) {
                    return fileSize.ToString("F01") + " kB";
                } else {
                    fileSize /= 1024.0;

                    if (fileSize < 1024) {
                        return fileSize.ToString("F01") + " MB";
                    } else {
                        fileSize /= 1024;
                        return fileSize.ToString("F01") + " GB";
                    }
                }
            } catch (System.Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return "0kB";
        }

        public static bool IsDirectory(string path)
        {
            if (Directory.Exists(path)) {
                return true;
            }
            return false;
        }

        public static string FormatKiloBytes(double size)
        {
            if (size < 1024) {
                return size.ToString("F01") + " kB";
            } else {
                size /= 1024.0;

                if (size < 1024) {
                    return size.ToString("F01") + " MB";
                } else {
                    size /= 1024;
                    return size.ToString("F01") + " GB";
                }
            }
        }

        public static string FormatMiliseconds(double miliseconds)
        {
            if (miliseconds < 1000) {
                return miliseconds.ToString("F01") + " ms";
            } else {
                miliseconds /= 1000;

                if (miliseconds < 60) {
                    return miliseconds.ToString("F01") + " s";
                } else {
                    miliseconds /= 60;

                    if (miliseconds < 60) {
                        return miliseconds.ToString("F01") + " m";
                    } else {
                        miliseconds /= 60;
                        return miliseconds.ToString("F01") + " h";
                    }
                }
            }
        }

        public static string FormatMBps(double MBps)
        {
            return MBps.ToString("F01") + " MBps";
        }

        public static ArrayList GetFileNamesInDirectory(String Path, bool Recursive, bool FullPath)
        {
            ArrayList files = new ArrayList();
            DirectoryInfo directory = new DirectoryInfo(Path);

            if (directory.Exists) {
                foreach (FileInfo file in directory.GetFiles()) {
                    if (FullPath) {
                        if (!files.Contains(Path + "\\" + file.Name)) {
                            files.Add(Path + "\\" + file.Name);
                        } else if (!files.Contains(file.Name)) {
                            files.Add(file.Name);
                        }
                    }
                }

                if (Recursive) {
                    foreach (DirectoryInfo subDirectory in directory.GetDirectories()) {
                        foreach (Object o in GetFileNamesInDirectory(Path + "\\" + subDirectory.Name, true, FullPath)) {
                            if (!files.Contains(o.ToString())) {
                                files.Add(o.ToString());
                            }
                        }
                    }
                }
            }
            return files;
        }
    }
}
