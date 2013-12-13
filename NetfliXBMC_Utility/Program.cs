using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NetfliXBMC_Utility
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 frm = new Form1(args);
            Application.Run();
        }
    }
}
