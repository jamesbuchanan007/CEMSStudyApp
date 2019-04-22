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
    public partial class UnitOfMeasure : Form
    {
        public UnitOfMeasure()
        {
            InitializeComponent();

            //SETS SAVE BUTTON TO WHEN USER PRESSES ENTER
            AcceptButton = buttonSave;
            buttonToggle.Enabled = true;
            buttonToggle.Show();

            //LOAD COMBOBOX PAGES
            var pagesDataSet = LoadTable("Pages");

            //LOAD INTO DICTIONARY TO REMOVE ACTIVE PAGE
            Dictionary<int, string> comboDictionary = new Dictionary<int, string>();

            for (int i = 0; i < pagesDataSet.Tables[0].Rows.Count; i++)
            {
                comboDictionary.Add((int)pagesDataSet.Tables[0].Rows[i]["Pages_Id"], pagesDataSet.Tables[0].Rows[i]["Pages_Name"].ToString());
            }

            //REMOVE FROM DICTIONARY
            var pageName = "UnitOfMeasure";
            var item = comboDictionary.First(q => q.Value == pageName);
            comboDictionary.Remove(item.Key);

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

        private void EnableTextBoxes()
        {
            textBoxAnswer.ReadOnly = false;
            textBoxAnswer.Enabled = true;
            textBoxUnitOfMeasure.ReadOnly = false;
            textBoxUnitOfMeasure.Enabled = true;
        }

        private void DisableTextBoxes()
        {
            textBoxAnswer.ReadOnly = true;
            textBoxAnswer.Enabled = false;
            textBoxUnitOfMeasure.ReadOnly = true;
            textBoxUnitOfMeasure.Enabled = false;
        }

        private void HideAllButtons()
        {
            buttonEdit.Hide();
            buttonNew.Hide();
            buttonDelete.Hide();
            buttonBack.Hide();
            buttonNext.Hide();
            buttonSave.Hide();
        }

        private void ShowAllButtons()
        {
            buttonEdit.Show();
            buttonDelete.Show();
            buttonNew.Show();
            buttonBack.Show();
            buttonNext.Show();
            buttonSave.Show();
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
            //IF NOTHING TO EDIT
            if (comboBoxUnitOfMeasure.Items.Count == 0) return;

            if (CheckPassword()) return;

            EnableTextBoxes();
            HideAllButtons();
            buttonEdit.Show();
            buttonSave.Show();
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
            if(CheckPassword()) return;

            EnableTextBoxes();
            textBoxAnswer.Text = "";
            textBoxUnitOfMeasure.Text = "";

            HideAllButtons();
            buttonNew.Show();
            buttonSave.Show();
            buttonToggle.Enabled = false;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Undo();
            textBoxUnitOfMeasure.Undo();
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
            var aDataTable = LoadTable("UnitOfMeasure");
            var index = comboBoxUnitOfMeasure.SelectedIndex;
            var count = comboBoxUnitOfMeasure.Items.Count - 1;    //Count is NOT zero-indexed

            if (index == count || aDataTable.Tables[0].Rows.Count == 0) return;

            var newIndex = index + 1;

            ChangeRecord(newIndex, aDataTable);
        }

        public void ChangeRecord(int newIndex, DataSet aDataTable)
        {
            textBoxUnitOfMeasure.Text = aDataTable.Tables[0].Rows[newIndex]["UnitOfMeasure_Name"].ToString();
            textBoxAnswer.Text = aDataTable.Tables[0].Rows[newIndex]["UnitOfMeasure_Description"].ToString();
            comboBoxUnitOfMeasure.SelectedIndex = comboBoxUnitOfMeasure.FindString(textBoxUnitOfMeasure.Text);

            textBoxAnswer.Hide();
            buttonToggle.Text = @"Show";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var aDataTable = LoadTable("UnitOfMeasure");
            var index = comboBoxUnitOfMeasure.SelectedIndex;

            if (index == 0 || aDataTable.Tables[0].Rows.Count == 0) return;

            var newIndex = index - 1;

            ChangeRecord(newIndex, aDataTable);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Visible && buttonNew.Visible) return;

            if (buttonEdit.Visible)
            {
                //IF NOTHING TO EDIT
                if (comboBoxUnitOfMeasure.Items.Count == 0) { RefreshDisableShow(); return; }

                //CHECK WHETHER USER MEANT TO HIT SAVE BUTTON
                if (SaveQuestion() == DialogResult.No) { RefreshDisableShow(); return; }

                UnitOfMeasureViewModel vm = new UnitOfMeasureViewModel
                {
                    UnitOfMeasure_Name = textBoxUnitOfMeasure.Text,
                    UnitOfMeasure_Description = textBoxAnswer.Text,
                    Pages_Id = 1,
                    Date_Edited = DateTime.Now,
                    IsActive = 1
                };

                var index = comboBoxUnitOfMeasure.SelectedIndex + 1;

                var format = "yyyy-MM-dd HH:mm:ss"; //FORMAT DATE

                var sql = "UPDATE UnitOfMeasure " +
                      "SET UnitOfMeasure_Name = " + "'" + vm.UnitOfMeasure_Name + "'," +
                      "UnitOfMeasure_Description = " + "'" + vm.UnitOfMeasure_Description + "'," +
                      "Pages_Id = " + vm.Pages_Id + "," +
                      "Date_Edited = " + "'" + vm.Date_Edited.ToString(format) + "'," +
                      "Is_Active = " + vm.IsActive + " " +
                      "WHERE UnitOfMeasure_Id = " + index;

                UpdateDataBase(sql);
            }

            if (buttonNew.Visible)
            {
                //CHECK WHETHER USER MEANT TO HIT SAVE BUTTON
                if (SaveQuestion() == DialogResult.No) { RefreshDisableShow(); return; }

                UnitOfMeasureViewModel vm = new UnitOfMeasureViewModel
                {
                    UnitOfMeasure_Name = textBoxUnitOfMeasure.Text,
                    UnitOfMeasure_Description = textBoxAnswer.Text,
                    Pages_Id = 1,
                    Date_Added = DateTime.Now,
                    IsActive = 1
                };

                var format = "yyyy-MM-dd HH:mm:ss";

                var sql = "INSERT into UnitOfMeasure (UnitOfMeasure_Name,UnitOfMeasure_Description,Pages_Id,Date_Added,Is_Active) values('" +
                      vm.UnitOfMeasure_Name + "'" + "," + "'" +
                      vm.UnitOfMeasure_Description + "'" + "," +
                      vm.Pages_Id + "," + "'" +
                      vm.Date_Added.ToString(format) + "'" + "," +
                      vm.IsActive + ")";
                AddToDatabase(sql);
            }

            RefreshDisableShow();
            buttonToggle.Enabled = true;
        }

        public void RefreshDisableShow()
        {
            RefreshComboboxTextboxes();
            DisableTextBoxes();
            ShowAllButtons();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            adapter.Dispose();
            connection.Close();

        }

        private void UpdateDataBase(string sqlCommandString)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            adapter.Dispose();
            connection.Close();
        }

        //REFRESH COMBOBOX AND TEXTBOXES
        public void RefreshComboboxTextboxes()
        {
            var aDataSet = LoadTable("UnitOfMeasure");
            var newIndex = comboBoxUnitOfMeasure.SelectedIndex;
            comboBoxUnitOfMeasure.DataSource = aDataSet.Tables[0];
            comboBoxUnitOfMeasure.ValueMember = "UnitOfMeasure_Id";
            comboBoxUnitOfMeasure.DisplayMember = "UnitOfMeasure_Name";
            comboBoxUnitOfMeasure.SelectedIndex = newIndex;
            ChangeRecord(newIndex, aDataSet);
        }

        private void comboBoxAcronym_SelectedIndexChanged(object sender, EventArgs e)
        {
            var aDataSet = LoadTable("UnitOfMeasure");
            var index = comboBoxUnitOfMeasure.SelectedIndex;

            if (aDataSet.Tables[0].Rows.Count == 0) return;

            ChangeRecord(index, aDataSet);
        }

        private DialogResult SaveQuestion()
        {
            var answer = MessageBox.Show("Save ??", "CEMS Study App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return answer;
        }

        //NAVIGATE TO DIFFERENT FORM
        private void comboBoxSiteNavigation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var formIndex = comboBoxSiteNavigation.GetItemText(comboBoxSiteNavigation.SelectedItem);

            switch (formIndex)
            {
                case "Formulas":
                    Hide();
                    Formulas formulas = new Formulas();
                    formulas.Show();
                    break;
                case "How To":
                    Hide();
                    HowTos howTos = new HowTos();
                    howTos.Show();
                    break;
                case "Main Menu":
                    Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    break;
                case "Part 63":
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var wantsToDelete = MessageBox.Show("Delete This Record ??", "CEMS Study App", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if(CheckPassword())return;

            var itemIndex = comboBoxUnitOfMeasure.SelectedIndex + 1;

            if (wantsToDelete == DialogResult.OK)
            {
                SqlConnection connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;

                var connectionString = Settings.Default.LocalDb;
                connection = new SqlConnection(connectionString);
                sql = "DELETE from UnitOfMeasure WHERE UnitOfMeasure_Id = " + itemIndex;
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
            //LOAD COMBOBOX UnitOfMeasure
            var aDataSet = LoadTable("UnitOfMeasure");

            comboBoxUnitOfMeasure.DataSource = aDataSet.Tables[0];
            comboBoxUnitOfMeasure.ValueMember = "UnitOfMeasure_Id";
            comboBoxUnitOfMeasure.DisplayMember = "UnitOfMeasure_Name";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            ChangeRecord(0, aDataSet);
        }
    }
}
