using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace csharp_File_Shredder
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
