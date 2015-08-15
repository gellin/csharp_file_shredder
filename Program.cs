#region Title

///////////////////////////////////////////////
//   ________        .__   .__   .__         //
//  /  XPL0_/  ____  |  |  |  |  |__| ____   //
// /   \  ____/ __ \ |  |  |  |  |  |/    \  //
// \    \_\  \  ___/ |  |__|  |__|  |   |  \ //
//  \______  /\___  >|____/|____/|__|___|  / //
//         \/     \/                     \/  //
///////////////////////////////////////////////

#endregion

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
