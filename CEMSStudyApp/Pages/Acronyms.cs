using System;
using System.Data;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class Acronyms : Form
    {
        public Acronyms()
        {
            InitializeComponent();
            comboBoxAcronym.SelectedIndex = -1;
        }

        private void EnableTextBoxes()
        {
            textBoxAnswer.ReadOnly = false;
            textBoxAnswer.Enabled = true;
            textBoxAcronym.ReadOnly = false;
            textBoxAcronym.Enabled = true;
        }

        private void DisableTextBoxes()
        {
            textBoxAnswer.ReadOnly = true;
            textBoxAnswer.Enabled = false;
            textBoxAcronym.ReadOnly = true;
            textBoxAcronym.Enabled = false;
        }

        private void HideAllButtons()
        {
            buttonEdit.Hide();
            buttonNew.Hide();
            buttonDelete.Hide();
            buttonBack.Hide();
            buttonNext.Hide();
            buttonBack.Hide();
            buttonNext.Hide();
        }

        private void ShowAllButtons()
        {
            buttonEdit.Show();
            buttonDelete.Show();
            buttonNew.Show();
            buttonBack.Show();
            buttonNext.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Acronyms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cEMS_Study_App_dbDataSet.Acronyms' table. You can move, or remove it, as needed.
            this.acronymsTableAdapter.Fill(this.cEMS_Study_App_dbDataSet.Acronyms);
            // TODO: This line of code loads data into the 'cEMS_Study_App_dbDataSet.Pages' table. You can move, or remove it, as needed.
            this.pagesTableAdapter.Fill(this.cEMS_Study_App_dbDataSet.Pages);

        }

        private void comboBoxSiteNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSiteNavigation.Text)
            {
                //case "Acronyms":
                //    this.Hide();
                //    Acronyms acronyms = new Acronyms();
                //    acronyms.Show();
                //    break;
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
                case "Part 60":
                    this.Hide();
                    Part60 part60 = new Part60();
                    part60.Show();
                    break;
                case "Part 75":
                    this.Hide();
                    Part75 part75 = new Part75();
                    part75.Show();
                    break;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            HideAllButtons();
            buttonEdit.Show();
            buttonToggle.Enabled = false;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            textBoxAnswer.Text = "";
            textBoxAcronym.Text = "";
            HideAllButtons();
            buttonNew.Show();
            buttonToggle.Enabled = false;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Undo();
            textBoxAcronym.Undo();
            DisableTextBoxes();
            ShowAllButtons();
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
            acronymsBindingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            acronymsBindingSource.MoveNext();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Enabled)
            {
                var id = (int)((DataRowView)acronymsBindingSource.Current).Row["Acronyms_Id"];
                var name = ((DataRowView)acronymsBindingSource.Current).Row["Acronyms_Name"];
                var description = ((DataRowView)acronymsBindingSource.Current).Row["Acronyms_Description"];
                var dateEdited = ((DataRowView)acronymsBindingSource.Current).Row["Date_Edited"];

                name = textBoxAcronym.Text;
                description = textBoxAnswer.Text;
                dateEdited = DateTime.Now;
            }

            if (buttonNew.Enabled)
            {
                var id = (int)((DataRowView)acronymsBindingSource.Current).Row["Acronyms_Id"];
                var name = ((DataRowView)acronymsBindingSource.Current).Row["Acronyms_Name"];
                var description = ((DataRowView)acronymsBindingSource.Current).Row["Acronyms_Description"];
                var dateEdited = ((DataRowView)acronymsBindingSource.Current).Row["Date_Edited"];

                name = textBoxAcronym.Text;
                description = textBoxAnswer.Text;
                dateEdited = DateTime.Now;
            }
        }

    }
}
