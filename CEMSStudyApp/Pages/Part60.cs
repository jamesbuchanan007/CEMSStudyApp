using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class Part60 : Form
    {
        public Part60()
        {
            InitializeComponent(); //LOAD COMBOBOX PAGES
            var pagesDataSet = LoadTable("Pages");

            //LOAD INTO DICTIONARY TO REMOVE ACTIVE PAGE
            Dictionary<int, string> comboDictionary = new Dictionary<int, string>();

            for (int i = 0; i < pagesDataSet.Tables[0].Rows.Count; i++)
            {
                comboDictionary.Add((int)pagesDataSet.Tables[0].Rows[i]["Pages_Id"], pagesDataSet.Tables[0].Rows[i]["Pages_Name"].ToString());
            }

            comboDictionary.Remove(2);  //REMOVE PART60 SELECTION

            comboBoxSiteNavigation.DataSource = new BindingSource(comboDictionary, null);
            comboBoxSiteNavigation.ValueMember = "Key";
            comboBoxSiteNavigation.DisplayMember = "Value";

            //LOAD COMBOBOX 
            var aDataSet = LoadTable("Part60");
            comboBoxSectionNumber.DataSource = aDataSet.Tables[0];
            comboBoxSectionNumber.ValueMember = "Part60_Id";
            comboBoxSectionNumber.DisplayMember = "Part60_Number";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            textBoxQuestion.Text = aDataSet.Tables[0].Rows[0]["Part60_Question"].ToString();
            textBoxSectionName.Text = aDataSet.Tables[0].Rows[0]["Part60_Name"].ToString();
            textBoxSectionNumber.Text = aDataSet.Tables[0].Rows[0]["Part60_Number"].ToString();
            textBoxAnswer.Text = aDataSet.Tables[0].Rows[0]["Part60_Answer"].ToString();

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
                    Hide();
                    Acronyms acronyms = new Acronyms();
                    acronyms.Show();
                    break;
                case "Formulas":
                    Hide();
                    Formulas formulas = new Formulas();
                    formulas.Show();
                    break;
                case "How To's":
                    Hide();
                    HowTos howTos = new HowTos();
                    howTos.Show();
                    break;
                case "Main Menu":
                    Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    break;
                case "Part 75":
                    Hide();
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
            var p60DataSet = LoadTable("Part60");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (index == 0 || p60DataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index - 1;

            textBoxSectionNumber.Text = p60DataSet.Tables[0].Rows[newIndex]["Part60_Number"].ToString();
            textBoxSectionName.Text = p60DataSet.Tables[0].Rows[newIndex]["Part60_Name"].ToString();
            textBoxQuestion.Text = p60DataSet.Tables[0].Rows[newIndex]["Part60_Question"].ToString();
            textBoxAnswer.Text = p60DataSet.Tables[0].Rows[newIndex]["Part60_Answer"].ToString();

            comboBoxSectionNumber.SelectedIndex = comboBoxSectionNumber.FindString(textBoxSectionNumber.Text);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var p60DataSet = LoadTable("Part60");
            var index = comboBoxSectionNumber.SelectedIndex;
            var count = comboBoxSiteNavigation.Items.Count - 1;

            if (index == count || p60DataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index + 1;

            textBoxSectionNumber.Text = p60DataSet.Tables[0].Rows[newIndex]["Part60_Number"].ToString();
            textBoxSectionName.Text = p60DataSet.Tables[0].Rows[newIndex]["Part60_Name"].ToString();
            textBoxQuestion.Text = p60DataSet.Tables[0].Rows[newIndex]["Part60_Question"].ToString();
            textBoxAnswer.Text = p60DataSet.Tables[0].Rows[newIndex]["Part60_Answer"].ToString();

            comboBoxSectionNumber.SelectedIndex = comboBoxSectionNumber.FindString(textBoxSectionNumber.Text);

        }

        private void comboBoxSectionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var part60DataSet = LoadTable("Part60");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (part60DataSet.Tables[0].Rows.Count == 0) return;
            textBoxQuestion.Text = part60DataSet.Tables[0].Rows[index]["Part60_Question"].ToString();
            textBoxSectionName.Text = part60DataSet.Tables[0].Rows[index]["Part60_Name"].ToString();
            textBoxSectionNumber.Text = part60DataSet.Tables[0].Rows[index]["Part60_Number"].ToString();
            textBoxAnswer.Text = part60DataSet.Tables[0].Rows[index]["Part60_Answer"].ToString();
        }
    }
}
