using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CEMSStudyApp.Models;
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
            var formIndex = comboBoxSiteNavigation.SelectedIndex;

            Hide();

            switch (formIndex)
            {
                case 4:
                    Hide();
                    Acronyms acronyms = new Acronyms();
                    acronyms.Show();
                    break;
                case 5:
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
            EnableTextBoxes();
            textBoxAnswer.Text = "";
            textBoxFormula.Text = "";
            HideAllButtons();
            buttonNew.Show();
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

            textBoxFormula.Text = fDataSet.Tables[0].Rows[newIndex]["Formulas_Name"].ToString();
            textBoxAnswer.Text = fDataSet.Tables[0].Rows[newIndex]["Formulas_Description"].ToString();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Visible)
            {
                SqlConnection connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql;

                //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
                var connectionString = Settings.Default.LocalDb;

                connection = new SqlConnection(connectionString);

                FormulasViewModel vm = new FormulasViewModel
                {
                    FormulasName = textBoxFormula.Text,
                    FormulasDescription = textBoxAnswer.Text,
                    PagesId = 1,
                    DateEdited = DateTime.Now,
                    IsActive = 1
                };

                var index = comboBoxFormula.SelectedIndex;


                var format = "yyyy-MM-dd HH:mm:ss"; //FORMAT DATE

                sql = "UPDATE Acronyms " +
                      "SET Acronyms_Name = " + "'" + vm.FormulasName + "'," +
                      "Acronyms_Description = " + "'" + vm.FormulasDescription + "'," +
                      "Pages_Id = " + vm.PagesId + "," +
                      "Date_Edited = " + "'" + vm.DateEdited.ToString(format) + "'," +
                      "Is_Active = " + vm.IsActive + " " +
                      "WHERE Acronyms_Id = " + index;

                try
                {

                    connection.Open();
                    adapter.UpdateCommand = connection.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Successful !!", "CEMS Study App", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                var aDataSet = LoadTable("Formulas");
                var newIndex = comboBoxFormula.SelectedIndex;
                comboBoxFormula.DataSource = aDataSet.Tables[0];
                comboBoxFormula.ValueMember = "Formulas_Id";
                comboBoxFormula.DisplayMember = "Formulas_Name";
                comboBoxFormula.SelectedIndex = newIndex;
                comboBoxFormula.Text = aDataSet.Tables[0].Rows[newIndex]["Formulas_Name"].ToString();
                textBoxAnswer.Text = aDataSet.Tables[0].Rows[newIndex]["Formulas_Description"].ToString();
            }

            if (buttonNew.Visible)
            {
                SqlConnection connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql;

                //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
                var connectionString = Settings.Default.LocalDb;

                connection = new SqlConnection(connectionString);

                var aName = textBoxFormula.Text;
                var aDescription = textBoxAnswer.Text;
                var pagesId = 1;
                var format = "yyyy-MM-dd HH:mm:ss"; //FORMAT DATE
                var dateAdded = DateTime.Now;
                var isActive = 1;

                sql = "INSERT into Formulas (Formulas_Name,Formulas_Description,Pages_Id,Date_Added,Is_Active) values('" +
                      aName + "'" + "," + "'" +
                      aDescription + "'" + "," +
                      pagesId + "," + "'" +
                      dateAdded.ToString(format) + "'" + "," +
                      isActive + ")";
                try
                {
                    connection.Open();
                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Row inserted !! ", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                var aDataSet = LoadTable("Formulas");
                var newIndex = comboBoxFormula.Items.Count;
                comboBoxFormula.DataSource = aDataSet.Tables[0];
                comboBoxFormula.ValueMember = "Formulas_Id";
                comboBoxFormula.DisplayMember = "Formulas_Name";
                comboBoxFormula.SelectedIndex = newIndex;
                comboBoxFormula.Text = aDataSet.Tables[0].Rows[newIndex]["Formulas_Name"].ToString();
                textBoxAnswer.Text = aDataSet.Tables[0].Rows[newIndex]["Formulas_Description"].ToString();

            }

            DisableTextBoxes();
            ShowAllButtons();
        }
        private void DisableTextBoxes()
        {
            textBoxAnswer.ReadOnly = true;
            textBoxAnswer.Enabled = false;
            textBoxFormula.ReadOnly = true;
            textBoxFormula.Enabled = false;
        }
        private void ShowAllButtons()
        {
            buttonEdit.Show();
            buttonDelete.Show();
            buttonNew.Show();
            buttonBack.Show();
            buttonNext.Show();
        }
        private void EnableTextBoxes()
        {
            textBoxAnswer.ReadOnly = false;
            textBoxAnswer.Enabled = true;
            textBoxFormula.ReadOnly = false;
            textBoxFormula.Enabled = true;
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




    }
}
