using System;
using System.Windows.Forms;
using KeLi.InputDialog.App.Forms;

namespace KeLi.InputDialog.App
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}