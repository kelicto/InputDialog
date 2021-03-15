using System;
using System.Windows.Forms;

namespace KeLi.InputDialog.App.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            if (Utils.InputDialog.Show(out var text) == DialogResult.OK)
                txtContent.Text = text;
        }
    }
}