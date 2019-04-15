using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CEMSStudyApp.Models;
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

            var pageName = "Part 60";
            var item = comboDictionary.First(q => q.Value == pageName);
            comboDictionary.Remove(item.Key);  //REMOVE PART60 SELECTION

            comboBoxSiteNavigation.DataSource = new BindingSource(comboDictionary, null);
            comboBoxSiteNavigation.ValueMember = "Key";
            comboBoxSiteNavigation.DisplayMember = "Value";

            LoadComboboxTextbox();
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
            var formIndex = comboBoxSiteNavigation.GetItemText(comboBoxSiteNavigation.SelectedItem);


            switch (formIndex)
            {
                case "Formulas":
                    Hide();
                    Formulas formulas = new Formulas();
                    formulas.Show();
                    break;
                case "Acronyms":
                    Hide();
                    Acronyms acronyms = new Acronyms();
                    acronyms.Show();
                    break;
                case "Main Menu":
                    Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    break;
                case "How To":
                    Hide();
                    HowTos howTos = new HowTos();
                    howTos.Show();
                    break;
                case "Part 75":
                    Hide();
                    Part75 part75 = new Part75();
                    part75.Show();
                    break;
                case "UnitOfMeasure":
                    Hide();
                    UnitOfMeasure unitOfMeasure = new UnitOfMeasure();
                    unitOfMeasure.Show();
                    break;
                case "DiagramsAndTables":
                    Hide();
                    DiagramsAndTables dt = new DiagramsAndTables();
                    dt.Show();
                    break;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //IF NOTHING TO EDIT
            if (comboBoxSectionNumber.Items.Count == 0) return;
            if (CheckPassword()) return;
            EnableTextBoxes();
            HideAllButtons();
            buttonEdit.Show();
            buttonToggle.Enabled = false;

        }

        private bool CheckPassword()
        {
            bool isLocked;

            using (PasswordsLogin pw = new PasswordsLogin(false))
            {
                pw.ShowDialog();
                isLocked = pw.appIsLocked;
            }

            return isLocked;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (CheckPassword()) return;
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var p60DataSet = LoadTable("Part60");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (index == 0 || p60DataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index - 1;

            ChangeRecord(newIndex, p60DataSet);
        }

        private void ChangeRecord(int newIndex, DataSet p60DataSet)
        {
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

            ChangeRecord(newIndex, p60DataSet);

        }

        private void comboBoxSectionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var part60DataSet = LoadTable("Part60");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (part60DataSet.Tables[0].Rows.Count == 0) return;
            ChangeRecord(index, part60DataSet);
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Visible && buttonNew.Visible) return;

            if (buttonEdit.Visible)
            {
                //IF NOTHING TO EDIT
                if (comboBoxSectionNumber.Items.Count == 0) { RefreshDisableShow(); return; }

                //CHECK WHETHER USER MEANT TO HIT SAVE BUTTON
                if (SaveQuestion() == DialogResult.No) { RefreshDisableShow(); return; }

                Part60ViewModel vm = new Part60ViewModel

                {
                    Part60Answer = textBoxAnswer.Text,
                    Part60Name = textBoxSectionName.Text,
                    Part60Number = textBoxSectionNumber.Text,
                    Part60Question = textBoxQuestion.Text,
                    PagesId = 1,
                    DateEdited = DateTime.Now,
                    IsActive = 1
                };

                var index = comboBoxSectionNumber.SelectedIndex;

                var format = "yyyy-MM-dd HH:mm:ss"; //FORMAT DATE

                var sql = "UPDATE Part60 " +
                       "SET Part60_Answer = " + "'" + vm.Part60Answer + "'," +
                       "Part60_Name = " + "'" + vm.Part60Name + "'," +
                       "Part60_Number = " + "'" + vm.Part60Number + "'," +
                       "Part60_Question = " + "'" + vm.Part60Question + "'," +
                       "Pages_Id = " + vm.PagesId + "," +
                       "Date_Edited = " + "'" + vm.DateEdited.ToString(format) + "'," +
                       "Is_Active = " + vm.IsActive + " " +
                       "WHERE Part60_Id = " + index;

                UpdateDatabase(sql);
            }

            if (buttonNew.Visible)
            {
                //CHECK WHETHER USER MEANT TO HIT SAVE BUTTON
                if (SaveQuestion() == DialogResult.No) { RefreshDisableShow(); return; }

                Part60ViewModel vm = new Part60ViewModel
                {
                    Part60Name = textBoxSectionName.Text,
                    Part60Number = textBoxSectionNumber.Text,
                    Part60Question = textBoxQuestion.Text,
                    Part60Answer = textBoxAnswer.Text,
                    PagesId = 1,
                    DateAdded = DateTime.Now,
                    IsActive = 1
                };

                var format = "yyyy-MM-dd HH:mm:ss";

                var sql = "INSERT into Acronyms (Acronyms_Name,Acronyms_Description,Pages_Id,Date_Added,Is_Active) values('" +
                      vm.Part60Name + "'" + "," + "'" +
                      vm.Part60Number + "'" + "," +
                      vm.Part60Question + "'" + "," + "'" +
                      vm.Part60Answer + "'" + "," + "'" +
                      vm.PagesId + "," + "'" +
                      vm.DateAdded.ToString(format) + "'" + "," +
                      vm.IsActive + ")";
                AddToDatabase(sql);
            }
            RefreshDisableShow();
        }
        //REFRESH COMBOBOXTEXTBOXES METHOD, DISABLE TEXTBOXES, SHOW ALL BUTTONS
        private void RefreshDisableShow()
        {
            RefreshComboboxTextboxes();
            DisableTextBoxes();
            ShowAllButtons();

        }

        private void UpdateDatabase(string sqlCommandString)
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = sqlCommandString;

            //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
            var connectionString = Settings.Default.LocalDb;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Update Successful !!", "CEMS Study App", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                adapter.Dispose();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void AddToDatabase(string sqlCommandString)
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = sqlCommandString;

            //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
            var connectionString = Settings.Default.LocalDb;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Record Added", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                adapter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RefreshComboboxTextboxes()
        {
            var aDataSet = LoadTable("Part60");
            var newIndex = comboBoxSectionNumber.SelectedIndex;
            comboBoxSectionNumber.DataSource = aDataSet.Tables[0];
            comboBoxSectionNumber.ValueMember = "Part60_Id";
            comboBoxSectionNumber.DisplayMember = "Part60_Name";
            ChangeRecord(newIndex, aDataSet);
        }
        private DialogResult SaveQuestion()
        {
            var answer = MessageBox.Show("Save ??", "CEMS Study App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return answer;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var wantsToDelete = MessageBox.Show("Delete This Record ??", "CEMS Study App", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (CheckPassword()) return;

            var itemIndex = comboBoxSectionNumber.SelectedIndex + 1;

            if (wantsToDelete == DialogResult.OK)
            {
                SqlConnection connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;

                var connectionString = Settings.Default.LocalDb;
                connection = new SqlConnection(connectionString);
                sql = "DELETE FROM Part60 WHERE Part60_Id = " + itemIndex;
                try
                {
                    connection.Open();
                    adapter.DeleteCommand = connection.CreateCommand();
                    adapter.DeleteCommand.CommandText = sql;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                adapter.Dispose();
                connection.Close();

                LoadComboboxTextbox();

                RefreshDisableShow();
            }
        }

        private void LoadComboboxTextbox()
        {
            //LOAD COMBOBOX 
            var aDataSet = LoadTable("Part60");
            comboBoxSectionNumber.DataSource = aDataSet.Tables[0];
            comboBoxSectionNumber.ValueMember = "Part60_Id";
            comboBoxSectionNumber.DisplayMember = "Part60_Number";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            ChangeRecord(0, aDataSet);
        }
    }
}
