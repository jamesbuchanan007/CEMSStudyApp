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

                MainDashboard md = new MainDashboard();

                if (textBoxPassword.Text != password)
                {
                    MessageBox.Show("Incorrect Password!!", "CEMS Study", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    SWPassword = false;
                    Hide();
                    //md.Show();
                    return;
                }

                SWPassword = true;
                Hide();
                md.Show();
            }
        }
    }
}
