using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class DbPassword : Form
    {
        public DbPassword()
        {
            InitializeComponent();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var password = "111";

                if (textBoxPassword.Text != password)
                {
                    MessageBox.Show("Incorrect Password!!", "CEMS Study App", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Hide();
                    var pl = new PasswordsLogin();
                    pl.Show();
                }
                else
                {
                    Hide();
                    var export = new ExportDb();
                    export.Show();
                }

              
            }

        }
    }
}
