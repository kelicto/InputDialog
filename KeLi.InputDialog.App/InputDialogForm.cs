using System.Windows.Forms;

namespace KeLi.InputDialog.App
{
    public partial class InputDialogForm : Form
    {
        public TextEventHandler TextHandler;

        public InputDialogForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            if (TextHandler == null)
                return;

            TextHandler.Invoke(txtInput.Text);
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Keys.Enter != (Keys)e.KeyChar)
                return;

            if (TextHandler == null)
                return;
            TextHandler.Invoke(txtInput.Text);
            DialogResult = DialogResult.OK;
        }
    }
}