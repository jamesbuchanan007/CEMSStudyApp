using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class Part63_Subpart_UUUUU : Form
    {
        public Part63_Subpart_UUUUU()
        {
            InitializeComponent(); //LOAD COMBOBOX PAGES

            var pagesDataSet = LoadTable("Pages");

            //LOAD INTO DICTIONARY TO REMOVE ACTIVE PAGE
            Dictionary<int, string> comboDictionary = new Dictionary<int, string>();

            for (int i = 0; i < pagesDataSet.Tables[0].Rows.Count; i++)
            {
                comboDictionary.Add((int)pagesDataSet.Tables[0].Rows[i]["Pages_Id"], pagesDataSet.Tables[0].Rows[i]["Pages_Name"].ToString());
            }

            var pageName = "Part 63 Subpart UUUUU";
            var item = comboDictionary.First(q => q.Value == pageName);
            comboDictionary.Remove(item.Key);  //REMOVE Part63_Appendix SELECTION

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
                    Part60 part60 = new Part60();
                    part60.Show();
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
            var p60DataSet = LoadTable("Part63_Subpart_UUUUU");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (index == 0 || p60DataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index - 1;

            ChangeRecord(newIndex, p60DataSet);
        }

        private void ChangeRecord(int newIndex, DataSet p60DataSet)
        {
            textBoxSectionName.Text = p60DataSet.Tables[0].Rows[newIndex]["Part63_Subpart_UUUUU_Name"].ToString();
            var Part63_AppendixAppendixNumber = p60DataSet.Tables[0].Rows[newIndex]["Part63_Subpart_UUUUU_Number"].ToString();
            comboBoxSectionNumber.SelectedIndex = comboBoxSectionNumber.FindString(Part63_AppendixAppendixNumber);

            buttonToggle.Text = @"Hide";

            string exePath = Application.StartupPath + @"\Part63_Files\";
            var fileName = p60DataSet.Tables[0].Rows[newIndex]["Part63_Subpart_UUUUU_FileLocation"].ToString();
            var path = exePath + fileName + ".pdf"; //PATH STRING
            path = path.Replace(@"\", "/");


            webBrowserPdf?.Navigate(new Uri(path));

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var p60DataSet = LoadTable("Part63_Subpart_UUUUU");
            var index = comboBoxSectionNumber.SelectedIndex;
            var count = comboBoxSiteNavigation.Items.Count - 1;

            if (index == count || p60DataSet.Tables[0].Rows.Count == 0) return;

            var newIndex = index + 1;

            ChangeRecord(newIndex, p60DataSet);

        }

        private void LoadComboboxTextbox()
        {
            //LOAD COMBOBOX 
            var aDataSet = LoadTable("Part63_Subpart_UUUUU");
            comboBoxSectionNumber.DataSource = aDataSet.Tables[0];
            comboBoxSectionNumber.ValueMember = "Part63_Subpart_UUUUU_Id";
            comboBoxSectionNumber.DisplayMember = "Part63_Subpart_UUUUU_Number";

            //LOAD TEXTBOXES
            if (aDataSet.Tables[0].Rows.Count == 0) return;
            ChangeRecord(0, aDataSet);
        }

        private void comboBoxSectionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Part63_AppendixDataSet = LoadTable("Part63_Subpart_UUUUU");
            var index = comboBoxSectionNumber.SelectedIndex;

            if (Part63_AppendixDataSet.Tables[0].Rows.Count == 0) return;
            ChangeRecord(index, Part63_AppendixDataSet);
        }
    }
}
