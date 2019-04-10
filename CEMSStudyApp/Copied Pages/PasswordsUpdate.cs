using System;
using System.Windows.Forms;

namespace CEMSStudyApp.Copied_Pages
{
    public partial class PasswordsUpdate : Form
    {
        public PasswordsUpdate()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
