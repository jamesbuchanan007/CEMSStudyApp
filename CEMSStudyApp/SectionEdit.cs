using System;
using System.Windows.Forms;

namespace CEMSStudyApp
{
    public partial class SectionEdit : Form
    {
        public SectionEdit()
        {
            InitializeComponent();
            comboBoxSiteNavigation.SelectedIndex = 0;
            comboBoxSectionNumber.SelectedIndex = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes) Application.Exit();
        }

        private void comboBoxSiteNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSiteNavigation.SelectedIndex)
            {
                case 1:
                    Hide();
                    var pageMenu = new PageMenu();
                    pageMenu.Show();
                    break;
                case 2:
                    Hide();
                    var part75 = new Part75();
                    part75.Show();
                    break;
                default:
                    Hide();
                    var pm = new PageMenu();
                    pm.Show();
                    break;
            }
        }
    }
}