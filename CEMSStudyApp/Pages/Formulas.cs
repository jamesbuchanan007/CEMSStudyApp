using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class Formulas : Form
    {
        public Formulas()
        {
            InitializeComponent();

            //LOAD COMBOBOX PAGES
            var pagesDataSet = LoadTable("Pages");  
            
            //LOAD INTO DICTIONARY TO REMOVE ACTIVE PAGE
            Dictionary<int, string> comboDictionary = new Dictionary<int, string>();

            for (int i = 0; i < pagesDataSet.Tables[0].Rows.Count; i++)
            {
                comboDictionary.Add((int)pagesDataSet.Tables[0].Rows[i]["Pages_Id"], pagesDataSet.Tables[0].Rows[i]["Pages_Name"].ToString());
            }

            comboDictionary.Remove(4);  //REMOVE FORMULA SELECTION

            comboBoxSiteNavigation.DataSource = new BindingSource(comboDictionary, null);
            comboBoxSiteNavigation.ValueMember = "Key";
            comboBoxSiteNavigation.DisplayMember = "Value";

            //LOAD COMBOBOX ACRONYMS
            var aDataSet = LoadTable("Formulas");
            comboBoxFormula.DataSource = aDataSet.Tables[0];
            comboBoxFormula.ValueMember = "Formulas_Id";
            comboBoxFormula.DisplayMember = "Formulas_Name";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            textBoxFormula.Text = aDataSet.Tables[0].Rows[0]["Formulas_Name"].ToString();
            textBoxAnswer.Text = aDataSet.Tables[0].Rows[0]["Formulas_Description"].ToString();
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
                case "Part 60":
                    Hide();
                    Part60 part60 = new Part60();
                    part60.Show();
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

            textBoxFormula.ReadOnly = false;
            textBoxFormula.Enabled = true;
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
            buttonEdit.Hide();
            buttonDelete.Hide();
            textBoxAnswer.Text = "";
            textBoxFormula.Text = "";
            buttonBack.Hide();
            buttonNext.Hide();
            buttonToggle.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Undo();
            textBoxFormula.Undo();
            textBoxAnswer.ReadOnly = true;
            textBoxAnswer.Enabled = false;
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
            var fDataTable = LoadTable("Formulas");
            var index = comboBoxFormula.SelectedIndex;

            if (index == 0 || fDataTable.Tables[0].Rows.Count == 0) return;

            var newIndex = index - 1;

            textBoxFormula.Text = fDataTable.Tables[0].Rows[newIndex]["Formulas_Name"].ToString();
            textBoxAnswer.Text = fDataTable.Tables[0].Rows[newIndex]["Formulas_Description"].ToString();
            comboBoxFormula.SelectedIndex = comboBoxFormula.FindString(textBoxFormula.Text);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var fDataSet = LoadTable("Formulas");
            var index = comboBoxFormula.SelectedIndex;
            var count = comboBoxFormula.Items.Count - 1;

            if (index == count || fDataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index + 1;

            textBoxFormula.Text = fDataSet.Tables[0].Rows[newIndex]["Acronyms_Name"].ToString();
            textBoxAnswer.Text = fDataSet.Tables[0].Rows[newIndex]["Acronyms_Description"].ToString();
            comboBoxFormula.SelectedIndex = comboBoxFormula.FindString(textBoxFormula.Text);
        }

        private void comboBoxFormula_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fDataSet = LoadTable("Formulas");
            var index = comboBoxFormula.SelectedIndex;

            if (fDataSet.Tables[0].Rows.Count == 0) return;

            textBoxFormula.Text = fDataSet.Tables[0].Rows[index]["Formula_Name"].ToString();
            textBoxAnswer.Text = fDataSet.Tables[0].Rows[index]["Formula_Description"].ToString();

        }
    }
}
