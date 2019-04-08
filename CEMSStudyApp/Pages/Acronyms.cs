using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CEMSStudyApp.Pages
{
    public partial class Acronyms : Form
    {
        public Acronyms()
        {
            InitializeComponent();

            string connectionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dtPages = new DataTable("Pages");
            DataTable dtAcronyms = new DataTable("Acronyms");
            int i;
            string sql = null;

            //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
            connectionString = Properties.Settings.Default.LocalDb;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "Select * from Pages";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, dtPages.ToString());

                sql = "Select * from Acronyms";
                adapter.SelectCommand.CommandText = sql;
                adapter.Fill(ds, dtAcronyms.ToString());

                adapter.Dispose();
                command.Dispose();
                connection.Close();

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1]);

                }

                for (i = 0; i <= ds.Tables[1].Rows.Count - 1; i++)
                {
                    MessageBox.Show(ds.Tables[1].Rows[i].ItemArray[0] + " -- " + ds.Tables[1].Rows[i].ItemArray[1]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            comboBoxSiteNavigation.DataSource = ds.Tables[0];
            comboBoxSiteNavigation.ValueMember = "Pages_Id";
            comboBoxSiteNavigation.DisplayMember = "Pages_Name";

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

        private void buttonNext_Click(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Visible)
            {
               
                try
                {
                    Validate();
                  
                    MessageBox.Show("Update successful","CEMS Study App", MessageBoxButtons.OK,MessageBoxIcon.Information);
                  
                }
                catch (Exception)
                {
                    MessageBox.Show("Update failed");
                }
            }

            if (buttonNew.Visible)
            {
                
            }

            DisableTextBoxes();
            ShowAllButtons();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
