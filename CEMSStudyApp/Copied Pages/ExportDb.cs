using System;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class ExportDb : Form
    {
        public ExportDb()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit Export/Import Process?", "CEMS Study App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Export Database??", "CEMS Study App", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (answer == DialogResult.OK)
            {

            }
        }
    }
}
