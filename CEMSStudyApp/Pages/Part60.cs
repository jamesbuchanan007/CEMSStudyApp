using System;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class Part60 : Form
    {
        public Part60()
        {
            InitializeComponent();
            comboBoxSiteNavigation.SelectedIndex = -1;
            comboBoxSectionNumber.SelectedIndex = -1;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBoxSiteNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSiteNavigation.Text)
            {
                case "Acronyms":
                    this.Hide();
                    Acronyms acronyms = new Acronyms();
                    acronyms.Show();
                    break;
                case "Formulas":
                    this.Hide();
                    Formulas formulas = new Formulas();
                    formulas.Show();
                    break;
                case "How To's":
                    this.Hide();
                    HowTos howTos = new HowTos();
                    howTos.Show();
                    break;
                case "Main Menu":
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    break;
                //case "Part 60":
                //    this.Hide();
                //    Part60 part60 = new Part60();
                //    part60.Show();
                //    break;
                case "Part 75":
                    this.Hide();
                    Part75 part75 = new Part75();
                    part75.Show();
                    break;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxAnswer.ReadOnly = false;
            textBoxAnswer.Enabled = true;
            textBoxSectionNumber.ReadOnly = false;
            textBoxSectionNumber.Enabled = true;
            textBoxSectionName.ReadOnly = false;
            textBoxSectionName.Enabled = true;
            textBoxQuestion.ReadOnly = false;
            textBoxQuestion.Enabled = true;
            buttonNew.Hide();
            buttonDelete.Hide();
            buttonBack.Hide();
            buttonNext.Hide();
            buttonToggle.Enabled = false;

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxAnswer.ReadOnly = false;
            textBoxAnswer.Enabled = true;
            textBoxSectionNumber.ReadOnly = false;
            textBoxSectionNumber.Enabled = true;
            textBoxSectionName.ReadOnly = false;
            textBoxSectionName.Enabled = true;
            textBoxQuestion.ReadOnly = false;
            textBoxQuestion.Enabled = true;
            buttonEdit.Hide();
            buttonDelete.Hide();
            textBoxAnswer.Text = "";
            textBoxQuestion.Text = "";
            textBoxSectionName.Text = "";
            textBoxSectionNumber.Text = "";
            buttonBack.Hide();
            buttonNext.Hide();
            buttonToggle.Enabled = false;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Undo();
            textBoxQuestion.Undo();

            textBoxQuestion.ReadOnly = true;
            textBoxQuestion.Enabled = false;
            textBoxSectionName.Undo();
            textBoxSectionNumber.Undo();
            textBoxAnswer.ReadOnly = true;
            textBoxAnswer.Enabled = false;
            textBoxSectionNumber.ReadOnly = true;
            textBoxSectionNumber.Enabled = false;
            textBoxSectionName.ReadOnly = true;
            textBoxSectionName.Enabled = false;
            buttonEdit.Show();
            buttonDelete.Show();
            buttonNew.Show();
            buttonBack.Show();
            buttonNext.Show();
            buttonToggle.Enabled = true;

        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            switch (buttonToggle.Text)
            {
                case "Hide":
                    textBoxAnswer.Hide();
                    buttonToggle.Text = @"Show";
                    break;
                case "Show":
                    textBoxAnswer.Show();
                    buttonToggle.Text = @"Hide";
                    break;

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
        }
    }
}
