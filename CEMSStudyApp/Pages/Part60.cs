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

        private void Part60_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cEMS_Study_App_dbDataSet.Part_60' table. You can move, or remove it, as needed.
            this.part_60TableAdapter.Fill(this.cEMS_Study_App_dbDataSet.Part_60);
            // TODO: This line of code loads data into the 'cEMS_Study_App_dbDataSet.Pages' table. You can move, or remove it, as needed.
            this.pagesTableAdapter.Fill(this.cEMS_Study_App_dbDataSet.Pages);

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            switch (comboBoxSiteNavigation.SelectedText)
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
    }
}
