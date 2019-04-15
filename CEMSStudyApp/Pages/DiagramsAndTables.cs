using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class DiagramsAndTables : Form
    {

        public DiagramsAndTables()
        {
            InitializeComponent();

            //SETS SAVE BUTTON TO WHEN USER PRESSES ENTER
            buttonToggle.Enabled = true;

            //LOAD COMBOBOX PAGES
            var pagesDataSet = LoadTable("Pages");

            //LOAD INTO DICTIONARY TO REMOVE ACTIVE PAGE
            Dictionary<int, string> comboDictionary = new Dictionary<int, string>();

            for (int i = 0; i < pagesDataSet.Tables[0].Rows.Count; i++)
            {
                comboDictionary.Add((int)pagesDataSet.Tables[0].Rows[i]["Pages_Id"], pagesDataSet.Tables[0].Rows[i]["Pages_Name"].ToString());
            }

            //REMOVE FROM DICTIONARY
            var pageName = "DiagramsAndTables";
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            switch (buttonToggle.Text)
            {
                case "Hide":
                    pictureBoxDiagramsAndTables_Image.Hide();
                    buttonToggle.Text = @"Show";
                    break;
                case "Show":
                    pictureBoxDiagramsAndTables_Image.Show();
                    buttonToggle.Text = @"Hide";
                    break;

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var aDataTable = LoadTable("DiagramsAndTables");
            var index = comboBoxDiagramsAndTables_Id.SelectedIndex;
            var count = comboBoxDiagramsAndTables_Id.Items.Count - 1;    //Count is NOT zero-indexed

            if (index == count || aDataTable.Tables[0].Rows.Count == 0) return;

            var newIndex = index + 1;

            ChangeRecord(newIndex, aDataTable);
        }

        public void ChangeRecord(int newIndex, DataSet aDataTable)
        {
            textBoxDiagramsAndTables_Name.Text = aDataTable.Tables[0].Rows[newIndex]["Table_Name"].ToString();
            textBoxDiagramsAndTables_Description.Text = aDataTable.Tables[0].Rows[newIndex]["Table_Description"].ToString();
            string exePath = Application.StartupPath + @"\Images";
            var fileNameFromDb = aDataTable.Tables[0].Rows[newIndex]["Table_FileLocation"].ToString();
            var imagePath = exePath + fileNameFromDb;
            pictureBoxDiagramsAndTables_Image.Image = Image.FromFile(imagePath);

            comboBoxDiagramsAndTables_Id.SelectedIndex = comboBoxDiagramsAndTables_Id.FindString(aDataTable.Tables[0].Rows[newIndex]["Table_Id"].ToString());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var aDataTable = LoadTable("DiagramsAndTables");
            var index = comboBoxDiagramsAndTables_Id.SelectedIndex;

            if (index == 0 || aDataTable.Tables[0].Rows.Count == 0) return;

            var newIndex = index - 1;

            ChangeRecord(newIndex, aDataTable);
        }

        private void comboBoxAcronym_SelectedIndexChanged(object sender, EventArgs e)
        {
            var aDataSet = LoadTable("DiagramsAndTables");
            var index = comboBoxDiagramsAndTables_Id.SelectedIndex;

            if (aDataSet.Tables[0].Rows.Count == 0) return;

            ChangeRecord(index, aDataSet);
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
                case "UnitOfMeasure":
                    Hide();
                    UnitOfMeasure unitOfMeasure = new UnitOfMeasure();
                    unitOfMeasure.Show();
                    break;

            }


        }

        private void LoadComboboxTextbox()
        {
            //LOAD COMBOBOX DiagramsAndTables
            var aDataSet = LoadTable("DiagramsAndTables");

            comboBoxDiagramsAndTables_Id.DataSource = aDataSet.Tables[0];
            comboBoxDiagramsAndTables_Id.ValueMember = "Table_Db_Id";
            comboBoxDiagramsAndTables_Id.DisplayMember = "Table_Id";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            ChangeRecord(0, aDataSet);
        }
    }
}
