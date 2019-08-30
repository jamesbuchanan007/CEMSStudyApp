using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Globalization;
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
        public static double tabHgHGRHAnswer { get; set; }
        public static double tabHgHGREAnswer { get; set; }
        public static double tabHglbhrAnswer { get; set; }
        public static int searchIndex { get; set; }
        public static bool isFullManualFunction { get; set; }

        public MainDashboard()
        {
            InitializeComponent(); //LOAD COMBOBOX PAGES

            this.Font = SystemFonts.IconTitleFont;
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            this.FormClosing += Form1_FormClosing;

            try
            {
                var version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
                labelVersion.Text = "Version: " + version;

            }
            catch (Exception e)
            {
                labelVersion.Text = "Version: Debug";
            }

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

            comboBoxSearch.SelectedIndex = 0;
            comboBoxSearch.ForeColor = Color.Gray;
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
            SystemEvents.UserPreferenceChanged -= SystemEvents_UserPreferenceChanged;
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
                MessageBox.Show("Can not open connection !! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return ds;
        }

        private void LoadDashboardViewModel(DataSet dataSet, string sectionColumnName, string sectionNumber, string file_LocationColumnName, string definitionColumnName)
        {
            string definition;
            string file_Location;
            string sectionName;
            string sectionHeading = "";
            string dropDown = "";

            //CHECK IF TABLE IS EMPTY
            if (dataSet.Tables[0].Rows.Count == 0) return;

            //INITIALIZE DICTIONARIES
            dashboardDictionary = new Dictionary<int, DashboardViewModel>();
            dropDownDictionary = new Dictionary<int, string>();

            if (sectionColumnName == "Elements")
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    var name = dataSet.Tables[0].Rows[i]["Name"].ToString();
                    var description = dataSet.Tables[0].Rows[i]["Description"].ToString();

                    //LOAD DASHBOARD DICTIONARY
                    dashboardDictionary.Add(i, new DashboardViewModel()
                    {
                        Heading = "Elements and Gas Types",
                        Section_Name = "",
                        File_Location = "",
                        Definition = description
                    });

                    dropDown = name;

                    //LOAD DROPDOWN DICTIONARY
                    dropDownDictionary.Add(i, dropDown);
                }
            }
            else
            {
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
                        dropDown = word + " - " + subHeading;

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

                        dropDown = dataSet.Tables[0].Rows[i][sectionNumber].ToString();

                        //LOAD DROPDOWN DICTIONARY
                        dropDownDictionary.Add(i, dropDown);
                    }
                }
            }



            //LOAD DROP DOWN NAVIGATION
            comboBoxSectionNumber.DataSource = new BindingSource(dropDownDictionary, null);
            comboBoxSectionNumber.ValueMember = "Key";
            comboBoxSectionNumber.DisplayMember = "Value";

            if (isFullManualFunction) comboBoxSectionNumber.SelectedIndex = searchIndex;
        }

        private void LoadDashboard(int index)
        {
            if (isFullManualFunction) index = searchIndex;
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
                    case "Chemical Compounds and Elements":
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
                        var tabIndex = comboBoxSectionNumber.SelectedIndex;
                        ShowTab(tabIndex);
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
                var path = exePath + fileName + ".pdf#toolbar=1&navpanes=0"; //PATH STRING
                path = path.Replace(@"\", "/");

                //GET PDF
                webBrowserPdf?.Navigate(new Uri(path));
            }

        }

        private void ShowTab(int tabIndex)
        {
            switch (tabIndex)
            {
                case 0:
                    tabFormulasMain.SelectTab(tabPage4_20ma);
                    break;
                case 1:
                    tabFormulasMain.SelectTab(tabCOlbshr);
                    break;
                case 2:
                    tabFormulasMain.SelectTab(tabColbsmmBtu);
                    break;
                case 3:
                    tabFormulasMain.SelectTab(tabCOppmvd);
                    break;
                case 4:
                    tabFormulasMain.SelectTab(tabCO2Flow);
                    break;
                case 5:
                    tabFormulasMain.SelectTab(tabCO2Gas);
                    break;
                case 6:
                    tabFormulasMain.SelectTab(tabCO2Oil);
                    break;
                case 7:
                    tabFormulasMain.SelectTab(tabCoal);
                    break;
                case 8:
                    tabFormulasMain.SelectTab(tabFuelFactor);
                    break;
                case 9:
                    tabFormulasMain.SelectTab(tabHeatInputFlow);
                    break;
                case 10:
                    tabFormulasMain.SelectTab(tabHeatInputGas);
                    break;
                case 11:
                    tabFormulasMain.SelectTab(tabHeatInputOil);
                    break;
                case 12:
                    tabFormulasMain.SelectTab(tabPageHg);
                    break;
                case 13:
                    tabFormulasMain.SelectTab(tabPageLME_HI);
                    break;
                case 14:
                    tabFormulasMain.SelectTab(tabPageLME_Mass);
                    break;
                case 15:
                    tabFormulasMain.SelectTab(tabNOxlbshr);
                    break;
                case 16:
                    tabFormulasMain.SelectTab(tabNOxlbsmmBtu);
                    break;
                case 17:
                    tabFormulasMain.SelectTab(tabNOxppmvd);
                    break;
                case 18:
                    tabFormulasMain.SelectTab(tabOilFlow);
                    break;
                case 19:
                    tabFormulasMain.SelectTab(tabSO2Flow);
                    break;
                case 20:
                    tabFormulasMain.SelectTab(tabSO2Gas);
                    break;
                case 21:
                    tabFormulasMain.SelectTab(tabSO2Oil);
                    break;
                case 22:
                    tabFormulasMain.SelectTab(tabTime);
                    break;

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
            isFullManualFunction = false;

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
            isFullManualFunction = false;

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

            if (dashboardDictionary.Count == 0) return;

            LoadDashboard(comboBoxSectionNumber.SelectedIndex);
        }

        private void buttonAcronyms_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("Acronyms_View");
            folderName = "";
            LoadDashboardViewModel(dataSet, "Acronyms_Name", "Acronyms_Name", "", "Acronyms_Description");
        }

        private void buttonFormulas_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("Formulas_View");
            folderName = "";
            LoadDashboardViewModel(dataSet, "Formulas_Name", "Formulas_Description", "", "");
            // LoadDashboard(0);
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
            var dataSet = LoadTable("UnitOfMeasure_View");
            folderName = "";
            LoadDashboardViewModel(dataSet, "UnitOfMeasure_Name", "UnitOfMeasure_Name", "", "UnitOfMeasure_Description");
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
            var dataSet = LoadTable("Part75_View");
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
            //OIL FLOW IN GALS/MIN
            var oilFlow = CTD(textBoxTabOilFlowF1OilFlow.Text, textBoxTabOilFlowF1OilFlow);
            if (oilFlow == null) return;

            //OIL DENSITY IN LBS/GAL
            var oilDensity = CTD(textBoxTabOilFlowF1Density.Text, textBoxTabOilFlowF1Density);
            if (oilDensity == null) return;

            //MASS OIL FLOW LBS/HR
            var answer = oilFlow * oilDensity;
            DisplayAnswer(answer, textBoxTabOilFlowMassF1OilFlow);
        }

        private void buttonTabCO2GasF1Calculate_Click(object sender, EventArgs e)
        {
            //CARBON CONTENT FOR GAS %
            var carbonContent = CTD(textBoxTabCO2GasF1CarbonContent.Text, textBoxTabCO2GasF1CarbonContent);
            if (carbonContent == null) return;

            //GAS FLOW IN 100 SCFH
            var gasFlow = CTD(textBoxTabCO2GasF1GasFlow.Text, textBoxTabCO2GasF1GasFlow);
            if (gasFlow == null) return;

            //CO2 TONS/HR
            var answer = ((carbonContent / 100 * gasFlow * 100 * 0.0452) * 44) / (2000 * 12);
            DisplayAnswer(answer, textBoxTabCO2F1Answer);
        }

        private void buttonTabCO2GasF2Calculate_Click(object sender, EventArgs e)
        {
            //HEAT INPUT FOR GAS
            var htip = CTD(textBoxTabCO2GasF2HTIP.Text, textBoxTabCO2GasF2HTIP);
            if (htip == null) return;

            //CO2 TONS/HR
            var answer = (htip * 1040) * (1.0 / 385) * (44.0 / 2000);
            DisplayAnswer(answer, textBoxTabCO2GasF2Answer);
        }

        private void buttonTabCO2GasF3Calculate_Click(object sender, EventArgs e)
        {
            //CO2 CONCENTRATION %
            var co2 = CTD(textBoxTabCO2GasF3CO2Concentration.Text, textBoxTabCO2GasF3CO2Concentration);
            if (co2 == null) return;

            //GAS FLOW
            var gasFlow = CTD(textBoxTabCO2GasF3GasFlow.Text, textBoxTabCO2GasF3GasFlow);
            if (gasFlow == null) return;

            //COT TONS/HR
            var answer = (5.7 / 10000000) * co2 * gasFlow;
            DisplayAnswer(answer, textBoxTabCO2GasF3Answer);
        }

        private void buttonTabCO2OilF1Calculate_Click(object sender, EventArgs e)
        {
            //CARBON CONTENT FOR OIL %
            var carbonContent = CTD(textBoxTabCO2OilF1CarbonContent.Text, textBoxTabCO2OilF1CarbonContent);
            if (carbonContent == null) return;

            //MASS OF OIL LB/HR
            var massOil = CTD(textBoxTabCO2OilF1MassOil.Text, textBoxTabCO2OilF1MassOil);
            if (massOil == null) return;

            //CO2 TONS/HR
            var answer = ((carbonContent / 100 * massOil) * 44) / (2000 * 12);
            DisplayAnswer(answer, textBoxTabCO2OilF1Answer);
        }

        private void buttonTabCO2OilF2Calculate_Click(object sender, EventArgs e)
        {
            //HEAT INPUT FOR OIL
            var htip = CTD(textBoxTabCO2OilF2HTIP.Text, textBoxTabCO2OilF2HTIP);
            if (htip == null) return;

            //CO2 TONS/HR
            var answer = htip * 1420 * (1.0 / 385) * (44.0 / 2000);
            DisplayAnswer(answer, textBoxTabCO2OilF2Answer);
        }

        private void buttonTabCO2OilF3Calculate_Click(object sender, EventArgs e)
        {
            //CO2 CONCENTRATION %
            var co2 = CTD(textBoxTabCO2OilF3CO2Concentration.Text, textBoxTabCO2OilF3CO2Concentration);
            if (co2 == null) return;

            //MASS OF OIL
            var massOfOil = CTD(textBoxTabCO2OilF3MassOfOil.Text, textBoxTabCO2OilF3MassOfOil);
            if (massOfOil == null) return;

            //CO2 TONS/HR
            var answer = (5.7 / 10000000) * co2 * massOfOil;
            DisplayAnswer(answer, textBoxTabCO2OilF3Answer);
        }

        private void buttonTabCO2FlowF1CO2Calculate_Click(object sender, EventArgs e)
        {
            //CO2 CONCENTRATION %
            var co2 = CTD(textBoxTabCO2FlowF1CO2Concentration.Text, textBoxTabCO2FlowF1CO2Concentration);
            if (co2 == null) return;

            //VOLUMETRIC FLOW SCFH
            var flow = CTD(textBoxTabCO2FlowF1Flow.Text, textBoxTabCO2FlowF1Flow);
            if (flow == null) return;

            //CO2 TONS/HR
            var answer = (5.7 / 10000000) * co2 * flow;
            DisplayAnswer(answer, textBoxTabCO2FlowF1Answer);
        }

        private void buttonTabHTIPGasF1Calculate_Click(object sender, EventArgs e)
        {
            //GROSS CALORIFIC VALUE FOR GAS
            var gcv = CTD(textBoxTabHTIPGasF1GCV.Text, textBoxTabHTIPGasF1GCV);
            if (gcv == null) return;

            //GAS FLOW 100/SCFH
            var gasFlow = CTD(textBoxTabHTIPGasF1GasFlow.Text, textBoxTabHTIPGasF1GasFlow);
            if (gasFlow == null) return;

            //HTIP MM/BTU
            var answer = gcv * gasFlow / 1000000;
            DisplayAnswer(answer, textBoxTabHTIPGasF1Answer);
        }

        private void buttonTabHTIPGasF2Answer_Click(object sender, EventArgs e)
        {
            //GAS FLOW 100/SCFH
            var gasFlow = CTD(textBoxTabHTIPGasF2GasFlow.Text, textBoxTabHTIPGasF2GasFlow);
            if (gasFlow == null) return;

            //CO2 CONCENTRATION %
            var co2 = CTD(textBoxTabHTIPGasF2CO2Concentration.Text, textBoxTabHTIPGasF2CO2Concentration);
            if (co2 == null) return;

            //FUEL FACTOR 1040 FOR GAS
            var fc = CTD(textBoxTabHTIPGasF2FuelFactor.Text, textBoxTabHTIPGasF2FuelFactor);
            if (fc == null) return;

            //HTIP MM/BTU
            var answer = (gasFlow * co2) / (fc * 100);
            DisplayAnswer(answer, textBoxTabHTIPGasF2Answer);

        }

        private void buttonTabHTIPOilF1Calculate_Click(object sender, EventArgs e)
        {
            //GROSS CALORIFIC VALUE FOR OIL
            var gcv = CTD(textBoxTabHTIPOilF1GCV.Text, textBoxTabHTIPOilF1GCV);
            if (gcv == null) return;

            //MASS OF OIL LBS/HR
            var massOfOil = CTD(textBoxTabHTIPOilF1MassOfOil.Text, textBoxTabHTIPOilF1MassOfOil);
            if (massOfOil == null) return;

            //HTIP MM/BTU
            var answer = gcv * massOfOil / 1000000;
            DisplayAnswer(answer, textBoxTabHTIPOilF1Answer);
        }

        private void buttonTabHTIPOilF2Calculate_Click(object sender, EventArgs e)
        {
            //MASS OF OIL LBS/HR
            var massOfOil = CTD(textBoxTabHTIPOilF2MassOfOil.Text, textBoxTabHTIPOilF2MassOfOil);
            if (massOfOil == null) return;

            //CO2 CONCENTRATION %
            var co2 = CTD(textBoxTabHTIPOilF2CO2Concentration.Text, textBoxTabHTIPOilF2CO2Concentration);
            if (co2 == null) return;

            //FUEL FACTOR 1420 FOR OIL
            var fc = CTD(textBoxTabHTIPOilF2FuelFactor.Text, textBoxTabHTIPOilF2FuelFactor);
            if (fc == null) return;

            //HTIP MM/BTU
            var answer = (massOfOil * co2) / (fc * 100);
            DisplayAnswer(answer, textBoxTabHTIPOilF2Answer);
        }

        private void buttonTabHTIPFlowF1Calculate_Click(object sender, EventArgs e)
        {
            //VOLUMETRIC FLOW SCFH
            var flow = CTD(textBoxTabHTIPFlowF1Flow.Text, textBoxTabHTIPFlowF1Flow);
            if (flow == null) return;

            //CO2 CONCENTRATION %
            var co2 = CTD(textBoxTabHTIPFlowF1CO2Concentration.Text, textBoxTabHTIPFlowF1CO2Concentration);
            if (co2 == null) return;

            //FUEL FACTOR 1420 FOR OIL
            var fc = CTD(textBoxTabHTIPFlowF1FuelFactor.Text, textBoxTabHTIPFlowF1FuelFactor);
            if (fc == null) return;

            //HTIP MM/BTU
            var answer = flow * (1 / fc) * (co2 / 100);
            DisplayAnswer(answer, textBoxTabHTIPFlowF1Answer);
        }

        private void buttonTabSO2GasF1Calculate_Click(object sender, EventArgs e)
        {
            //HEAT INPUT GAS MM/BTU
            var htip = CTD(textBoxTabSO2GasF1HTIP.Text, textBoxTabSO2GasF1HTIP);
            if (htip == null) return;

            //MASS EMISSIONS SO2 LBS/HR
            var answer = htip * 0.0006;
            DisplayAnswer(answer, textBoxTabSO2GasF1Answer);
        }

        private void buttonTabSO2GasF2Calculate_Click(object sender, EventArgs e)
        {
            //SO2 CONCENTRATION PPM
            var so2 = CTD(textBoxTabSO2GasF2SO2Concentration.Text, textBoxTabSO2GasF2SO2Concentration);
            if (so2 == null) return;

            //GAS FLOW
            var gasFlow = CTD(textBoxTabSO2GasF2GasFlow.Text, textBoxTabSO2GasF2GasFlow);
            if (gasFlow == null) return;

            //MASS EMISSIONS SO2 LBS/HR
            var answer = 0.000000166 * so2 * gasFlow;
            DisplayAnswer(answer, textBoxTabSO2GasF2Answer);
        }

        private void buttonTabSO2OilF1Calculate_Click(object sender, EventArgs e)
        {
            //MASS OIL IN LBS/HR
            var massOfOil = CTD(textBoxTabSO2OilF1MassOfOil.Text, textBoxTabSO2OilF1MassOfOil);
            if (massOfOil == null) return;

            //SULFUR CONTENT OIL%
            var sulfur = CTD(textBoxTabSO2OilF1SulfurContent.Text, textBoxTabSO2OilF1SulfurContent);
            if (sulfur == null) return;

            //MASS EMISSIONS SO2 LBS/HR
            var answer = 2 * massOfOil * sulfur / 100;
            DisplayAnswer(answer, textBoxTabSO2OilF1Answer);
        }

        private void buttonTabSO2OilF2Calculate_Click(object sender, EventArgs e)
        {
            //MASS OIL IN LBS/HR
            var massOfOil = CTD(textBoxTabSO2OilF2MassOfOil.Text, textBoxTabSO2OilF2MassOfOil);
            if (massOfOil == null) return;

            //SULFUR CONTENT OIL%
            var sulfur = CTD(textBoxTabSO2OilF2SulfurContent.Text, textBoxTabSO2OilF2SulfurContent);
            if (sulfur == null) return;

            //MASS EMISSIONS SO2 LBS/HR
            var answer = 2 * massOfOil * sulfur / 100;
            DisplayAnswer(answer, textBoxTabSO2OilF2Answer);
        }

        private void buttonTabSO2OilF3Calculate_Click(object sender, EventArgs e)
        {
            //SO2 CONCENTRATION PPM
            var so2 = CTD(textBoxTabSO2OilF3SO2Concentration.Text, textBoxTabSO2OilF3SO2Concentration);
            if (so2 == null) return;

            //MASS OF OIL
            var massOfOil = CTD(textBoxTabSO2OilF3MassOfOil.Text, textBoxTabSO2OilF3MassOfOil);
            if (massOfOil == null) return;

            //MASS EMISSIONS SO2 LBS/HR
            var answer = 0.000000166 * so2 * massOfOil;
            DisplayAnswer(answer, textBoxTabSO2OilF3Answer);
        }

        private void buttonTabSO2FlowF1Calculate_Click(object sender, EventArgs e)
        {
            //SO2 CONCENTRATION %
            var so2 = CTD(textBoxTabSO2FlowF1SO2Concentration.Text, textBoxTabSO2FlowF1SO2Concentration);
            if (so2 == null) return;

            //VOLUMETRIC FLOW SCFH
            var flow = CTD(textBoxTabSO2FlowF1Flow.Text, textBoxTabSO2FlowF1Flow);
            if (flow == null) return;

            //MASS EMISSIONS SO2 LBS/HR
            var answer = 0.000000166 * so2 * flow;
            DisplayAnswer(answer, textBoxTabSO2FlowF1Answer);
        }

        private void buttonTabNOxlbsmmBtuF1Calculate_Click(object sender, EventArgs e)
        {
            //NOX PPM
            var nox = CTD(textBoxTabNOxlbsmmBtuF1NOx.Text, textBoxTabNOxlbsmmBtuF1NOx);
            if (nox == null) return;

            //CO2 %
            var co2 = CTD(textBoxTabNOxlbsmmBtuF1CO2.Text, textBoxTabNOxlbsmmBtuF1CO2);
            if (co2 == null) return;

            //FUEL FACTOR FOR CO2
            var fc = CTD(textBoxTabNOxlbsmmBtuF1Fc.Text, textBoxTabNOxlbsmmBtuF1Fc);
            if (fc == null) return;

            //NOX BIAS ADJUSTMENT FACTOR
            var baf = CTD(textBoxTabNOxlbsmmBtuF1BAF.Text, textBoxTabNOxlbsmmBtuF1BAF);
            if (baf == null) return;

            //NOX LBS/MMBTU
            var answer = (0.0000001194 * nox * fc * (100 / co2)) * baf;
            textBoxTabNOxlbsmmBtuF1Answer.Text = $@"{answer:N3}";
        }

        private void buttonTabNOxlbsmmBtuF2Calculate_Click(object sender, EventArgs e)
        {
            //NOX PPM
            var nox = CTD(textBoxTabNOxlbsmmBtuF2NOx.Text, textBoxTabNOxlbsmmBtuF2NOx);
            if (nox == null) return;

            //O2 %
            var o2 = CTD(textBoxTabNOxlbsmmBtuF2O2.Text, textBoxTabNOxlbsmmBtuF2O2);
            if (o2 == null) return;

            //FUEL FACTOR FOR O2
            var fc = CTD(textBoxTabNOxlbsmmBtuF2Fc.Text, textBoxTabNOxlbsmmBtuF2Fc);
            if (fc == null) return;

            //NOX BIAS ADJUSTMENT FACTOR
            var baf = CTD(textBoxTabNOxlbsmmBtuF2BAF.Text, textBoxTabNOxlbsmmBtuF2BAF);
            if (baf == null) return;

            //NOX LBS/MMBTU
            var answer = 0.0000001194 * nox * fc * (20.9 / (20.9 - o2)) * baf;
            textBoxTabNOxlbsmmBtuF2Answer.Text = $@"{answer:N3}";
        }

        private void buttonTabNOxlbshrF1Calculate_Click(object sender, EventArgs e)
        {
            //NOX CONCENTRATION PPM WET
            var nox = CTD(textBoxTabNOxlbshrF1NOx.Text, textBoxTabNOxlbshrF1NOx);
            if (nox == null) return;

            //VOLUMETRIC FLOW RATE SCFH
            var flow = CTD(textBoxTabNOxlbshrF1Fc.Text, textBoxTabNOxlbshrF1Fc);
            if (flow == null) return;

            //UNIT/STACK OPERATING TIME
            var ot = CTD(textBoxTabNOxlbshrF1OT.Text, textBoxTabNOxlbshrF1OT);
            if (ot == null) return;

            //NOX LBS/HR
            var answer = 0.0000001194 * nox * flow * ot;
            DisplayAnswer(answer, textBoxTabNOxlbshrF1Answer);
        }

        private void buttonTabNOxlbshrF2Answer_Click(object sender, EventArgs e)
        {
            //NOX RATE LBS/MMBTU
            var nox = CTD(textBoxTabNOxlbshrF2NOx.Text, textBoxTabNOxlbshrF2NOx);
            if (nox == null) return;

            //HEAT INPUT RATE MMBTU/HR
            var htip = CTD(textBoxTabNOxlbshrF2HTIP.Text, textBoxTabNOxlbshrF2HTIP);
            if (htip == null) return;

            //UNIT/STACK OPERATING TIME
            var ot = CTD(textBoxTabNOxlbshrF2OT.Text, textBoxTabNOxlbshrF2OT);
            if (ot == null) return;

            var answer = nox * htip * ot;
            DisplayAnswer(answer, textBoxTabNOxlbshrF2Answer);
        }

        private void buttonTabNOxppmvdF1Calculate_Click(object sender, EventArgs e)
        {
            //NOX PPM
            var nox = CTD(textBoxTabNOxppmvdF1NOx.Text, textBoxTabNOxppmvdF1NOx);
            if (nox == null) return;

            //O2 %
            var o2 = CTD(textBoxTabNOxppmvdF1O2.Text, textBoxTabNOxppmvdF1O2);
            if (o2 == null) return;

            //NOX PPMVD
            var answer = ((20.9 - 15) * nox) / (20.9 - o2);
            DisplayAnswer(answer, textBoxTabNOxppmvdF1Answer);
        }

        private void buttonTabNOxppmvdF2Calculate_Click(object sender, EventArgs e)
        {
            //NOX PPM
            var nox = CTD(textBoxTabNOxppmvdF2NOx.Text, textBoxTabNOxppmvdF2NOx);
            if (nox == null) return;

            //CO2 %
            var co2 = CTD(textBoxTabNOxppmvdF2CO2.Text, textBoxTabNOxppmvdF2CO2);
            if (co2 == null) return;

            //SCO2 FO4 GAS OR OIL
            var xco2 = comboBoxTabNOxppmvdF2XCO2;
            if (xco2.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose XCO2", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxTabNOxppmvdF2XCO2.Focus();
                return;
            }

            double.TryParse(xco2.SelectedItem.ToString(), out var xco2Number);

            //NOX PPMVD
            var answer = ((nox * xco2Number) / co2);
            DisplayAnswer(answer, textBoxTabNOxppmvdF2Answer);
        }

        private void buttonTabFuelFactorF1Calculate_Click(object sender, EventArgs e)
        {
            //HEAT INPUT OIL MMBTU
            var htipOil = CTD(textBoxTabFuelFactorF1HTIPOil.Text, textBoxTabFuelFactorF1HTIPOil);
            if (htipOil == null) return;

            //HEAT INPUT GAS MMBTU
            var htipGas = CTD(textBoxTabFuelFactorF1HTIPGas.Text, textBoxTabFuelFactorF1HTIPGas);
            if (htipGas == null) return;

            //APPORTIONED FUEL FACTOR
            var answer = (htipOil * 1420 + htipGas * 1040) / (htipOil + htipGas);
            DisplayAnswer(answer, textBoxTabFuelFactorF1Answer);
        }

        private void buttonTabCoalF1Calculate_Click(object sender, EventArgs e)
        {
            //FUEL FLOW KSCFH
            var ff = CTD(textBoxTabCoalF1FuelFlow.Text, textBoxTabCoalF1FuelFlow);
            if (ff == null) return;

            //CO2 CONCENTRATION %
            var co2 = CTD(textBoxTabCoalF1CO2Concentration.Text, textBoxTabCoalF1CO2Concentration);
            if (co2 == null) return;

            //FUEL FACTOR
            var fc = CTD(textBoxTabCoalF1FuelFactor.Text, textBoxTabCoalF1FuelFactor);
            if (fc == null) return;

            //HTIP MM/BTU
            var answer = (ff * 1000 * co2) / (fc * 100);
            DisplayAnswer(answer, textBoxTabCoalF1Answer);
        }

        private void buttonTabCoalF2Calculate_Click(object sender, EventArgs e)
        {
            //SO2 CONCENTRATION PPM
            var so2 = CTD(textBoxTabCoalF2SO2Concentration.Text, textBoxTabCoalF2SO2Concentration);
            if (so2 == null) return;

            //FUEL FLOW KSCFH
            var ff = CTD(textBoxTabCoalF2FuelFlow.Text, textBoxTabCoalF2FuelFlow);
            if (ff == null) return;

            //MASS EMISSIONS SO2 LBS/HR
            var answer = 0.000000166 * so2 * ff * 1000;
            DisplayAnswer(answer, textBoxTabCoalF2Answer);
        }

        private void buttonTabCoalF3Calculate_Click(object sender, EventArgs e)
        {
            //CO2 CONCENTRATION %
            var co2 = CTD(textBoxTabCoalF3CO2Concentration.Text, textBoxTabCoalF3CO2Concentration);
            if (co2 == null) return;

            //FUEL FLOW KSCFH
            var ff = CTD(textBoxTabCoalF3FuelFlow.Text, textBoxTabCoalF3FuelFlow);
            if (ff == null) return;

            //CO2 TONS/HR
            var answer = (5.7 / 10000000) * co2 * ff * 1000;
            DisplayAnswer(answer, textBoxTabCoalF3Answer);
        }

        private void buttonTabCoalF4Calculate_Click(object sender, EventArgs e)
        {
            //NOX PPM
            var nox = CTD(textBoxTabCoalF4NOx.Text, textBoxTabCoalF4NOx);
            if (nox == null) return;

            //CO2 %
            var co2 = CTD(textBoxTabCoalF4CO2.Text, textBoxTabCoalF4CO2);
            if (co2 == null) return;

            //FUEFL FACTOR FOR CO2
            var fc = CTD(textBoxTabCoalF4Fc.Text, textBoxTabCoalF4Fc);
            if (fc == null) return;

            //NOX BIAS ADJUSTMENT FACTOR
            var baf = CTD(textBoxTabCoalF4BAF.Text, textBoxTabCoalF4BAF);
            if (baf == null) return;

            //NOX LBS/MMBTU
            var answer = 0.0000001194 * nox * fc * (100 / co2) * baf;
            textBoxTabCoalF4Answer.Text = $@"{answer:N3}";
        }

        private void buttonCOlbsmmBtuF1Calculate_Click(object sender, EventArgs e)
        {
            //CO PPM
            var co = CTD(textBoxTabCOlbsmmBtuF1CO.Text, textBoxTabCOlbsmmBtuF1CO);
            if (co == null) return;

            //CO2 %
            var co2 = CTD(textBoxTabCOlbsmmBtuF1CO2.Text, textBoxTabCOlbsmmBtuF1CO2);
            if (co2 == null) return;

            //FUEL FACTOR FOR CO2
            var fc = CTD(textBoxTabCOlbsmmBtuF1FuelFactor.Text, textBoxTabCOlbsmmBtuF1FuelFactor);
            if (fc == null) return;

            //CO LBS/MMBTU
            var answer = 0.00000007263 * co * fc * (100 / co2);
            textBoxTabCOlbsmmBtuF1Answer.Text = $@"{answer:N3}";
        }

        private void buttonCOlbsmmBtuF2Calculate_Click(object sender, EventArgs e)
        {
            //CO PPM
            var co = CTD(textBoxTabCOlbsmmBtuF2CO.Text, textBoxTabCOlbsmmBtuF2CO);
            if (co == null) return;

            //O2 %
            var o2 = CTD(textBoxTabCOlbsmmBtuF2O2.Text, textBoxTabCOlbsmmBtuF2O2);
            if (o2 == null) return;

            //FUEL FACTOR FOR O2
            var fc = CTD(textBoxTabCOlbsmmBtuF2FuelFactor.Text, textBoxTabCOlbsmmBtuF2FuelFactor);
            if (fc == null) return;

            //CO LBS/MMBTU
            var answer = 0.00000007263 * co * fc * (20.9 / (20.9 - o2));
            textBoxTabCOlbsmmBtuF2Answer.Text = $@"{answer:N3}";
        }

        private void buttonTabCOlbshrF1Calculate_Click(object sender, EventArgs e)
        {
            //CO RATE LBS/MMBTU
            var co = CTD(textBoxTabCOlbshrF1CO.Text, textBoxTabCOlbshrF1CO);
            if (co == null) return;

            //HEAT INPUT RATE MMBTU/HR
            var htip = CTD(textBoxTabCOlbshrF1HTIP.Text, textBoxTabCOlbshrF1HTIP);
            if (htip == null) return;

            //CO LBS/HR
            var answer = co * htip;
            DisplayAnswer(answer, textBoxTabCOlbshrF1Answer);
        }

        private void buttonTabCOppmvdF1Calculate_Click(object sender, EventArgs e)
        {
            //CO PPM
            var co = CTD(textBoxTabCOppmvdF1CO.Text, textBoxTabCOppmvdF1CO);
            if (co == null) return;

            //O2 %
            var o2 = CTD(textBoxTabCOppmvdF1O2.Text, textBoxTabCOppmvdF1O2);
            if (o2 == null) return;

            //CO PPMVD
            var answer = ((20.9 - 15) * co) / (20.9 - o2);
            DisplayAnswer(answer, textBoxTabCOppmvdF1Answer);
        }

        private void buttonTabCOppmvdF2Calculate_Click(object sender, EventArgs e)
        {
            //CO PPM
            var co = CTD(textBoxTabCOppmvdF2CO.Text, textBoxTabCOppmvdF2CO);
            if (co == null) return;

            //CO2 %
            var co2 = CTD(textBoxTabCOppmvdF2CO2.Text, textBoxTabCOppmvdF2CO2);
            if (co2 == null) return;

            //XCO2 FOR GAS OR OIL
            var xco2 = comboBoxTabCOppmvdF2XCO2;

            if (xco2.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select XCO2", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxTabCOppmvdF2XCO2.Focus();
                return;
            }

            double.TryParse(comboBoxTabCOppmvdF2XCO2.SelectedItem.ToString(), out var bafNumber);

            //CO LBS/MMBTU
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
            if (!SoftwarePassword.SWPassword)
            {
                SoftwarePassword sw = new SoftwarePassword();
                sw.ShowDialog();
            }

            if (SoftwarePassword.SWPassword)
            {
                var dataSet = LoadTable("Prism");
                folderName = "Prism_Files";

                LoadDashboardViewModel(dataSet, "Prism_SectionNumber", "Prism_SectionName", "File_Location", "");
            }
            else
            {
                MessageBox.Show("Access Not Granted", "CEMS Study");

            }
        }

        private void buttonTab420Clear_Click(object sender, EventArgs e)
        {
            textBoxTab42020ma.Clear();
            textBoxTab4204ma.Clear();
            textBoxTab420ActualCount.Clear();
            textBoxTab420Answer.Clear();
            textBoxTab420HighScale.Clear();
            textBoxTab420LowScale.Clear();
            textBoxTab420ActualCount.Focus();
        }

        private void buttonTab420Calculate_Click(object sender, EventArgs e)
        {
            //ACTUAL COUNT
            var ac = CTD(textBoxTab420ActualCount.Text, textBoxTab420ActualCount);
            if (ac == null) return;

            //LOW COUNT 4mA
            var low4ma = CTD(textBoxTab4204ma.Text, textBoxTab4204ma);
            if (low4ma == null) return;

            //HIGH COUNT 20mA
            var high20ma = CTD(textBoxTab42020ma.Text, textBoxTab42020ma);
            if (high20ma == null) return;

            //HIGH SCALE
            var highScale = CTD(textBoxTab420HighScale.Text, textBoxTab420HighScale);
            if (highScale == null) return;

            //LOW SCALE
            var lowScale = CTD(textBoxTab420LowScale.Text, textBoxTab420LowScale);
            if (lowScale == null) return;

            //ANALOG READING
            var answer = (ac - low4ma) / (high20ma - low4ma) * (highScale - lowScale);
            DisplayAnswer(answer, textBoxTab420Answer);
        }

        private void comboBoxSearch_Enter(object sender, EventArgs e)
        {
            comboBoxSearch.ForeColor = Color.Black;
        }

        private void comboBoxSearch_Leave(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedIndex == 0) comboBoxSearch.ForeColor = Color.Gray;
        }

        private void buttonTabHgHGRHAnswer_Click(object sender, EventArgs e)
        {
            //HG IN UG/SCM
            var hg = CTD(textBoxTabHgHGRHHg.Text, textBoxTabHgHGRHHg);
            if (hg == null) return;

            //FUEL FACTOR DEFAULT 1800 FOR COAL
            var fc = CTD(textBoxTabHgHGRHFc.Text, textBoxTabHgHGRHFc);
            if (fc == null) return;

            //CO2 %
            var co2 = CTD(textBoxTabHgHGRHCO2.Text, textBoxTabHgHGRHCO2);
            if (co2 == null) return;

            //HG RATE LB/TBTU
            tabHgHGRHAnswer = (double)(6.243E-11 * hg * fc * (100 / co2) * 1000000);
            textBoxTabHgHGRHAnswer.Text = $@"{tabHgHGRHAnswer:E2}";
        }

        private void buttonTabHgHGREAnswer_Click(object sender, EventArgs e)
        {
            //UNBIASED STACK FLOW SCFH
            var flow = CTD(textBoxTabHgHGREFlow.Text, textBoxTabHgHGREFlow);
            if (flow == null) return;

            //HG IN UG/SCM
            var hg = CTD(textBoxTabHgHGREHg.Text, textBoxTabHgHGREHg);
            if (hg == null) return;

            //MATS LOAD
            var mw = CTD(textBoxTabHgHGREMW.Text, textBoxTabHgHGREMW);
            if (mw == null) return;

            //HG RATE LB/GWH
            tabHgHGREAnswer = (double)(hg * flow * 6.243E-11 / (mw / 1000));
            textBoxTabHgHGREAnswer.Text = $@"{tabHgHGREAnswer:E2}";
        }

        private void buttonTabHglbhrAnswer_Click(object sender, EventArgs e)
        {
            //UNBIASED STACK FLOW SCFH
            var flow = CTD(textBoxTabHglbhrFlow.Text, textBoxTabHglbhrFlow);
            if (flow == null) return;

            //HG IN UG/SCM
            var hg = CTD(textBoxTabHglbhrHg.Text, textBoxTabHglbhrHg);
            if (hg == null) return;

            //HG RATE LB/HR
            tabHglbhrAnswer = (double)(hg * flow * 6.243E-11);
            textBoxTabHglbhrAnswer.Text = $@"{tabHglbhrAnswer:E2}";
        }

        private void buttonTabHgHGRHClear_Click(object sender, EventArgs e)
        {
            textBoxTabHgHGRHHg.Text = "";
            textBoxTabHgHGRHHg.Focus();
            textBoxTabHgHGRHFc.Text = "";
            textBoxTabHgHGRHCO2.Text = "";
            textBoxTabHgHGRHAnswer.Text = "";
        }

        private void buttonTabHgHGREClear_Click(object sender, EventArgs e)
        {
            textBoxTabHgHGREFlow.Text = "";
            textBoxTabHgHGREFlow.Focus();
            textBoxTabHgHGREHg.Text = "";
            textBoxTabHgHGREMW.Text = "";
            textBoxTabHgHGREAnswer.Text = "";
        }

        private void buttonTabHglbhrClear_Click(object sender, EventArgs e)
        {
            textBoxTabHglbhrFlow.Text = "";
            textBoxTabHglbhrFlow.Focus();
            textBoxTabHglbhrHg.Text = "";
            textBoxTabHglbhrAnswer.Text = "";
        }

        private void buttonTabHgHGRHConvert_Click(object sender, EventArgs e)
        {
            if (buttonTabHgHGRHConvert.Text == "D")
            {
                textBoxTabHgHGRHAnswer.Text = $@"{tabHgHGRHAnswer}";
                buttonTabHgHGRHConvert.Text = "E";
                toolTip1.SetToolTip(buttonTabHgHGRHConvert, "Convert to Exponent");
            }
            else
            {
                textBoxTabHgHGRHAnswer.Text = $@"{tabHgHGRHAnswer:E2}";
                buttonTabHgHGRHConvert.Text = "D";
                toolTip1.SetToolTip(buttonTabHgHGRHConvert, "Convert to Decimal");
            }
        }

        private void buttonTabHgHGREConvert_Click(object sender, EventArgs e)
        {
            if (buttonTabHgHGREConvert.Text == "D")
            {
                textBoxTabHgHGREAnswer.Text = $@"{tabHgHGREAnswer:N}";
                buttonTabHgHGREConvert.Text = "E";
                toolTip1.SetToolTip(buttonTabHgHGREConvert, "Convert to Exponent");
            }
            else
            {
                textBoxTabHgHGREAnswer.Text = $@"{tabHgHGREAnswer:E2}";
                buttonTabHgHGREConvert.Text = "D";
                toolTip1.SetToolTip(buttonTabHgHGREConvert, "Convert to Decimal");
            }
        }

        private void buttonTabHglbhrConvert_Click(object sender, EventArgs e)
        {
            if (buttonTabHglbhrConvert.Text == "D")
            {
                textBoxTabHglbhrAnswer.Text = $@"{tabHglbhrAnswer:N}";
                buttonTabHglbhrConvert.Text = "E";
                toolTip1.SetToolTip(buttonTabHglbhrConvert, "Convert to Exponent");
            }
            else
            {
                textBoxTabHglbhrAnswer.Text = $@"{tabHglbhrAnswer:E2}";
                buttonTabHglbhrConvert.Text = "D";
                toolTip1.SetToolTip(buttonTabHglbhrConvert, "Convert to Decimal");
            }
        }

        private void tabFormulasMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabText = tabFormulasMain.SelectedTab.Text;
            var index = comboBoxSectionNumber.FindString(tabText);
            comboBoxSectionNumber.SelectedIndex = index == -1 ? 0 : index;
        }

        private void buttonTabLMEHIQuarterCalculate_Click(object sender, EventArgs e)
        {
            //LME FUEL FLOW
            var ff = CTD(textBoxTabLMEHIQuarterFF.Text, textBoxTabLMEHIQuarterFF);
            if (ff == null) return;

            //LME GROSS CALORIC VALUE
            var gcv = CTD(textBoxTabLMEHIQuarterGCV.Text, textBoxTabLMEHIQuarterGCV);
            if (gcv == null) return;

            //QUARTERLY TOTAL HEAT INPUT MMBTU
            var answer = ff * gcv / 1000000;
            DisplayAnswer(answer, textBoxTabLMEHIQuarterAnswer);
        }

        private void buttonTabLMEHIQuarterClear_Click(object sender, EventArgs e)
        {
            textBoxTabLMEHIQuarterFF.Text = "";
            textBoxTabLMEHIQuarterFF.Focus();
            textBoxTabLMEHIQuarterGCV.Text = "";
        }

        //LME HEAT INPUT
        private void buttonTabLMEHIHourCalculate_Click(object sender, EventArgs e)
        {
            //HOUR LOAD
            var l = CTD(textBoxTabLMEHIHourL.Text, textBoxTabLMEHIHourL);
            if (l == null) return;

            //TOTAL LOAD FOR QUARTER
            var ql = CTD(textBoxTabLMEHIHourQL.Text, textBoxTabLMEHIHourQL);
            if (ql == null) return;

            //TOTAL HEAT INPUT
            var h = CTD(textBoxTabLMEHIHourH.Text, textBoxTabLMEHIHourH);
            if (h == null) return;

            //HOURLY HEAT INPUT MMBTU
            var answer = (l / ql) * h;
            DisplayAnswer(answer, textBoxTabLMEHIHourAnswer);
        }

        private void buttonTabLMEHIHourClear_Click(object sender, EventArgs e)
        {
            textBoxTabLMEHIHourL.Text = "";
            textBoxTabLMEHIHourL.Focus();
            textBoxTabLMEHIHourQL.Text = "";
            textBoxTabLMEHIHourH.Text = "";
            textBoxTabLMEHIHourAnswer.Text = "";
        }

        private void buttonTabLMEHourNoxCalculate_Click(object sender, EventArgs e)
        {
            //LME HOURLY HEAT INPUT
            var h = CTD(textBoxTabLMEHourNoxH.Text, textBoxTabLMEHourNoxH);
            if (h == null) return;

            //LME NOX RATE CONSTANT
            var nox = CTD(textBoxTabLMEHourNoxNox.Text, textBoxTabLMEHourNoxNox);
            if (nox == null) return;

            //HOURLY NOX MASS LB
            var answer = h * nox;
            DisplayAnswer(answer, textBoxTabLMEHourNoxAnswer);
        }

        private void buttonTabLMEHourNoxClear_Click(object sender, EventArgs e)
        {
            textBoxTabLMEHourNoxH.Text = "";
            textBoxTabLMEHourNoxH.Focus();
            textBoxTabLMEHourNoxNox.Text = "";
        }

        private void buttonTabLMEHourSo2Calculate_Click(object sender, EventArgs e)
        {
            //LME HOURLY HEAT INPUT
            var h = CTD(textBoxTabLMEHourSo2H.Text, textBoxTabLMEHourSo2H);
            if (h == null) return;

            //SO2 RATE CONSTANT
            var so2 = CTD(textBoxTabLMEHourSo2So2.Text, textBoxTabLMEHourSo2So2);
            if (so2 == null) return;

            //HOURLY SO2 MASS LB
            var answer = h * so2;
            DisplayAnswer(answer, textBoxTabLMEHourSo2Answer);
        }

        private void buttonTabLMEHourSo2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabLMEHourSo2H.Text = "";
            textBoxTabLMEHourSo2H.Focus();
            textBoxTabLMEHourSo2So2.Text = "";
        }

        private void buttonTabLMEHourCo2Calculate_Click(object sender, EventArgs e)
        {
            //LME HOURLY HEAT INPUT
            var h = CTD(textBoxTabLMEHourCo2H.Text, textBoxTabLMEHourCo2H);
            if (h == null) return;

            //CO2 RATE CONSTANT
            var co2 = CTD(textBoxTabLMEHourCo2Co2.Text, textBoxTabLMEHourCo2Co2);
            if (co2 == null) return;

            //HOURLY CO2 MASS TONS
            var answer = h * co2;
            DisplayAnswer(answer, textBoxTabLMEHourCo2Answer);
        }

        private void buttonTabLMEHourCo2Clear_Click(object sender, EventArgs e)
        {
            textBoxTabLMEHourCo2H.Text = "";
            textBoxTabLMEHourCo2H.Focus();
            textBoxTabLMEHourCo2Co2.Text = "";
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var searchRegIndex = comboBoxSearch.SelectedIndex;

            switch (searchRegIndex)
            {
                case 1:
                    searchIndex = 352;
                    isFullManualFunction = true;
                    buttonPart75_Click(sender, e);
                    break;
                case 2:
                    searchIndex = 347;
                    isFullManualFunction = true;
                    buttonPart75_Click(sender, e);
                    break;
                case 3:
                    isFullManualFunction = true;
                    searchIndex = 118;
                    buttonPart75PlainEnglish_Click(sender, e);
                    break;
                case 4:
                    searchIndex = 349;
                    isFullManualFunction = true;
                    buttonPart75_Click(sender, e);
                    break;
                case 5:
                    isFullManualFunction = true;
                    searchIndex = 348;
                    buttonPart75_Click(sender, e);
                    break;
                case 6:
                    isFullManualFunction = true;
                    searchIndex = 114;
                    button60AppBF_Click(sender, e);
                    break;
                case 7:
                    isFullManualFunction = true;
                    searchIndex = 115;
                    button60AppBF_Click(sender, e);
                    break;
                case 8:
                    isFullManualFunction = true;
                    searchIndex = 37;
                    buttonPart63SubUUUUU_Click(sender, e);
                    break;
                case 9:
                    isFullManualFunction = true;
                    searchIndex = 350;
                    buttonPart75_Click(sender, e);
                    break;
                case 10:
                    isFullManualFunction = true;
                    searchIndex = 354;
                    buttonPart75_Click(sender, e);
                    break;
                case 11:
                    isFullManualFunction = true;
                    searchIndex = 351;
                    buttonPart75_Click(sender, e);
                    break;
                case 12:
                    isFullManualFunction = true;
                    searchIndex = 353;
                    buttonPart75_Click(sender, e);
                    break;
                case 13:
                    isFullManualFunction = true;
                    searchIndex = 355;
                    buttonPart75_Click(sender, e);
                    break;
                case 14:
                    isFullManualFunction = true;
                    searchIndex = 356;
                    buttonPart75_Click(sender, e);
                    break;
                case 15:
                    isFullManualFunction = true;
                    searchIndex = 357;
                    buttonPart75_Click(sender, e);
                    break;
                default:
                    isFullManualFunction = false;
                    searchIndex = -1;
                    break;

            }
            isFullManualFunction = false;
        }

        private void buttonTimeCalculate_Click(object sender, EventArgs e)
        {
            var dateYear1 = dateTimePicker1.Value.Year;
            var dateMonth1 = dateTimePicker1.Value.Month;
            var dateDay1 = dateTimePicker1.Value.Day;

            var dateYear2 = dateTimePicker2.Value.Year;
            var dateMonth2 = dateTimePicker2.Value.Month;
            var dateDay2 = dateTimePicker2.Value.Day;

            IsEmpty(textBoxHH1);
            var isValidHour1 = int.TryParse(textBoxHH1.Text, out var hour1);
            IsValid(isValidHour1, textBoxHH1);

            IsEmpty(textBoxmm1);
            var isValidMinute1 = int.TryParse(textBoxmm1.Text, out var minute1);
            IsValid(isValidMinute1, textBoxmm1);

            IsEmpty(textBoxss1);
            var isValidSecond1 = int.TryParse(textBoxss1.Text, out var second1);
            IsValid(isValidSecond1, textBoxss1);

            IsEmpty(textBoxHH2);
            var isValidHour2 = int.TryParse(textBoxHH2.Text, out var hour2);
            IsValid(isValidHour2, textBoxHH2);

            IsEmpty(textBoxmm2);
            var isValidMinute2 = int.TryParse(textBoxmm2.Text, out var minute2);
            IsValid(isValidMinute2, textBoxmm2);

            IsEmpty(textBoxss2);
            var isValidSecond2 = int.TryParse(textBoxss2.Text, out var second2);
            IsValid(isValidSecond2, textBoxss2);

            DateTime formatedDate1 = new DateTime(dateYear1, dateMonth1, dateDay1, hour1, minute1, second1);
            DateTime formatedDate2 = new DateTime(dateYear2, dateMonth2, dateDay2, hour2, minute2, second2);

            var difference = formatedDate2.Subtract(formatedDate1);
            textBoxDays.Text = difference.Days.ToString();
            textBoxHours.Text = difference.Hours.ToString();
            textBoxMinutes.Text = difference.Minutes.ToString();
            textBoxSeconds.Text = difference.Seconds.ToString();

            textBoxHourlyDecimal.Text = $@"{difference.TotalHours:F2}";

        }

        private void IsEmpty(TextBox textBoxObject)
        {
            if (string.IsNullOrEmpty(textBoxObject.Text)) textBoxObject.Text = "0";
        }

        private void IsValid(bool isValidObject, TextBox textBox)
        {
            if (!isValidObject)
            {
                MessageBox.Show("Must Be A Number", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox.Clear();
                textBox.Focus();
            }
        }

        private void buttonTimeClear_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            textBoxHH1.Clear();
            textBoxHH2.Clear();
            textBoxmm1.Clear();
            textBoxmm2.Clear();
            textBoxss1.Clear();
            textBoxss2.Clear();
            textBoxDays.Clear();
            textBoxHours.Clear();
            textBoxMinutes.Clear();
            textBoxSeconds.Clear();
            textBoxHourlyDecimal.Clear();

            textBoxHH1.Focus();
        }

        private void buttonTimeCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxHourlyDecimal.Text);
        }

        private void buttonChemicalFormulas_Click(object sender, EventArgs e)
        {
            var dataSet = LoadTable("ChemicalCompounds_View");
            folderName = "";
            LoadDashboardViewModel(dataSet, "Elements", "Name", "", "Description");
        }
    }
}
