using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

            var pageName = "Part 63";
            var item = comboDictionary.First(q => q.Value == pageName);
            comboDictionary.Remove(item.Key);  //REMOVE PART60 SELECTION

            comboBoxSiteNavigation.DataSource = new BindingSource(comboDictionary, null);
            comboBoxSiteNavigation.ValueMember = "Key";
            comboBoxSiteNavigation.DisplayMember = "Value";

            LoadComboboxTextbox();

            buttonToggle.Show();
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
                case "Part 63":
                    Hide();
                    Part63 part63 = new Part63();
                    part63.Show();
                    break;
            }
        }
        
        private void buttonToggle_Click(object sender, EventArgs e)
        {
            switch (buttonToggle.Text)
            {
                case "Hide":
                    webBrowserPdf.Hide();
                    buttonToggle.Text = @"Show";
                    break;
                case "Show":
                    webBrowserPdf.Show();
                    buttonToggle.Text = @"Hide";
                    break;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var p60DataSet = LoadTable("Part60_Appendix");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (index == 0 || p60DataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index - 1;

            ChangeRecord(newIndex, p60DataSet);
        }

        private void ChangeRecord(int newIndex, DataSet p60DataSet)
        {
            textBoxSectionName.Text = p60DataSet.Tables[0].Rows[newIndex]["Part60_Appendix_Name"].ToString();
            var part60AppendixNumber = p60DataSet.Tables[0].Rows[newIndex]["Part60_Appendix_Number"].ToString();
            comboBoxSectionNumber.SelectedIndex = comboBoxSectionNumber.FindString(part60AppendixNumber);

            buttonToggle.Text = @"Hide";

            string exePath = Application.StartupPath + @"\Images\";
            var fileName = p60DataSet.Tables[0].Rows[newIndex]["Part60_Appendix_FileLocation"].ToString();
            var path = exePath + fileName + ".pdf"; //PATH STRING
            path = path.Replace(@"\", "/");


            webBrowserPdf?.Navigate(new Uri(path));

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var p60DataSet = LoadTable("Part60_Appendix");
            var index = comboBoxSectionNumber.SelectedIndex;
            var count = comboBoxSiteNavigation.Items.Count - 1;

            if (index == count || p60DataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index + 1;

            ChangeRecord(newIndex, p60DataSet);

        }

        private void comboBoxSectionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var part60DataSet = LoadTable("Part60_Appendix");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (part60DataSet.Tables[0].Rows.Count == 0) return;
            ChangeRecord(index, part60DataSet);
        }

        private void LoadComboboxTextbox()
        {
            //LOAD COMBOBOX 
            var aDataSet = LoadTable("Part60_Appendix");
            comboBoxSectionNumber.DataSource = aDataSet.Tables[0];
            comboBoxSectionNumber.ValueMember = "Part60_Appendix_Id";
            comboBoxSectionNumber.DisplayMember = "Part60_Appendix_Number";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            ChangeRecord(0, aDataSet);
        }
    }
}
