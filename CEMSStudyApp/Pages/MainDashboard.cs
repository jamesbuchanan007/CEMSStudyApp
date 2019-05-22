using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
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

            labelVersion.Text = "Version: " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);

            buttonToggle.Show();
            buttonToggle.Enabled = false;
            buttonToggle.Text = "Show";
            EnableNavButtons(false);

            buttonRandom.Show();
            buttonRandom.Enabled = false;

            folderName = "";

            pictureBoxMain.Show();

            webBrowserPdf.Hide();
            textBoxDefinitions.Hide();
            panelFormulas.Hide();
            comboBoxTabCOppmvdF2XCO2.SelectedIndex = 0;
            comboBoxTabNOxppmvdF2XCO2.SelectedIndex = 0;
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
            string sectionHeading = "";

            //CHECK IF TABLE IS EMPTY
            if (dataSet.Tables[0].Rows.Count == 0) return;

            //INITIALIZE DICTIONARIES
            dashboardDictionary = new Dictionary<int, DashboardViewModel>();
            dropDownDictionary = new Dictionary<int, string>();


            if (sectionColumnName == "Definitions")
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    var regulation = dataSet.Tables[0].Rows[i]["Part75_Regulation"].ToString();
                    var section = dataSet.Tables[0].Rows[i]["Part75_Section"].ToString();
                    sectionHeading = regulation + " - " + section;
                    var secNumber = dataSet.Tables[0].Rows[i]["Part75_Section_Number"].ToString();
                    var secName = dataSet.Tables[0].Rows[i]["Part75_Section_Sub_Name"].ToString();
                    var subHeading = secNumber + " - " + secName;
                    definition = dataSet.Tables[0].Rows[i]["Part75_Definition"].ToString();

                    //LOAD DASHBOARD DICTIONARY
                    dashboardDictionary.Add(i, new DashboardViewModel()
                    {
                        Heading = sectionHeading,
                        Section_Name = subHeading,
                        File_Location = "",
                        Definition = definition
                    });

                    var word = dataSet.Tables[0].Rows[i]["Part75_Word"].ToString();
                    var dropDown = word + " - " + subHeading;

                    //LOAD DROPDOWN DICTIONARY
                    dropDownDictionary.Add(i, dropDown);
                }
            }
            else
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {

                    sectionName = string.IsNullOrEmpty(sectionColumnName) ? "" : dataSet.Tables[0].Rows[i][sectionColumnName].ToString();
                    file_Location = string.IsNullOrEmpty(file_LocationColumnName) ? "" : dataSet.Tables[0].Rows[i][file_LocationColumnName].ToString();
                    definition = string.IsNullOrEmpty(definitionColumnName) ? "" : dataSet.Tables[0].Rows[i][definitionColumnName].ToString();
                    sectionHeading = sectionColumnName == "Part75_Section_Number"
                        ? dataSet.Tables[0].Rows[i]["Part75_Section_Heading"].ToString()
                        : dataSet.Tables[0].Rows[i]["Section_Heading"].ToString();

                    //LOAD DASHBOARD DICTIONARY
                    dashboardDictionary.Add(i, new DashboardViewModel()
                    {
                        Heading = sectionHeading,
                        Section_Name = sectionName,
                        File_Location = file_Location,
                        Definition = definition
                    });

                    if (sectionHeading == "Formulas") return;

                    //LOAD DROPDOWN DICTIONARY
                    dropDownDictionary.Add(i, dataSet.Tables[0].Rows[i][sectionNumber].ToString());
                }
            }

            if (sectionHeading == "Formulas") return;

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

            //LOAD MAIN VIEWER TYPE
            if (string.IsNullOrEmpty(dashboardDictionary[index].File_Location)) //FILE LOCATION IN DB
            {
                switch (dashboardDictionary[index].Heading)
                {
                    //ENABLE STUDYING OF ACRONYMS, FORMULAS, AND UNITS OF MEASURE PRIOR TO SEEING ANSWER
                    case "Acronyms":
                    case "Units of Measure":
                    case "Part 60 - Appendix B":
                    case "Part 60 - Appendix F":
                    case "Part 63 - Subpart UUUUU":
                    case "Part 75 - Section 7":
                    case "Part 75 - Section 8":
                    case "Part 75 - Section 9":
                    case "Part 75 - Section 20":
                    case "Part 75 - Section 22":
                    case "Part 75 - Appendix A":
                        comboBoxSectionNumber.Show();
                        panelFormulas.Hide();
                        textBoxDefinitions.Hide();
                        webBrowserPdf.Hide();
                        EnableNavButtons(true);
                        buttonToggle.Text = "Show";
                        textBoxDefinitions.Text = dashboardDictionary[index].Definition;
                        break;
                    case "Formulas":
                        panelFormulas.Show();
                        textBoxDefinitions.Hide();
                        webBrowserPdf.Hide();
                        buttonToggle.Text = "Show";
                        EnableNavButtons(false);
                        comboBoxSectionNumber.Hide();
                        break;
                    default:
                        comboBoxSectionNumber.Show();
                        textBoxDefinitions.Show();
                        panelFormulas.Hide();
                        webBrowserPdf.Hide();
                        EnableNavButtons(true);
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
                    case "Software Questions":
                    case "Technical Questions":
                        comboBoxSectionNumber.Show();
                        panelFormulas.Hide();
                        textBoxDefinitions.Hide();
                        webBrowserPdf.Hide();
                        EnableNavButtons(true);
                        buttonToggle.Text = "Show";
                        break;
                    default:
                        comboBoxSectionNumber.Show();
                        panelFormulas.Hide();
                        textBoxDefinitions.Hide();
                        webBrowserPdf.Show();
                        EnableNavButtons(true);
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

        private void EnableNavButtons(bool b)
        {
            buttonToggle.Enabled = b;
            buttonNext.Enabled = b;
            buttonBack.Enabled = b;
            buttonRandom.Enabled = b;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit Application", "CEMS Study", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            LoadDashboardViewModel(dataSet, "Formulas_Name", "", "", "");
            LoadDashboard(0);
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

        private void buttonPart75_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("Part75");
            folderName = "Part75_Files";
            LoadDashboardViewModel(dataSet, "Part75_Section_Number", "Part_75_Question_Number", "File_Location", "");
        }

        //TRY AND CONVERT TO DOUBLE
        private double? CTD(string textValue, TextBox textBox)
        {
            if (string.IsNullOrEmpty(textValue))
            {
                MessageBox.Show("Please Enter Value", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return null;
            }

            double OutVal;
            double.TryParse(textValue, out OutVal);

            if (double.TryParse(textValue, out OutVal)) return OutVal;
            MessageBox.Show("Please Enter a Valid Number", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus();
            textBox.Clear();
            return null;
        }

        //FORMAT ANSWER AND DISPLAY
        private void DisplayAnswer(double? answer, TextBox textBox)
        {
            textBox.Text = $@"{answer:N1}";
        }

        private void buttonTabOilFlowF1Calculate_Click(object sender, EventArgs e)
        {
            var oilFlow = CTD(textBoxTabOilFlowF1OilFlow.Text, textBoxTabOilFlowF1OilFlow);
            if (oilFlow == null) return;
            var oilDensity = CTD(textBoxTabOilFlowF1Density.Text, textBoxTabOilFlowF1Density);
            if (oilDensity == null) return;
            var answer = oilFlow * oilDensity;
            DisplayAnswer(answer, textBoxTabOilFlowMassF1OilFlow);
        }

        private void buttonTabCO2GasF1Calculate_Click(object sender, EventArgs e)
        {
            var carbonContent = CTD(textBoxTabCO2GasF1CarbonContent.Text, textBoxTabCO2GasF1CarbonContent);
            if (carbonContent == null) return;

            var gasFlow = CTD(textBoxTabCO2GasF1GasFlow.Text, textBoxTabCO2GasF1GasFlow);
            if (gasFlow == null) return;

            var answer = ((carbonContent / 100 * gasFlow * 100 * 0.0452) * 44) / (2000 * 12);
            DisplayAnswer(answer, textBoxTabCO2F1Answer);
        }

        private void buttonTabCO2GasF2Calculate_Click(object sender, EventArgs e)
        {
            var htip = CTD(textBoxTabCO2GasF2HTIP.Text, textBoxTabCO2GasF2HTIP);
            if (htip == null) return;
            var answer = (htip * 1040) * (1.0 / 385) * (44.0 / 2000);
            DisplayAnswer(answer, textBoxTabCO2GasF2Answer);
        }

        private void buttonTabCO2GasF3Calculate_Click(object sender, EventArgs e)
        {
            var co2 = CTD(textBoxTabCO2GasF3CO2Concentration.Text, textBoxTabCO2GasF3CO2Concentration);
            if (co2 == null) return;

            var gasFlow = CTD(textBoxTabCO2GasF3GasFlow.Text, textBoxTabCO2GasF3GasFlow);
            if (gasFlow == null) return;

            var answer = (5.7 / 10000000) * co2 * gasFlow;
            DisplayAnswer(answer, textBoxTabCO2GasF3Answer);
        }

        private void buttonTabCO2OilF1Calculate_Click(object sender, EventArgs e)
        {
            var carbonContent = CTD(textBoxTabCO2OilF1CarbonContent.Text, textBoxTabCO2OilF1CarbonContent);
            if (carbonContent == null) return;

            var massOil = CTD(textBoxTabCO2OilF1MassOil.Text, textBoxTabCO2OilF1MassOil);
            if (massOil == null) return;

            var answer = ((carbonContent / 100 * massOil) * 44) / (2000 * 12);
            DisplayAnswer(answer, textBoxTabCO2OilF1Answer);
        }

        private void buttonTabCO2OilF2Calculate_Click(object sender, EventArgs e)
        {
            var htip = CTD(textBoxTabCO2OilF2HTIP.Text, textBoxTabCO2OilF2HTIP);
            if (htip == null) return;

            var answer = htip * 1420 * (1.0 / 385) * (44.0 / 2000);
            DisplayAnswer(answer, textBoxTabCO2OilF2Answer);
        }

        private void buttonTabCO2OilF3Calculate_Click(object sender, EventArgs e)
        {
            var co2 = CTD(textBoxTabCO2OilF3CO2Concentration.Text, textBoxTabCO2OilF3CO2Concentration);
            if (co2 == null) return;

            var massOfOil = CTD(textBoxTabCO2OilF3MassOfOil.Text, textBoxTabCO2OilF3MassOfOil);
            if (massOfOil == null) return;

            var answer = (5.7 / 10000000) * co2 * massOfOil;
            DisplayAnswer(answer, textBoxTabCO2OilF3Answer);
        }

        private void buttonTabCO2FlowF1CO2Calculate_Click(object sender, EventArgs e)
        {
            var co2 = CTD(textBoxTabCO2FlowF1CO2Concentration.Text, textBoxTabCO2FlowF1CO2Concentration);
            if (co2 == null) return;

            var flow = CTD(textBoxTabCO2FlowF1Flow.Text, textBoxTabCO2FlowF1Flow);
            if (flow == null) return;

            var answer = (5.7 / 10000000) * co2 * flow;
            DisplayAnswer(answer, textBoxTabCO2FlowF1Answer);
        }

        private void buttonTabHTIPGasF1Calculate_Click(object sender, EventArgs e)
        {
            var gcv = CTD(textBoxTabHTIPGasF1GCV.Text, textBoxTabHTIPGasF1GCV);
            if (gcv == null) return;

            var gasFlow = CTD(textBoxTabHTIPGasF1GasFlow.Text, textBoxTabHTIPGasF1GasFlow);
            if (gasFlow == null) return;

            var answer = gcv * gasFlow / 1000000;
            DisplayAnswer(answer, textBoxTabHTIPGasF1Answer);
        }

        private void buttonTabHTIPGasF2Answer_Click(object sender, EventArgs e)
        {
            var gasFlow = CTD(textBoxTabHTIPGasF2GasFlow.Text, textBoxTabHTIPGasF2GasFlow);
            if (gasFlow == null) return;

            var co2 = CTD(textBoxTabHTIPGasF2CO2Concentration.Text, textBoxTabHTIPGasF2CO2Concentration);
            if (co2 == null) return;

            var fc = CTD(textBoxTabHTIPGasF2FuelFactor.Text, textBoxTabHTIPGasF2FuelFactor);
            if (fc == null) return;

            var answer = (gasFlow * co2) / (fc * 100);
            DisplayAnswer(answer, textBoxTabHTIPGasF2Answer);

        }

        private void buttonTabHTIPOilF1Calculate_Click(object sender, EventArgs e)
        {
            var gcv = CTD(textBoxTabHTIPOilF1GCV.Text, textBoxTabHTIPOilF1GCV);
            if (gcv == null) return;

            var massOfOil = CTD(textBoxTabHTIPOilF1MassOfOil.Text, textBoxTabHTIPOilF1MassOfOil);
            if (massOfOil == null) return;

            var answer = gcv * massOfOil / 1000000;
            DisplayAnswer(answer, textBoxTabHTIPOilF1Answer);
        }

        private void buttonTabHTIPOilF2Calculate_Click(object sender, EventArgs e)
        {
            var massOfOil = CTD(textBoxTabHTIPOilF2MassOfOil.Text, textBoxTabHTIPOilF2MassOfOil);
            if (massOfOil == null) return;

            var co2 = CTD(textBoxTabHTIPOilF2CO2Concentration.Text, textBoxTabHTIPOilF2CO2Concentration);
            if (co2 == null) return;

            var fc = CTD(textBoxTabHTIPOilF2FuelFactor.Text, textBoxTabHTIPOilF2FuelFactor);
            if (fc == null) return;

            var answer = (massOfOil * co2) / (fc * 100);
            DisplayAnswer(answer, textBoxTabHTIPOilF2Answer);
        }

        private void buttonTabHTIPFlowF1Calculate_Click(object sender, EventArgs e)
        {
            var flow = CTD(textBoxTabHTIPFlowF1Flow.Text, textBoxTabHTIPFlowF1Flow);
            if (flow == null) return;

            var co2 = CTD(textBoxTabHTIPFlowF1CO2Concentration.Text, textBoxTabHTIPFlowF1CO2Concentration);
            if (co2 == null) return;

            var fc = CTD(textBoxTabHTIPFlowF1FuelFactor.Text, textBoxTabHTIPFlowF1FuelFactor);
            if (fc == null) return;

            var answer = flow * (1 / fc) * (co2 / 100);
            DisplayAnswer(answer, textBoxTabHTIPFlowF1Answer);
        }

        private void buttonTabSO2GasF1Calculate_Click(object sender, EventArgs e)
        {
            var htip = CTD(textBoxTabSO2GasF1HTIP.Text, textBoxTabSO2GasF1HTIP);
            if (htip == null) return;

            var answer = htip * 0.0006;
            DisplayAnswer(answer, textBoxTabSO2GasF1Answer);
        }

        private void buttonTabSO2GasF2Calculate_Click(object sender, EventArgs e)
        {
            var so2 = CTD(textBoxTabSO2GasF2SO2Concentration.Text, textBoxTabSO2GasF2SO2Concentration);
            if (so2 == null) return;

            var gasFlow = CTD(textBoxTabSO2GasF2GasFlow.Text, textBoxTabSO2GasF2GasFlow);
            if (gasFlow == null) return;

            var answer = 0.000000166 * so2 * gasFlow;
            DisplayAnswer(answer, textBoxTabSO2GasF2Answer);
        }

        private void buttonTabSO2OilF1Calculate_Click(object sender, EventArgs e)
        {
            var massOfOil = CTD(textBoxTabSO2OilF1MassOfOil.Text, textBoxTabSO2OilF1MassOfOil);
            if (massOfOil == null) return;

            var sulfur = CTD(textBoxTabSO2OilF1SulfurContent.Text, textBoxTabSO2OilF1SulfurContent);
            if (sulfur == null) return;

            var answer = 2 * massOfOil * sulfur / 100;
            DisplayAnswer(answer, textBoxTabSO2OilF1Answer);
        }

        private void buttonTabSO2OilF2Calculate_Click(object sender, EventArgs e)
        {
            var massOfOil = CTD(textBoxTabSO2OilF2MassOfOil.Text, textBoxTabSO2OilF2MassOfOil);
            if (massOfOil == null) return;

            var sulfur = CTD(textBoxTabSO2OilF2SulfurContent.Text, textBoxTabSO2OilF2SulfurContent);
            if (sulfur == null) return;

            var answer = 2 * massOfOil * sulfur / 100;
            DisplayAnswer(answer, textBoxTabSO2OilF2Answer);
        }

        private void buttonTabSO2OilF3Calculate_Click(object sender, EventArgs e)
        {
            var so2 = CTD(textBoxTabSO2OilF3SO2Concentration.Text, textBoxTabSO2OilF3SO2Concentration);
            if (so2 == null) return;

            var massOfOil = CTD(textBoxTabSO2OilF3MassOfOil.Text, textBoxTabSO2OilF3MassOfOil);
            if (massOfOil == null) return;

            var answer = 0.000000166 * so2 * massOfOil;
            DisplayAnswer(answer, textBoxTabSO2OilF3Answer);
        }

        private void buttonTabSO2FlowF1Calculate_Click(object sender, EventArgs e)
        {
            var so2 = CTD(textBoxTabSO2FlowF1SO2Concentration.Text, textBoxTabSO2FlowF1SO2Concentration);
            if (so2 == null) return;

            var flow = CTD(textBoxTabSO2FlowF1Flow.Text, textBoxTabSO2FlowF1Flow);
            if (flow == null) return;

            var answer = 0.000000166 * so2 * flow;
            DisplayAnswer(answer, textBoxTabSO2FlowF1Answer);
        }

        private void buttonTabNOxlbsmmBtuF1Calculate_Click(object sender, EventArgs e)
        {
            var nox = CTD(textBoxTabNOxlbsmmBtuF1NOx.Text, textBoxTabNOxlbsmmBtuF1NOx);
            if (nox == null) return;

            var co2 = CTD(textBoxTabNOxlbsmmBtuF1CO2.Text, textBoxTabNOxlbsmmBtuF1CO2);
            if (co2 == null) return;

            var fc = CTD(textBoxTabNOxlbsmmBtuF1Fc.Text, textBoxTabNOxlbsmmBtuF1Fc);
            if (fc == null) return;

            var baf = CTD(textBoxTabNOxlbsmmBtuF1BAF.Text, textBoxTabNOxlbsmmBtuF1BAF);
            if (baf == null) return;

            var answer = (0.0000001194 * nox * fc * (100 / co2)) * baf;
            textBoxTabNOxlbsmmBtuF1Answer.Text = $@"{answer:N3}";
        }

        private void buttonTabNOxlbsmmBtuF2Calculate_Click(object sender, EventArgs e)
        {
            var nox = CTD(textBoxTabNOxlbsmmBtuF2NOx.Text, textBoxTabNOxlbsmmBtuF2NOx);
            if (nox == null) return;

            var o2 = CTD(textBoxTabNOxlbsmmBtuF2O2.Text, textBoxTabNOxlbsmmBtuF2O2);
            if (o2 == null) return;

            var fc = CTD(textBoxTabNOxlbsmmBtuF2Fc.Text, textBoxTabNOxlbsmmBtuF2Fc);
            if (fc == null) return;

            var baf = CTD(textBoxTabNOxlbsmmBtuF2BAF.Text, textBoxTabNOxlbsmmBtuF2BAF);
            if (baf == null) return;

            var answer = 0.0000001194 * nox * fc * (20.9 / (20.9 - o2)) * baf;
            textBoxTabNOxlbsmmBtuF2Answer.Text = $@"{answer:N3}";
        }

        private void buttonTabNOxlbshrF1Calculate_Click(object sender, EventArgs e)
        {
            var nox = CTD(textBoxTabNOxlbshrF1NOx.Text, textBoxTabNOxlbshrF1NOx);
            if (nox == null) return;

            var flow = CTD(textBoxTabNOxlbshrF1Fc.Text, textBoxTabNOxlbshrF1Fc);
            if (flow == null) return;

            var ot = CTD(textBoxTabNOxlbshrF1OT.Text, textBoxTabNOxlbshrF1OT);
            if (ot == null) return;

            var answer = 0.0000001194 * nox * flow * ot;
            DisplayAnswer(answer, textBoxTabNOxlbshrF1Answer);
        }

        private void buttonTabNOxlbshrF2Answer_Click(object sender, EventArgs e)
        {
            var nox = CTD(textBoxTabNOxlbshrF2NOx.Text, textBoxTabNOxlbshrF2NOx);
            if (nox == null) return;

            var htip = CTD(textBoxTabNOxlbshrF2HTIP.Text, textBoxTabNOxlbshrF2HTIP);
            if (htip == null) return;

            var ot = CTD(textBoxTabNOxlbshrF2OT.Text, textBoxTabNOxlbshrF2OT);
            if (ot == null) return;

            var answer = nox * htip * ot;
            DisplayAnswer(answer, textBoxTabNOxlbshrF2Answer);
        }

        private void buttonTabNOxppmvdF1Calculate_Click(object sender, EventArgs e)
        {
            var nox = CTD(textBoxTabNOxppmvdF1NOx.Text, textBoxTabNOxppmvdF1NOx);
            if (nox == null) return;

            var o2 = CTD(textBoxTabNOxppmvdF1O2.Text, textBoxTabNOxppmvdF1O2);
            if (o2 == null) return;

            var answer = ((20.9 - 15) * nox) / (20.9 - o2);
            DisplayAnswer(answer, textBoxTabNOxppmvdF1Answer);
        }

        private void buttonTabNOxppmvdF2Calculate_Click(object sender, EventArgs e)
        {
            var nox = CTD(textBoxTabNOxppmvdF2NOx.Text, textBoxTabNOxppmvdF2NOx);
            if (nox == null) return;

            var co2 = CTD(textBoxTabNOxppmvdF2CO2.Text, textBoxTabNOxppmvdF2CO2);
            if (co2 == null) return;

            var xco2 = comboBoxTabNOxppmvdF2XCO2;
            if (xco2.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose XCO2", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxTabNOxppmvdF2XCO2.Focus();
                return;
            }

            double.TryParse(xco2.SelectedItem.ToString(), out var xco2Number);

            var answer = ((nox * xco2Number) / co2);
            DisplayAnswer(answer, textBoxTabNOxppmvdF2Answer);
        }

        private void buttonTabFuelFactorF1Calculate_Click(object sender, EventArgs e)
        {
            var htipOil = CTD(textBoxTabFuelFactorF1HTIPOil.Text, textBoxTabFuelFactorF1HTIPOil);
            if (htipOil == null) return;

            var htipGas = CTD(textBoxTabFuelFactorF1HTIPGas.Text, textBoxTabFuelFactorF1HTIPGas);
            if (htipGas == null) return;

            var answer = (htipOil * 1420 + htipGas * 1040) / (htipOil + htipGas);
            DisplayAnswer(answer, textBoxTabFuelFactorF1Answer);
        }

        private void buttonTabCoalF1Calculate_Click(object sender, EventArgs e)
        {
            var ff = CTD(textBoxTabCoalF1FuelFlow.Text, textBoxTabCoalF1FuelFlow);
            if (ff == null) return;

            var co2 = CTD(textBoxTabCoalF1CO2Concentration.Text, textBoxTabCoalF1CO2Concentration);
            if (co2 == null) return;

            var fc = CTD(textBoxTabCoalF1FuelFactor.Text, textBoxTabCoalF1FuelFactor);
            if (fc == null) return;

            var answer = (ff * 1000 * co2) / (fc * 100);
            DisplayAnswer(answer, textBoxTabCoalF1Answer);
        }

        private void buttonTabCoalF2Calculate_Click(object sender, EventArgs e)
        {
            var so2 = CTD(textBoxTabCoalF2SO2Concentration.Text, textBoxTabCoalF2SO2Concentration);
            if (so2 == null) return;

            var ff = CTD(textBoxTabCoalF2FuelFlow.Text, textBoxTabCoalF2FuelFlow);
            if (ff == null) return;

            var answer = 0.000000166 * so2 * ff * 1000;
            DisplayAnswer(answer, textBoxTabCoalF2Answer);
        }

        private void buttonTabCoalF3Calculate_Click(object sender, EventArgs e)
        {
            var co2 = CTD(textBoxTabCoalF3CO2Concentration.Text, textBoxTabCoalF3CO2Concentration);
            if (co2 == null) return;

            var ff = CTD(textBoxTabCoalF3FuelFlow.Text, textBoxTabCoalF3FuelFlow);
            if (ff == null) return;

            var answer = (5.7 / 10000000) * co2 * ff * 1000;
            DisplayAnswer(answer, textBoxTabCoalF3Answer);
        }

        private void buttonTabCoalF4Calculate_Click(object sender, EventArgs e)
        {
            var nox = CTD(textBoxTabCoalF4NOx.Text, textBoxTabCoalF4NOx);
            if (nox == null) return;

            var co2 = CTD(textBoxTabCoalF4CO2.Text, textBoxTabCoalF4CO2);
            if (co2 == null) return;

            var fc = CTD(textBoxTabCoalF4Fc.Text, textBoxTabCoalF4Fc);
            if (fc == null) return;

            var baf = CTD(textBoxTabCoalF4BAF.Text, textBoxTabCoalF4BAF);
            if (baf == null) return;

            var answer = 0.0000001194 * nox * fc * (100 / co2) * baf;
            textBoxTabCoalF4Answer.Text = $@"{answer:N3}";
        }

        private void buttonCOlbsmmBtuF1Calculate_Click(object sender, EventArgs e)
        {
            var co = CTD(textBoxTabCOlbsmmBtuF1CO.Text, textBoxTabCOlbsmmBtuF1CO);
            if (co == null) return;

            var co2 = CTD(textBoxTabCOlbsmmBtuF1CO2.Text, textBoxTabCOlbsmmBtuF1CO2);
            if (co2 == null) return;

            var fc = CTD(textBoxTabCOlbsmmBtuF1FuelFactor.Text, textBoxTabCOlbsmmBtuF1FuelFactor);
            if (fc == null) return;

            var answer = 0.00000007263 * co * fc * (100 / co2);
            textBoxTabCOlbsmmBtuF1Answer.Text = $@"{answer:N3}";
        }

        private void buttonCOlbsmmBtuF2Calculate_Click(object sender, EventArgs e)
        {
            var co = CTD(textBoxTabCOlbsmmBtuF2CO.Text, textBoxTabCOlbsmmBtuF2CO);
            if (co == null) return;

            var o2 = CTD(textBoxTabCOlbsmmBtuF2O2.Text, textBoxTabCOlbsmmBtuF2O2);
            if (o2 == null) return;

            var fc = CTD(textBoxTabCOlbsmmBtuF2FuelFactor.Text, textBoxTabCOlbsmmBtuF2FuelFactor);
            if (fc == null) return;

            var answer = 0.00000007263 * co * fc * (20.9 / (20.9 - o2));
            textBoxTabCOlbsmmBtuF2Answer.Text = $@"{answer:N3}";
        }

        private void buttonTabCOlbshrF1Calculate_Click(object sender, EventArgs e)
        {
            var co = CTD(textBoxTabCOlbshrF1CO.Text, textBoxTabCOlbshrF1CO);
            if (co == null) return;

            var htip = CTD(textBoxTabCOlbshrF1HTIP.Text, textBoxTabCOlbshrF1HTIP);
            if (htip == null) return;

            var answer = co * htip;
            DisplayAnswer(answer, textBoxTabCOlbshrF1Answer);
        }

        private void buttonTabCOppmvdF1Calculate_Click(object sender, EventArgs e)
        {
            var co = CTD(textBoxTabCOppmvdF1CO.Text, textBoxTabCOppmvdF1CO);
            if (co == null) return;

            var o2 = CTD(textBoxTabCOppmvdF1O2.Text, textBoxTabCOppmvdF1O2);
            if (o2 == null) return;

            var answer = ((20.9 - 15) * co) / (20.9 - o2);
            DisplayAnswer(answer, textBoxTabCOppmvdF1Answer);
        }

        private void buttonTabCOppmvdF2Calculate_Click(object sender, EventArgs e)
        {
            var co = CTD(textBoxTabCOppmvdF2CO.Text, textBoxTabCOppmvdF2CO);
            if (co == null) return;

            var co2 = CTD(textBoxTabCOppmvdF2CO2.Text, textBoxTabCOppmvdF2CO2);
            if (co2 == null) return;

            var baf = comboBoxTabCOppmvdF2XCO2;

            if (baf.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select XCO2", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxTabCOppmvdF2XCO2.Focus();
                return;
            }

            double.TryParse(comboBoxTabCOppmvdF2XCO2.SelectedItem.ToString(), out var bafNumber);

            var answer = (co * bafNumber) / co2;
            DisplayAnswer(answer, textBoxTabCOppmvdF2Answer);
        }

        private void buttonTabOilFlowF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabOilFlowF1OilFlow.Clear();
            textBoxTabOilFlowF1OilFlow.Focus();
            textBoxTabOilFlowF1Density.Clear();
            textBoxTabOilFlowMassF1OilFlow.Clear();
        }

        private void buttonTabCO2GasF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCO2GasF1CarbonContent.Clear();
            textBoxTabCO2GasF1CarbonContent.Focus();
            textBoxTabCO2GasF1GasFlow.Clear();
            textBoxTabCO2F1Answer.Clear();
        }

        private void buttonTabCO2GasF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCO2GasF2HTIP.Clear();
            textBoxTabCO2GasF2HTIP.Focus();
            textBoxTabCO2GasF2Answer.Clear();
        }

        private void buttonTabCO2GasF3Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCO2GasF3CO2Concentration.Clear();
            textBoxTabCO2GasF3CO2Concentration.Focus();
            textBoxTabCO2GasF3GasFlow.Clear();
            textBoxTabCO2GasF3Answer.Clear();
        }

        private void buttonTabCO2OilF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCO2OilF1CarbonContent.Clear();
            textBoxTabCO2OilF1CarbonContent.Focus();
            textBoxTabCO2OilF1MassOil.Clear();
            textBoxTabCO2OilF1Answer.Clear();
        }

        private void buttonTabCO2OilF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCO2OilF2HTIP.Clear();
            textBoxTabCO2OilF2HTIP.Focus();
            textBoxTabCO2OilF2Answer.Clear();
        }

        private void buttonTabCO2FlowF1CO2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCO2FlowF1CO2Concentration.Clear();
            textBoxTabCO2FlowF1CO2Concentration.Focus();
            textBoxTabCO2FlowF1Flow.Clear();
            textBoxTabCO2FlowF1Answer.Clear();
        }

        private void buttonTabHTIPGasF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabHTIPGasF1GCV.Clear();
            textBoxTabHTIPGasF1GCV.Focus();
            textBoxTabHTIPGasF1GasFlow.Clear();
            textBoxTabHTIPGasF1Answer.Clear();
        }

        private void buttonTabHTIPGasF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabHTIPGasF2GasFlow.Clear();
            textBoxTabHTIPGasF2GasFlow.Focus();
            textBoxTabHTIPGasF2CO2Concentration.Clear();
            textBoxTabHTIPGasF2FuelFactor.Clear();
            textBoxTabHTIPGasF2Answer.Clear();
        }

        private void buttonTabHTIPOilF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabHTIPOilF1GCV.Clear();
            textBoxTabHTIPOilF1GCV.Focus();
            textBoxTabHTIPOilF1MassOfOil.Clear();
            textBoxTabHTIPOilF1Answer.Clear();
        }

        private void buttonTabHTIPOilF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabHTIPOilF2MassOfOil.Clear();
            textBoxTabHTIPOilF2MassOfOil.Focus();
            textBoxTabHTIPOilF2CO2Concentration.Clear();
            textBoxTabHTIPOilF2FuelFactor.Clear();
            textBoxTabHTIPOilF2Answer.Clear();
        }

        private void buttonTabHTIPFlowF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabHTIPFlowF1Flow.Clear();
            textBoxTabHTIPFlowF1Flow.Focus();
            textBoxTabHTIPFlowF1CO2Concentration.Clear();
            textBoxTabHTIPFlowF1FuelFactor.Clear();
            textBoxTabHTIPFlowF1Answer.Clear();
        }

        private void buttonTabSO2GasF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabSO2GasF1HTIP.Clear();
            textBoxTabSO2GasF1HTIP.Focus();
            textBoxTabSO2GasF1Answer.Clear();
        }

        private void buttonTabSO2GasF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabSO2GasF2SO2Concentration.Clear();
            textBoxTabSO2GasF2SO2Concentration.Focus();
            textBoxTabSO2GasF2GasFlow.Clear();
            textBoxTabSO2GasF2Answer.Clear();
        }

        private void buttonTabSO2OilF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabSO2OilF1MassOfOil.Clear();
            textBoxTabSO2OilF1MassOfOil.Focus();
            textBoxTabSO2OilF1SulfurContent.Clear();
            textBoxTabSO2OilF1Answer.Clear();
        }

        private void buttonTabSO2OilF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabSO2OilF2MassOfOil.Clear();
            textBoxTabSO2OilF2MassOfOil.Focus();
            textBoxTabSO2OilF2SulfurContent.Clear();
            textBoxTabSO2OilF2Answer.Clear();
        }

        private void buttonTabSO2OilF3Clear_Click(object sender, EventArgs e)
        {
            textBoxTabSO2OilF3SO2Concentration.Clear();
            textBoxTabSO2OilF3SO2Concentration.Focus();
            textBoxTabSO2OilF3MassOfOil.Clear();
            textBoxTabSO2OilF3Answer.Clear();
        }

        private void buttonTabSO2FlowF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabSO2FlowF1SO2Concentration.Clear();
            textBoxTabSO2FlowF1SO2Concentration.Focus();
            textBoxTabSO2FlowF1Flow.Clear();
            textBoxTabSO2FlowF1Answer.Clear();
        }

        private void buttonTabNOxlbsmmBtuF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabNOxlbsmmBtuF1NOx.Clear();
            textBoxTabNOxlbsmmBtuF1NOx.Focus();
            textBoxTabNOxlbsmmBtuF1CO2.Clear();
            textBoxTabNOxlbsmmBtuF1Fc.Clear();
            textBoxTabNOxlbsmmBtuF1BAF.Clear();
            textBoxTabNOxlbsmmBtuF1Answer.Clear();
        }

        private void buttonTabNOxlbsmmBtuF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabNOxlbsmmBtuF2NOx.Clear();
            textBoxTabNOxlbsmmBtuF2NOx.Focus();
            textBoxTabNOxlbsmmBtuF2O2.Clear();
            textBoxTabNOxlbsmmBtuF2Fc.Clear();
            textBoxTabNOxlbsmmBtuF2BAF.Clear();
            textBoxTabNOxlbsmmBtuF2Answer.Clear();
        }

        private void buttonTabNOxlbshrF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabNOxlbshrF1NOx.Clear();
            textBoxTabNOxlbshrF1NOx.Focus();
            textBoxTabNOxlbshrF1Fc.Clear();
            textBoxTabNOxlbshrF1OT.Clear();
            textBoxTabNOxlbshrF1Answer.Clear();
        }

        private void buttonTabNOxlbshrF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabNOxlbshrF2NOx.Clear();
            textBoxTabNOxlbshrF2NOx.Focus();
            textBoxTabNOxlbshrF2HTIP.Clear();
            textBoxTabNOxlbshrF2OT.Clear();
            textBoxTabNOxlbshrF2Answer.Clear();
        }

        private void buttonTabNOxppmvdF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabNOxppmvdF1NOx.Clear();
            textBoxTabNOxppmvdF1NOx.Focus();
            textBoxTabNOxppmvdF1O2.Clear();
            textBoxTabNOxppmvdF1Answer.Clear();
        }

        private void buttonTabNOxppmvdF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabNOxppmvdF2NOx.Clear();
            textBoxTabNOxppmvdF2NOx.Focus();
            textBoxTabNOxppmvdF2CO2.Clear();
            comboBoxTabNOxppmvdF2XCO2.SelectedIndex = 0;
            textBoxTabNOxppmvdF2Answer.Clear();
        }

        private void buttonTabFuelFactorF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabFuelFactorF1HTIPOil.Clear();
            textBoxTabFuelFactorF1HTIPOil.Focus();
            textBoxTabFuelFactorF1HTIPGas.Clear();
            textBoxTabFuelFactorF1Answer.Clear();
        }

        private void buttonTabCoalF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCoalF1FuelFlow.Clear();
            textBoxTabCoalF1FuelFlow.Focus();
            textBoxTabCoalF1CO2Concentration.Clear();
            textBoxTabCoalF1FuelFactor.Clear();
            textBoxTabCoalF1Answer.Clear();
        }

        private void buttonTabCoalF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCoalF2SO2Concentration.Clear();
            textBoxTabCoalF2SO2Concentration.Focus();
            textBoxTabCoalF2FuelFlow.Clear();
            textBoxTabCoalF2Answer.Clear();
        }

        private void buttonTabCoalF3Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCoalF3CO2Concentration.Clear();
            textBoxTabCoalF3CO2Concentration.Focus();
            textBoxTabCoalF3FuelFlow.Clear();
            textBoxTabCoalF3Answer.Clear();
        }

        private void buttonTabCoalF4Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCoalF4NOx.Clear();
            textBoxTabCoalF4NOx.Focus();
            textBoxTabCoalF4CO2.Clear();
            textBoxTabCoalF4Fc.Clear();
            textBoxTabCoalF4BAF.Clear();
            textBoxTabCoalF4Answer.Clear();
        }

        private void buttonCOlbsmmBtuF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCOlbsmmBtuF1CO.Clear();
            textBoxTabCOlbsmmBtuF1CO.Focus();
            textBoxTabCOlbsmmBtuF1CO2.Clear();
            textBoxTabCOlbsmmBtuF1FuelFactor.Clear();
            textBoxTabCOlbsmmBtuF1Answer.Clear();
        }

        private void buttonCOlbsmmBtuF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCOlbsmmBtuF2CO.Clear();
            textBoxTabCOlbsmmBtuF2CO.Focus();
            textBoxTabCOlbsmmBtuF2O2.Clear();
            textBoxTabCOlbsmmBtuF2FuelFactor.Clear();
            textBoxTabCOlbsmmBtuF2Answer.Clear();
        }

        private void buttonTabCOlbshrF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCOlbshrF1CO.Clear();
            textBoxTabCOlbshrF1CO.Focus();
            textBoxTabCOlbshrF1HTIP.Clear();
            textBoxTabCOlbshrF1Answer.Clear();
        }

        private void buttonTabCOppmvdF1Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCOppmvdF1CO.Clear();
            textBoxTabCOppmvdF1CO.Focus();
            textBoxTabCOppmvdF1O2.Clear();
            textBoxTabCOppmvdF1Answer.Clear();
        }

        private void buttonTabCOppmvdF2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCOppmvdF2CO.Clear();
            textBoxTabCOppmvdF2CO.Focus();
            textBoxTabCOppmvdF2CO2.Clear();
            comboBoxTabCOppmvdF2XCO2.SelectedIndex = 0;
            textBoxTabCOppmvdF2Answer.Clear();
        }

        private void buttonTabCO2OilF3Clear_Click(object sender, EventArgs e)
        {
            textBoxTabCO2OilF3CO2Concentration.Clear();
            textBoxTabCO2OilF3CO2Concentration.Focus();
            textBoxTabCO2OilF3MassOfOil.Clear();
            textBoxTabCO2OilF3Answer.Clear();
        }

        private void buttonDefinitions_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("Definitions_View");
            folderName = "";
            LoadDashboardViewModel(dataSet, "Definitions", "", "", "");
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            var max = dropDownDictionary.Count;
            var n = new Random().Next(0, max - 1);

            LoadDashboard(n);
            comboBoxSectionNumber.SelectedIndex = n;

        }

        private void buttonSoftwareQuestions_Click(object sender, EventArgs e)
        {
            SoftwarePassword sw = new SoftwarePassword();
            sw.ShowDialog();

            if (SoftwarePassword.SWPassword)
            {
                MessageBox.Show("Access Granted", "CEMS Study");
            }
            else
            {
                MessageBox.Show("Access Not Granted", "CEMS Study");

            }
        }
    }
}
