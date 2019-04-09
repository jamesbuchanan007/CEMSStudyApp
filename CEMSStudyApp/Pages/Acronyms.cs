using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class Acronyms : Form
    {
        public Acronyms()
        {
            InitializeComponent();

            //LOAD COMBOBOX PAGES
            var pagesDataSet = LoadTable("Pages");

            //LOAD INTO DICTIONARY TO REMOVE ACTIVE PAGE
            Dictionary<int,string> comboDictionary = new Dictionary<int, string>();

            for (int i = 0; i < pagesDataSet.Tables[0].Rows.Count; i++)
            {
                comboDictionary.Add((int)pagesDataSet.Tables[0].Rows[i]["Pages_Id"],pagesDataSet.Tables[0].Rows[i]["Pages_Name"].ToString());
            }

            comboDictionary.Remove(5);

            comboBoxSiteNavigation.DataSource = new BindingSource(comboDictionary, null);
            comboBoxSiteNavigation.ValueMember = "Key";
            comboBoxSiteNavigation.DisplayMember = "Value";

            //LOAD COMBOBOX ACRONYMS
            var aDataSet = LoadTable("Acronyms");
            comboBoxAcronym.DataSource = aDataSet.Tables[0];
            comboBoxAcronym.ValueMember = "Acronyms_Id";
            comboBoxAcronym.DisplayMember = "Acronyms_Name";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            textBoxAcronym.Text = aDataSet.Tables[0].Rows[0]["Acronyms_Name"].ToString();
            textBoxAnswer.Text = aDataSet.Tables[0].Rows[0]["Acronyms_Description"].ToString();
        }

        //CONNECTS TO DB AND LOADS DATA SET
        public DataSet LoadTable(string nameOfTable)
        {
            var tableName = nameOfTable;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql;

            //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
            var connectionString = Settings.Default.LocalDb;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "Select * from " + tableName;
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, tableName);

                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection !! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return ds;
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
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
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
            var aDataTable = LoadTable("Acronyms");
            var index = comboBoxAcronym.SelectedIndex;
            var count = comboBoxAcronym.Items.Count - 1;    //Count is NOT zero-indexed

            if (index == count || aDataTable.Tables[0].Rows.Count == 0) return;

            var newIndex = index + 1;

            textBoxAcronym.Text = aDataTable.Tables[0].Rows[newIndex]["Acronyms_Name"].ToString();
            textBoxAnswer.Text = aDataTable.Tables[0].Rows[newIndex]["Acronyms_Description"].ToString();
            comboBoxAcronym.SelectedIndex = comboBoxAcronym.FindString(textBoxAcronym.Text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Visible)
            {

                try
                {
                    Validate();

                    MessageBox.Show("Update successful", "CEMS Study App", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

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
            var aDataTable = LoadTable("Acronyms");
            var index = comboBoxAcronym.SelectedIndex;

            if (index == 0 || aDataTable.Tables[0].Rows.Count == 0) return;

            var newIndex = index - 1;

            textBoxAcronym.Text = aDataTable.Tables[0].Rows[newIndex]["Acronyms_Name"].ToString();
            textBoxAnswer.Text = aDataTable.Tables[0].Rows[newIndex]["Acronyms_Description"].ToString();
            comboBoxAcronym.SelectedIndex = comboBoxAcronym.FindString(textBoxAcronym.Text);
        }

        private void comboBoxAcronym_SelectedIndexChanged(object sender, EventArgs e)
        {
            var aDataSet = LoadTable("Acronyms");
            var index = comboBoxAcronym.SelectedIndex;

            if (aDataSet.Tables[0].Rows.Count == 0) return;
            textBoxAcronym.Text = aDataSet.Tables[0].Rows[index]["Acronyms_Name"].ToString();
            textBoxAnswer.Text = aDataSet.Tables[0].Rows[index]["Acronyms_Description"].ToString();
        }

        //NAVIGATE TO DIFFERENT FORM
        private void comboBoxSiteNavigation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var formIndex = comboBoxSiteNavigation.SelectedIndex;

            Hide();

            switch (formIndex)
            {
                case 3:
                    Hide();
                    Formulas formulas = new Formulas();
                    formulas.Show();
                    break;
                case 4:
                    Hide();
                    HowTos howTos = new HowTos();
                    howTos.Show();
                    break;
                case 0:
                    Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    break;
                case 1:
                    Hide();
                    Part60 part60 = new Part60();
                    part60.Show();
                    break;
                case 2:
                    Hide();
                    Part75 part75 = new Part75();
                    part75.Show();
                    break;
            }


        }
    }
}
