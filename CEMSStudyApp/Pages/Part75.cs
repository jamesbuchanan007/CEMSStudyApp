using System;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class Part75 : Form
    {
        public Part75()
        {
            InitializeComponent();
            comboBoxSiteNavigation.SelectedIndex = 0;
            comboBoxSectionNumber.SelectedIndex = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSiteNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSiteNavigation.SelectedIndex)
            {
                case 1:
                    this.Hide();
                    PageMenu pageMenu = new PageMenu();
                    pageMenu.Show();
                    break;
                case 2:
                    this.Hide();
                    Part60 part60 = new Part60();
                    part60.Show();
                    break;
                default:
                    this.Hide();
                    PageMenu pm = new PageMenu();
                    pm.Show();
                    break;
            }
        }
    }
}
