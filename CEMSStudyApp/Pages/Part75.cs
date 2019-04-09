using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class Part75 : Form
    {
        public Part75()
        {
            InitializeComponent();  //LOAD COMBOBOX PAGES
            var pagesDataSet = LoadTable("Pages");

            //LOAD INTO DICTIONARY TO REMOVE ACTIVE PAGE
            Dictionary<int, string> comboDictionary = new Dictionary<int, string>();

            for (int i = 0; i < pagesDataSet.Tables[0].Rows.Count; i++)
            {
                comboDictionary.Add((int)pagesDataSet.Tables[0].Rows[i]["Pages_Id"], pagesDataSet.Tables[0].Rows[i]["Pages_Name"].ToString());
            }

            comboDictionary.Remove(3);  //REMOVE FORMULA SELECTION

            comboBoxSiteNavigation.DataSource = new BindingSource(comboDictionary, null);
            comboBoxSiteNavigation.ValueMember = "Key";
            comboBoxSiteNavigation.DisplayMember = "Value";

            //LOAD COMBOBOX
            var aDataSet = LoadTable("Part75");
            comboBoxSectionNumber.DataSource = aDataSet.Tables[0];
            comboBoxSectionNumber.ValueMember = "Part75_Id";
            comboBoxSectionNumber.DisplayMember = "Part75_Number";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            textBoxQuestion.Text = aDataSet.Tables[0].Rows[0]["Part75_Question"].ToString();
            textBoxSectionName.Text = aDataSet.Tables[0].Rows[0]["Part75_Name"].ToString();
            textBoxSectionNumber.Text = aDataSet.Tables[0].Rows[0]["Part75_Number"].ToString();
            textBoxAnswer.Text = aDataSet.Tables[0].Rows[0]["Part75_Answer"].ToString();
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
                    Acronyms acronyms = new Acronyms();
                    acronyms.Show();
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
                case 5:
                    Hide();
                    HowTos howTos = new HowTos();
                    howTos.Show();
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
            textBoxQuestion.Text = "";
            textBoxSectionName.Text = "";
            textBoxSectionNumber.Text = "";
            HideAllButtons();
            buttonNew.Show();
            buttonToggle.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Undo();
            textBoxQuestion.Undo();
            textBoxSectionName.Undo();
            textBoxSectionNumber.Undo();
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
            var p75DataSet = LoadTable("Part75");
            var index = comboBoxSectionNumber.SelectedIndex;
            var count = comboBoxSiteNavigation.Items.Count - 1;

            if (index == count || p75DataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index + 1;

            textBoxSectionNumber.Text = p75DataSet.Tables[0].Rows[newIndex]["Part75_Number"].ToString();
            textBoxSectionName.Text = p75DataSet.Tables[0].Rows[newIndex]["Part75_Name"].ToString();
            textBoxQuestion.Text = p75DataSet.Tables[0].Rows[newIndex]["Part75_Question"].ToString();
            textBoxAnswer.Text = p75DataSet.Tables[0].Rows[newIndex]["Part75_Answer"].ToString();

            comboBoxSectionNumber.SelectedIndex = comboBoxSectionNumber.FindString(textBoxSectionNumber.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var p75DataSet = LoadTable("Part75");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (index == 0 || p75DataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index - 1;

            textBoxSectionNumber.Text = p75DataSet.Tables[0].Rows[newIndex]["Part75_Number"].ToString();
            textBoxSectionName.Text = p75DataSet.Tables[0].Rows[newIndex]["Part75_Name"].ToString();
            textBoxQuestion.Text = p75DataSet.Tables[0].Rows[newIndex]["Part75_Question"].ToString();
            textBoxAnswer.Text = p75DataSet.Tables[0].Rows[newIndex]["Part75_Answer"].ToString();

            comboBoxSectionNumber.SelectedIndex = comboBoxSectionNumber.FindString(textBoxSectionNumber.Text);
        }

        private void comboBoxSectionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var part75DataSet = LoadTable("Part75");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (part75DataSet.Tables[0].Rows.Count == 0) return;
            textBoxQuestion.Text = part75DataSet.Tables[0].Rows[index]["Part75_Question"].ToString();
            textBoxSectionName.Text = part75DataSet.Tables[0].Rows[index]["Part75_Name"].ToString();
            textBoxSectionNumber.Text = part75DataSet.Tables[0].Rows[index]["Part75_Number"].ToString();
            textBoxAnswer.Text = part75DataSet.Tables[0].Rows[index]["Part75_Answer"].ToString();
        }
        private void EnableTextBoxes()
        {
            textBoxAnswer.Enabled = true;
            textBoxQuestion.Enabled = true;
            textBoxSectionName.Enabled = true;
            textBoxSectionNumber.Enabled = true;

            textBoxAnswer.ReadOnly = false;
            textBoxQuestion.ReadOnly = false;
            textBoxSectionName.ReadOnly = false;
            textBoxSectionNumber.ReadOnly = false;
        }

        private void DisableTextBoxes()
        {
            textBoxAnswer.Enabled = false;
            textBoxQuestion.Enabled = false;
            textBoxSectionName.Enabled = false;
            textBoxSectionNumber.Enabled = false;

            textBoxAnswer.ReadOnly = true;
            textBoxQuestion.ReadOnly = true;
            textBoxSectionName.ReadOnly = true;
            textBoxSectionNumber.ReadOnly = true;
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
    }
}
