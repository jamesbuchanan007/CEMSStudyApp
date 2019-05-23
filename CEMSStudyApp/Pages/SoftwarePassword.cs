using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class SoftwarePassword : Form
    {
        public static bool SWPassword { get; set; }

        public SoftwarePassword()
        {
            InitializeComponent();
        }
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                var password = "prism";
                
                if (textBoxPassword.Text != password)
                {
                    MessageBox.Show("Incorrect Password!!", "CEMS Study", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    SWPassword = false;
                    Hide();
                    return;
                }

                SWPassword = true;
                Hide();
            }
        }
    }
}
