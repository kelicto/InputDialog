using System.Windows.Forms;

namespace KeLi.InputDialog.App
{
    public static class InputDialog
    {
        public static DialogResult Show(out string text)
        {
            var temp = string.Empty;
            var dlg = new InputDialogForm { TextHandler = t => { temp = t; } };
            var result = dlg.ShowDialog();

            text = temp;

            return result;
        }
    }
}