using System;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class PasswordsLogin : Form
    {
        public PasswordsLogin()
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
