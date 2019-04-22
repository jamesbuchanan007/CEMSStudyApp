using System;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Part75 part75 = new Part75();
            part75.Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonPart60_Click(object sender, EventArgs e)
        {
            Hide();
            Part60 part60 = new Part60();
            part60.Show();
        }

        private void buttonFormulas_Click(object sender, EventArgs e)
        {
            Hide();
            Formulas formulas = new Formulas();
            formulas.Show();
        }

        private void buttonAcronyms_Click(object sender, EventArgs e)
        {
            Hide();
            Acronyms acronyms = new Acronyms();
            acronyms.Show();
        }

        private void buttonHowTos_Click(object sender, EventArgs e)
        {
            Hide();
            HowTos howTos = new HowTos();
            howTos.Show();
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
           PasswordsLogin pw = new PasswordsLogin(true);
           pw.ShowDialog();
        }

        private void buttonUoM_Click(object sender, EventArgs e)
        {
            Hide();
            UnitOfMeasure unitOfMeasure = new UnitOfMeasure();
            unitOfMeasure.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            DiagramsAndTables dt = new DiagramsAndTables();
            dt.Show();
        }
    }
}
