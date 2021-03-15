using System.Windows.Forms;
using KeLi.InputDialog.App.Forms;

namespace KeLi.InputDialog.App.Utils
{
    public static class InputDialog
    {
        public static DialogResult Show(out string text)
        {
            var temp = string.Empty;
            var dlg = new InputDialogForm { TextHandler = t => { temp = t; } };

            text = temp;

            return dlg.ShowDialog();
        }
    }
}