using System;
using System.Windows.Forms;
using KeLi.InputDialog.App.Utils;

namespace KeLi.InputDialog.App.Forms
{
    public partial class InputDialogForm : Form
    {
        public InputDialogForm()
        {
            InitializeComponent();
        }

        public TextEventHandler TextHandler { get; set; }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TextHandler == null)
                return;

            TextHandler.Invoke(txtInput.Text);
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
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