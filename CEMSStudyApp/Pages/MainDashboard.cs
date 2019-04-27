using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CEMSStudyApp.Models;
using CEMSStudyApp.Properties;
using Microsoft.Win32;

namespace CEMSStudyApp.Pages
{
    public partial class MainDashboard : Form
    {
        public static Dictionary<int, DashboardViewModel> dashboardDictionary { get; set; }
        public static Dictionary<int, string> dropDownDictionary { get; set; }
        public static string folderName { get; set; }

        public MainDashboard()
        {
            InitializeComponent(); //LOAD COMBOBOX PAGES

            this.Font = SystemFonts.IconTitleFont;
            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            buttonToggle.Show();
            buttonToggle.Text = "Show";

            folderName = "";

            pictureBoxMain.Show();

            webBrowserPdf.Hide();
            textBoxDefinitions.Hide();
        }

        void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.Window)
            {
                this.Font = SystemFonts.IconTitleFont;
            }
        }
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
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

        private void LoadDashboardViewModel(DataSet dataSet, string sectionColumnName, string sectionNumber, string file_LocationColumnName, string definitionColumnName)
        {
            string definition;
            string file_Location;
            string sectionName;

            //CHECK IF TABLE IS EMPTY
            if (dataSet.Tables[0].Rows.Count == 0) return;

            //INITIALIZE DICTIONARIES
            dashboardDictionary = new Dictionary<int, DashboardViewModel>();
            dropDownDictionary = new Dictionary<int, string>();


            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                sectionName = string.IsNullOrEmpty(sectionColumnName) ? "" : dataSet.Tables[0].Rows[i][sectionColumnName].ToString();
                file_Location = string.IsNullOrEmpty(file_LocationColumnName) ? "" : dataSet.Tables[0].Rows[i][file_LocationColumnName].ToString();
                definition = string.IsNullOrEmpty(definitionColumnName) ? "" : dataSet.Tables[0].Rows[i][definitionColumnName].ToString();

                //LOAD DASHBOARD DICTIONARY
                dashboardDictionary.Add(i, new DashboardViewModel()
                {
                    Heading = dataSet.Tables[0].Rows[i]["Section_Heading"].ToString(),
                    Section_Name = sectionName,
                    File_Location = file_Location,
                    Definition = definition
                });

                //LOAD DROPDOWN DICTIONARY
                dropDownDictionary.Add(i, dataSet.Tables[0].Rows[i][sectionNumber].ToString());
            }

            //LOAD DROP DOWN NAVIGATION
            comboBoxSectionNumber.DataSource = new BindingSource(dropDownDictionary, null);
            comboBoxSectionNumber.ValueMember = "Key";
            comboBoxSectionNumber.DisplayMember = "Value";
        }

        private void LoadDashboard(int index)
        {
            pictureBoxMain.Hide();

            //LOAD MAIN HEADING
            textBoxSectionHeading.Text = dashboardDictionary[index].Heading;

            //LOAD SUB HEADING
            labelSectionSubHeading.Text = dashboardDictionary[index].Section_Name;

            //LOAD MAIN VIEWER
            if (string.IsNullOrEmpty(dashboardDictionary[index].File_Location)) //FILE LOCATION IN DB
            {
                switch (dashboardDictionary[index].Heading)
                {
                    //ENABLE STUDYING OF ACRONYMS, FORMULAS, AND UNITS OF MEASURE PRIOR TO SEEING ANSWER
                    case "Acronyms":
                    case "Units of Measure":
                        textBoxDefinitions.Hide();
                        webBrowserPdf.Hide();
                        buttonToggle.Text = "Show";
                        textBoxDefinitions.Text = dashboardDictionary[index].Definition;
                        break;
                    default:
                        textBoxDefinitions.Show();
                        webBrowserPdf.Hide();
                        buttonToggle.Text = "Hide";
                        textBoxDefinitions.Text = dashboardDictionary[index].Definition;
                        break;
                }
            }
            //FILE LOCATION IN APP
            else
            {
                switch (dashboardDictionary[index].Heading)
                {
                    //ENABLE STUDYING OF ACRONYMS, FORMULAS, AND UNITS OF MEASURE PRIOR TO SEEING ANSWER
                    case "Formulas":
                    case "Software Questions":
                    case "Technical Questions":
                        textBoxDefinitions.Hide();
                        webBrowserPdf.Hide();
                        buttonToggle.Text = "Show";
                        break;
                    default:
                        textBoxDefinitions.Hide();
                        webBrowserPdf.Show();
                        buttonToggle.Text = "Hide";
                        break;
                }

                string exePath = Application.StartupPath + @"\" + folderName + @"\";
                var fileName = dashboardDictionary[index].File_Location;
                var path = exePath + fileName + ".pdf"; //PATH STRING
                path = path.Replace(@"\", "/");

                //GET PDF
                webBrowserPdf?.Navigate(new Uri(path));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit Application", "CEMS Study App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    webBrowserPdf.Hide();
                    textBoxDefinitions.Hide();
                    buttonToggle.Text = @"Show";
                    break;
                case "Show":
                    if (!string.IsNullOrEmpty(dashboardDictionary[comboBoxSectionNumber.SelectedIndex].File_Location))
                    {
                        webBrowserPdf.Show();
                    }
                    else
                    {
                        textBoxDefinitions.Show();
                    }
                    //webBrowserPdf?.Show();
                    //textBoxDefinitions.Show();
                    buttonToggle.Text = @"Hide";
                    break;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var index = comboBoxSectionNumber.SelectedIndex;
            if (index == -1) return;

            if (dashboardDictionary.Count == 0) return;

            var newIndex = index - 1;

            //MAKE SURE DOES NOT GO MORE THAN DICTIONARY COUNT
            if (newIndex < 0) return;

            LoadDashboard(newIndex);
            comboBoxSectionNumber.SelectedIndex = newIndex;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var index = comboBoxSectionNumber.SelectedIndex;
            if (index == -1) return;


            if (dashboardDictionary.Count == 0 || index == -1) return;

            var newIndex = index + 1;

            //CHECK IF MORE THAN DICTIONARY COUNT
            if (newIndex >= dropDownDictionary.Count) return;

            LoadDashboard(newIndex);
            comboBoxSectionNumber.SelectedIndex = newIndex;
        }

        private void comboBoxSectionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBoxSectionNumber.SelectedIndex;

            if (dashboardDictionary.Count == 0) return;

            LoadDashboard(index);
        }

        private void buttonAcronyms_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("Acronyms");
            folderName = "";

            LoadDashboardViewModel(dataSet, "", "Acronyms_Name", "", "Acronyms_Description");
        }

        private void buttonFormulas_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("Formulas");
            folderName = "";
            LoadDashboardViewModel(dataSet, "", "Formulas_Name", "", "Formulas_Description");
        }

        private void button60AppBF_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("Part60_Appendix");
            folderName = "Part60_Files";
            LoadDashboardViewModel(dataSet, "Part60_Appendix_Name", "Part60_Appendix_Number", "Part60_Appendix_FileLocation", "");
        }

        private void buttonPart75PlainEnglish_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("Part75New");
            folderName = "Part75_PlainEnglish_Files";
            LoadDashboardViewModel(dataSet, "Part75_PE_SectionNumber", "Part75_PE_SectionName", "Part75_PE_FileLocation", "");
        }

        private void buttonPart63SubUUUUU_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("Part63_Subpart_UUUUU");
            folderName = "Part63_Files";
            LoadDashboardViewModel(dataSet, "Part63_Subpart_UUUUU_Name", "Part63_Subpart_UUUUU_Number", "Part63_Subpart_UUUUU_FileLocation", "");
        }

        private void buttonUnitsOfMeasure_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("UnitOfMeasure");
            folderName = "";
            LoadDashboardViewModel(dataSet, "", "UnitOfMeasure_Name", "", "UnitOfMeasure_Description");
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            PasswordsLogin pw = new PasswordsLogin();
            pw.ShowDialog();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            AutoSize = true;
        }
    }
}
