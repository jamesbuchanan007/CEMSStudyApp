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
    public partial class HowTos : Form
    {
        public HowTos()
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

            var pageName = "How To";
            var item = comboDictionary.First(q => q.Value == pageName);
            comboDictionary.Remove(item.Key);  //REMOVE HOW TO'S SELECTION

            comboBoxSiteNavigation.DataSource = new BindingSource(comboDictionary, null);
            comboBoxSiteNavigation.ValueMember = "Key";
            comboBoxSiteNavigation.DisplayMember = "Value";

            LoadComboboxTextbox();
        }

        private void LoadComboboxTextbox()
        {
            //LOAD COMBOBOX 
            var aDataSet = LoadTable("HowTos");
            comboBoxHowTo.DataSource = aDataSet.Tables[0];
            comboBoxHowTo.ValueMember = "HowTos_Id";
            comboBoxHowTo.DisplayMember = "HowTos_Name";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            textBoxHowTos.Text = aDataSet.Tables[0].Rows[0]["HowTos_Name"].ToString();
            textBoxAnswer.Text = aDataSet.Tables[0].Rows[0]["HowTos_Description"].ToString();
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
            DialogResult dr = MessageBox.Show("Exit Application", "CEMS Study App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                case "Part 63 Subpart UUUUU":
                    Hide();
                    Part63_Subpart_UUUUU part63 = new Part63_Subpart_UUUUU();
                    part63.Show();
                    break;
                case "Part 75 Plain English":
                    Hide();
                    Part75_PE part75_Pe = new Part75_PE();
                    part75_Pe.Show();
                    break;
                case "Unit of Measure":
                    Hide();
                    UnitOfMeasure unitOfMeasure = new UnitOfMeasure();
                    unitOfMeasure.Show();
                    break;
                case "Diagrams and Tables":
                    Hide();
                    DiagramsAndTables dt = new DiagramsAndTables();
                    dt.Show();
                    break;
                case "Part 60 Appendix B, F":
                    Hide();
                    Part60 p60 = new Part60();
                    p60.Show();
                    break;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //IF NOTHING TO EDIT
            if (comboBoxHowTo.Items.Count == 0) return;

            if (CheckPassword()) return;

            textBoxAnswer.ReadOnly = false;
            textBoxAnswer.Enabled = true;

            textBoxHowTos.ReadOnly = false;
            textBoxHowTos.Enabled = true;
            buttonNew.Hide();
            buttonDelete.Hide();
            buttonBack.Hide();
            buttonNext.Hide();
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
            textBoxHowTos.Text = "";
            HideAllButtons();
            buttonNew.Show();
            buttonToggle.Enabled = false;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Undo();
            textBoxHowTos.Undo();
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
        private void ChangeRecord(int index, DataSet aDataSet)
        {
            textBoxHowTos.Text = aDataSet.Tables[0].Rows[index]["HowTos_Name"].ToString();
            textBoxAnswer.Text = aDataSet.Tables[0].Rows[index]["HowTos_Description"].ToString();
            comboBoxHowTo.SelectedIndex = comboBoxHowTo.FindString(textBoxHowTos.Text);

            textBoxAnswer.Hide();
            buttonToggle.Text = @"Show";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var hDataSet = LoadTable("HowTos");
            var index = comboBoxHowTo.SelectedIndex;

            if (index == 0 || hDataSet.Tables[0].Rows.Count == 0) return;   //CHECK IF TABLE IS EMPTY

            var newIndex = index - 1;

            ChangeRecord(newIndex,hDataSet);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var hDataSet = LoadTable("HowTos");
            var index = comboBoxHowTo.SelectedIndex;
            var count = comboBoxHowTo.Items.Count - 1;

            if (index == count || hDataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index + 1;

            ChangeRecord(newIndex,hDataSet);
        }

        private void comboBoxHowTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hDataSet = LoadTable("HowTos");
            var index = comboBoxHowTo.SelectedIndex;

            if (hDataSet.Tables[0].Rows.Count == 0) return;
            textBoxHowTos.Text = hDataSet.Tables[0].Rows[index]["HowTos_Name"].ToString();
            textBoxAnswer.Text = hDataSet.Tables[0].Rows[index]["HowTos_Description"].ToString();
        }
        private void EnableTextBoxes()
        {
            textBoxAnswer.ReadOnly = false;
            textBoxAnswer.Enabled = true;
            textBoxHowTos.ReadOnly = false;
            textBoxHowTos.Enabled = true;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Visible && buttonNew.Visible) return;

            if (buttonEdit.Visible)
            {
                //IF NOTHING TO EDIT
                if (comboBoxHowTo.Items.Count == 0) { RefreshDisableShow(); return; }

                //CHECK WHETHER USER MEANT TO HIT SAVE BUTTON
                if (SaveQuestion() == DialogResult.No) { RefreshDisableShow(); return; }

                HowTosViewModel vm = new HowTosViewModel

                {
                    Name = textBoxHowTos.Text,
                    Description = textBoxAnswer.Text,
                    PagesId = 1,
                    DateEdited = DateTime.Now,
                    IsActive = 1
                };

                var index = comboBoxHowTo.SelectedIndex;

                var format = "yyyy-MM-dd HH:mm:ss"; //FORMAT DATE

                var sql = "UPDATE HowTos " +
                      "SET HowTos_Name = " + "'" + vm.Name + "'," +
                      "HowTos_Description = " + "'" + vm.Description + "'," +
                      "Pages_Id = " + vm.PagesId + "," +
                      "Date_Edited = " + "'" + vm.DateEdited.ToString(format) + "'," +
                      "Is_Active = " + vm.IsActive + " " +
                      "WHERE HowTos_Id = " + index;

                UpdateDatabase(sql);
            }

            if (buttonNew.Visible)
            {
                //CHECK WHETHER USER MEANT TO HIT SAVE BUTTON
                if (SaveQuestion() == DialogResult.No) { RefreshDisableShow(); return; }

                HowTosViewModel vm = new HowTosViewModel
                {
                    Name = textBoxHowTos.Text,
                    Description = textBoxAnswer.Text,
                    PagesId = 1,
                    DateAdded = DateTime.Now,
                    IsActive = 1
                };

                var format = "yyyy-MM-dd HH:mm:ss"; //FORMAT DATE


                var sql = "INSERT into HowTos (HowTos_Name,HowTos_Description,Pages_Id,Date_Added,Is_Active) values('" +
                      vm.Name + "'" + "," + "'" +
                      vm.Description + "'" + "," +
                      vm.PagesId + "," + "'" +
                      vm.DateAdded.ToString(format) + "'" + "," +
                      vm.IsActive + ")";

                AddToDatabase(sql);
            }
            RefreshDisableShow();

        }

        private void RefreshDisableShow()
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
                MessageBox.Show("Record Added", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                adapter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


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

        private DialogResult SaveQuestion()
        {
            var answer = MessageBox.Show("Save ??", "CEMS Study App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return answer;
        }

        private void RefreshComboboxTextboxes()
        {
            var aDataSet = LoadTable("HowTos");
            var newIndex = comboBoxHowTo.Items.Count;
            comboBoxHowTo.DataSource = aDataSet.Tables[0];
            comboBoxHowTo.ValueMember = "HowTos_Id";
            comboBoxHowTo.DisplayMember = "HowTos_Name";
            comboBoxHowTo.SelectedIndex = newIndex;
            textBoxHowTos.Text = aDataSet.Tables[0].Rows[newIndex]["HowTos_Name"].ToString();
            textBoxAnswer.Text = aDataSet.Tables[0].Rows[newIndex]["HowTos_Description"].ToString();
        }
        private void DisableTextBoxes()
        {
            textBoxAnswer.ReadOnly = true;
            textBoxAnswer.Enabled = false;
            textBoxHowTos.ReadOnly = true;
            textBoxHowTos.Enabled = false;
        }
        private void ShowAllButtons()
        {
            buttonEdit.Show();
            buttonDelete.Show();
            buttonNew.Show();
            buttonBack.Show();
            buttonNext.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var wantsToDelete = MessageBox.Show("Delete This Record ??", "CEMS Study App", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (CheckPassword()) return;

            var itemIndex = comboBoxHowTo.SelectedIndex + 1;

            if (wantsToDelete == DialogResult.OK)
            {
                SqlConnection connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;

                var connectionString = Settings.Default.LocalDb;
                connection = new SqlConnection(connectionString);
                sql = "DELETE FROM HowTos WHERE HowTos_Id = " + itemIndex;
                try
                {
                    connection.Open();
                    adapter.DeleteCommand = connection.CreateCommand();
                    adapter.DeleteCommand.CommandText = sql;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Delted", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
