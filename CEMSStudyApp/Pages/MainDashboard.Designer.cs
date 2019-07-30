using System.ComponentModel;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.panelFormulas = new System.Windows.Forms.Panel();
            this.tabFormulasMain = new System.Windows.Forms.TabControl();
            this.tabOilFlow = new System.Windows.Forms.TabPage();
            this.buttonTabOilFlowF1Clear = new System.Windows.Forms.Button();
            this.textBoxTabOilFlowMassF1OilFlow = new System.Windows.Forms.TextBox();
            this.textBoxTabOilFlowF1Density = new System.Windows.Forms.TextBox();
            this.textBoxTabOilFlowF1OilFlow = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox170 = new System.Windows.Forms.TextBox();
            this.buttonTabOilFlowF1Calculate = new System.Windows.Forms.Button();
            this.label207 = new System.Windows.Forms.Label();
            this.label208 = new System.Windows.Forms.Label();
            this.label210 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.label212 = new System.Windows.Forms.Label();
            this.label213 = new System.Windows.Forms.Label();
            this.tabCO2Gas = new System.Windows.Forms.TabPage();
            this.buttonTabCO2GasF3Clear = new System.Windows.Forms.Button();
            this.buttonTabCO2GasF2Clear = new System.Windows.Forms.Button();
            this.buttonTabCO2GasF1Clear = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonTabCO2GasF3Calculate = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxTabCO2GasF3Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2GasF3GasFlow = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2GasF3CO2Concentration = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonTabCO2GasF2Calculate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTabCO2GasF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2GasF2HTIP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonTabCO2GasF1Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTabCO2F1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2GasF1GasFlow = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2GasF1CarbonContent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabCO2Oil = new System.Windows.Forms.TabPage();
            this.buttonTabCO2OilF3Clear = new System.Windows.Forms.Button();
            this.buttonTabCO2OilF2Clear = new System.Windows.Forms.Button();
            this.buttonTabCO2OilF1Clear = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.buttonTabCO2OilF3Calculate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxTabCO2OilF3Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2OilF3MassOfOil = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2OilF3CO2Concentration = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.buttonTabCO2OilF2Calculate = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxTabCO2OilF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2OilF2HTIP = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.buttonTabCO2OilF1Calculate = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxTabCO2OilF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2OilF1MassOil = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2OilF1CarbonContent = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.tabCO2Flow = new System.Windows.Forms.TabPage();
            this.buttonTabCO2FlowF1CO2Clear = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.buttonTabCO2FlowF1CO2Calculate = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.textBoxTabCO2FlowF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2FlowF1Flow = new System.Windows.Forms.TextBox();
            this.textBoxTabCO2FlowF1CO2Concentration = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.tabHeatInputGas = new System.Windows.Forms.TabPage();
            this.buttonTabHTIPGasF2Clear = new System.Windows.Forms.Button();
            this.buttonTabHTIPGasF1Clear = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPGasF2FuelFactor = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPGasF2CO2Concentration = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.buttonTabHTIPGasF2Answer = new System.Windows.Forms.Button();
            this.label59 = new System.Windows.Forms.Label();
            this.textBoxTabHTIPGasF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPGasF2GasFlow = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.buttonTabHTIPGasF1Calculate = new System.Windows.Forms.Button();
            this.textBoxTabHTIPGasF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPGasF1GasFlow = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPGasF1GCV = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.tabHeatInputOil = new System.Windows.Forms.TabPage();
            this.buttonTabHTIPOilF2Clear = new System.Windows.Forms.Button();
            this.buttonTabHTIPOilF1Clear = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.textBoxTabHTIPOilF2FuelFactor = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPOilF2CO2Concentration = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.buttonTabHTIPOilF2Calculate = new System.Windows.Forms.Button();
            this.label74 = new System.Windows.Forms.Label();
            this.textBoxTabHTIPOilF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPOilF2MassOfOil = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.buttonTabHTIPOilF1Calculate = new System.Windows.Forms.Button();
            this.label78 = new System.Windows.Forms.Label();
            this.textBoxTabHTIPOilF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPOilF1MassOfOil = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPOilF1GCV = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.tabHeatInputFlow = new System.Windows.Forms.TabPage();
            this.buttonTabHTIPFlowF1Clear = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.textBoxTabHTIPFlowF1FuelFactor = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.buttonTabHTIPFlowF1Calculate = new System.Windows.Forms.Button();
            this.label92 = new System.Windows.Forms.Label();
            this.textBoxTabHTIPFlowF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPFlowF1CO2Concentration = new System.Windows.Forms.TextBox();
            this.textBoxTabHTIPFlowF1Flow = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.tabSO2Gas = new System.Windows.Forms.TabPage();
            this.buttonTabSO2GasF2Clear = new System.Windows.Forms.Button();
            this.buttonTabSO2GasF1Clear = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.textBoxTabSO2GasF2GasFlow = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.buttonTabSO2GasF2Calculate = new System.Windows.Forms.Button();
            this.label102 = new System.Windows.Forms.Label();
            this.textBoxTabSO2GasF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabSO2GasF2SO2Concentration = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.buttonTabSO2GasF1Calculate = new System.Windows.Forms.Button();
            this.label106 = new System.Windows.Forms.Label();
            this.textBoxTabSO2GasF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabSO2GasF1HTIP = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.tabSO2Oil = new System.Windows.Forms.TabPage();
            this.buttonTabSO2OilF3Clear = new System.Windows.Forms.Button();
            this.buttonTabSO2OilF2Clear = new System.Windows.Forms.Button();
            this.buttonTabSO2OilF1Clear = new System.Windows.Forms.Button();
            this.textBoxTabSO2OilF2SulfurContent = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.buttonTabSO2OilF3Calculate = new System.Windows.Forms.Button();
            this.label111 = new System.Windows.Forms.Label();
            this.textBoxTabSO2OilF3Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabSO2OilF3MassOfOil = new System.Windows.Forms.TextBox();
            this.textBoxTabSO2OilF3SO2Concentration = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.buttonTabSO2OilF2Calculate = new System.Windows.Forms.Button();
            this.label116 = new System.Windows.Forms.Label();
            this.textBoxTabSO2OilF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabSO2OilF2MassOfOil = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.textBox96 = new System.Windows.Forms.TextBox();
            this.buttonTabSO2OilF1Calculate = new System.Windows.Forms.Button();
            this.label120 = new System.Windows.Forms.Label();
            this.textBoxTabSO2OilF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabSO2OilF1SulfurContent = new System.Windows.Forms.TextBox();
            this.textBoxTabSO2OilF1MassOfOil = new System.Windows.Forms.TextBox();
            this.label121 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.tabSO2Flow = new System.Windows.Forms.TabPage();
            this.buttonTabSO2FlowF1Clear = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.textBox107 = new System.Windows.Forms.TextBox();
            this.buttonTabSO2FlowF1Calculate = new System.Windows.Forms.Button();
            this.label134 = new System.Windows.Forms.Label();
            this.textBoxTabSO2FlowF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabSO2FlowF1Flow = new System.Windows.Forms.TextBox();
            this.textBoxTabSO2FlowF1SO2Concentration = new System.Windows.Forms.TextBox();
            this.tabNOxlbsmmBtu = new System.Windows.Forms.TabPage();
            this.buttonTabNOxlbsmmBtuF2Clear = new System.Windows.Forms.Button();
            this.buttonTabNOxlbsmmBtuF1Clear = new System.Windows.Forms.Button();
            this.label72 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbsmmBtuF2BAF = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbsmmBtuF2Fc = new System.Windows.Forms.TextBox();
            this.buttonTabNOxlbsmmBtuF2Calculate = new System.Windows.Forms.Button();
            this.label81 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbsmmBtuF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxlbsmmBtuF2O2 = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxlbsmmBtuF2NOx = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbsmmBtuF1BAF = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbsmmBtuF1Fc = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox115 = new System.Windows.Forms.TextBox();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.textBox118 = new System.Windows.Forms.TextBox();
            this.buttonTabNOxlbsmmBtuF1Calculate = new System.Windows.Forms.Button();
            this.label148 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbsmmBtuF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxlbsmmBtuF1CO2 = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxlbsmmBtuF1NOx = new System.Windows.Forms.TextBox();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.tabNOxlbshr = new System.Windows.Forms.TabPage();
            this.buttonTabNOxlbshrF2Clear = new System.Windows.Forms.Button();
            this.buttonTabNOxlbshrF1Clear = new System.Windows.Forms.Button();
            this.label89 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbshrF2OT = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.buttonTabNOxlbshrF2Answer = new System.Windows.Forms.Button();
            this.label98 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbshrF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxlbshrF2HTIP = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxlbshrF2NOx = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbshrF1OT = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox126 = new System.Windows.Forms.TextBox();
            this.textBox129 = new System.Windows.Forms.TextBox();
            this.buttonTabNOxlbshrF1Calculate = new System.Windows.Forms.Button();
            this.label162 = new System.Windows.Forms.Label();
            this.textBoxTabNOxlbshrF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxlbshrF1Fc = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxlbshrF1NOx = new System.Windows.Forms.TextBox();
            this.label163 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.tabNOxppmvd = new System.Windows.Forms.TabPage();
            this.buttonTabNOxppmvdF2Clear = new System.Windows.Forms.Button();
            this.buttonTabNOxppmvdF1Clear = new System.Windows.Forms.Button();
            this.comboBoxTabNOxppmvdF2XCO2 = new System.Windows.Forms.ComboBox();
            this.textBoxTabNOxppmvdF2CO2 = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox137 = new System.Windows.Forms.TextBox();
            this.buttonTabNOxppmvdF2Calculate = new System.Windows.Forms.Button();
            this.label172 = new System.Windows.Forms.Label();
            this.textBoxTabNOxppmvdF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxppmvdF2NOx = new System.Windows.Forms.TextBox();
            this.label173 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.textBox140 = new System.Windows.Forms.TextBox();
            this.buttonTabNOxppmvdF1Calculate = new System.Windows.Forms.Button();
            this.label176 = new System.Windows.Forms.Label();
            this.textBoxTabNOxppmvdF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxppmvdF1O2 = new System.Windows.Forms.TextBox();
            this.textBoxTabNOxppmvdF1NOx = new System.Windows.Forms.TextBox();
            this.label177 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.tabFuelFactor = new System.Windows.Forms.TabPage();
            this.buttonTabFuelFactorF1Clear = new System.Windows.Forms.Button();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox151 = new System.Windows.Forms.TextBox();
            this.buttonTabFuelFactorF1Calculate = new System.Windows.Forms.Button();
            this.label190 = new System.Windows.Forms.Label();
            this.textBoxTabFuelFactorF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabFuelFactorF1HTIPGas = new System.Windows.Forms.TextBox();
            this.textBoxTabFuelFactorF1HTIPOil = new System.Windows.Forms.TextBox();
            this.label191 = new System.Windows.Forms.Label();
            this.label192 = new System.Windows.Forms.Label();
            this.label194 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.tabCoal = new System.Windows.Forms.TabPage();
            this.buttonTabCoalF3Clear = new System.Windows.Forms.Button();
            this.buttonTabCoalF4Clear = new System.Windows.Forms.Button();
            this.buttonTabCoalF2Clear = new System.Windows.Forms.Button();
            this.buttonTabCoalF1Clear = new System.Windows.Forms.Button();
            this.label161 = new System.Windows.Forms.Label();
            this.textBoxTabCoalF4BAF = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.textBoxTabCoalF4Fc = new System.Windows.Forms.TextBox();
            this.buttonTabCoalF4Calculate = new System.Windows.Forms.Button();
            this.label125 = new System.Windows.Forms.Label();
            this.textBoxTabCoalF4Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCoalF4CO2 = new System.Windows.Forms.TextBox();
            this.textBoxTabCoalF4NOx = new System.Windows.Forms.TextBox();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.label137 = new System.Windows.Forms.Label();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.buttonTabCoalF3Calculate = new System.Windows.Forms.Button();
            this.label139 = new System.Windows.Forms.Label();
            this.textBoxTabCoalF3Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCoalF3FuelFlow = new System.Windows.Forms.TextBox();
            this.textBoxTabCoalF3CO2Concentration = new System.Windows.Forms.TextBox();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.buttonTabCoalF2Calculate = new System.Windows.Forms.Button();
            this.label130 = new System.Windows.Forms.Label();
            this.textBoxTabCoalF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCoalF2FuelFlow = new System.Windows.Forms.TextBox();
            this.textBoxTabCoalF2SO2Concentration = new System.Windows.Forms.TextBox();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.textBoxTabCoalF1FuelFactor = new System.Windows.Forms.TextBox();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.label151 = new System.Windows.Forms.Label();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.buttonTabCoalF1Calculate = new System.Windows.Forms.Button();
            this.label152 = new System.Windows.Forms.Label();
            this.textBoxTabCoalF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCoalF1CO2Concentration = new System.Windows.Forms.TextBox();
            this.textBoxTabCoalF1FuelFlow = new System.Windows.Forms.TextBox();
            this.label153 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.tabColbsmmBtu = new System.Windows.Forms.TabPage();
            this.buttonCOlbsmmBtuF2Clear = new System.Windows.Forms.Button();
            this.buttonCOlbsmmBtuF1Clear = new System.Windows.Forms.Button();
            this.label168 = new System.Windows.Forms.Label();
            this.textBoxTabCOlbsmmBtuF2FuelFactor = new System.Windows.Forms.TextBox();
            this.buttonCOlbsmmBtuF2Calculate = new System.Windows.Forms.Button();
            this.label169 = new System.Windows.Forms.Label();
            this.textBoxTabCOlbsmmBtuF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCOlbsmmBtuF2O2 = new System.Windows.Forms.TextBox();
            this.textBoxTabCOlbsmmBtuF2CO = new System.Windows.Forms.TextBox();
            this.label170 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label182 = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.textBoxTabCOlbsmmBtuF1FuelFactor = new System.Windows.Forms.TextBox();
            this.label186 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.textBox134 = new System.Windows.Forms.TextBox();
            this.textBox135 = new System.Windows.Forms.TextBox();
            this.label189 = new System.Windows.Forms.Label();
            this.textBox136 = new System.Windows.Forms.TextBox();
            this.buttonCOlbsmmBtuF1Calculate = new System.Windows.Forms.Button();
            this.label193 = new System.Windows.Forms.Label();
            this.textBoxTabCOlbsmmBtuF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCOlbsmmBtuF1CO2 = new System.Windows.Forms.TextBox();
            this.textBoxTabCOlbsmmBtuF1CO = new System.Windows.Forms.TextBox();
            this.label199 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.tabCOlbshr = new System.Windows.Forms.TabPage();
            this.buttonTabCOlbshrF1Clear = new System.Windows.Forms.Button();
            this.textBox150 = new System.Windows.Forms.TextBox();
            this.textBox156 = new System.Windows.Forms.TextBox();
            this.buttonTabCOlbshrF1Calculate = new System.Windows.Forms.Button();
            this.label215 = new System.Windows.Forms.Label();
            this.textBoxTabCOlbshrF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCOlbshrF1HTIP = new System.Windows.Forms.TextBox();
            this.textBoxTabCOlbshrF1CO = new System.Windows.Forms.TextBox();
            this.label216 = new System.Windows.Forms.Label();
            this.label217 = new System.Windows.Forms.Label();
            this.label218 = new System.Windows.Forms.Label();
            this.label219 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.tabCOppmvd = new System.Windows.Forms.TabPage();
            this.buttonTabCOppmvdF2Clear = new System.Windows.Forms.Button();
            this.buttonTabCOppmvdF1Clear = new System.Windows.Forms.Button();
            this.comboBoxTabCOppmvdF2XCO2 = new System.Windows.Forms.ComboBox();
            this.label167 = new System.Windows.Forms.Label();
            this.buttonTabCOppmvdF2Calculate = new System.Windows.Forms.Button();
            this.label179 = new System.Windows.Forms.Label();
            this.textBoxTabCOppmvdF2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCOppmvdF2CO2 = new System.Windows.Forms.TextBox();
            this.textBoxTabCOppmvdF2CO = new System.Windows.Forms.TextBox();
            this.label184 = new System.Windows.Forms.Label();
            this.label205 = new System.Windows.Forms.Label();
            this.label209 = new System.Windows.Forms.Label();
            this.textBox155 = new System.Windows.Forms.TextBox();
            this.textBox160 = new System.Windows.Forms.TextBox();
            this.label214 = new System.Windows.Forms.Label();
            this.textBox161 = new System.Windows.Forms.TextBox();
            this.buttonTabCOppmvdF1Calculate = new System.Windows.Forms.Button();
            this.label221 = new System.Windows.Forms.Label();
            this.textBoxTabCOppmvdF1Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabCOppmvdF1O2 = new System.Windows.Forms.TextBox();
            this.textBoxTabCOppmvdF1CO = new System.Windows.Forms.TextBox();
            this.label222 = new System.Windows.Forms.Label();
            this.label223 = new System.Windows.Forms.Label();
            this.label224 = new System.Windows.Forms.Label();
            this.tabPage4_20ma = new System.Windows.Forms.TabPage();
            this.label226 = new System.Windows.Forms.Label();
            this.label225 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.textBoxTab420LowScale = new System.Windows.Forms.TextBox();
            this.textBoxTab420HighScale = new System.Windows.Forms.TextBox();
            this.textBoxTab42020ma = new System.Windows.Forms.TextBox();
            this.buttonTab420Clear = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonTab420Calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTab420Answer = new System.Windows.Forms.TextBox();
            this.textBoxTab4204ma = new System.Windows.Forms.TextBox();
            this.textBoxTab420ActualCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageHg = new System.Windows.Forms.TabPage();
            this.buttonTabHglbhrConvert = new System.Windows.Forms.Button();
            this.buttonTabHgHGREConvert = new System.Windows.Forms.Button();
            this.buttonTabHgHGRHConvert = new System.Windows.Forms.Button();
            this.textBoxTabHglbhrHg = new System.Windows.Forms.TextBox();
            this.textBoxTabHglbhrFlow = new System.Windows.Forms.TextBox();
            this.label239 = new System.Windows.Forms.Label();
            this.label240 = new System.Windows.Forms.Label();
            this.label246 = new System.Windows.Forms.Label();
            this.label241 = new System.Windows.Forms.Label();
            this.buttonTabHglbhrClear = new System.Windows.Forms.Button();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.buttonTabHglbhrAnswer = new System.Windows.Forms.Button();
            this.label242 = new System.Windows.Forms.Label();
            this.textBoxTabHglbhrAnswer = new System.Windows.Forms.TextBox();
            this.label245 = new System.Windows.Forms.Label();
            this.textBoxTabHgHGREMW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label237 = new System.Windows.Forms.Label();
            this.label236 = new System.Windows.Forms.Label();
            this.textBoxTabHgHGRHCO2 = new System.Windows.Forms.TextBox();
            this.label235 = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.buttonTabHgHGREClear = new System.Windows.Forms.Button();
            this.buttonTabHgHGRHClear = new System.Windows.Forms.Button();
            this.buttonTabHgHGREAnswer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTabHgHGREAnswer = new System.Windows.Forms.TextBox();
            this.textBoxTabHgHGREHg = new System.Windows.Forms.TextBox();
            this.textBoxTabHgHGREFlow = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label227 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.buttonTabHgHGRHAnswer = new System.Windows.Forms.Button();
            this.label228 = new System.Windows.Forms.Label();
            this.textBoxTabHgHGRHAnswer = new System.Windows.Forms.TextBox();
            this.textBoxTabHgHGRHFc = new System.Windows.Forms.TextBox();
            this.textBoxTabHgHGRHHg = new System.Windows.Forms.TextBox();
            this.label229 = new System.Windows.Forms.Label();
            this.label230 = new System.Windows.Forms.Label();
            this.label231 = new System.Windows.Forms.Label();
            this.tabPageLME_HI = new System.Windows.Forms.TabPage();
            this.buttonTabLMEHIHourClear = new System.Windows.Forms.Button();
            this.buttonTabLMEHIQuarterClear = new System.Windows.Forms.Button();
            this.label238 = new System.Windows.Forms.Label();
            this.textBoxTabLMEHIHourH = new System.Windows.Forms.TextBox();
            this.buttonTabLMEHIHourCalculate = new System.Windows.Forms.Button();
            this.label243 = new System.Windows.Forms.Label();
            this.textBoxTabLMEHIHourAnswer = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHIHourQL = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHIHourL = new System.Windows.Forms.TextBox();
            this.label244 = new System.Windows.Forms.Label();
            this.label247 = new System.Windows.Forms.Label();
            this.label249 = new System.Windows.Forms.Label();
            this.label250 = new System.Windows.Forms.Label();
            this.label251 = new System.Windows.Forms.Label();
            this.label254 = new System.Windows.Forms.Label();
            this.label255 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label256 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.buttonTabLMEHIQuarterCalculate = new System.Windows.Forms.Button();
            this.label257 = new System.Windows.Forms.Label();
            this.textBoxTabLMEHIQuarterAnswer = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHIQuarterGCV = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHIQuarterFF = new System.Windows.Forms.TextBox();
            this.label258 = new System.Windows.Forms.Label();
            this.label259 = new System.Windows.Forms.Label();
            this.label260 = new System.Windows.Forms.Label();
            this.tabPageLME_Mass = new System.Windows.Forms.TabPage();
            this.buttonTabLMEHourCo2Clear = new System.Windows.Forms.Button();
            this.label248 = new System.Windows.Forms.Label();
            this.label262 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.buttonTabLMEHourCo2Calculate = new System.Windows.Forms.Button();
            this.label272 = new System.Windows.Forms.Label();
            this.textBoxTabLMEHourCo2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHourCo2Co2 = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHourCo2H = new System.Windows.Forms.TextBox();
            this.label273 = new System.Windows.Forms.Label();
            this.label274 = new System.Windows.Forms.Label();
            this.label275 = new System.Windows.Forms.Label();
            this.buttonTabLMEHourSo2Clear = new System.Windows.Forms.Button();
            this.buttonTabLMEHourNoxClear = new System.Windows.Forms.Button();
            this.buttonTabLMEHourSo2Calculate = new System.Windows.Forms.Button();
            this.label252 = new System.Windows.Forms.Label();
            this.textBoxTabLMEHourSo2Answer = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHourSo2So2 = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHourSo2H = new System.Windows.Forms.TextBox();
            this.label253 = new System.Windows.Forms.Label();
            this.label261 = new System.Windows.Forms.Label();
            this.label263 = new System.Windows.Forms.Label();
            this.label264 = new System.Windows.Forms.Label();
            this.label265 = new System.Windows.Forms.Label();
            this.label266 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label267 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.buttonTabLMEHourNoxCalculate = new System.Windows.Forms.Button();
            this.label268 = new System.Windows.Forms.Label();
            this.textBoxTabLMEHourNoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHourNoxNox = new System.Windows.Forms.TextBox();
            this.textBoxTabLMEHourNoxH = new System.Windows.Forms.TextBox();
            this.label269 = new System.Windows.Forms.Label();
            this.label270 = new System.Windows.Forms.Label();
            this.label271 = new System.Windows.Forms.Label();
            this.tabTime = new System.Windows.Forms.TabPage();
            this.buttonTimeCopy = new System.Windows.Forms.Button();
            this.textBoxHourlyDecimal = new System.Windows.Forms.TextBox();
            this.label291 = new System.Windows.Forms.Label();
            this.buttonTimeClear = new System.Windows.Forms.Button();
            this.buttonTimeCalculate = new System.Windows.Forms.Button();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.label290 = new System.Windows.Forms.Label();
            this.label289 = new System.Windows.Forms.Label();
            this.label288 = new System.Windows.Forms.Label();
            this.label287 = new System.Windows.Forms.Label();
            this.label284 = new System.Windows.Forms.Label();
            this.label281 = new System.Windows.Forms.Label();
            this.textBoxss2 = new System.Windows.Forms.TextBox();
            this.label282 = new System.Windows.Forms.Label();
            this.textBoxmm2 = new System.Windows.Forms.TextBox();
            this.label283 = new System.Windows.Forms.Label();
            this.textBoxHH2 = new System.Windows.Forms.TextBox();
            this.label280 = new System.Windows.Forms.Label();
            this.textBoxss1 = new System.Windows.Forms.TextBox();
            this.label279 = new System.Windows.Forms.Label();
            this.textBoxmm1 = new System.Windows.Forms.TextBox();
            this.label278 = new System.Windows.Forms.Label();
            this.textBoxHH1 = new System.Windows.Forms.TextBox();
            this.label277 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label276 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.buttonPart75 = new System.Windows.Forms.Button();
            this.textBoxSectionHeading = new System.Windows.Forms.TextBox();
            this.buttonDefinitions = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.textBoxDefinitions = new System.Windows.Forms.TextBox();
            this.buttonTechQuestions = new System.Windows.Forms.Button();
            this.buttonSoftwareQuestions = new System.Windows.Forms.Button();
            this.labelSectionSubHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonUnitsOfMeasure = new System.Windows.Forms.Button();
            this.buttonPart75PlainEnglish = new System.Windows.Forms.Button();
            this.buttonPart63SubUUUUU = new System.Windows.Forms.Button();
            this.button60AppBF = new System.Windows.Forms.Button();
            this.buttonChemicalFormulas = new System.Windows.Forms.Button();
            this.buttonFormulas = new System.Windows.Forms.Button();
            this.buttonAcronyms = new System.Windows.Forms.Button();
            this.webBrowserPdf = new System.Windows.Forms.WebBrowser();
            this.comboBoxSectionNumber = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelFormulas.SuspendLayout();
            this.tabFormulasMain.SuspendLayout();
            this.tabOilFlow.SuspendLayout();
            this.tabCO2Gas.SuspendLayout();
            this.tabCO2Oil.SuspendLayout();
            this.tabCO2Flow.SuspendLayout();
            this.tabHeatInputGas.SuspendLayout();
            this.tabHeatInputOil.SuspendLayout();
            this.tabHeatInputFlow.SuspendLayout();
            this.tabSO2Gas.SuspendLayout();
            this.tabSO2Oil.SuspendLayout();
            this.tabSO2Flow.SuspendLayout();
            this.tabNOxlbsmmBtu.SuspendLayout();
            this.tabNOxlbshr.SuspendLayout();
            this.tabNOxppmvd.SuspendLayout();
            this.tabFuelFactor.SuspendLayout();
            this.tabCoal.SuspendLayout();
            this.tabColbsmmBtu.SuspendLayout();
            this.tabCOlbshr.SuspendLayout();
            this.tabCOppmvd.SuspendLayout();
            this.tabPage4_20ma.SuspendLayout();
            this.tabPageHg.SuspendLayout();
            this.tabPageLME_HI.SuspendLayout();
            this.tabPageLME_Mass.SuspendLayout();
            this.tabTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBoxSearch);
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.buttonRandom);
            this.panel1.Controls.Add(this.panelFormulas);
            this.panel1.Controls.Add(this.buttonPart75);
            this.panel1.Controls.Add(this.textBoxSectionHeading);
            this.panel1.Controls.Add(this.buttonDefinitions);
            this.panel1.Controls.Add(this.pictureBoxMain);
            this.panel1.Controls.Add(this.textBoxDefinitions);
            this.panel1.Controls.Add(this.buttonTechQuestions);
            this.panel1.Controls.Add(this.buttonSoftwareQuestions);
            this.panel1.Controls.Add(this.labelSectionSubHeading);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonAdmin);
            this.panel1.Controls.Add(this.buttonUnitsOfMeasure);
            this.panel1.Controls.Add(this.buttonPart75PlainEnglish);
            this.panel1.Controls.Add(this.buttonPart63SubUUUUU);
            this.panel1.Controls.Add(this.button60AppBF);
            this.panel1.Controls.Add(this.buttonChemicalFormulas);
            this.panel1.Controls.Add(this.buttonFormulas);
            this.panel1.Controls.Add(this.buttonAcronyms);
            this.panel1.Controls.Add(this.webBrowserPdf);
            this.panel1.Controls.Add(this.comboBoxSectionNumber);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonToggle);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Location = new System.Drawing.Point(16, 13);
            this.panel1.MinimumSize = new System.Drawing.Size(1193, 729);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 729);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Select Regulation",
            "Part 75",
            "Part 75 Emissions Monitoring Policy",
            "Part 75 Appendix D",
            "Part 75 Plain English Guide",
            "Part 75 Field Audit Manual",
            "Part 60 Appendix B",
            "Part 60 Appendix F",
            "Part 63 Subpart UUUUU",
            "ECMPS Emissions Reporting Instructions",
            "ECMPS QA Reporting Instructions"});
            this.comboBoxSearch.Location = new System.Drawing.Point(603, 690);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(302, 21);
            this.comboBoxSearch.TabIndex = 132;
            this.toolTip1.SetToolTip(this.comboBoxSearch, "Select Full Regulation");
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            this.comboBoxSearch.Enter += new System.EventHandler(this.comboBoxSearch_Enter);
            this.comboBoxSearch.Leave += new System.EventHandler(this.comboBoxSearch_Leave);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(40, 7);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(48, 13);
            this.labelVersion.TabIndex = 131;
            this.labelVersion.Text = "Version: ";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRandom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRandom.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonRandom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandom.ForeColor = System.Drawing.Color.White;
            this.buttonRandom.Location = new System.Drawing.Point(483, 688);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 130;
            this.buttonRandom.Tag = "Click to toggle Answer";
            this.buttonRandom.Text = "Random";
            this.toolTip1.SetToolTip(this.buttonRandom, "Gets Random Section");
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.Visible = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // panelFormulas
            // 
            this.panelFormulas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFormulas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFormulas.Controls.Add(this.tabFormulasMain);
            this.panelFormulas.Location = new System.Drawing.Point(200, 133);
            this.panelFormulas.Name = "panelFormulas";
            this.panelFormulas.Size = new System.Drawing.Size(947, 542);
            this.panelFormulas.TabIndex = 129;
            // 
            // tabFormulasMain
            // 
            this.tabFormulasMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabFormulasMain.Controls.Add(this.tabOilFlow);
            this.tabFormulasMain.Controls.Add(this.tabCO2Gas);
            this.tabFormulasMain.Controls.Add(this.tabCO2Oil);
            this.tabFormulasMain.Controls.Add(this.tabCO2Flow);
            this.tabFormulasMain.Controls.Add(this.tabHeatInputGas);
            this.tabFormulasMain.Controls.Add(this.tabHeatInputOil);
            this.tabFormulasMain.Controls.Add(this.tabHeatInputFlow);
            this.tabFormulasMain.Controls.Add(this.tabSO2Gas);
            this.tabFormulasMain.Controls.Add(this.tabSO2Oil);
            this.tabFormulasMain.Controls.Add(this.tabSO2Flow);
            this.tabFormulasMain.Controls.Add(this.tabNOxlbsmmBtu);
            this.tabFormulasMain.Controls.Add(this.tabNOxlbshr);
            this.tabFormulasMain.Controls.Add(this.tabNOxppmvd);
            this.tabFormulasMain.Controls.Add(this.tabFuelFactor);
            this.tabFormulasMain.Controls.Add(this.tabCoal);
            this.tabFormulasMain.Controls.Add(this.tabColbsmmBtu);
            this.tabFormulasMain.Controls.Add(this.tabCOlbshr);
            this.tabFormulasMain.Controls.Add(this.tabCOppmvd);
            this.tabFormulasMain.Controls.Add(this.tabPage4_20ma);
            this.tabFormulasMain.Controls.Add(this.tabPageHg);
            this.tabFormulasMain.Controls.Add(this.tabPageLME_HI);
            this.tabFormulasMain.Controls.Add(this.tabPageLME_Mass);
            this.tabFormulasMain.Controls.Add(this.tabTime);
            this.tabFormulasMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFormulasMain.Location = new System.Drawing.Point(0, -3);
            this.tabFormulasMain.Name = "tabFormulasMain";
            this.tabFormulasMain.SelectedIndex = 0;
            this.tabFormulasMain.Size = new System.Drawing.Size(947, 542);
            this.tabFormulasMain.TabIndex = 0;
            this.tabFormulasMain.SelectedIndexChanged += new System.EventHandler(this.tabFormulasMain_SelectedIndexChanged);
            // 
            // tabOilFlow
            // 
            this.tabOilFlow.BackColor = System.Drawing.Color.Ivory;
            this.tabOilFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabOilFlow.Controls.Add(this.buttonTabOilFlowF1Clear);
            this.tabOilFlow.Controls.Add(this.textBoxTabOilFlowMassF1OilFlow);
            this.tabOilFlow.Controls.Add(this.textBoxTabOilFlowF1Density);
            this.tabOilFlow.Controls.Add(this.textBoxTabOilFlowF1OilFlow);
            this.tabOilFlow.Controls.Add(this.textBox1);
            this.tabOilFlow.Controls.Add(this.textBox170);
            this.tabOilFlow.Controls.Add(this.buttonTabOilFlowF1Calculate);
            this.tabOilFlow.Controls.Add(this.label207);
            this.tabOilFlow.Controls.Add(this.label208);
            this.tabOilFlow.Controls.Add(this.label210);
            this.tabOilFlow.Controls.Add(this.label211);
            this.tabOilFlow.Controls.Add(this.label212);
            this.tabOilFlow.Controls.Add(this.label213);
            this.tabOilFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOilFlow.Location = new System.Drawing.Point(4, 24);
            this.tabOilFlow.Name = "tabOilFlow";
            this.tabOilFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabOilFlow.Size = new System.Drawing.Size(939, 514);
            this.tabOilFlow.TabIndex = 0;
            this.tabOilFlow.Text = "Oil Flow";
            this.tabOilFlow.ToolTipText = "Copy To Clipboard";
            // 
            // buttonTabOilFlowF1Clear
            // 
            this.buttonTabOilFlowF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabOilFlowF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabOilFlowF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabOilFlowF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabOilFlowF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabOilFlowF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabOilFlowF1Clear.Location = new System.Drawing.Point(258, 177);
            this.buttonTabOilFlowF1Clear.Name = "buttonTabOilFlowF1Clear";
            this.buttonTabOilFlowF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabOilFlowF1Clear.TabIndex = 84;
            this.buttonTabOilFlowF1Clear.Text = "Clear";
            this.buttonTabOilFlowF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabOilFlowF1Clear.Click += new System.EventHandler(this.buttonTabOilFlowF1Clear_Click);
            // 
            // textBoxTabOilFlowMassF1OilFlow
            // 
            this.textBoxTabOilFlowMassF1OilFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabOilFlowMassF1OilFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTabOilFlowMassF1OilFlow.Location = new System.Drawing.Point(342, 150);
            this.textBoxTabOilFlowMassF1OilFlow.Name = "textBoxTabOilFlowMassF1OilFlow";
            this.textBoxTabOilFlowMassF1OilFlow.ReadOnly = true;
            this.textBoxTabOilFlowMassF1OilFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabOilFlowMassF1OilFlow.TabIndex = 82;
            this.textBoxTabOilFlowMassF1OilFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabOilFlowF1Density
            // 
            this.textBoxTabOilFlowF1Density.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabOilFlowF1Density.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTabOilFlowF1Density.Location = new System.Drawing.Point(342, 123);
            this.textBoxTabOilFlowF1Density.Name = "textBoxTabOilFlowF1Density";
            this.textBoxTabOilFlowF1Density.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabOilFlowF1Density.TabIndex = 81;
            this.textBoxTabOilFlowF1Density.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabOilFlowF1OilFlow
            // 
            this.textBoxTabOilFlowF1OilFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabOilFlowF1OilFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTabOilFlowF1OilFlow.Location = new System.Drawing.Point(342, 96);
            this.textBoxTabOilFlowF1OilFlow.Name = "textBoxTabOilFlowF1OilFlow";
            this.textBoxTabOilFlowF1OilFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabOilFlowF1OilFlow.TabIndex = 80;
            this.textBoxTabOilFlowF1OilFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(927, 29);
            this.textBox1.TabIndex = 79;
            this.textBox1.Text = "Calculate Mass Flow of OIL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox170
            // 
            this.textBox170.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox170.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox170.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox170.ForeColor = System.Drawing.Color.White;
            this.textBox170.Location = new System.Drawing.Point(23, 64);
            this.textBox170.Name = "textBox170";
            this.textBox170.ReadOnly = true;
            this.textBox170.Size = new System.Drawing.Size(419, 22);
            this.textBox170.TabIndex = 60;
            this.textBox170.Text = "E=OF x OD  x 60                          Formula D-3";
            this.textBox170.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabOilFlowF1Calculate
            // 
            this.buttonTabOilFlowF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabOilFlowF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabOilFlowF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabOilFlowF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabOilFlowF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabOilFlowF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabOilFlowF1Calculate.Location = new System.Drawing.Point(367, 177);
            this.buttonTabOilFlowF1Calculate.Name = "buttonTabOilFlowF1Calculate";
            this.buttonTabOilFlowF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabOilFlowF1Calculate.TabIndex = 83;
            this.buttonTabOilFlowF1Calculate.Text = "Calculate";
            this.buttonTabOilFlowF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabOilFlowF1Calculate.Click += new System.EventHandler(this.buttonTabOilFlowF1Calculate_Click);
            // 
            // label207
            // 
            this.label207.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label207.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label207.Location = new System.Drawing.Point(186, 153);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(149, 20);
            this.label207.TabIndex = 58;
            this.label207.Text = "Mass Oil Flow lbs/hr = ";
            // 
            // label208
            // 
            this.label208.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label208.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label208.Location = new System.Drawing.Point(247, 126);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(88, 18);
            this.label208.TabIndex = 54;
            this.label208.Text = "Density of Oil = ";
            // 
            // label210
            // 
            this.label210.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label210.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label210.Location = new System.Drawing.Point(269, 98);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(64, 19);
            this.label210.TabIndex = 53;
            this.label210.Text = "Oil Flow  = ";
            // 
            // label211
            // 
            this.label211.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label211.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label211.Location = new System.Drawing.Point(23, 135);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(142, 17);
            this.label211.TabIndex = 52;
            this.label211.Text = "60  - Conversion min/hr";
            // 
            // label212
            // 
            this.label212.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label212.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label212.Location = new System.Drawing.Point(23, 116);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(150, 19);
            this.label212.TabIndex = 51;
            this.label212.Text = "OD - Oil Density in lbs/gal";
            // 
            // label213
            // 
            this.label213.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label213.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label213.Location = new System.Drawing.Point(23, 96);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(150, 20);
            this.label213.TabIndex = 50;
            this.label213.Text = "OF - Oil Flow in gals/min";
            // 
            // tabCO2Gas
            // 
            this.tabCO2Gas.BackColor = System.Drawing.Color.Ivory;
            this.tabCO2Gas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCO2Gas.Controls.Add(this.buttonTabCO2GasF3Clear);
            this.tabCO2Gas.Controls.Add(this.buttonTabCO2GasF2Clear);
            this.tabCO2Gas.Controls.Add(this.buttonTabCO2GasF1Clear);
            this.tabCO2Gas.Controls.Add(this.textBox5);
            this.tabCO2Gas.Controls.Add(this.textBox7);
            this.tabCO2Gas.Controls.Add(this.buttonTabCO2GasF3Calculate);
            this.tabCO2Gas.Controls.Add(this.label21);
            this.tabCO2Gas.Controls.Add(this.textBoxTabCO2GasF3Answer);
            this.tabCO2Gas.Controls.Add(this.textBoxTabCO2GasF3GasFlow);
            this.tabCO2Gas.Controls.Add(this.textBoxTabCO2GasF3CO2Concentration);
            this.tabCO2Gas.Controls.Add(this.label22);
            this.tabCO2Gas.Controls.Add(this.label23);
            this.tabCO2Gas.Controls.Add(this.label25);
            this.tabCO2Gas.Controls.Add(this.label26);
            this.tabCO2Gas.Controls.Add(this.textBox3);
            this.tabCO2Gas.Controls.Add(this.buttonTabCO2GasF2Calculate);
            this.tabCO2Gas.Controls.Add(this.label15);
            this.tabCO2Gas.Controls.Add(this.textBoxTabCO2GasF2Answer);
            this.tabCO2Gas.Controls.Add(this.textBoxTabCO2GasF2HTIP);
            this.tabCO2Gas.Controls.Add(this.label17);
            this.tabCO2Gas.Controls.Add(this.label19);
            this.tabCO2Gas.Controls.Add(this.label20);
            this.tabCO2Gas.Controls.Add(this.textBox2);
            this.tabCO2Gas.Controls.Add(this.buttonTabCO2GasF1Calculate);
            this.tabCO2Gas.Controls.Add(this.label1);
            this.tabCO2Gas.Controls.Add(this.textBoxTabCO2F1Answer);
            this.tabCO2Gas.Controls.Add(this.textBoxTabCO2GasF1GasFlow);
            this.tabCO2Gas.Controls.Add(this.textBoxTabCO2GasF1CarbonContent);
            this.tabCO2Gas.Controls.Add(this.label10);
            this.tabCO2Gas.Controls.Add(this.label11);
            this.tabCO2Gas.Controls.Add(this.label12);
            this.tabCO2Gas.Controls.Add(this.label13);
            this.tabCO2Gas.Controls.Add(this.label14);
            this.tabCO2Gas.Location = new System.Drawing.Point(4, 24);
            this.tabCO2Gas.Name = "tabCO2Gas";
            this.tabCO2Gas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCO2Gas.Size = new System.Drawing.Size(939, 514);
            this.tabCO2Gas.TabIndex = 1;
            this.tabCO2Gas.Text = "CO2 - Gas";
            // 
            // buttonTabCO2GasF3Clear
            // 
            this.buttonTabCO2GasF3Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2GasF3Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2GasF3Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCO2GasF3Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2GasF3Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2GasF3Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2GasF3Clear.Location = new System.Drawing.Point(254, 349);
            this.buttonTabCO2GasF3Clear.Name = "buttonTabCO2GasF3Clear";
            this.buttonTabCO2GasF3Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2GasF3Clear.TabIndex = 96;
            this.buttonTabCO2GasF3Clear.Text = "Clear";
            this.buttonTabCO2GasF3Clear.UseVisualStyleBackColor = false;
            this.buttonTabCO2GasF3Clear.Click += new System.EventHandler(this.buttonTabCO2GasF3Clear_Click);
            // 
            // buttonTabCO2GasF2Clear
            // 
            this.buttonTabCO2GasF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2GasF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2GasF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCO2GasF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2GasF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2GasF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2GasF2Clear.Location = new System.Drawing.Point(726, 178);
            this.buttonTabCO2GasF2Clear.Name = "buttonTabCO2GasF2Clear";
            this.buttonTabCO2GasF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2GasF2Clear.TabIndex = 92;
            this.buttonTabCO2GasF2Clear.Text = "Clear";
            this.buttonTabCO2GasF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabCO2GasF2Clear.Click += new System.EventHandler(this.buttonTabCO2GasF2Clear_Click);
            // 
            // buttonTabCO2GasF1Clear
            // 
            this.buttonTabCO2GasF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2GasF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2GasF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCO2GasF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2GasF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2GasF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2GasF1Clear.Location = new System.Drawing.Point(254, 178);
            this.buttonTabCO2GasF1Clear.Name = "buttonTabCO2GasF1Clear";
            this.buttonTabCO2GasF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2GasF1Clear.TabIndex = 89;
            this.buttonTabCO2GasF1Clear.Text = "Clear";
            this.buttonTabCO2GasF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabCO2GasF1Clear.Click += new System.EventHandler(this.buttonTabCO2GasF1Clear_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.Color.Blue;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(5, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(927, 29);
            this.textBox5.TabIndex = 49;
            this.textBox5.Text = "Calculate CO2 Tons / Hr for GAS";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(23, 235);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(419, 22);
            this.textBox7.TabIndex = 48;
            this.textBox7.Text = "E = (5.7 / 10000000) x CO2 x GF      Formula F-11";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCO2GasF3Calculate
            // 
            this.buttonTabCO2GasF3Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2GasF3Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2GasF3Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCO2GasF3Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2GasF3Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2GasF3Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2GasF3Calculate.Location = new System.Drawing.Point(367, 349);
            this.buttonTabCO2GasF3Calculate.Name = "buttonTabCO2GasF3Calculate";
            this.buttonTabCO2GasF3Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2GasF3Calculate.TabIndex = 95;
            this.buttonTabCO2GasF3Calculate.Text = "Calculate";
            this.buttonTabCO2GasF3Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCO2GasF3Calculate.Click += new System.EventHandler(this.buttonTabCO2GasF3Calculate_Click);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(237, 324);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 15);
            this.label21.TabIndex = 46;
            this.label21.Text = "CO2 tons/hr = ";
            // 
            // textBoxTabCO2GasF3Answer
            // 
            this.textBoxTabCO2GasF3Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2GasF3Answer.Location = new System.Drawing.Point(342, 321);
            this.textBoxTabCO2GasF3Answer.Name = "textBoxTabCO2GasF3Answer";
            this.textBoxTabCO2GasF3Answer.ReadOnly = true;
            this.textBoxTabCO2GasF3Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2GasF3Answer.TabIndex = 45;
            this.textBoxTabCO2GasF3Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2GasF3GasFlow
            // 
            this.textBoxTabCO2GasF3GasFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2GasF3GasFlow.Location = new System.Drawing.Point(342, 293);
            this.textBoxTabCO2GasF3GasFlow.Name = "textBoxTabCO2GasF3GasFlow";
            this.textBoxTabCO2GasF3GasFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2GasF3GasFlow.TabIndex = 94;
            this.textBoxTabCO2GasF3GasFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2GasF3CO2Concentration
            // 
            this.textBoxTabCO2GasF3CO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2GasF3CO2Concentration.Location = new System.Drawing.Point(342, 265);
            this.textBoxTabCO2GasF3CO2Concentration.Name = "textBoxTabCO2GasF3CO2Concentration";
            this.textBoxTabCO2GasF3CO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2GasF3CO2Concentration.TabIndex = 93;
            this.textBoxTabCO2GasF3CO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(263, 295);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 14);
            this.label22.TabIndex = 42;
            this.label22.Text = "Gas Flow = ";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(211, 266);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 19);
            this.label23.TabIndex = 41;
            this.label23.Text = "CO2 Concentration =  ";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(21, 285);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 19);
            this.label25.TabIndex = 39;
            this.label25.Text = "GF - Gas Flow";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(23, 267);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(173, 18);
            this.label26.TabIndex = 38;
            this.label26.Text = "CO2 - CO2 Concentration (%)";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(491, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(419, 22);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "E = Fc x HTIP (1 / 385) x (44 / 2000)      Formula G-4";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCO2GasF2Calculate
            // 
            this.buttonTabCO2GasF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2GasF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2GasF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCO2GasF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2GasF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2GasF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2GasF2Calculate.Location = new System.Drawing.Point(835, 178);
            this.buttonTabCO2GasF2Calculate.Name = "buttonTabCO2GasF2Calculate";
            this.buttonTabCO2GasF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2GasF2Calculate.TabIndex = 91;
            this.buttonTabCO2GasF2Calculate.Text = "Calculate";
            this.buttonTabCO2GasF2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCO2GasF2Calculate.Click += new System.EventHandler(this.buttonTabCO2GasF2Calculate_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(708, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 18);
            this.label15.TabIndex = 35;
            this.label15.Text = "CO2 tons/hr = ";
            // 
            // textBoxTabCO2GasF2Answer
            // 
            this.textBoxTabCO2GasF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2GasF2Answer.Location = new System.Drawing.Point(810, 150);
            this.textBoxTabCO2GasF2Answer.Name = "textBoxTabCO2GasF2Answer";
            this.textBoxTabCO2GasF2Answer.ReadOnly = true;
            this.textBoxTabCO2GasF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2GasF2Answer.TabIndex = 34;
            this.textBoxTabCO2GasF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2GasF2HTIP
            // 
            this.textBoxTabCO2GasF2HTIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2GasF2HTIP.Location = new System.Drawing.Point(810, 94);
            this.textBoxTabCO2GasF2HTIP.Name = "textBoxTabCO2GasF2HTIP";
            this.textBoxTabCO2GasF2HTIP.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2GasF2HTIP.TabIndex = 90;
            this.textBoxTabCO2GasF2HTIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(759, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 18);
            this.label17.TabIndex = 30;
            this.label17.Text = "HTIP = ";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(491, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 19);
            this.label19.TabIndex = 28;
            this.label19.Text = "HTIP - Heat Input for GAS";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(491, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 17);
            this.label20.TabIndex = 27;
            this.label20.Text = "Fc - 1040 Fuel Factor for GAS";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(23, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(419, 22);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "E = ((CC / 100 x GAS x 100 x DEN) x 44) / (2000 x12)      Formula G-1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCO2GasF1Calculate
            // 
            this.buttonTabCO2GasF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2GasF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2GasF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCO2GasF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2GasF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2GasF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2GasF1Calculate.Location = new System.Drawing.Point(367, 178);
            this.buttonTabCO2GasF1Calculate.Name = "buttonTabCO2GasF1Calculate";
            this.buttonTabCO2GasF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2GasF1Calculate.TabIndex = 88;
            this.buttonTabCO2GasF1Calculate.Text = "Calculate";
            this.buttonTabCO2GasF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCO2GasF1Calculate.Click += new System.EventHandler(this.buttonTabCO2GasF1Calculate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "CO2 tons/hr = ";
            // 
            // textBoxTabCO2F1Answer
            // 
            this.textBoxTabCO2F1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2F1Answer.Location = new System.Drawing.Point(342, 150);
            this.textBoxTabCO2F1Answer.Name = "textBoxTabCO2F1Answer";
            this.textBoxTabCO2F1Answer.ReadOnly = true;
            this.textBoxTabCO2F1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2F1Answer.TabIndex = 87;
            this.textBoxTabCO2F1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2GasF1GasFlow
            // 
            this.textBoxTabCO2GasF1GasFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2GasF1GasFlow.Location = new System.Drawing.Point(342, 122);
            this.textBoxTabCO2GasF1GasFlow.Name = "textBoxTabCO2GasF1GasFlow";
            this.textBoxTabCO2GasF1GasFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2GasF1GasFlow.TabIndex = 86;
            this.textBoxTabCO2GasF1GasFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2GasF1CarbonContent
            // 
            this.textBoxTabCO2GasF1CarbonContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2GasF1CarbonContent.Location = new System.Drawing.Point(342, 94);
            this.textBoxTabCO2GasF1CarbonContent.Name = "textBoxTabCO2GasF1CarbonContent";
            this.textBoxTabCO2GasF1CarbonContent.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2GasF1CarbonContent.TabIndex = 85;
            this.textBoxTabCO2GasF1CarbonContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(263, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Gas Flow = ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(230, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Carbon Content = ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "DEN - Density, 0.0452 lbs/scf";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "GAS - Gas Flow in 100 scfh";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "CC   - Carbon Content for GAS %";
            // 
            // tabCO2Oil
            // 
            this.tabCO2Oil.BackColor = System.Drawing.Color.Ivory;
            this.tabCO2Oil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCO2Oil.Controls.Add(this.buttonTabCO2OilF3Clear);
            this.tabCO2Oil.Controls.Add(this.buttonTabCO2OilF2Clear);
            this.tabCO2Oil.Controls.Add(this.buttonTabCO2OilF1Clear);
            this.tabCO2Oil.Controls.Add(this.textBox11);
            this.tabCO2Oil.Controls.Add(this.textBox23);
            this.tabCO2Oil.Controls.Add(this.buttonTabCO2OilF3Calculate);
            this.tabCO2Oil.Controls.Add(this.label16);
            this.tabCO2Oil.Controls.Add(this.textBoxTabCO2OilF3Answer);
            this.tabCO2Oil.Controls.Add(this.textBoxTabCO2OilF3MassOfOil);
            this.tabCO2Oil.Controls.Add(this.textBoxTabCO2OilF3CO2Concentration);
            this.tabCO2Oil.Controls.Add(this.label18);
            this.tabCO2Oil.Controls.Add(this.label24);
            this.tabCO2Oil.Controls.Add(this.label27);
            this.tabCO2Oil.Controls.Add(this.label28);
            this.tabCO2Oil.Controls.Add(this.textBox27);
            this.tabCO2Oil.Controls.Add(this.buttonTabCO2OilF2Calculate);
            this.tabCO2Oil.Controls.Add(this.label29);
            this.tabCO2Oil.Controls.Add(this.textBoxTabCO2OilF2Answer);
            this.tabCO2Oil.Controls.Add(this.textBoxTabCO2OilF2HTIP);
            this.tabCO2Oil.Controls.Add(this.label30);
            this.tabCO2Oil.Controls.Add(this.label31);
            this.tabCO2Oil.Controls.Add(this.label32);
            this.tabCO2Oil.Controls.Add(this.textBox30);
            this.tabCO2Oil.Controls.Add(this.buttonTabCO2OilF1Calculate);
            this.tabCO2Oil.Controls.Add(this.label33);
            this.tabCO2Oil.Controls.Add(this.textBoxTabCO2OilF1Answer);
            this.tabCO2Oil.Controls.Add(this.textBoxTabCO2OilF1MassOil);
            this.tabCO2Oil.Controls.Add(this.textBoxTabCO2OilF1CarbonContent);
            this.tabCO2Oil.Controls.Add(this.label34);
            this.tabCO2Oil.Controls.Add(this.label35);
            this.tabCO2Oil.Controls.Add(this.label37);
            this.tabCO2Oil.Controls.Add(this.label38);
            this.tabCO2Oil.Location = new System.Drawing.Point(4, 24);
            this.tabCO2Oil.Name = "tabCO2Oil";
            this.tabCO2Oil.Padding = new System.Windows.Forms.Padding(3);
            this.tabCO2Oil.Size = new System.Drawing.Size(939, 514);
            this.tabCO2Oil.TabIndex = 2;
            this.tabCO2Oil.Text = "CO2 - Oil";
            // 
            // buttonTabCO2OilF3Clear
            // 
            this.buttonTabCO2OilF3Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2OilF3Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2OilF3Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCO2OilF3Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2OilF3Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2OilF3Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2OilF3Clear.Location = new System.Drawing.Point(254, 349);
            this.buttonTabCO2OilF3Clear.Name = "buttonTabCO2OilF3Clear";
            this.buttonTabCO2OilF3Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2OilF3Clear.TabIndex = 107;
            this.buttonTabCO2OilF3Clear.Text = "Clear";
            this.buttonTabCO2OilF3Clear.UseVisualStyleBackColor = false;
            this.buttonTabCO2OilF3Clear.Click += new System.EventHandler(this.buttonTabCO2OilF3Clear_Click);
            // 
            // buttonTabCO2OilF2Clear
            // 
            this.buttonTabCO2OilF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2OilF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2OilF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCO2OilF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2OilF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2OilF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2OilF2Clear.Location = new System.Drawing.Point(721, 148);
            this.buttonTabCO2OilF2Clear.Name = "buttonTabCO2OilF2Clear";
            this.buttonTabCO2OilF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2OilF2Clear.TabIndex = 103;
            this.buttonTabCO2OilF2Clear.Text = "Clear";
            this.buttonTabCO2OilF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabCO2OilF2Clear.Click += new System.EventHandler(this.buttonTabCO2OilF2Clear_Click);
            // 
            // buttonTabCO2OilF1Clear
            // 
            this.buttonTabCO2OilF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2OilF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2OilF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCO2OilF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2OilF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2OilF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2OilF1Clear.Location = new System.Drawing.Point(256, 178);
            this.buttonTabCO2OilF1Clear.Name = "buttonTabCO2OilF1Clear";
            this.buttonTabCO2OilF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2OilF1Clear.TabIndex = 100;
            this.buttonTabCO2OilF1Clear.Text = "Clear";
            this.buttonTabCO2OilF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabCO2OilF1Clear.Click += new System.EventHandler(this.buttonTabCO2OilF1Clear_Click);
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox11.BackColor = System.Drawing.Color.Blue;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(5, 6);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(927, 29);
            this.textBox11.TabIndex = 79;
            this.textBox11.Text = "Calculate CO2 Tons / Hr for OIL";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox23.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.ForeColor = System.Drawing.Color.White;
            this.textBox23.Location = new System.Drawing.Point(23, 235);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(419, 22);
            this.textBox23.TabIndex = 78;
            this.textBox23.Text = "E = (5.7 / 10000000) x CO2 x MO      Formula F-11";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCO2OilF3Calculate
            // 
            this.buttonTabCO2OilF3Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2OilF3Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2OilF3Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCO2OilF3Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2OilF3Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2OilF3Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2OilF3Calculate.Location = new System.Drawing.Point(367, 349);
            this.buttonTabCO2OilF3Calculate.Name = "buttonTabCO2OilF3Calculate";
            this.buttonTabCO2OilF3Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2OilF3Calculate.TabIndex = 106;
            this.buttonTabCO2OilF3Calculate.Text = "Calculate";
            this.buttonTabCO2OilF3Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCO2OilF3Calculate.Click += new System.EventHandler(this.buttonTabCO2OilF3Calculate_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(237, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 17);
            this.label16.TabIndex = 76;
            this.label16.Text = "CO2 tons/hr = ";
            // 
            // textBoxTabCO2OilF3Answer
            // 
            this.textBoxTabCO2OilF3Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2OilF3Answer.Location = new System.Drawing.Point(342, 321);
            this.textBoxTabCO2OilF3Answer.Name = "textBoxTabCO2OilF3Answer";
            this.textBoxTabCO2OilF3Answer.ReadOnly = true;
            this.textBoxTabCO2OilF3Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2OilF3Answer.TabIndex = 75;
            this.textBoxTabCO2OilF3Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2OilF3MassOfOil
            // 
            this.textBoxTabCO2OilF3MassOfOil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2OilF3MassOfOil.Location = new System.Drawing.Point(342, 293);
            this.textBoxTabCO2OilF3MassOfOil.Name = "textBoxTabCO2OilF3MassOfOil";
            this.textBoxTabCO2OilF3MassOfOil.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2OilF3MassOfOil.TabIndex = 105;
            this.textBoxTabCO2OilF3MassOfOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2OilF3CO2Concentration
            // 
            this.textBoxTabCO2OilF3CO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2OilF3CO2Concentration.Location = new System.Drawing.Point(342, 265);
            this.textBoxTabCO2OilF3CO2Concentration.Name = "textBoxTabCO2OilF3CO2Concentration";
            this.textBoxTabCO2OilF3CO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2OilF3CO2Concentration.TabIndex = 104;
            this.textBoxTabCO2OilF3CO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(253, 295);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 14);
            this.label18.TabIndex = 72;
            this.label18.Text = "Mass of Oil = ";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(211, 266);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 19);
            this.label24.TabIndex = 71;
            this.label24.Text = "CO2 Concentration =  ";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(21, 288);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 16);
            this.label27.TabIndex = 70;
            this.label27.Text = "MO - Mass of Oil";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(23, 267);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(173, 16);
            this.label28.TabIndex = 69;
            this.label28.Text = "CO2 - CO2 Concentration (%)";
            // 
            // textBox27
            // 
            this.textBox27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox27.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox27.ForeColor = System.Drawing.Color.White;
            this.textBox27.Location = new System.Drawing.Point(491, 64);
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(419, 22);
            this.textBox27.TabIndex = 68;
            this.textBox27.Text = "E = Fc x HTIP (1 / 385) x (44 / 2000)      Formula G-4";
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCO2OilF2Calculate
            // 
            this.buttonTabCO2OilF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2OilF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2OilF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCO2OilF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2OilF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2OilF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2OilF2Calculate.Location = new System.Drawing.Point(835, 148);
            this.buttonTabCO2OilF2Calculate.Name = "buttonTabCO2OilF2Calculate";
            this.buttonTabCO2OilF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2OilF2Calculate.TabIndex = 102;
            this.buttonTabCO2OilF2Calculate.Text = "Calculate";
            this.buttonTabCO2OilF2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCO2OilF2Calculate.Click += new System.EventHandler(this.buttonTabCO2OilF2Calculate_Click);
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(703, 122);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 18);
            this.label29.TabIndex = 66;
            this.label29.Text = "CO2 tons/hr = ";
            // 
            // textBoxTabCO2OilF2Answer
            // 
            this.textBoxTabCO2OilF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2OilF2Answer.Location = new System.Drawing.Point(810, 120);
            this.textBoxTabCO2OilF2Answer.Name = "textBoxTabCO2OilF2Answer";
            this.textBoxTabCO2OilF2Answer.ReadOnly = true;
            this.textBoxTabCO2OilF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2OilF2Answer.TabIndex = 65;
            this.textBoxTabCO2OilF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2OilF2HTIP
            // 
            this.textBoxTabCO2OilF2HTIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2OilF2HTIP.Location = new System.Drawing.Point(810, 94);
            this.textBoxTabCO2OilF2HTIP.Name = "textBoxTabCO2OilF2HTIP";
            this.textBoxTabCO2OilF2HTIP.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2OilF2HTIP.TabIndex = 101;
            this.textBoxTabCO2OilF2HTIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(754, 95);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 18);
            this.label30.TabIndex = 63;
            this.label30.Text = "HTIP = ";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(491, 116);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(152, 19);
            this.label31.TabIndex = 62;
            this.label31.Text = "HTIP - Heat Input for OIL";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(491, 96);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(174, 15);
            this.label32.TabIndex = 61;
            this.label32.Text = "Fc - 1420 Fuel factor for OIL";
            // 
            // textBox30
            // 
            this.textBox30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox30.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox30.ForeColor = System.Drawing.Color.White;
            this.textBox30.Location = new System.Drawing.Point(23, 64);
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            this.textBox30.Size = new System.Drawing.Size(419, 22);
            this.textBox30.TabIndex = 60;
            this.textBox30.Text = "E = ((CC / 100 x MO) x 44) / (2000 x 12)      Formula G-1";
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCO2OilF1Calculate
            // 
            this.buttonTabCO2OilF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2OilF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2OilF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCO2OilF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2OilF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2OilF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2OilF1Calculate.Location = new System.Drawing.Point(367, 178);
            this.buttonTabCO2OilF1Calculate.Name = "buttonTabCO2OilF1Calculate";
            this.buttonTabCO2OilF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2OilF1Calculate.TabIndex = 99;
            this.buttonTabCO2OilF1Calculate.Text = "Calculate";
            this.buttonTabCO2OilF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCO2OilF1Calculate.Click += new System.EventHandler(this.buttonTabCO2OilF1Calculate_Click);
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(238, 152);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(96, 20);
            this.label33.TabIndex = 58;
            this.label33.Text = "CO2 tons/hr = ";
            // 
            // textBoxTabCO2OilF1Answer
            // 
            this.textBoxTabCO2OilF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2OilF1Answer.Location = new System.Drawing.Point(342, 150);
            this.textBoxTabCO2OilF1Answer.Name = "textBoxTabCO2OilF1Answer";
            this.textBoxTabCO2OilF1Answer.ReadOnly = true;
            this.textBoxTabCO2OilF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2OilF1Answer.TabIndex = 57;
            this.textBoxTabCO2OilF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2OilF1MassOil
            // 
            this.textBoxTabCO2OilF1MassOil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2OilF1MassOil.Location = new System.Drawing.Point(342, 122);
            this.textBoxTabCO2OilF1MassOil.Name = "textBoxTabCO2OilF1MassOil";
            this.textBoxTabCO2OilF1MassOil.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2OilF1MassOil.TabIndex = 98;
            this.textBoxTabCO2OilF1MassOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2OilF1CarbonContent
            // 
            this.textBoxTabCO2OilF1CarbonContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2OilF1CarbonContent.Location = new System.Drawing.Point(342, 94);
            this.textBoxTabCO2OilF1CarbonContent.Name = "textBoxTabCO2OilF1CarbonContent";
            this.textBoxTabCO2OilF1CarbonContent.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2OilF1CarbonContent.TabIndex = 97;
            this.textBoxTabCO2OilF1CarbonContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(267, 123);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 18);
            this.label34.TabIndex = 54;
            this.label34.Text = "Mass Oil = ";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(231, 96);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(105, 19);
            this.label35.TabIndex = 53;
            this.label35.Text = "Carbon Content = ";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(23, 116);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(146, 19);
            this.label37.TabIndex = 51;
            this.label37.Text = "MO - Mass of Oil lb/hr";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(23, 96);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(173, 20);
            this.label38.TabIndex = 50;
            this.label38.Text = "CC - Carbon Content for OIL %";
            // 
            // tabCO2Flow
            // 
            this.tabCO2Flow.BackColor = System.Drawing.Color.Ivory;
            this.tabCO2Flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCO2Flow.Controls.Add(this.buttonTabCO2FlowF1CO2Clear);
            this.tabCO2Flow.Controls.Add(this.textBox12);
            this.tabCO2Flow.Controls.Add(this.textBox41);
            this.tabCO2Flow.Controls.Add(this.buttonTabCO2FlowF1CO2Calculate);
            this.tabCO2Flow.Controls.Add(this.label48);
            this.tabCO2Flow.Controls.Add(this.textBoxTabCO2FlowF1Answer);
            this.tabCO2Flow.Controls.Add(this.textBoxTabCO2FlowF1Flow);
            this.tabCO2Flow.Controls.Add(this.textBoxTabCO2FlowF1CO2Concentration);
            this.tabCO2Flow.Controls.Add(this.label49);
            this.tabCO2Flow.Controls.Add(this.label50);
            this.tabCO2Flow.Controls.Add(this.label52);
            this.tabCO2Flow.Controls.Add(this.label53);
            this.tabCO2Flow.Location = new System.Drawing.Point(4, 24);
            this.tabCO2Flow.Name = "tabCO2Flow";
            this.tabCO2Flow.Padding = new System.Windows.Forms.Padding(3);
            this.tabCO2Flow.Size = new System.Drawing.Size(939, 514);
            this.tabCO2Flow.TabIndex = 3;
            this.tabCO2Flow.Text = "CO2 - Flow";
            // 
            // buttonTabCO2FlowF1CO2Clear
            // 
            this.buttonTabCO2FlowF1CO2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2FlowF1CO2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2FlowF1CO2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCO2FlowF1CO2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2FlowF1CO2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2FlowF1CO2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2FlowF1CO2Clear.Location = new System.Drawing.Point(253, 178);
            this.buttonTabCO2FlowF1CO2Clear.Name = "buttonTabCO2FlowF1CO2Clear";
            this.buttonTabCO2FlowF1CO2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2FlowF1CO2Clear.TabIndex = 111;
            this.buttonTabCO2FlowF1CO2Clear.Text = "Clear";
            this.buttonTabCO2FlowF1CO2Clear.UseVisualStyleBackColor = false;
            this.buttonTabCO2FlowF1CO2Clear.Click += new System.EventHandler(this.buttonTabCO2FlowF1CO2Clear_Click);
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox12.BackColor = System.Drawing.Color.Blue;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(5, 6);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(927, 29);
            this.textBox12.TabIndex = 79;
            this.textBox12.Text = "Calculate CO2 Tons / Hr for FLOW";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox41
            // 
            this.textBox41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox41.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox41.ForeColor = System.Drawing.Color.White;
            this.textBox41.Location = new System.Drawing.Point(23, 64);
            this.textBox41.Name = "textBox41";
            this.textBox41.ReadOnly = true;
            this.textBox41.Size = new System.Drawing.Size(419, 22);
            this.textBox41.TabIndex = 60;
            this.textBox41.Text = "E = (5.7 / 10000000) x CO2 x FLO      Formula F-11";
            this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCO2FlowF1CO2Calculate
            // 
            this.buttonTabCO2FlowF1CO2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCO2FlowF1CO2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCO2FlowF1CO2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCO2FlowF1CO2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCO2FlowF1CO2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCO2FlowF1CO2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCO2FlowF1CO2Calculate.Location = new System.Drawing.Point(367, 178);
            this.buttonTabCO2FlowF1CO2Calculate.Name = "buttonTabCO2FlowF1CO2Calculate";
            this.buttonTabCO2FlowF1CO2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCO2FlowF1CO2Calculate.TabIndex = 110;
            this.buttonTabCO2FlowF1CO2Calculate.Text = "Calculate";
            this.buttonTabCO2FlowF1CO2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCO2FlowF1CO2Calculate.Click += new System.EventHandler(this.buttonTabCO2FlowF1CO2Calculate_Click);
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(236, 152);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(95, 20);
            this.label48.TabIndex = 58;
            this.label48.Text = "CO2 tons/hr = ";
            // 
            // textBoxTabCO2FlowF1Answer
            // 
            this.textBoxTabCO2FlowF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2FlowF1Answer.Location = new System.Drawing.Point(342, 150);
            this.textBoxTabCO2FlowF1Answer.Name = "textBoxTabCO2FlowF1Answer";
            this.textBoxTabCO2FlowF1Answer.ReadOnly = true;
            this.textBoxTabCO2FlowF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2FlowF1Answer.TabIndex = 57;
            this.textBoxTabCO2FlowF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2FlowF1Flow
            // 
            this.textBoxTabCO2FlowF1Flow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2FlowF1Flow.Location = new System.Drawing.Point(342, 122);
            this.textBoxTabCO2FlowF1Flow.Name = "textBoxTabCO2FlowF1Flow";
            this.textBoxTabCO2FlowF1Flow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2FlowF1Flow.TabIndex = 109;
            this.textBoxTabCO2FlowF1Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCO2FlowF1CO2Concentration
            // 
            this.textBoxTabCO2FlowF1CO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCO2FlowF1CO2Concentration.Location = new System.Drawing.Point(342, 94);
            this.textBoxTabCO2FlowF1CO2Concentration.Name = "textBoxTabCO2FlowF1CO2Concentration";
            this.textBoxTabCO2FlowF1CO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCO2FlowF1CO2Concentration.TabIndex = 108;
            this.textBoxTabCO2FlowF1CO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(288, 123);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(48, 18);
            this.label49.TabIndex = 54;
            this.label49.Text = "Flow = ";
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(212, 95);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(130, 19);
            this.label50.TabIndex = 53;
            this.label50.Text = "CO2 Concentration =  ";
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(23, 116);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(162, 19);
            this.label52.TabIndex = 51;
            this.label52.Text = "FLO - Volumetric Flow (scfh)";
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(23, 96);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(173, 20);
            this.label53.TabIndex = 50;
            this.label53.Text = "CO2 - CO2 Concentration (%)";
            // 
            // tabHeatInputGas
            // 
            this.tabHeatInputGas.BackColor = System.Drawing.Color.Ivory;
            this.tabHeatInputGas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHeatInputGas.Controls.Add(this.buttonTabHTIPGasF2Clear);
            this.tabHeatInputGas.Controls.Add(this.buttonTabHTIPGasF1Clear);
            this.tabHeatInputGas.Controls.Add(this.label40);
            this.tabHeatInputGas.Controls.Add(this.label39);
            this.tabHeatInputGas.Controls.Add(this.label36);
            this.tabHeatInputGas.Controls.Add(this.textBox13);
            this.tabHeatInputGas.Controls.Add(this.textBoxTabHTIPGasF2FuelFactor);
            this.tabHeatInputGas.Controls.Add(this.textBoxTabHTIPGasF2CO2Concentration);
            this.tabHeatInputGas.Controls.Add(this.label56);
            this.tabHeatInputGas.Controls.Add(this.textBox49);
            this.tabHeatInputGas.Controls.Add(this.buttonTabHTIPGasF2Answer);
            this.tabHeatInputGas.Controls.Add(this.label59);
            this.tabHeatInputGas.Controls.Add(this.textBoxTabHTIPGasF2Answer);
            this.tabHeatInputGas.Controls.Add(this.textBoxTabHTIPGasF2GasFlow);
            this.tabHeatInputGas.Controls.Add(this.label60);
            this.tabHeatInputGas.Controls.Add(this.label61);
            this.tabHeatInputGas.Controls.Add(this.label62);
            this.tabHeatInputGas.Controls.Add(this.textBox52);
            this.tabHeatInputGas.Controls.Add(this.buttonTabHTIPGasF1Calculate);
            this.tabHeatInputGas.Controls.Add(this.textBoxTabHTIPGasF1Answer);
            this.tabHeatInputGas.Controls.Add(this.textBoxTabHTIPGasF1GasFlow);
            this.tabHeatInputGas.Controls.Add(this.textBoxTabHTIPGasF1GCV);
            this.tabHeatInputGas.Controls.Add(this.label64);
            this.tabHeatInputGas.Controls.Add(this.label65);
            this.tabHeatInputGas.Controls.Add(this.label67);
            this.tabHeatInputGas.Controls.Add(this.label68);
            this.tabHeatInputGas.Location = new System.Drawing.Point(4, 24);
            this.tabHeatInputGas.Name = "tabHeatInputGas";
            this.tabHeatInputGas.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeatInputGas.Size = new System.Drawing.Size(939, 514);
            this.tabHeatInputGas.TabIndex = 4;
            this.tabHeatInputGas.Text = "Heat Input - Gas";
            // 
            // buttonTabHTIPGasF2Clear
            // 
            this.buttonTabHTIPGasF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPGasF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPGasF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabHTIPGasF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPGasF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPGasF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPGasF2Clear.Location = new System.Drawing.Point(723, 210);
            this.buttonTabHTIPGasF2Clear.Name = "buttonTabHTIPGasF2Clear";
            this.buttonTabHTIPGasF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPGasF2Clear.TabIndex = 120;
            this.buttonTabHTIPGasF2Clear.Text = "Clear";
            this.buttonTabHTIPGasF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabHTIPGasF2Clear.Click += new System.EventHandler(this.buttonTabHTIPGasF2Clear_Click);
            // 
            // buttonTabHTIPGasF1Clear
            // 
            this.buttonTabHTIPGasF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPGasF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPGasF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabHTIPGasF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPGasF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPGasF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPGasF1Clear.Location = new System.Drawing.Point(250, 178);
            this.buttonTabHTIPGasF1Clear.Name = "buttonTabHTIPGasF1Clear";
            this.buttonTabHTIPGasF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPGasF1Clear.TabIndex = 115;
            this.buttonTabHTIPGasF1Clear.Text = "Clear";
            this.buttonTabHTIPGasF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabHTIPGasF1Clear.Click += new System.EventHandler(this.buttonTabHTIPGasF1Clear_Click);
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(214, 152);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(122, 18);
            this.label40.TabIndex = 82;
            this.label40.Text = " HTIP mm/Btu = ";
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(723, 150);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(84, 18);
            this.label39.TabIndex = 81;
            this.label39.Text = "Fuel Factor =";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(491, 135);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(170, 19);
            this.label36.TabIndex = 80;
            this.label36.Text = "FF - Fuel Factor 1040 for GAS";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox13.BackColor = System.Drawing.Color.Blue;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.White;
            this.textBox13.Location = new System.Drawing.Point(5, 6);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(927, 29);
            this.textBox13.TabIndex = 79;
            this.textBox13.Text = "Calculate Heat Input mm/Btu for GAS";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTabHTIPGasF2FuelFactor
            // 
            this.textBoxTabHTIPGasF2FuelFactor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPGasF2FuelFactor.Location = new System.Drawing.Point(810, 147);
            this.textBoxTabHTIPGasF2FuelFactor.Name = "textBoxTabHTIPGasF2FuelFactor";
            this.textBoxTabHTIPGasF2FuelFactor.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPGasF2FuelFactor.TabIndex = 118;
            this.textBoxTabHTIPGasF2FuelFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPGasF2CO2Concentration
            // 
            this.textBoxTabHTIPGasF2CO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPGasF2CO2Concentration.Location = new System.Drawing.Point(810, 120);
            this.textBoxTabHTIPGasF2CO2Concentration.Name = "textBoxTabHTIPGasF2CO2Concentration";
            this.textBoxTabHTIPGasF2CO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPGasF2CO2Concentration.TabIndex = 117;
            this.textBoxTabHTIPGasF2CO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(681, 122);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(121, 19);
            this.label56.TabIndex = 71;
            this.label56.Text = "CO2 Concentration =  ";
            // 
            // textBox49
            // 
            this.textBox49.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox49.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox49.ForeColor = System.Drawing.Color.White;
            this.textBox49.Location = new System.Drawing.Point(491, 64);
            this.textBox49.Name = "textBox49";
            this.textBox49.ReadOnly = true;
            this.textBox49.Size = new System.Drawing.Size(419, 22);
            this.textBox49.TabIndex = 68;
            this.textBox49.Text = "E = (MO x CO2) / (FF x 100)     Formula F-15";
            this.textBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabHTIPGasF2Answer
            // 
            this.buttonTabHTIPGasF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPGasF2Answer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPGasF2Answer.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabHTIPGasF2Answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPGasF2Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPGasF2Answer.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPGasF2Answer.Location = new System.Drawing.Point(835, 210);
            this.buttonTabHTIPGasF2Answer.Name = "buttonTabHTIPGasF2Answer";
            this.buttonTabHTIPGasF2Answer.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPGasF2Answer.TabIndex = 119;
            this.buttonTabHTIPGasF2Answer.Text = "Calculate";
            this.buttonTabHTIPGasF2Answer.UseVisualStyleBackColor = false;
            this.buttonTabHTIPGasF2Answer.Click += new System.EventHandler(this.buttonTabHTIPGasF2Answer_Click);
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(687, 176);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(120, 18);
            this.label59.TabIndex = 66;
            this.label59.Text = " HTIP mm/Btu = ";
            // 
            // textBoxTabHTIPGasF2Answer
            // 
            this.textBoxTabHTIPGasF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPGasF2Answer.Location = new System.Drawing.Point(810, 174);
            this.textBoxTabHTIPGasF2Answer.Name = "textBoxTabHTIPGasF2Answer";
            this.textBoxTabHTIPGasF2Answer.ReadOnly = true;
            this.textBoxTabHTIPGasF2Answer.Size = new System.Drawing.Size(101, 21);
            this.textBoxTabHTIPGasF2Answer.TabIndex = 65;
            this.textBoxTabHTIPGasF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPGasF2GasFlow
            // 
            this.textBoxTabHTIPGasF2GasFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPGasF2GasFlow.Location = new System.Drawing.Point(810, 94);
            this.textBoxTabHTIPGasF2GasFlow.Name = "textBoxTabHTIPGasF2GasFlow";
            this.textBoxTabHTIPGasF2GasFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPGasF2GasFlow.TabIndex = 116;
            this.textBoxTabHTIPGasF2GasFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(733, 97);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(72, 18);
            this.label60.TabIndex = 63;
            this.label60.Text = "Gas Flow =";
            // 
            // label61
            // 
            this.label61.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(491, 116);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(170, 19);
            this.label61.TabIndex = 62;
            this.label61.Text = "CO2 - CO2 Concentration (%)";
            // 
            // label62
            // 
            this.label62.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(491, 96);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(156, 15);
            this.label62.TabIndex = 61;
            this.label62.Text = "GF - Gas Flow 100 / scfh";
            // 
            // textBox52
            // 
            this.textBox52.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox52.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox52.ForeColor = System.Drawing.Color.White;
            this.textBox52.Location = new System.Drawing.Point(23, 64);
            this.textBox52.Name = "textBox52";
            this.textBox52.ReadOnly = true;
            this.textBox52.Size = new System.Drawing.Size(419, 22);
            this.textBox52.TabIndex = 60;
            this.textBox52.Text = "E = GCV x GF / 1000000     Formula F-20/D-6";
            this.textBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabHTIPGasF1Calculate
            // 
            this.buttonTabHTIPGasF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPGasF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPGasF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabHTIPGasF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPGasF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPGasF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPGasF1Calculate.Location = new System.Drawing.Point(367, 178);
            this.buttonTabHTIPGasF1Calculate.Name = "buttonTabHTIPGasF1Calculate";
            this.buttonTabHTIPGasF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPGasF1Calculate.TabIndex = 114;
            this.buttonTabHTIPGasF1Calculate.Text = "Calculate";
            this.buttonTabHTIPGasF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabHTIPGasF1Calculate.Click += new System.EventHandler(this.buttonTabHTIPGasF1Calculate_Click);
            // 
            // textBoxTabHTIPGasF1Answer
            // 
            this.textBoxTabHTIPGasF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPGasF1Answer.Location = new System.Drawing.Point(342, 150);
            this.textBoxTabHTIPGasF1Answer.Name = "textBoxTabHTIPGasF1Answer";
            this.textBoxTabHTIPGasF1Answer.ReadOnly = true;
            this.textBoxTabHTIPGasF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPGasF1Answer.TabIndex = 57;
            this.textBoxTabHTIPGasF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPGasF1GasFlow
            // 
            this.textBoxTabHTIPGasF1GasFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPGasF1GasFlow.Location = new System.Drawing.Point(342, 122);
            this.textBoxTabHTIPGasF1GasFlow.Name = "textBoxTabHTIPGasF1GasFlow";
            this.textBoxTabHTIPGasF1GasFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPGasF1GasFlow.TabIndex = 113;
            this.textBoxTabHTIPGasF1GasFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPGasF1GCV
            // 
            this.textBoxTabHTIPGasF1GCV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPGasF1GCV.Location = new System.Drawing.Point(342, 94);
            this.textBoxTabHTIPGasF1GCV.Name = "textBoxTabHTIPGasF1GCV";
            this.textBoxTabHTIPGasF1GCV.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPGasF1GCV.TabIndex = 112;
            this.textBoxTabHTIPGasF1GCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label64
            // 
            this.label64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(260, 123);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(76, 18);
            this.label64.TabIndex = 54;
            this.label64.Text = "Gas Flow = ";
            // 
            // label65
            // 
            this.label65.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(286, 97);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(50, 19);
            this.label65.TabIndex = 53;
            this.label65.Text = "GCV = ";
            // 
            // label67
            // 
            this.label67.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(23, 116);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(146, 19);
            this.label67.TabIndex = 51;
            this.label67.Text = "GF - Gas Flow 100/scfh";
            // 
            // label68
            // 
            this.label68.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(23, 96);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(183, 20);
            this.label68.TabIndex = 50;
            this.label68.Text = "GCV - Gross Calorific Value GAS";
            // 
            // tabHeatInputOil
            // 
            this.tabHeatInputOil.BackColor = System.Drawing.Color.Ivory;
            this.tabHeatInputOil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHeatInputOil.Controls.Add(this.buttonTabHTIPOilF2Clear);
            this.tabHeatInputOil.Controls.Add(this.buttonTabHTIPOilF1Clear);
            this.tabHeatInputOil.Controls.Add(this.label43);
            this.tabHeatInputOil.Controls.Add(this.textBoxTabHTIPOilF2FuelFactor);
            this.tabHeatInputOil.Controls.Add(this.textBoxTabHTIPOilF2CO2Concentration);
            this.tabHeatInputOil.Controls.Add(this.label42);
            this.tabHeatInputOil.Controls.Add(this.label41);
            this.tabHeatInputOil.Controls.Add(this.textBox14);
            this.tabHeatInputOil.Controls.Add(this.textBox60);
            this.tabHeatInputOil.Controls.Add(this.buttonTabHTIPOilF2Calculate);
            this.tabHeatInputOil.Controls.Add(this.label74);
            this.tabHeatInputOil.Controls.Add(this.textBoxTabHTIPOilF2Answer);
            this.tabHeatInputOil.Controls.Add(this.textBoxTabHTIPOilF2MassOfOil);
            this.tabHeatInputOil.Controls.Add(this.label75);
            this.tabHeatInputOil.Controls.Add(this.label76);
            this.tabHeatInputOil.Controls.Add(this.label77);
            this.tabHeatInputOil.Controls.Add(this.textBox63);
            this.tabHeatInputOil.Controls.Add(this.buttonTabHTIPOilF1Calculate);
            this.tabHeatInputOil.Controls.Add(this.label78);
            this.tabHeatInputOil.Controls.Add(this.textBoxTabHTIPOilF1Answer);
            this.tabHeatInputOil.Controls.Add(this.textBoxTabHTIPOilF1MassOfOil);
            this.tabHeatInputOil.Controls.Add(this.textBoxTabHTIPOilF1GCV);
            this.tabHeatInputOil.Controls.Add(this.label79);
            this.tabHeatInputOil.Controls.Add(this.label80);
            this.tabHeatInputOil.Controls.Add(this.label82);
            this.tabHeatInputOil.Controls.Add(this.label195);
            this.tabHeatInputOil.Location = new System.Drawing.Point(4, 24);
            this.tabHeatInputOil.Name = "tabHeatInputOil";
            this.tabHeatInputOil.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeatInputOil.Size = new System.Drawing.Size(939, 514);
            this.tabHeatInputOil.TabIndex = 5;
            this.tabHeatInputOil.Text = "Heat Input - Oil";
            // 
            // buttonTabHTIPOilF2Clear
            // 
            this.buttonTabHTIPOilF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPOilF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPOilF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabHTIPOilF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPOilF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPOilF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPOilF2Clear.Location = new System.Drawing.Point(721, 202);
            this.buttonTabHTIPOilF2Clear.Name = "buttonTabHTIPOilF2Clear";
            this.buttonTabHTIPOilF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPOilF2Clear.TabIndex = 129;
            this.buttonTabHTIPOilF2Clear.Text = "Clear";
            this.buttonTabHTIPOilF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabHTIPOilF2Clear.Click += new System.EventHandler(this.buttonTabHTIPOilF2Clear_Click);
            // 
            // buttonTabHTIPOilF1Clear
            // 
            this.buttonTabHTIPOilF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPOilF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPOilF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabHTIPOilF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPOilF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPOilF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPOilF1Clear.Location = new System.Drawing.Point(254, 178);
            this.buttonTabHTIPOilF1Clear.Name = "buttonTabHTIPOilF1Clear";
            this.buttonTabHTIPOilF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPOilF1Clear.TabIndex = 124;
            this.buttonTabHTIPOilF1Clear.Text = "Clear";
            this.buttonTabHTIPOilF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabHTIPOilF1Clear.Click += new System.EventHandler(this.buttonTabHTIPOilF1Clear_Click);
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(721, 153);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(83, 18);
            this.label43.TabIndex = 84;
            this.label43.Text = "Fuel Factor = ";
            // 
            // textBoxTabHTIPOilF2FuelFactor
            // 
            this.textBoxTabHTIPOilF2FuelFactor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPOilF2FuelFactor.Location = new System.Drawing.Point(810, 148);
            this.textBoxTabHTIPOilF2FuelFactor.Name = "textBoxTabHTIPOilF2FuelFactor";
            this.textBoxTabHTIPOilF2FuelFactor.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPOilF2FuelFactor.TabIndex = 127;
            this.textBoxTabHTIPOilF2FuelFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPOilF2CO2Concentration
            // 
            this.textBoxTabHTIPOilF2CO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPOilF2CO2Concentration.Location = new System.Drawing.Point(810, 121);
            this.textBoxTabHTIPOilF2CO2Concentration.Name = "textBoxTabHTIPOilF2CO2Concentration";
            this.textBoxTabHTIPOilF2CO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPOilF2CO2Concentration.TabIndex = 126;
            this.textBoxTabHTIPOilF2CO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(680, 124);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(129, 18);
            this.label42.TabIndex = 81;
            this.label42.Text = "CO2 Concentration = ";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(491, 135);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(169, 19);
            this.label41.TabIndex = 80;
            this.label41.Text = "FF - Fuel Factor 1420 for OIL";
            // 
            // textBox14
            // 
            this.textBox14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox14.BackColor = System.Drawing.Color.Blue;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.White;
            this.textBox14.Location = new System.Drawing.Point(5, 6);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(927, 29);
            this.textBox14.TabIndex = 79;
            this.textBox14.Text = "Calculate Heat Input mm/Btu for OIL";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox60
            // 
            this.textBox60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox60.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox60.ForeColor = System.Drawing.Color.White;
            this.textBox60.Location = new System.Drawing.Point(491, 64);
            this.textBox60.Name = "textBox60";
            this.textBox60.ReadOnly = true;
            this.textBox60.Size = new System.Drawing.Size(419, 22);
            this.textBox60.TabIndex = 68;
            this.textBox60.Text = "E = (MO x CO2) / (FF x 100)     Formula F-15";
            this.textBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabHTIPOilF2Calculate
            // 
            this.buttonTabHTIPOilF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPOilF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPOilF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabHTIPOilF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPOilF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPOilF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPOilF2Calculate.Location = new System.Drawing.Point(835, 202);
            this.buttonTabHTIPOilF2Calculate.Name = "buttonTabHTIPOilF2Calculate";
            this.buttonTabHTIPOilF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPOilF2Calculate.TabIndex = 128;
            this.buttonTabHTIPOilF2Calculate.Text = "Calculate";
            this.buttonTabHTIPOilF2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabHTIPOilF2Calculate.Click += new System.EventHandler(this.buttonTabHTIPOilF2Calculate_Click);
            // 
            // label74
            // 
            this.label74.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(695, 178);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(109, 18);
            this.label74.TabIndex = 66;
            this.label74.Text = "HTIP mm/Btu = ";
            // 
            // textBoxTabHTIPOilF2Answer
            // 
            this.textBoxTabHTIPOilF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPOilF2Answer.Location = new System.Drawing.Point(810, 175);
            this.textBoxTabHTIPOilF2Answer.Name = "textBoxTabHTIPOilF2Answer";
            this.textBoxTabHTIPOilF2Answer.ReadOnly = true;
            this.textBoxTabHTIPOilF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPOilF2Answer.TabIndex = 65;
            this.textBoxTabHTIPOilF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPOilF2MassOfOil
            // 
            this.textBoxTabHTIPOilF2MassOfOil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPOilF2MassOfOil.Location = new System.Drawing.Point(810, 94);
            this.textBoxTabHTIPOilF2MassOfOil.Name = "textBoxTabHTIPOilF2MassOfOil";
            this.textBoxTabHTIPOilF2MassOfOil.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPOilF2MassOfOil.TabIndex = 125;
            this.textBoxTabHTIPOilF2MassOfOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label75
            // 
            this.label75.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(722, 95);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(83, 18);
            this.label75.TabIndex = 63;
            this.label75.Text = "Mass of Oil = ";
            // 
            // label76
            // 
            this.label76.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(491, 116);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(169, 19);
            this.label76.TabIndex = 62;
            this.label76.Text = "CO2 - CO2 Concentration (%)";
            // 
            // label77
            // 
            this.label77.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(491, 96);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(156, 15);
            this.label77.TabIndex = 61;
            this.label77.Text = "MO - Mass of Oil lbs/hr";
            // 
            // textBox63
            // 
            this.textBox63.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox63.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox63.ForeColor = System.Drawing.Color.White;
            this.textBox63.Location = new System.Drawing.Point(23, 64);
            this.textBox63.Name = "textBox63";
            this.textBox63.ReadOnly = true;
            this.textBox63.Size = new System.Drawing.Size(419, 22);
            this.textBox63.TabIndex = 60;
            this.textBox63.Text = "E = GCV x MO / 1000000     Formula F-19/D-8";
            this.textBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabHTIPOilF1Calculate
            // 
            this.buttonTabHTIPOilF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPOilF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPOilF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabHTIPOilF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPOilF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPOilF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPOilF1Calculate.Location = new System.Drawing.Point(367, 178);
            this.buttonTabHTIPOilF1Calculate.Name = "buttonTabHTIPOilF1Calculate";
            this.buttonTabHTIPOilF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPOilF1Calculate.TabIndex = 123;
            this.buttonTabHTIPOilF1Calculate.Text = "Calculate";
            this.buttonTabHTIPOilF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabHTIPOilF1Calculate.Click += new System.EventHandler(this.buttonTabHTIPOilF1Calculate_Click);
            // 
            // label78
            // 
            this.label78.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(229, 153);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(107, 20);
            this.label78.TabIndex = 58;
            this.label78.Text = "HTIP mm/Btu = ";
            // 
            // textBoxTabHTIPOilF1Answer
            // 
            this.textBoxTabHTIPOilF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPOilF1Answer.Location = new System.Drawing.Point(342, 150);
            this.textBoxTabHTIPOilF1Answer.Name = "textBoxTabHTIPOilF1Answer";
            this.textBoxTabHTIPOilF1Answer.ReadOnly = true;
            this.textBoxTabHTIPOilF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPOilF1Answer.TabIndex = 57;
            this.textBoxTabHTIPOilF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPOilF1MassOfOil
            // 
            this.textBoxTabHTIPOilF1MassOfOil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPOilF1MassOfOil.Location = new System.Drawing.Point(342, 122);
            this.textBoxTabHTIPOilF1MassOfOil.Name = "textBoxTabHTIPOilF1MassOfOil";
            this.textBoxTabHTIPOilF1MassOfOil.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPOilF1MassOfOil.TabIndex = 122;
            this.textBoxTabHTIPOilF1MassOfOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPOilF1GCV
            // 
            this.textBoxTabHTIPOilF1GCV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPOilF1GCV.Location = new System.Drawing.Point(342, 94);
            this.textBoxTabHTIPOilF1GCV.Name = "textBoxTabHTIPOilF1GCV";
            this.textBoxTabHTIPOilF1GCV.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPOilF1GCV.TabIndex = 121;
            this.textBoxTabHTIPOilF1GCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label79
            // 
            this.label79.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(250, 123);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(83, 18);
            this.label79.TabIndex = 54;
            this.label79.Text = "Mass of OIL = ";
            // 
            // label80
            // 
            this.label80.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(290, 95);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(49, 19);
            this.label80.TabIndex = 53;
            this.label80.Text = "GCV = ";
            // 
            // label82
            // 
            this.label82.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(23, 116);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(146, 19);
            this.label82.TabIndex = 51;
            this.label82.Text = "MO - Mass of Oil lbs/hr";
            // 
            // label195
            // 
            this.label195.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label195.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label195.Location = new System.Drawing.Point(23, 96);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(178, 20);
            this.label195.TabIndex = 50;
            this.label195.Text = "GCV - Gross Calorific Value OIL";
            // 
            // tabHeatInputFlow
            // 
            this.tabHeatInputFlow.BackColor = System.Drawing.Color.Ivory;
            this.tabHeatInputFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHeatInputFlow.Controls.Add(this.buttonTabHTIPFlowF1Clear);
            this.tabHeatInputFlow.Controls.Add(this.label44);
            this.tabHeatInputFlow.Controls.Add(this.textBoxTabHTIPFlowF1FuelFactor);
            this.tabHeatInputFlow.Controls.Add(this.textBox15);
            this.tabHeatInputFlow.Controls.Add(this.textBox74);
            this.tabHeatInputFlow.Controls.Add(this.buttonTabHTIPFlowF1Calculate);
            this.tabHeatInputFlow.Controls.Add(this.label92);
            this.tabHeatInputFlow.Controls.Add(this.textBoxTabHTIPFlowF1Answer);
            this.tabHeatInputFlow.Controls.Add(this.textBoxTabHTIPFlowF1CO2Concentration);
            this.tabHeatInputFlow.Controls.Add(this.textBoxTabHTIPFlowF1Flow);
            this.tabHeatInputFlow.Controls.Add(this.label93);
            this.tabHeatInputFlow.Controls.Add(this.label94);
            this.tabHeatInputFlow.Controls.Add(this.label95);
            this.tabHeatInputFlow.Controls.Add(this.label96);
            this.tabHeatInputFlow.Controls.Add(this.label196);
            this.tabHeatInputFlow.Location = new System.Drawing.Point(4, 24);
            this.tabHeatInputFlow.Name = "tabHeatInputFlow";
            this.tabHeatInputFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeatInputFlow.Size = new System.Drawing.Size(939, 514);
            this.tabHeatInputFlow.TabIndex = 6;
            this.tabHeatInputFlow.Text = "Heat Input - Flow";
            // 
            // buttonTabHTIPFlowF1Clear
            // 
            this.buttonTabHTIPFlowF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPFlowF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPFlowF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabHTIPFlowF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPFlowF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPFlowF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPFlowF1Clear.Location = new System.Drawing.Point(256, 203);
            this.buttonTabHTIPFlowF1Clear.Name = "buttonTabHTIPFlowF1Clear";
            this.buttonTabHTIPFlowF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPFlowF1Clear.TabIndex = 134;
            this.buttonTabHTIPFlowF1Clear.Text = "Clear";
            this.buttonTabHTIPFlowF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabHTIPFlowF1Clear.Click += new System.EventHandler(this.buttonTabHTIPFlowF1Clear_Click);
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(256, 149);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(82, 18);
            this.label44.TabIndex = 81;
            this.label44.Text = "Fuel Factor = ";
            // 
            // textBoxTabHTIPFlowF1FuelFactor
            // 
            this.textBoxTabHTIPFlowF1FuelFactor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPFlowF1FuelFactor.Location = new System.Drawing.Point(342, 149);
            this.textBoxTabHTIPFlowF1FuelFactor.Name = "textBoxTabHTIPFlowF1FuelFactor";
            this.textBoxTabHTIPFlowF1FuelFactor.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPFlowF1FuelFactor.TabIndex = 132;
            this.textBoxTabHTIPFlowF1FuelFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox15
            // 
            this.textBox15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox15.BackColor = System.Drawing.Color.Blue;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.ForeColor = System.Drawing.Color.White;
            this.textBox15.Location = new System.Drawing.Point(5, 6);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(927, 29);
            this.textBox15.TabIndex = 79;
            this.textBox15.Text = "Calculate Heat Input mm/Btu for FLOW";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox74
            // 
            this.textBox74.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox74.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox74.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox74.ForeColor = System.Drawing.Color.White;
            this.textBox74.Location = new System.Drawing.Point(23, 64);
            this.textBox74.Name = "textBox74";
            this.textBox74.ReadOnly = true;
            this.textBox74.Size = new System.Drawing.Size(419, 22);
            this.textBox74.TabIndex = 60;
            this.textBox74.Text = "E = FLO x (1 / FF) x (CO2 / 100)     Formula F-15";
            this.textBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabHTIPFlowF1Calculate
            // 
            this.buttonTabHTIPFlowF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHTIPFlowF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHTIPFlowF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabHTIPFlowF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHTIPFlowF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHTIPFlowF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabHTIPFlowF1Calculate.Location = new System.Drawing.Point(367, 203);
            this.buttonTabHTIPFlowF1Calculate.Name = "buttonTabHTIPFlowF1Calculate";
            this.buttonTabHTIPFlowF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHTIPFlowF1Calculate.TabIndex = 133;
            this.buttonTabHTIPFlowF1Calculate.Text = "Calculate";
            this.buttonTabHTIPFlowF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabHTIPFlowF1Calculate.Click += new System.EventHandler(this.buttonTabHTIPFlowF1Calculate_Click);
            // 
            // label92
            // 
            this.label92.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(231, 179);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(105, 20);
            this.label92.TabIndex = 58;
            this.label92.Text = "HTIP mm/Btu = ";
            // 
            // textBoxTabHTIPFlowF1Answer
            // 
            this.textBoxTabHTIPFlowF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPFlowF1Answer.Location = new System.Drawing.Point(342, 176);
            this.textBoxTabHTIPFlowF1Answer.Name = "textBoxTabHTIPFlowF1Answer";
            this.textBoxTabHTIPFlowF1Answer.ReadOnly = true;
            this.textBoxTabHTIPFlowF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPFlowF1Answer.TabIndex = 57;
            this.textBoxTabHTIPFlowF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPFlowF1CO2Concentration
            // 
            this.textBoxTabHTIPFlowF1CO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPFlowF1CO2Concentration.Location = new System.Drawing.Point(342, 122);
            this.textBoxTabHTIPFlowF1CO2Concentration.Name = "textBoxTabHTIPFlowF1CO2Concentration";
            this.textBoxTabHTIPFlowF1CO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPFlowF1CO2Concentration.TabIndex = 131;
            this.textBoxTabHTIPFlowF1CO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHTIPFlowF1Flow
            // 
            this.textBoxTabHTIPFlowF1Flow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHTIPFlowF1Flow.Location = new System.Drawing.Point(342, 94);
            this.textBoxTabHTIPFlowF1Flow.Name = "textBoxTabHTIPFlowF1Flow";
            this.textBoxTabHTIPFlowF1Flow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHTIPFlowF1Flow.TabIndex = 130;
            this.textBoxTabHTIPFlowF1Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label93
            // 
            this.label93.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(214, 122);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(123, 18);
            this.label93.TabIndex = 54;
            this.label93.Text = "CO2 Concentration = ";
            // 
            // label94
            // 
            this.label94.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(291, 94);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(45, 19);
            this.label94.TabIndex = 53;
            this.label94.Text = "Flow = ";
            // 
            // label95
            // 
            this.label95.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(23, 135);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(173, 17);
            this.label95.TabIndex = 52;
            this.label95.Text = "FF - Fuel Factor 1420 for OIL";
            // 
            // label96
            // 
            this.label96.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(23, 116);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(173, 19);
            this.label96.TabIndex = 51;
            this.label96.Text = "CO2- CO2 Concentration (%)";
            // 
            // label196
            // 
            this.label196.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label196.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label196.Location = new System.Drawing.Point(23, 96);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(173, 20);
            this.label196.TabIndex = 50;
            this.label196.Text = "FLO - Volumetric Flow (scfh)";
            // 
            // tabSO2Gas
            // 
            this.tabSO2Gas.BackColor = System.Drawing.Color.Ivory;
            this.tabSO2Gas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSO2Gas.Controls.Add(this.buttonTabSO2GasF2Clear);
            this.tabSO2Gas.Controls.Add(this.buttonTabSO2GasF1Clear);
            this.tabSO2Gas.Controls.Add(this.label46);
            this.tabSO2Gas.Controls.Add(this.textBoxTabSO2GasF2GasFlow);
            this.tabSO2Gas.Controls.Add(this.textBox16);
            this.tabSO2Gas.Controls.Add(this.textBox82);
            this.tabSO2Gas.Controls.Add(this.buttonTabSO2GasF2Calculate);
            this.tabSO2Gas.Controls.Add(this.label102);
            this.tabSO2Gas.Controls.Add(this.textBoxTabSO2GasF2Answer);
            this.tabSO2Gas.Controls.Add(this.textBoxTabSO2GasF2SO2Concentration);
            this.tabSO2Gas.Controls.Add(this.label103);
            this.tabSO2Gas.Controls.Add(this.label104);
            this.tabSO2Gas.Controls.Add(this.label105);
            this.tabSO2Gas.Controls.Add(this.textBox85);
            this.tabSO2Gas.Controls.Add(this.buttonTabSO2GasF1Calculate);
            this.tabSO2Gas.Controls.Add(this.label106);
            this.tabSO2Gas.Controls.Add(this.textBoxTabSO2GasF1Answer);
            this.tabSO2Gas.Controls.Add(this.textBoxTabSO2GasF1HTIP);
            this.tabSO2Gas.Controls.Add(this.label108);
            this.tabSO2Gas.Controls.Add(this.label197);
            this.tabSO2Gas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSO2Gas.Location = new System.Drawing.Point(4, 24);
            this.tabSO2Gas.Name = "tabSO2Gas";
            this.tabSO2Gas.Padding = new System.Windows.Forms.Padding(3);
            this.tabSO2Gas.Size = new System.Drawing.Size(939, 514);
            this.tabSO2Gas.TabIndex = 7;
            this.tabSO2Gas.Text = "SO2 - Gas";
            // 
            // buttonTabSO2GasF2Clear
            // 
            this.buttonTabSO2GasF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2GasF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2GasF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabSO2GasF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2GasF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2GasF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2GasF2Clear.Location = new System.Drawing.Point(722, 178);
            this.buttonTabSO2GasF2Clear.Name = "buttonTabSO2GasF2Clear";
            this.buttonTabSO2GasF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2GasF2Clear.TabIndex = 141;
            this.buttonTabSO2GasF2Clear.Text = "Clear";
            this.buttonTabSO2GasF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabSO2GasF2Clear.Click += new System.EventHandler(this.buttonTabSO2GasF2Clear_Click);
            // 
            // buttonTabSO2GasF1Clear
            // 
            this.buttonTabSO2GasF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2GasF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2GasF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabSO2GasF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2GasF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2GasF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2GasF1Clear.Location = new System.Drawing.Point(258, 150);
            this.buttonTabSO2GasF1Clear.Name = "buttonTabSO2GasF1Clear";
            this.buttonTabSO2GasF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2GasF1Clear.TabIndex = 137;
            this.buttonTabSO2GasF1Clear.Text = "Clear";
            this.buttonTabSO2GasF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabSO2GasF1Clear.Click += new System.EventHandler(this.buttonTabSO2GasF1Clear_Click);
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(722, 125);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(85, 18);
            this.label46.TabIndex = 82;
            this.label46.Text = "Stack Flow = ";
            // 
            // textBoxTabSO2GasF2GasFlow
            // 
            this.textBoxTabSO2GasF2GasFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2GasF2GasFlow.Location = new System.Drawing.Point(810, 122);
            this.textBoxTabSO2GasF2GasFlow.Name = "textBoxTabSO2GasF2GasFlow";
            this.textBoxTabSO2GasF2GasFlow.Size = new System.Drawing.Size(100, 22);
            this.textBoxTabSO2GasF2GasFlow.TabIndex = 139;
            this.textBoxTabSO2GasF2GasFlow.TabStop = false;
            this.textBoxTabSO2GasF2GasFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox16
            // 
            this.textBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox16.BackColor = System.Drawing.Color.Blue;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.White;
            this.textBox16.Location = new System.Drawing.Point(5, 6);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(927, 29);
            this.textBox16.TabIndex = 79;
            this.textBox16.Text = "Calculate SO2 Mass Emissions for GAS";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox82
            // 
            this.textBox82.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox82.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox82.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox82.ForeColor = System.Drawing.Color.White;
            this.textBox82.Location = new System.Drawing.Point(491, 64);
            this.textBox82.Name = "textBox82";
            this.textBox82.ReadOnly = true;
            this.textBox82.Size = new System.Drawing.Size(419, 22);
            this.textBox82.TabIndex = 68;
            this.textBox82.Text = "E = 0.000000166 x SO2 x GF            Formula F-1";
            this.textBox82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabSO2GasF2Calculate
            // 
            this.buttonTabSO2GasF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2GasF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2GasF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabSO2GasF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2GasF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2GasF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2GasF2Calculate.Location = new System.Drawing.Point(835, 178);
            this.buttonTabSO2GasF2Calculate.Name = "buttonTabSO2GasF2Calculate";
            this.buttonTabSO2GasF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2GasF2Calculate.TabIndex = 140;
            this.buttonTabSO2GasF2Calculate.Text = "Calculate";
            this.buttonTabSO2GasF2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabSO2GasF2Calculate.Click += new System.EventHandler(this.buttonTabSO2GasF2Calculate_Click);
            // 
            // label102
            // 
            this.label102.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(647, 152);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(158, 18);
            this.label102.TabIndex = 66;
            this.label102.Text = "Mass Em. SO2 lbs/hr = ";
            // 
            // textBoxTabSO2GasF2Answer
            // 
            this.textBoxTabSO2GasF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2GasF2Answer.Location = new System.Drawing.Point(810, 150);
            this.textBoxTabSO2GasF2Answer.Name = "textBoxTabSO2GasF2Answer";
            this.textBoxTabSO2GasF2Answer.ReadOnly = true;
            this.textBoxTabSO2GasF2Answer.Size = new System.Drawing.Size(100, 22);
            this.textBoxTabSO2GasF2Answer.TabIndex = 65;
            this.textBoxTabSO2GasF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabSO2GasF2SO2Concentration
            // 
            this.textBoxTabSO2GasF2SO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2GasF2SO2Concentration.Location = new System.Drawing.Point(810, 94);
            this.textBoxTabSO2GasF2SO2Concentration.Name = "textBoxTabSO2GasF2SO2Concentration";
            this.textBoxTabSO2GasF2SO2Concentration.Size = new System.Drawing.Size(100, 22);
            this.textBoxTabSO2GasF2SO2Concentration.TabIndex = 138;
            this.textBoxTabSO2GasF2SO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label103
            // 
            this.label103.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(680, 95);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(127, 18);
            this.label103.TabIndex = 63;
            this.label103.Text = "SO2 Concentration = ";
            // 
            // label104
            // 
            this.label104.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label104.Location = new System.Drawing.Point(491, 116);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(138, 19);
            this.label104.TabIndex = 62;
            this.label104.Text = "GF - Gas Flow";
            // 
            // label105
            // 
            this.label105.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label105.Location = new System.Drawing.Point(491, 96);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(183, 15);
            this.label105.TabIndex = 61;
            this.label105.Text = "SO2 - SO2 Concentration (ppm)";
            // 
            // textBox85
            // 
            this.textBox85.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox85.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox85.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox85.ForeColor = System.Drawing.Color.White;
            this.textBox85.Location = new System.Drawing.Point(23, 64);
            this.textBox85.Name = "textBox85";
            this.textBox85.ReadOnly = true;
            this.textBox85.Size = new System.Drawing.Size(419, 22);
            this.textBox85.TabIndex = 60;
            this.textBox85.Text = "E = 0.0006 x HTIP             Formula D-5";
            this.textBox85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabSO2GasF1Calculate
            // 
            this.buttonTabSO2GasF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2GasF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2GasF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabSO2GasF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2GasF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2GasF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2GasF1Calculate.Location = new System.Drawing.Point(367, 150);
            this.buttonTabSO2GasF1Calculate.Name = "buttonTabSO2GasF1Calculate";
            this.buttonTabSO2GasF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2GasF1Calculate.TabIndex = 136;
            this.buttonTabSO2GasF1Calculate.Text = "Calculate";
            this.buttonTabSO2GasF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabSO2GasF1Calculate.Click += new System.EventHandler(this.buttonTabSO2GasF1Calculate_Click);
            // 
            // label106
            // 
            this.label106.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.Location = new System.Drawing.Point(181, 124);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(155, 20);
            this.label106.TabIndex = 58;
            this.label106.Text = "Mass Em. SO2 lbs/hr = ";
            // 
            // textBoxTabSO2GasF1Answer
            // 
            this.textBoxTabSO2GasF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2GasF1Answer.Location = new System.Drawing.Point(342, 122);
            this.textBoxTabSO2GasF1Answer.Name = "textBoxTabSO2GasF1Answer";
            this.textBoxTabSO2GasF1Answer.ReadOnly = true;
            this.textBoxTabSO2GasF1Answer.Size = new System.Drawing.Size(100, 22);
            this.textBoxTabSO2GasF1Answer.TabIndex = 57;
            this.textBoxTabSO2GasF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabSO2GasF1HTIP
            // 
            this.textBoxTabSO2GasF1HTIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2GasF1HTIP.Location = new System.Drawing.Point(342, 94);
            this.textBoxTabSO2GasF1HTIP.Name = "textBoxTabSO2GasF1HTIP";
            this.textBoxTabSO2GasF1HTIP.Size = new System.Drawing.Size(100, 22);
            this.textBoxTabSO2GasF1HTIP.TabIndex = 135;
            this.textBoxTabSO2GasF1HTIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label108
            // 
            this.label108.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.Location = new System.Drawing.Point(290, 95);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(49, 19);
            this.label108.TabIndex = 53;
            this.label108.Text = "HTIP = ";
            // 
            // label197
            // 
            this.label197.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label197.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label197.Location = new System.Drawing.Point(23, 96);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(173, 20);
            this.label197.TabIndex = 50;
            this.label197.Text = "HTIP - Heat Input Gas mm/Btu";
            // 
            // tabSO2Oil
            // 
            this.tabSO2Oil.BackColor = System.Drawing.Color.Ivory;
            this.tabSO2Oil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSO2Oil.Controls.Add(this.buttonTabSO2OilF3Clear);
            this.tabSO2Oil.Controls.Add(this.buttonTabSO2OilF2Clear);
            this.tabSO2Oil.Controls.Add(this.buttonTabSO2OilF1Clear);
            this.tabSO2Oil.Controls.Add(this.textBoxTabSO2OilF2SulfurContent);
            this.tabSO2Oil.Controls.Add(this.label45);
            this.tabSO2Oil.Controls.Add(this.textBox17);
            this.tabSO2Oil.Controls.Add(this.textBox89);
            this.tabSO2Oil.Controls.Add(this.buttonTabSO2OilF3Calculate);
            this.tabSO2Oil.Controls.Add(this.label111);
            this.tabSO2Oil.Controls.Add(this.textBoxTabSO2OilF3Answer);
            this.tabSO2Oil.Controls.Add(this.textBoxTabSO2OilF3MassOfOil);
            this.tabSO2Oil.Controls.Add(this.textBoxTabSO2OilF3SO2Concentration);
            this.tabSO2Oil.Controls.Add(this.label112);
            this.tabSO2Oil.Controls.Add(this.label113);
            this.tabSO2Oil.Controls.Add(this.label114);
            this.tabSO2Oil.Controls.Add(this.label115);
            this.tabSO2Oil.Controls.Add(this.textBox93);
            this.tabSO2Oil.Controls.Add(this.buttonTabSO2OilF2Calculate);
            this.tabSO2Oil.Controls.Add(this.label116);
            this.tabSO2Oil.Controls.Add(this.textBoxTabSO2OilF2Answer);
            this.tabSO2Oil.Controls.Add(this.textBoxTabSO2OilF2MassOfOil);
            this.tabSO2Oil.Controls.Add(this.label117);
            this.tabSO2Oil.Controls.Add(this.label118);
            this.tabSO2Oil.Controls.Add(this.label119);
            this.tabSO2Oil.Controls.Add(this.textBox96);
            this.tabSO2Oil.Controls.Add(this.buttonTabSO2OilF1Calculate);
            this.tabSO2Oil.Controls.Add(this.label120);
            this.tabSO2Oil.Controls.Add(this.textBoxTabSO2OilF1Answer);
            this.tabSO2Oil.Controls.Add(this.textBoxTabSO2OilF1SulfurContent);
            this.tabSO2Oil.Controls.Add(this.textBoxTabSO2OilF1MassOfOil);
            this.tabSO2Oil.Controls.Add(this.label121);
            this.tabSO2Oil.Controls.Add(this.label122);
            this.tabSO2Oil.Controls.Add(this.label124);
            this.tabSO2Oil.Controls.Add(this.label198);
            this.tabSO2Oil.Location = new System.Drawing.Point(4, 24);
            this.tabSO2Oil.Name = "tabSO2Oil";
            this.tabSO2Oil.Padding = new System.Windows.Forms.Padding(3);
            this.tabSO2Oil.Size = new System.Drawing.Size(939, 514);
            this.tabSO2Oil.TabIndex = 8;
            this.tabSO2Oil.Text = "SO2 - Oil";
            // 
            // buttonTabSO2OilF3Clear
            // 
            this.buttonTabSO2OilF3Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2OilF3Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2OilF3Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabSO2OilF3Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2OilF3Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2OilF3Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2OilF3Clear.Location = new System.Drawing.Point(256, 349);
            this.buttonTabSO2OilF3Clear.Name = "buttonTabSO2OilF3Clear";
            this.buttonTabSO2OilF3Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2OilF3Clear.TabIndex = 153;
            this.buttonTabSO2OilF3Clear.Text = "Clear";
            this.buttonTabSO2OilF3Clear.UseVisualStyleBackColor = false;
            this.buttonTabSO2OilF3Clear.Click += new System.EventHandler(this.buttonTabSO2OilF3Clear_Click);
            // 
            // buttonTabSO2OilF2Clear
            // 
            this.buttonTabSO2OilF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2OilF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2OilF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabSO2OilF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2OilF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2OilF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2OilF2Clear.Location = new System.Drawing.Point(727, 178);
            this.buttonTabSO2OilF2Clear.Name = "buttonTabSO2OilF2Clear";
            this.buttonTabSO2OilF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2OilF2Clear.TabIndex = 149;
            this.buttonTabSO2OilF2Clear.Text = "Clear";
            this.buttonTabSO2OilF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabSO2OilF2Clear.Click += new System.EventHandler(this.buttonTabSO2OilF2Clear_Click);
            // 
            // buttonTabSO2OilF1Clear
            // 
            this.buttonTabSO2OilF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2OilF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2OilF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabSO2OilF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2OilF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2OilF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2OilF1Clear.Location = new System.Drawing.Point(255, 178);
            this.buttonTabSO2OilF1Clear.Name = "buttonTabSO2OilF1Clear";
            this.buttonTabSO2OilF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2OilF1Clear.TabIndex = 145;
            this.buttonTabSO2OilF1Clear.Text = "Clear";
            this.buttonTabSO2OilF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabSO2OilF1Clear.Click += new System.EventHandler(this.buttonTabSO2OilF1Clear_Click);
            // 
            // textBoxTabSO2OilF2SulfurContent
            // 
            this.textBoxTabSO2OilF2SulfurContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2OilF2SulfurContent.Location = new System.Drawing.Point(811, 121);
            this.textBoxTabSO2OilF2SulfurContent.Name = "textBoxTabSO2OilF2SulfurContent";
            this.textBoxTabSO2OilF2SulfurContent.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2OilF2SulfurContent.TabIndex = 147;
            this.textBoxTabSO2OilF2SulfurContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(680, 124);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(125, 18);
            this.label45.TabIndex = 80;
            this.label45.Text = "Sulfur Content of Oil = ";
            // 
            // textBox17
            // 
            this.textBox17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox17.BackColor = System.Drawing.Color.Blue;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.ForeColor = System.Drawing.Color.White;
            this.textBox17.Location = new System.Drawing.Point(5, 6);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(927, 29);
            this.textBox17.TabIndex = 79;
            this.textBox17.Text = "Calculate SO2 Mass Emissions for OIL";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox89
            // 
            this.textBox89.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox89.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox89.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox89.ForeColor = System.Drawing.Color.White;
            this.textBox89.Location = new System.Drawing.Point(23, 235);
            this.textBox89.Name = "textBox89";
            this.textBox89.ReadOnly = true;
            this.textBox89.Size = new System.Drawing.Size(419, 22);
            this.textBox89.TabIndex = 78;
            this.textBox89.Text = "E = 0.000000166 x SO2 x MO            Formula F-1";
            this.textBox89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabSO2OilF3Calculate
            // 
            this.buttonTabSO2OilF3Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2OilF3Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2OilF3Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabSO2OilF3Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2OilF3Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2OilF3Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2OilF3Calculate.Location = new System.Drawing.Point(367, 349);
            this.buttonTabSO2OilF3Calculate.Name = "buttonTabSO2OilF3Calculate";
            this.buttonTabSO2OilF3Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2OilF3Calculate.TabIndex = 152;
            this.buttonTabSO2OilF3Calculate.Text = "Calculate";
            this.buttonTabSO2OilF3Calculate.UseVisualStyleBackColor = false;
            this.buttonTabSO2OilF3Calculate.Click += new System.EventHandler(this.buttonTabSO2OilF3Calculate_Click);
            // 
            // label111
            // 
            this.label111.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(181, 324);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(156, 18);
            this.label111.TabIndex = 76;
            this.label111.Text = "Mass Em. SO2 lbs/hr = ";
            // 
            // textBoxTabSO2OilF3Answer
            // 
            this.textBoxTabSO2OilF3Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2OilF3Answer.Location = new System.Drawing.Point(342, 321);
            this.textBoxTabSO2OilF3Answer.Name = "textBoxTabSO2OilF3Answer";
            this.textBoxTabSO2OilF3Answer.ReadOnly = true;
            this.textBoxTabSO2OilF3Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2OilF3Answer.TabIndex = 75;
            this.textBoxTabSO2OilF3Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabSO2OilF3MassOfOil
            // 
            this.textBoxTabSO2OilF3MassOfOil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2OilF3MassOfOil.Location = new System.Drawing.Point(342, 293);
            this.textBoxTabSO2OilF3MassOfOil.Name = "textBoxTabSO2OilF3MassOfOil";
            this.textBoxTabSO2OilF3MassOfOil.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2OilF3MassOfOil.TabIndex = 151;
            this.textBoxTabSO2OilF3MassOfOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabSO2OilF3SO2Concentration
            // 
            this.textBoxTabSO2OilF3SO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2OilF3SO2Concentration.Location = new System.Drawing.Point(342, 265);
            this.textBoxTabSO2OilF3SO2Concentration.Name = "textBoxTabSO2OilF3SO2Concentration";
            this.textBoxTabSO2OilF3SO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2OilF3SO2Concentration.TabIndex = 150;
            this.textBoxTabSO2OilF3SO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label112
            // 
            this.label112.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.Location = new System.Drawing.Point(255, 295);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(82, 14);
            this.label112.TabIndex = 72;
            this.label112.Text = "Mass of Oil = ";
            // 
            // label113
            // 
            this.label113.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.Location = new System.Drawing.Point(214, 268);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(127, 19);
            this.label113.TabIndex = 71;
            this.label113.Text = "SO2 Concentration =  ";
            // 
            // label114
            // 
            this.label114.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label114.Location = new System.Drawing.Point(21, 288);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(101, 16);
            this.label114.TabIndex = 70;
            this.label114.Text = "MO - Mass of Oil";
            // 
            // label115
            // 
            this.label115.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label115.Location = new System.Drawing.Point(23, 267);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(189, 16);
            this.label115.TabIndex = 69;
            this.label115.Text = "SO2 - SO2 Concentration (ppm)";
            // 
            // textBox93
            // 
            this.textBox93.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox93.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox93.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox93.ForeColor = System.Drawing.Color.White;
            this.textBox93.Location = new System.Drawing.Point(491, 64);
            this.textBox93.Name = "textBox93";
            this.textBox93.ReadOnly = true;
            this.textBox93.Size = new System.Drawing.Size(419, 22);
            this.textBox93.TabIndex = 68;
            this.textBox93.Text = "E = 2.0 x MO * SC / 100.0                           Formula D-1";
            this.textBox93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabSO2OilF2Calculate
            // 
            this.buttonTabSO2OilF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2OilF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2OilF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabSO2OilF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2OilF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2OilF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2OilF2Calculate.Location = new System.Drawing.Point(835, 178);
            this.buttonTabSO2OilF2Calculate.Name = "buttonTabSO2OilF2Calculate";
            this.buttonTabSO2OilF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2OilF2Calculate.TabIndex = 148;
            this.buttonTabSO2OilF2Calculate.Text = "Calculate";
            this.buttonTabSO2OilF2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabSO2OilF2Calculate.Click += new System.EventHandler(this.buttonTabSO2OilF2Calculate_Click);
            // 
            // label116
            // 
            this.label116.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label116.Location = new System.Drawing.Point(643, 152);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(164, 18);
            this.label116.TabIndex = 66;
            this.label116.Text = "  Mass Em. SO2 lbs/hr = ";
            // 
            // textBoxTabSO2OilF2Answer
            // 
            this.textBoxTabSO2OilF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2OilF2Answer.Location = new System.Drawing.Point(810, 150);
            this.textBoxTabSO2OilF2Answer.Name = "textBoxTabSO2OilF2Answer";
            this.textBoxTabSO2OilF2Answer.ReadOnly = true;
            this.textBoxTabSO2OilF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2OilF2Answer.TabIndex = 65;
            this.textBoxTabSO2OilF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabSO2OilF2MassOfOil
            // 
            this.textBoxTabSO2OilF2MassOfOil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2OilF2MassOfOil.Location = new System.Drawing.Point(810, 94);
            this.textBoxTabSO2OilF2MassOfOil.Name = "textBoxTabSO2OilF2MassOfOil";
            this.textBoxTabSO2OilF2MassOfOil.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2OilF2MassOfOil.TabIndex = 146;
            this.textBoxTabSO2OilF2MassOfOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label117
            // 
            this.label117.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label117.Location = new System.Drawing.Point(727, 95);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(80, 18);
            this.label117.TabIndex = 63;
            this.label117.Text = "Mass of Oil = ";
            // 
            // label118
            // 
            this.label118.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label118.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label118.Location = new System.Drawing.Point(491, 116);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(156, 19);
            this.label118.TabIndex = 62;
            this.label118.Text = "SC - Sulfur Content Oil %";
            // 
            // label119
            // 
            this.label119.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label119.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label119.Location = new System.Drawing.Point(491, 96);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(156, 15);
            this.label119.TabIndex = 61;
            this.label119.Text = "MO - Mass Oil in lbs/hr";
            // 
            // textBox96
            // 
            this.textBox96.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox96.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox96.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox96.ForeColor = System.Drawing.Color.White;
            this.textBox96.Location = new System.Drawing.Point(23, 64);
            this.textBox96.Name = "textBox96";
            this.textBox96.ReadOnly = true;
            this.textBox96.Size = new System.Drawing.Size(419, 22);
            this.textBox96.TabIndex = 60;
            this.textBox96.Text = "E = 2.0 x MO * SC / 100.0                           Formula D-2";
            this.textBox96.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabSO2OilF1Calculate
            // 
            this.buttonTabSO2OilF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2OilF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2OilF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabSO2OilF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2OilF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2OilF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2OilF1Calculate.Location = new System.Drawing.Point(367, 178);
            this.buttonTabSO2OilF1Calculate.Name = "buttonTabSO2OilF1Calculate";
            this.buttonTabSO2OilF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2OilF1Calculate.TabIndex = 144;
            this.buttonTabSO2OilF1Calculate.Text = "Calculate";
            this.buttonTabSO2OilF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabSO2OilF1Calculate.Click += new System.EventHandler(this.buttonTabSO2OilF1Calculate_Click);
            // 
            // label120
            // 
            this.label120.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label120.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label120.Location = new System.Drawing.Point(171, 152);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(165, 20);
            this.label120.TabIndex = 58;
            this.label120.Text = "  Mass Em. SO2 lbs/hr = ";
            // 
            // textBoxTabSO2OilF1Answer
            // 
            this.textBoxTabSO2OilF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2OilF1Answer.Location = new System.Drawing.Point(342, 150);
            this.textBoxTabSO2OilF1Answer.Name = "textBoxTabSO2OilF1Answer";
            this.textBoxTabSO2OilF1Answer.ReadOnly = true;
            this.textBoxTabSO2OilF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2OilF1Answer.TabIndex = 57;
            this.textBoxTabSO2OilF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabSO2OilF1SulfurContent
            // 
            this.textBoxTabSO2OilF1SulfurContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2OilF1SulfurContent.Location = new System.Drawing.Point(342, 122);
            this.textBoxTabSO2OilF1SulfurContent.Name = "textBoxTabSO2OilF1SulfurContent";
            this.textBoxTabSO2OilF1SulfurContent.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2OilF1SulfurContent.TabIndex = 143;
            this.textBoxTabSO2OilF1SulfurContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabSO2OilF1MassOfOil
            // 
            this.textBoxTabSO2OilF1MassOfOil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2OilF1MassOfOil.Location = new System.Drawing.Point(342, 94);
            this.textBoxTabSO2OilF1MassOfOil.Name = "textBoxTabSO2OilF1MassOfOil";
            this.textBoxTabSO2OilF1MassOfOil.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2OilF1MassOfOil.TabIndex = 142;
            this.textBoxTabSO2OilF1MassOfOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label121
            // 
            this.label121.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label121.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label121.Location = new System.Drawing.Point(207, 123);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(126, 18);
            this.label121.TabIndex = 54;
            this.label121.Text = "Sulfur Content of Oil = ";
            // 
            // label122
            // 
            this.label122.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label122.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label122.Location = new System.Drawing.Point(254, 96);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(80, 19);
            this.label122.TabIndex = 53;
            this.label122.Text = "Mass of Oil = ";
            // 
            // label124
            // 
            this.label124.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label124.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label124.Location = new System.Drawing.Point(23, 116);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(146, 19);
            this.label124.TabIndex = 51;
            this.label124.Text = "SC - Sulfur Content Oil %";
            // 
            // label198
            // 
            this.label198.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label198.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label198.Location = new System.Drawing.Point(23, 96);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(173, 20);
            this.label198.TabIndex = 50;
            this.label198.Text = "MO - Mass Oil in lbs/hr";
            // 
            // tabSO2Flow
            // 
            this.tabSO2Flow.BackColor = System.Drawing.Color.Ivory;
            this.tabSO2Flow.Controls.Add(this.buttonTabSO2FlowF1Clear);
            this.tabSO2Flow.Controls.Add(this.textBox18);
            this.tabSO2Flow.Controls.Add(this.label126);
            this.tabSO2Flow.Controls.Add(this.label127);
            this.tabSO2Flow.Controls.Add(this.label128);
            this.tabSO2Flow.Controls.Add(this.label129);
            this.tabSO2Flow.Controls.Add(this.textBox107);
            this.tabSO2Flow.Controls.Add(this.buttonTabSO2FlowF1Calculate);
            this.tabSO2Flow.Controls.Add(this.label134);
            this.tabSO2Flow.Controls.Add(this.textBoxTabSO2FlowF1Answer);
            this.tabSO2Flow.Controls.Add(this.textBoxTabSO2FlowF1Flow);
            this.tabSO2Flow.Controls.Add(this.textBoxTabSO2FlowF1SO2Concentration);
            this.tabSO2Flow.Location = new System.Drawing.Point(4, 24);
            this.tabSO2Flow.Name = "tabSO2Flow";
            this.tabSO2Flow.Size = new System.Drawing.Size(939, 514);
            this.tabSO2Flow.TabIndex = 9;
            this.tabSO2Flow.Text = "SO2 - Flow";
            // 
            // buttonTabSO2FlowF1Clear
            // 
            this.buttonTabSO2FlowF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2FlowF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2FlowF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabSO2FlowF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2FlowF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2FlowF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2FlowF1Clear.Location = new System.Drawing.Point(255, 179);
            this.buttonTabSO2FlowF1Clear.Name = "buttonTabSO2FlowF1Clear";
            this.buttonTabSO2FlowF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2FlowF1Clear.TabIndex = 157;
            this.buttonTabSO2FlowF1Clear.Text = "Clear";
            this.buttonTabSO2FlowF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabSO2FlowF1Clear.Click += new System.EventHandler(this.buttonTabSO2FlowF1Clear_Click);
            // 
            // textBox18
            // 
            this.textBox18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox18.BackColor = System.Drawing.Color.Blue;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.ForeColor = System.Drawing.Color.White;
            this.textBox18.Location = new System.Drawing.Point(6, 7);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(927, 29);
            this.textBox18.TabIndex = 79;
            this.textBox18.Text = "Calculate SO2 Mass Emissions for FLOW";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label126
            // 
            this.label126.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label126.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label126.Location = new System.Drawing.Point(289, 127);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(43, 14);
            this.label126.TabIndex = 72;
            this.label126.Text = "Flow = ";
            // 
            // label127
            // 
            this.label127.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label127.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label127.Location = new System.Drawing.Point(212, 98);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(120, 19);
            this.label127.TabIndex = 71;
            this.label127.Text = "SO2 Concentration =  ";
            // 
            // label128
            // 
            this.label128.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label128.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label128.Location = new System.Drawing.Point(24, 120);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(164, 16);
            this.label128.TabIndex = 70;
            this.label128.Text = "FLO - Volumetric Flow (scfh)";
            // 
            // label129
            // 
            this.label129.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label129.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label129.Location = new System.Drawing.Point(24, 98);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(173, 16);
            this.label129.TabIndex = 69;
            this.label129.Text = "SO2 - SO2 Concentration (%)";
            // 
            // textBox107
            // 
            this.textBox107.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox107.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox107.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox107.ForeColor = System.Drawing.Color.White;
            this.textBox107.Location = new System.Drawing.Point(24, 65);
            this.textBox107.Name = "textBox107";
            this.textBox107.ReadOnly = true;
            this.textBox107.Size = new System.Drawing.Size(419, 22);
            this.textBox107.TabIndex = 60;
            this.textBox107.Text = "E = 0.000000166 x SO2 x FLO            Formula F-1";
            this.textBox107.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabSO2FlowF1Calculate
            // 
            this.buttonTabSO2FlowF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabSO2FlowF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabSO2FlowF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabSO2FlowF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSO2FlowF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabSO2FlowF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabSO2FlowF1Calculate.Location = new System.Drawing.Point(368, 179);
            this.buttonTabSO2FlowF1Calculate.Name = "buttonTabSO2FlowF1Calculate";
            this.buttonTabSO2FlowF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabSO2FlowF1Calculate.TabIndex = 156;
            this.buttonTabSO2FlowF1Calculate.Text = "Calculate";
            this.buttonTabSO2FlowF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabSO2FlowF1Calculate.Click += new System.EventHandler(this.buttonTabSO2FlowF1Calculate_Click);
            // 
            // label134
            // 
            this.label134.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label134.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label134.Location = new System.Drawing.Point(171, 153);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(164, 20);
            this.label134.TabIndex = 58;
            this.label134.Text = "  Mass Em. SO2 lbs/hr = ";
            // 
            // textBoxTabSO2FlowF1Answer
            // 
            this.textBoxTabSO2FlowF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2FlowF1Answer.Location = new System.Drawing.Point(343, 151);
            this.textBoxTabSO2FlowF1Answer.Name = "textBoxTabSO2FlowF1Answer";
            this.textBoxTabSO2FlowF1Answer.ReadOnly = true;
            this.textBoxTabSO2FlowF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2FlowF1Answer.TabIndex = 57;
            this.textBoxTabSO2FlowF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabSO2FlowF1Flow
            // 
            this.textBoxTabSO2FlowF1Flow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2FlowF1Flow.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabSO2FlowF1Flow.Name = "textBoxTabSO2FlowF1Flow";
            this.textBoxTabSO2FlowF1Flow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2FlowF1Flow.TabIndex = 155;
            this.textBoxTabSO2FlowF1Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabSO2FlowF1SO2Concentration
            // 
            this.textBoxTabSO2FlowF1SO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabSO2FlowF1SO2Concentration.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabSO2FlowF1SO2Concentration.Name = "textBoxTabSO2FlowF1SO2Concentration";
            this.textBoxTabSO2FlowF1SO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabSO2FlowF1SO2Concentration.TabIndex = 154;
            this.textBoxTabSO2FlowF1SO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabNOxlbsmmBtu
            // 
            this.tabNOxlbsmmBtu.BackColor = System.Drawing.Color.Ivory;
            this.tabNOxlbsmmBtu.Controls.Add(this.buttonTabNOxlbsmmBtuF2Clear);
            this.tabNOxlbsmmBtu.Controls.Add(this.buttonTabNOxlbsmmBtuF1Clear);
            this.tabNOxlbsmmBtu.Controls.Add(this.label72);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF2BAF);
            this.tabNOxlbsmmBtu.Controls.Add(this.label73);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF2Fc);
            this.tabNOxlbsmmBtu.Controls.Add(this.buttonTabNOxlbsmmBtuF2Calculate);
            this.tabNOxlbsmmBtu.Controls.Add(this.label81);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF2Answer);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF2O2);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF2NOx);
            this.tabNOxlbsmmBtu.Controls.Add(this.label83);
            this.tabNOxlbsmmBtu.Controls.Add(this.label84);
            this.tabNOxlbsmmBtu.Controls.Add(this.label71);
            this.tabNOxlbsmmBtu.Controls.Add(this.label70);
            this.tabNOxlbsmmBtu.Controls.Add(this.label69);
            this.tabNOxlbsmmBtu.Controls.Add(this.label66);
            this.tabNOxlbsmmBtu.Controls.Add(this.label63);
            this.tabNOxlbsmmBtu.Controls.Add(this.label58);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF1BAF);
            this.tabNOxlbsmmBtu.Controls.Add(this.label57);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF1Fc);
            this.tabNOxlbsmmBtu.Controls.Add(this.label55);
            this.tabNOxlbsmmBtu.Controls.Add(this.label54);
            this.tabNOxlbsmmBtu.Controls.Add(this.label51);
            this.tabNOxlbsmmBtu.Controls.Add(this.label47);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBox19);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBox115);
            this.tabNOxlbsmmBtu.Controls.Add(this.label146);
            this.tabNOxlbsmmBtu.Controls.Add(this.label147);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBox118);
            this.tabNOxlbsmmBtu.Controls.Add(this.buttonTabNOxlbsmmBtuF1Calculate);
            this.tabNOxlbsmmBtu.Controls.Add(this.label148);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF1Answer);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF1CO2);
            this.tabNOxlbsmmBtu.Controls.Add(this.textBoxTabNOxlbsmmBtuF1NOx);
            this.tabNOxlbsmmBtu.Controls.Add(this.label149);
            this.tabNOxlbsmmBtu.Controls.Add(this.label150);
            this.tabNOxlbsmmBtu.Controls.Add(this.label200);
            this.tabNOxlbsmmBtu.Location = new System.Drawing.Point(4, 24);
            this.tabNOxlbsmmBtu.Name = "tabNOxlbsmmBtu";
            this.tabNOxlbsmmBtu.Size = new System.Drawing.Size(939, 514);
            this.tabNOxlbsmmBtu.TabIndex = 10;
            this.tabNOxlbsmmBtu.Text = "NOx lbs/mmBtu";
            // 
            // buttonTabNOxlbsmmBtuF2Clear
            // 
            this.buttonTabNOxlbsmmBtuF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxlbsmmBtuF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxlbsmmBtuF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabNOxlbsmmBtuF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxlbsmmBtuF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxlbsmmBtuF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxlbsmmBtuF2Clear.Location = new System.Drawing.Point(723, 232);
            this.buttonTabNOxlbsmmBtuF2Clear.Name = "buttonTabNOxlbsmmBtuF2Clear";
            this.buttonTabNOxlbsmmBtuF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxlbsmmBtuF2Clear.TabIndex = 169;
            this.buttonTabNOxlbsmmBtuF2Clear.Text = "Clear";
            this.buttonTabNOxlbsmmBtuF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabNOxlbsmmBtuF2Clear.Click += new System.EventHandler(this.buttonTabNOxlbsmmBtuF2Clear_Click);
            // 
            // buttonTabNOxlbsmmBtuF1Clear
            // 
            this.buttonTabNOxlbsmmBtuF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxlbsmmBtuF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxlbsmmBtuF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabNOxlbsmmBtuF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxlbsmmBtuF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxlbsmmBtuF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxlbsmmBtuF1Clear.Location = new System.Drawing.Point(255, 232);
            this.buttonTabNOxlbsmmBtuF1Clear.Name = "buttonTabNOxlbsmmBtuF1Clear";
            this.buttonTabNOxlbsmmBtuF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxlbsmmBtuF1Clear.TabIndex = 163;
            this.buttonTabNOxlbsmmBtuF1Clear.Text = "Clear";
            this.buttonTabNOxlbsmmBtuF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabNOxlbsmmBtuF1Clear.Click += new System.EventHandler(this.buttonTabNOxlbsmmBtuF1Clear_Click);
            // 
            // label72
            // 
            this.label72.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(726, 179);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(79, 18);
            this.label72.TabIndex = 103;
            this.label72.Text = "NOx B.A.F. =";
            // 
            // textBoxTabNOxlbsmmBtuF2BAF
            // 
            this.textBoxTabNOxlbsmmBtuF2BAF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF2BAF.Location = new System.Drawing.Point(811, 177);
            this.textBoxTabNOxlbsmmBtuF2BAF.Name = "textBoxTabNOxlbsmmBtuF2BAF";
            this.textBoxTabNOxlbsmmBtuF2BAF.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF2BAF.TabIndex = 167;
            this.textBoxTabNOxlbsmmBtuF2BAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label73
            // 
            this.label73.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(724, 153);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(79, 18);
            this.label73.TabIndex = 101;
            this.label73.Text = "Fuel Factor = ";
            // 
            // textBoxTabNOxlbsmmBtuF2Fc
            // 
            this.textBoxTabNOxlbsmmBtuF2Fc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF2Fc.Location = new System.Drawing.Point(811, 150);
            this.textBoxTabNOxlbsmmBtuF2Fc.Name = "textBoxTabNOxlbsmmBtuF2Fc";
            this.textBoxTabNOxlbsmmBtuF2Fc.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF2Fc.TabIndex = 166;
            this.textBoxTabNOxlbsmmBtuF2Fc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonTabNOxlbsmmBtuF2Calculate
            // 
            this.buttonTabNOxlbsmmBtuF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxlbsmmBtuF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxlbsmmBtuF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabNOxlbsmmBtuF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxlbsmmBtuF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxlbsmmBtuF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxlbsmmBtuF2Calculate.Location = new System.Drawing.Point(836, 232);
            this.buttonTabNOxlbsmmBtuF2Calculate.Name = "buttonTabNOxlbsmmBtuF2Calculate";
            this.buttonTabNOxlbsmmBtuF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxlbsmmBtuF2Calculate.TabIndex = 168;
            this.buttonTabNOxlbsmmBtuF2Calculate.Text = "Calculate";
            this.buttonTabNOxlbsmmBtuF2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabNOxlbsmmBtuF2Calculate.Click += new System.EventHandler(this.buttonTabNOxlbsmmBtuF2Calculate_Click);
            // 
            // label81
            // 
            this.label81.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(682, 206);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(123, 20);
            this.label81.TabIndex = 98;
            this.label81.Text = "NOx lbs/mmBtu =";
            // 
            // textBoxTabNOxlbsmmBtuF2Answer
            // 
            this.textBoxTabNOxlbsmmBtuF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF2Answer.Location = new System.Drawing.Point(811, 204);
            this.textBoxTabNOxlbsmmBtuF2Answer.Name = "textBoxTabNOxlbsmmBtuF2Answer";
            this.textBoxTabNOxlbsmmBtuF2Answer.ReadOnly = true;
            this.textBoxTabNOxlbsmmBtuF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF2Answer.TabIndex = 97;
            this.textBoxTabNOxlbsmmBtuF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxlbsmmBtuF2O2
            // 
            this.textBoxTabNOxlbsmmBtuF2O2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF2O2.Location = new System.Drawing.Point(811, 123);
            this.textBoxTabNOxlbsmmBtuF2O2.Name = "textBoxTabNOxlbsmmBtuF2O2";
            this.textBoxTabNOxlbsmmBtuF2O2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF2O2.TabIndex = 165;
            this.textBoxTabNOxlbsmmBtuF2O2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxlbsmmBtuF2NOx
            // 
            this.textBoxTabNOxlbsmmBtuF2NOx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF2NOx.Location = new System.Drawing.Point(811, 95);
            this.textBoxTabNOxlbsmmBtuF2NOx.Name = "textBoxTabNOxlbsmmBtuF2NOx";
            this.textBoxTabNOxlbsmmBtuF2NOx.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF2NOx.TabIndex = 164;
            this.textBoxTabNOxlbsmmBtuF2NOx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label83
            // 
            this.label83.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(747, 125);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(55, 18);
            this.label83.TabIndex = 94;
            this.label83.Text = "O2 (%) =";
            // 
            // label84
            // 
            this.label84.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(725, 97);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(80, 19);
            this.label84.TabIndex = 93;
            this.label84.Text = "NOx (ppm) =";
            // 
            // label71
            // 
            this.label71.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label71.Location = new System.Drawing.Point(492, 177);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(200, 15);
            this.label71.TabIndex = 92;
            this.label71.Text = "B.A.F. - NOx Bias Adjustment Factor";
            // 
            // label70
            // 
            this.label70.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(493, 197);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(85, 19);
            this.label70.TabIndex = 91;
            this.label70.Text = "O2 - % O2";
            // 
            // label69
            // 
            this.label69.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label69.Location = new System.Drawing.Point(492, 158);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(127, 15);
            this.label69.TabIndex = 90;
            this.label69.Text = "Fc - Fuel Factor for O2";
            // 
            // label66
            // 
            this.label66.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label66.Location = new System.Drawing.Point(492, 138);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(77, 15);
            this.label66.TabIndex = 89;
            this.label66.Text = "C - NOx ppm";
            // 
            // label63
            // 
            this.label63.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label63.Location = new System.Drawing.Point(492, 117);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(181, 15);
            this.label63.TabIndex = 88;
            this.label63.Text = "K - 1.194 X 10e-7 (lbs/scf) / ppm";
            // 
            // label58
            // 
            this.label58.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(258, 179);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(79, 18);
            this.label58.TabIndex = 87;
            this.label58.Text = "NOx B.A.F. =";
            // 
            // textBoxTabNOxlbsmmBtuF1BAF
            // 
            this.textBoxTabNOxlbsmmBtuF1BAF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF1BAF.Location = new System.Drawing.Point(343, 177);
            this.textBoxTabNOxlbsmmBtuF1BAF.Name = "textBoxTabNOxlbsmmBtuF1BAF";
            this.textBoxTabNOxlbsmmBtuF1BAF.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF1BAF.TabIndex = 161;
            this.textBoxTabNOxlbsmmBtuF1BAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(256, 155);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(79, 18);
            this.label57.TabIndex = 85;
            this.label57.Text = "Fuel Factor = ";
            // 
            // textBoxTabNOxlbsmmBtuF1Fc
            // 
            this.textBoxTabNOxlbsmmBtuF1Fc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF1Fc.Location = new System.Drawing.Point(343, 150);
            this.textBoxTabNOxlbsmmBtuF1Fc.Name = "textBoxTabNOxlbsmmBtuF1Fc";
            this.textBoxTabNOxlbsmmBtuF1Fc.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF1Fc.TabIndex = 160;
            this.textBoxTabNOxlbsmmBtuF1Fc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(24, 179);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(200, 15);
            this.label55.TabIndex = 83;
            this.label55.Text = "B.A.F. - NOx Bias Adjustment Factor";
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label54.Location = new System.Drawing.Point(24, 158);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(135, 15);
            this.label54.TabIndex = 82;
            this.label54.Text = "Fc - Fuel Factor for CO2";
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label51.Location = new System.Drawing.Point(24, 138);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(77, 15);
            this.label51.TabIndex = 81;
            this.label51.Text = "C - NOx ppm";
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label47.Location = new System.Drawing.Point(24, 117);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(181, 15);
            this.label47.TabIndex = 80;
            this.label47.Text = "K - 1.194 X 10e-7 (lbs/scf) / ppm";
            // 
            // textBox19
            // 
            this.textBox19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox19.BackColor = System.Drawing.Color.Blue;
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.ForeColor = System.Drawing.Color.White;
            this.textBox19.Location = new System.Drawing.Point(6, 7);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(927, 29);
            this.textBox19.TabIndex = 79;
            this.textBox19.Text = "Calculate NOx Emission Rate (lbs/mmBtu)";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox115
            // 
            this.textBox115.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox115.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox115.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox115.ForeColor = System.Drawing.Color.White;
            this.textBox115.Location = new System.Drawing.Point(492, 65);
            this.textBox115.Name = "textBox115";
            this.textBox115.ReadOnly = true;
            this.textBox115.Size = new System.Drawing.Size(419, 22);
            this.textBox115.TabIndex = 68;
            this.textBox115.Text = "E = K x C x Fc (20.9 / (20.9 - O2)) x B.A.F.              Formula F-5";
            this.textBox115.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label146
            // 
            this.label146.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label146.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label146.Location = new System.Drawing.Point(24, 199);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(85, 19);
            this.label146.TabIndex = 62;
            this.label146.Text = "CO2 - % CO2";
            // 
            // label147
            // 
            this.label147.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label147.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label147.Location = new System.Drawing.Point(492, 97);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(156, 15);
            this.label147.TabIndex = 61;
            this.label147.Text = "E - NOx lbs/mmBtu";
            // 
            // textBox118
            // 
            this.textBox118.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox118.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox118.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox118.ForeColor = System.Drawing.Color.White;
            this.textBox118.Location = new System.Drawing.Point(24, 65);
            this.textBox118.Name = "textBox118";
            this.textBox118.ReadOnly = true;
            this.textBox118.Size = new System.Drawing.Size(419, 22);
            this.textBox118.TabIndex = 60;
            this.textBox118.Text = "E = K x C x Fc (100 / CO2) x B.A.F.              Formula F-6";
            this.textBox118.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabNOxlbsmmBtuF1Calculate
            // 
            this.buttonTabNOxlbsmmBtuF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxlbsmmBtuF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxlbsmmBtuF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabNOxlbsmmBtuF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxlbsmmBtuF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxlbsmmBtuF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxlbsmmBtuF1Calculate.Location = new System.Drawing.Point(368, 232);
            this.buttonTabNOxlbsmmBtuF1Calculate.Name = "buttonTabNOxlbsmmBtuF1Calculate";
            this.buttonTabNOxlbsmmBtuF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxlbsmmBtuF1Calculate.TabIndex = 162;
            this.buttonTabNOxlbsmmBtuF1Calculate.Text = "Calculate";
            this.buttonTabNOxlbsmmBtuF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabNOxlbsmmBtuF1Calculate.Click += new System.EventHandler(this.buttonTabNOxlbsmmBtuF1Calculate_Click);
            // 
            // label148
            // 
            this.label148.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label148.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label148.Location = new System.Drawing.Point(214, 206);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(123, 20);
            this.label148.TabIndex = 58;
            this.label148.Text = "NOx lbs/mmBtu =";
            // 
            // textBoxTabNOxlbsmmBtuF1Answer
            // 
            this.textBoxTabNOxlbsmmBtuF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF1Answer.Location = new System.Drawing.Point(343, 204);
            this.textBoxTabNOxlbsmmBtuF1Answer.Name = "textBoxTabNOxlbsmmBtuF1Answer";
            this.textBoxTabNOxlbsmmBtuF1Answer.ReadOnly = true;
            this.textBoxTabNOxlbsmmBtuF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF1Answer.TabIndex = 57;
            this.textBoxTabNOxlbsmmBtuF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxlbsmmBtuF1CO2
            // 
            this.textBoxTabNOxlbsmmBtuF1CO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF1CO2.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabNOxlbsmmBtuF1CO2.Name = "textBoxTabNOxlbsmmBtuF1CO2";
            this.textBoxTabNOxlbsmmBtuF1CO2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF1CO2.TabIndex = 159;
            this.textBoxTabNOxlbsmmBtuF1CO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxlbsmmBtuF1NOx
            // 
            this.textBoxTabNOxlbsmmBtuF1NOx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbsmmBtuF1NOx.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabNOxlbsmmBtuF1NOx.Name = "textBoxTabNOxlbsmmBtuF1NOx";
            this.textBoxTabNOxlbsmmBtuF1NOx.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbsmmBtuF1NOx.TabIndex = 158;
            this.textBoxTabNOxlbsmmBtuF1NOx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label149
            // 
            this.label149.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label149.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label149.Location = new System.Drawing.Point(271, 124);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(63, 18);
            this.label149.TabIndex = 54;
            this.label149.Text = "CO2 (%) =";
            // 
            // label150
            // 
            this.label150.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label150.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.Location = new System.Drawing.Point(257, 97);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(80, 19);
            this.label150.TabIndex = 53;
            this.label150.Text = "NOx (ppm) =";
            // 
            // label200
            // 
            this.label200.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label200.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label200.Location = new System.Drawing.Point(24, 97);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(173, 20);
            this.label200.TabIndex = 50;
            this.label200.Text = "E - NOx lbs/mmBtu";
            // 
            // tabNOxlbshr
            // 
            this.tabNOxlbshr.BackColor = System.Drawing.Color.Ivory;
            this.tabNOxlbshr.Controls.Add(this.buttonTabNOxlbshrF2Clear);
            this.tabNOxlbshr.Controls.Add(this.buttonTabNOxlbshrF1Clear);
            this.tabNOxlbshr.Controls.Add(this.label89);
            this.tabNOxlbshr.Controls.Add(this.textBoxTabNOxlbshrF2OT);
            this.tabNOxlbshr.Controls.Add(this.label90);
            this.tabNOxlbshr.Controls.Add(this.label97);
            this.tabNOxlbshr.Controls.Add(this.buttonTabNOxlbshrF2Answer);
            this.tabNOxlbshr.Controls.Add(this.label98);
            this.tabNOxlbshr.Controls.Add(this.textBoxTabNOxlbshrF2Answer);
            this.tabNOxlbshr.Controls.Add(this.textBoxTabNOxlbshrF2HTIP);
            this.tabNOxlbshr.Controls.Add(this.textBoxTabNOxlbshrF2NOx);
            this.tabNOxlbshr.Controls.Add(this.label99);
            this.tabNOxlbshr.Controls.Add(this.label100);
            this.tabNOxlbshr.Controls.Add(this.label101);
            this.tabNOxlbshr.Controls.Add(this.label107);
            this.tabNOxlbshr.Controls.Add(this.label109);
            this.tabNOxlbshr.Controls.Add(this.label88);
            this.tabNOxlbshr.Controls.Add(this.textBoxTabNOxlbshrF1OT);
            this.tabNOxlbshr.Controls.Add(this.label87);
            this.tabNOxlbshr.Controls.Add(this.label86);
            this.tabNOxlbshr.Controls.Add(this.label85);
            this.tabNOxlbshr.Controls.Add(this.textBox20);
            this.tabNOxlbshr.Controls.Add(this.textBox126);
            this.tabNOxlbshr.Controls.Add(this.textBox129);
            this.tabNOxlbshr.Controls.Add(this.buttonTabNOxlbshrF1Calculate);
            this.tabNOxlbshr.Controls.Add(this.label162);
            this.tabNOxlbshr.Controls.Add(this.textBoxTabNOxlbshrF1Answer);
            this.tabNOxlbshr.Controls.Add(this.textBoxTabNOxlbshrF1Fc);
            this.tabNOxlbshr.Controls.Add(this.textBoxTabNOxlbshrF1NOx);
            this.tabNOxlbshr.Controls.Add(this.label163);
            this.tabNOxlbshr.Controls.Add(this.label164);
            this.tabNOxlbshr.Controls.Add(this.label165);
            this.tabNOxlbshr.Controls.Add(this.label166);
            this.tabNOxlbshr.Controls.Add(this.label201);
            this.tabNOxlbshr.Location = new System.Drawing.Point(4, 24);
            this.tabNOxlbshr.Name = "tabNOxlbshr";
            this.tabNOxlbshr.Size = new System.Drawing.Size(939, 514);
            this.tabNOxlbshr.TabIndex = 11;
            this.tabNOxlbshr.Text = "NOx lbs/hr";
            // 
            // buttonTabNOxlbshrF2Clear
            // 
            this.buttonTabNOxlbshrF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxlbshrF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxlbshrF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabNOxlbshrF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxlbshrF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxlbshrF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxlbshrF2Clear.Location = new System.Drawing.Point(718, 205);
            this.buttonTabNOxlbshrF2Clear.Name = "buttonTabNOxlbshrF2Clear";
            this.buttonTabNOxlbshrF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxlbshrF2Clear.TabIndex = 179;
            this.buttonTabNOxlbshrF2Clear.Text = "Clear";
            this.buttonTabNOxlbshrF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabNOxlbshrF2Clear.Click += new System.EventHandler(this.buttonTabNOxlbshrF2Clear_Click);
            // 
            // buttonTabNOxlbshrF1Clear
            // 
            this.buttonTabNOxlbshrF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxlbshrF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxlbshrF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabNOxlbshrF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxlbshrF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxlbshrF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxlbshrF1Clear.Location = new System.Drawing.Point(250, 205);
            this.buttonTabNOxlbshrF1Clear.Name = "buttonTabNOxlbshrF1Clear";
            this.buttonTabNOxlbshrF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxlbshrF1Clear.TabIndex = 174;
            this.buttonTabNOxlbshrF1Clear.Text = "Clear";
            this.buttonTabNOxlbshrF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabNOxlbshrF1Clear.Click += new System.EventHandler(this.buttonTabNOxlbshrF1Clear_Click);
            // 
            // label89
            // 
            this.label89.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(693, 151);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(109, 18);
            this.label89.TabIndex = 99;
            this.label89.Text = "Operating Time = ";
            // 
            // textBoxTabNOxlbshrF2OT
            // 
            this.textBoxTabNOxlbshrF2OT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbshrF2OT.Location = new System.Drawing.Point(811, 150);
            this.textBoxTabNOxlbshrF2OT.Name = "textBoxTabNOxlbshrF2OT";
            this.textBoxTabNOxlbshrF2OT.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbshrF2OT.TabIndex = 177;
            this.textBoxTabNOxlbshrF2OT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label90
            // 
            this.label90.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label90.Location = new System.Drawing.Point(507, 173);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(158, 15);
            this.label90.TabIndex = 97;
            this.label90.Text = " (hour or fraction of an hour)";
            // 
            // label97
            // 
            this.label97.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(492, 156);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(186, 17);
            this.label97.TabIndex = 95;
            this.label97.Text = "T - Unit/Stack Operating Time";
            // 
            // buttonTabNOxlbshrF2Answer
            // 
            this.buttonTabNOxlbshrF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxlbshrF2Answer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxlbshrF2Answer.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabNOxlbshrF2Answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxlbshrF2Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxlbshrF2Answer.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxlbshrF2Answer.Location = new System.Drawing.Point(836, 205);
            this.buttonTabNOxlbshrF2Answer.Name = "buttonTabNOxlbshrF2Answer";
            this.buttonTabNOxlbshrF2Answer.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxlbshrF2Answer.TabIndex = 178;
            this.buttonTabNOxlbshrF2Answer.Text = "Calculate";
            this.buttonTabNOxlbshrF2Answer.UseVisualStyleBackColor = false;
            this.buttonTabNOxlbshrF2Answer.Click += new System.EventHandler(this.buttonTabNOxlbshrF2Answer_Click);
            // 
            // label98
            // 
            this.label98.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(709, 179);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(96, 20);
            this.label98.TabIndex = 93;
            this.label98.Text = "NOx lbs/hr =";
            // 
            // textBoxTabNOxlbshrF2Answer
            // 
            this.textBoxTabNOxlbshrF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbshrF2Answer.Location = new System.Drawing.Point(811, 177);
            this.textBoxTabNOxlbshrF2Answer.Name = "textBoxTabNOxlbshrF2Answer";
            this.textBoxTabNOxlbshrF2Answer.ReadOnly = true;
            this.textBoxTabNOxlbshrF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbshrF2Answer.TabIndex = 92;
            this.textBoxTabNOxlbshrF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxlbshrF2HTIP
            // 
            this.textBoxTabNOxlbshrF2HTIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbshrF2HTIP.Location = new System.Drawing.Point(811, 123);
            this.textBoxTabNOxlbshrF2HTIP.Name = "textBoxTabNOxlbshrF2HTIP";
            this.textBoxTabNOxlbshrF2HTIP.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbshrF2HTIP.TabIndex = 176;
            this.textBoxTabNOxlbshrF2HTIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxlbshrF2NOx
            // 
            this.textBoxTabNOxlbshrF2NOx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbshrF2NOx.Location = new System.Drawing.Point(811, 95);
            this.textBoxTabNOxlbshrF2NOx.Name = "textBoxTabNOxlbshrF2NOx";
            this.textBoxTabNOxlbshrF2NOx.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbshrF2NOx.TabIndex = 175;
            this.textBoxTabNOxlbshrF2NOx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label99
            // 
            this.label99.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(722, 125);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(78, 18);
            this.label99.TabIndex = 89;
            this.label99.Text = "Heat Input =";
            // 
            // label100
            // 
            this.label100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(684, 97);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(115, 19);
            this.label100.TabIndex = 88;
            this.label100.Text = "NOx (lbs/mmBtu) =";
            // 
            // label101
            // 
            this.label101.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.Location = new System.Drawing.Point(492, 136);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(186, 17);
            this.label101.TabIndex = 87;
            this.label101.Text = "HI - Heat Input Rate (mmBtu/hr)";
            // 
            // label107
            // 
            this.label107.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.Location = new System.Drawing.Point(492, 117);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(186, 19);
            this.label107.TabIndex = 86;
            this.label107.Text = "E(NOx) - NOx Rate (lbs/mmBtu)";
            // 
            // label109
            // 
            this.label109.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.Location = new System.Drawing.Point(492, 97);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(173, 20);
            this.label109.TabIndex = 85;
            this.label109.Text = "MNOx - NOx Mass lbs";
            // 
            // label88
            // 
            this.label88.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(224, 151);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(109, 18);
            this.label88.TabIndex = 84;
            this.label88.Text = "Operating Time = ";
            // 
            // textBoxTabNOxlbshrF1OT
            // 
            this.textBoxTabNOxlbshrF1OT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbshrF1OT.Location = new System.Drawing.Point(343, 150);
            this.textBoxTabNOxlbshrF1OT.Name = "textBoxTabNOxlbshrF1OT";
            this.textBoxTabNOxlbshrF1OT.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbshrF1OT.TabIndex = 172;
            this.textBoxTabNOxlbshrF1OT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label87
            // 
            this.label87.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label87.Location = new System.Drawing.Point(33, 188);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(158, 15);
            this.label87.TabIndex = 82;
            this.label87.Text = " (hour or fraction of an hour)";
            // 
            // label86
            // 
            this.label86.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label86.Location = new System.Drawing.Point(24, 173);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(167, 15);
            this.label86.TabIndex = 81;
            this.label86.Text = "T - Unit/Stack Operating Time";
            // 
            // label85
            // 
            this.label85.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(24, 156);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(186, 17);
            this.label85.TabIndex = 80;
            this.label85.Text = "Q - Volumetric Flow Rate (scfh)";
            // 
            // textBox20
            // 
            this.textBox20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox20.BackColor = System.Drawing.Color.Blue;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.ForeColor = System.Drawing.Color.White;
            this.textBox20.Location = new System.Drawing.Point(6, 7);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(927, 29);
            this.textBox20.TabIndex = 79;
            this.textBox20.Text = "Calculate NOx Mass Emission Rate (lbs/hr)";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox126
            // 
            this.textBox126.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox126.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox126.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox126.ForeColor = System.Drawing.Color.White;
            this.textBox126.Location = new System.Drawing.Point(492, 65);
            this.textBox126.Name = "textBox126";
            this.textBox126.ReadOnly = true;
            this.textBox126.Size = new System.Drawing.Size(419, 22);
            this.textBox126.TabIndex = 68;
            this.textBox126.Text = "MNOx = E(Nox) x HI x T          Formula F-24";
            this.textBox126.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox129
            // 
            this.textBox129.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox129.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox129.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox129.ForeColor = System.Drawing.Color.White;
            this.textBox129.Location = new System.Drawing.Point(24, 65);
            this.textBox129.Name = "textBox129";
            this.textBox129.ReadOnly = true;
            this.textBox129.Size = new System.Drawing.Size(419, 22);
            this.textBox129.TabIndex = 60;
            this.textBox129.Text = "MNOx = K x Cw x Q x T          Formula F-26 / N-1";
            this.textBox129.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabNOxlbshrF1Calculate
            // 
            this.buttonTabNOxlbshrF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxlbshrF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxlbshrF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabNOxlbshrF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxlbshrF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxlbshrF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxlbshrF1Calculate.Location = new System.Drawing.Point(368, 205);
            this.buttonTabNOxlbshrF1Calculate.Name = "buttonTabNOxlbshrF1Calculate";
            this.buttonTabNOxlbshrF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxlbshrF1Calculate.TabIndex = 173;
            this.buttonTabNOxlbshrF1Calculate.Text = "Calculate";
            this.buttonTabNOxlbshrF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabNOxlbshrF1Calculate.Click += new System.EventHandler(this.buttonTabNOxlbshrF1Calculate_Click);
            // 
            // label162
            // 
            this.label162.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label162.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label162.Location = new System.Drawing.Point(241, 179);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(96, 20);
            this.label162.TabIndex = 58;
            this.label162.Text = "NOx lbs/hr =";
            // 
            // textBoxTabNOxlbshrF1Answer
            // 
            this.textBoxTabNOxlbshrF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbshrF1Answer.Location = new System.Drawing.Point(343, 177);
            this.textBoxTabNOxlbshrF1Answer.Name = "textBoxTabNOxlbshrF1Answer";
            this.textBoxTabNOxlbshrF1Answer.ReadOnly = true;
            this.textBoxTabNOxlbshrF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbshrF1Answer.TabIndex = 57;
            this.textBoxTabNOxlbshrF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxlbshrF1Fc
            // 
            this.textBoxTabNOxlbshrF1Fc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbshrF1Fc.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabNOxlbshrF1Fc.Name = "textBoxTabNOxlbshrF1Fc";
            this.textBoxTabNOxlbshrF1Fc.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbshrF1Fc.TabIndex = 171;
            this.textBoxTabNOxlbshrF1Fc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxlbshrF1NOx
            // 
            this.textBoxTabNOxlbshrF1NOx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxlbshrF1NOx.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabNOxlbshrF1NOx.Name = "textBoxTabNOxlbshrF1NOx";
            this.textBoxTabNOxlbshrF1NOx.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxlbshrF1NOx.TabIndex = 170;
            this.textBoxTabNOxlbshrF1NOx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label163
            // 
            this.label163.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label163.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label163.Location = new System.Drawing.Point(250, 125);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(84, 18);
            this.label163.TabIndex = 54;
            this.label163.Text = "Flow (scfh) =";
            // 
            // label164
            // 
            this.label164.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label164.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label164.Location = new System.Drawing.Point(247, 97);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(87, 19);
            this.label164.TabIndex = 53;
            this.label164.Text = "NOx (ppm) =";
            // 
            // label165
            // 
            this.label165.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label165.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label165.Location = new System.Drawing.Point(24, 136);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(211, 17);
            this.label165.TabIndex = 52;
            this.label165.Text = "Cw - NOx Concentration (ppm (wet))";
            // 
            // label166
            // 
            this.label166.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label166.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label166.Location = new System.Drawing.Point(24, 117);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(186, 19);
            this.label166.TabIndex = 51;
            this.label166.Text = "K - 1.194 X 10E-7 (lbs/scf) / ppm";
            // 
            // label201
            // 
            this.label201.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label201.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label201.Location = new System.Drawing.Point(24, 97);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(173, 20);
            this.label201.TabIndex = 50;
            this.label201.Text = "MNOx - NOx Mass lbs";
            // 
            // tabNOxppmvd
            // 
            this.tabNOxppmvd.BackColor = System.Drawing.Color.Ivory;
            this.tabNOxppmvd.Controls.Add(this.buttonTabNOxppmvdF2Clear);
            this.tabNOxppmvd.Controls.Add(this.buttonTabNOxppmvdF1Clear);
            this.tabNOxppmvd.Controls.Add(this.comboBoxTabNOxppmvdF2XCO2);
            this.tabNOxppmvd.Controls.Add(this.textBoxTabNOxppmvdF2CO2);
            this.tabNOxppmvd.Controls.Add(this.label110);
            this.tabNOxppmvd.Controls.Add(this.label91);
            this.tabNOxppmvd.Controls.Add(this.textBox21);
            this.tabNOxppmvd.Controls.Add(this.textBox137);
            this.tabNOxppmvd.Controls.Add(this.buttonTabNOxppmvdF2Calculate);
            this.tabNOxppmvd.Controls.Add(this.label172);
            this.tabNOxppmvd.Controls.Add(this.textBoxTabNOxppmvdF2Answer);
            this.tabNOxppmvd.Controls.Add(this.textBoxTabNOxppmvdF2NOx);
            this.tabNOxppmvd.Controls.Add(this.label173);
            this.tabNOxppmvd.Controls.Add(this.label174);
            this.tabNOxppmvd.Controls.Add(this.label175);
            this.tabNOxppmvd.Controls.Add(this.textBox140);
            this.tabNOxppmvd.Controls.Add(this.buttonTabNOxppmvdF1Calculate);
            this.tabNOxppmvd.Controls.Add(this.label176);
            this.tabNOxppmvd.Controls.Add(this.textBoxTabNOxppmvdF1Answer);
            this.tabNOxppmvd.Controls.Add(this.textBoxTabNOxppmvdF1O2);
            this.tabNOxppmvd.Controls.Add(this.textBoxTabNOxppmvdF1NOx);
            this.tabNOxppmvd.Controls.Add(this.label177);
            this.tabNOxppmvd.Controls.Add(this.label178);
            this.tabNOxppmvd.Location = new System.Drawing.Point(4, 24);
            this.tabNOxppmvd.Name = "tabNOxppmvd";
            this.tabNOxppmvd.Padding = new System.Windows.Forms.Padding(3);
            this.tabNOxppmvd.Size = new System.Drawing.Size(939, 514);
            this.tabNOxppmvd.TabIndex = 12;
            this.tabNOxppmvd.Text = "NOx ppmvd";
            // 
            // buttonTabNOxppmvdF2Clear
            // 
            this.buttonTabNOxppmvdF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxppmvdF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxppmvdF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabNOxppmvdF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxppmvdF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxppmvdF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxppmvdF2Clear.Location = new System.Drawing.Point(721, 204);
            this.buttonTabNOxppmvdF2Clear.Name = "buttonTabNOxppmvdF2Clear";
            this.buttonTabNOxppmvdF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxppmvdF2Clear.TabIndex = 189;
            this.buttonTabNOxppmvdF2Clear.Text = "Clear";
            this.buttonTabNOxppmvdF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabNOxppmvdF2Clear.Click += new System.EventHandler(this.buttonTabNOxppmvdF2Clear_Click);
            // 
            // buttonTabNOxppmvdF1Clear
            // 
            this.buttonTabNOxppmvdF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxppmvdF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxppmvdF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabNOxppmvdF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxppmvdF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxppmvdF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxppmvdF1Clear.Location = new System.Drawing.Point(257, 178);
            this.buttonTabNOxppmvdF1Clear.Name = "buttonTabNOxppmvdF1Clear";
            this.buttonTabNOxppmvdF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxppmvdF1Clear.TabIndex = 183;
            this.buttonTabNOxppmvdF1Clear.Text = "Clear";
            this.buttonTabNOxppmvdF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabNOxppmvdF1Clear.Click += new System.EventHandler(this.buttonTabNOxppmvdF1Clear_Click);
            // 
            // comboBoxTabNOxppmvdF2XCO2
            // 
            this.comboBoxTabNOxppmvdF2XCO2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTabNOxppmvdF2XCO2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTabNOxppmvdF2XCO2.FormattingEnabled = true;
            this.comboBoxTabNOxppmvdF2XCO2.Items.AddRange(new object[] {
            "SELECT XCO2",
            "3.3707",
            "4.3619"});
            this.comboBoxTabNOxppmvdF2XCO2.Location = new System.Drawing.Point(811, 148);
            this.comboBoxTabNOxppmvdF2XCO2.Name = "comboBoxTabNOxppmvdF2XCO2";
            this.comboBoxTabNOxppmvdF2XCO2.Size = new System.Drawing.Size(100, 23);
            this.comboBoxTabNOxppmvdF2XCO2.TabIndex = 186;
            // 
            // textBoxTabNOxppmvdF2CO2
            // 
            this.textBoxTabNOxppmvdF2CO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxppmvdF2CO2.Location = new System.Drawing.Point(811, 122);
            this.textBoxTabNOxppmvdF2CO2.Name = "textBoxTabNOxppmvdF2CO2";
            this.textBoxTabNOxppmvdF2CO2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxppmvdF2CO2.TabIndex = 185;
            this.textBoxTabNOxppmvdF2CO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label110
            // 
            this.label110.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.Location = new System.Drawing.Point(733, 123);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(74, 18);
            this.label110.TabIndex = 82;
            this.label110.Text = "CO2 (%)  =";
            // 
            // label91
            // 
            this.label91.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(750, 149);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(55, 18);
            this.label91.TabIndex = 80;
            this.label91.Text = "XCO2 =";
            // 
            // textBox21
            // 
            this.textBox21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox21.BackColor = System.Drawing.Color.Blue;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.ForeColor = System.Drawing.Color.White;
            this.textBox21.Location = new System.Drawing.Point(6, 7);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(927, 29);
            this.textBox21.TabIndex = 79;
            this.textBox21.Text = "Calculate NOx ppmvd (Parts Per Million by Volume, Dry)";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox137
            // 
            this.textBox137.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox137.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox137.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox137.ForeColor = System.Drawing.Color.White;
            this.textBox137.Location = new System.Drawing.Point(492, 65);
            this.textBox137.Name = "textBox137";
            this.textBox137.ReadOnly = true;
            this.textBox137.Size = new System.Drawing.Size(419, 22);
            this.textBox137.TabIndex = 68;
            this.textBox137.Text = "E = (NOx * XCO2) / (CO2)";
            this.textBox137.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabNOxppmvdF2Calculate
            // 
            this.buttonTabNOxppmvdF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxppmvdF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxppmvdF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabNOxppmvdF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxppmvdF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxppmvdF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxppmvdF2Calculate.Location = new System.Drawing.Point(836, 204);
            this.buttonTabNOxppmvdF2Calculate.Name = "buttonTabNOxppmvdF2Calculate";
            this.buttonTabNOxppmvdF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxppmvdF2Calculate.TabIndex = 188;
            this.buttonTabNOxppmvdF2Calculate.Text = "Calculate";
            this.buttonTabNOxppmvdF2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabNOxppmvdF2Calculate.Click += new System.EventHandler(this.buttonTabNOxppmvdF2Calculate_Click);
            // 
            // label172
            // 
            this.label172.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label172.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label172.Location = new System.Drawing.Point(707, 178);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(94, 18);
            this.label172.TabIndex = 66;
            this.label172.Text = "NOx ppmvd =";
            // 
            // textBoxTabNOxppmvdF2Answer
            // 
            this.textBoxTabNOxppmvdF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxppmvdF2Answer.Location = new System.Drawing.Point(811, 176);
            this.textBoxTabNOxppmvdF2Answer.Name = "textBoxTabNOxppmvdF2Answer";
            this.textBoxTabNOxppmvdF2Answer.ReadOnly = true;
            this.textBoxTabNOxppmvdF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxppmvdF2Answer.TabIndex = 187;
            this.textBoxTabNOxppmvdF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxppmvdF2NOx
            // 
            this.textBoxTabNOxppmvdF2NOx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxppmvdF2NOx.Location = new System.Drawing.Point(811, 95);
            this.textBoxTabNOxppmvdF2NOx.Name = "textBoxTabNOxppmvdF2NOx";
            this.textBoxTabNOxppmvdF2NOx.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxppmvdF2NOx.TabIndex = 184;
            this.textBoxTabNOxppmvdF2NOx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label173
            // 
            this.label173.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label173.Location = new System.Drawing.Point(723, 96);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(80, 18);
            this.label173.TabIndex = 63;
            this.label173.Text = "NOx (ppm) =";
            // 
            // label174
            // 
            this.label174.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label174.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label174.Location = new System.Drawing.Point(492, 117);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(138, 19);
            this.label174.TabIndex = 62;
            this.label174.Text = "XCO2 = 4.3619 for OIL";
            // 
            // label175
            // 
            this.label175.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label175.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label175.Location = new System.Drawing.Point(492, 97);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(156, 15);
            this.label175.TabIndex = 61;
            this.label175.Text = "XCO2 = 3.3707 for GAS";
            // 
            // textBox140
            // 
            this.textBox140.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox140.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox140.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox140.ForeColor = System.Drawing.Color.White;
            this.textBox140.Location = new System.Drawing.Point(24, 65);
            this.textBox140.Name = "textBox140";
            this.textBox140.ReadOnly = true;
            this.textBox140.Size = new System.Drawing.Size(419, 22);
            this.textBox140.TabIndex = 60;
            this.textBox140.Text = "E = ((20.9 - 15) * NOx) / (20.9 - O2)";
            this.textBox140.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabNOxppmvdF1Calculate
            // 
            this.buttonTabNOxppmvdF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabNOxppmvdF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabNOxppmvdF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabNOxppmvdF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabNOxppmvdF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabNOxppmvdF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabNOxppmvdF1Calculate.Location = new System.Drawing.Point(368, 178);
            this.buttonTabNOxppmvdF1Calculate.Name = "buttonTabNOxppmvdF1Calculate";
            this.buttonTabNOxppmvdF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabNOxppmvdF1Calculate.TabIndex = 182;
            this.buttonTabNOxppmvdF1Calculate.Text = "Calculate";
            this.buttonTabNOxppmvdF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabNOxppmvdF1Calculate.Click += new System.EventHandler(this.buttonTabNOxppmvdF1Calculate_Click);
            // 
            // label176
            // 
            this.label176.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label176.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label176.Location = new System.Drawing.Point(242, 152);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(92, 20);
            this.label176.TabIndex = 58;
            this.label176.Text = "NOx ppmvd =";
            // 
            // textBoxTabNOxppmvdF1Answer
            // 
            this.textBoxTabNOxppmvdF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxppmvdF1Answer.Location = new System.Drawing.Point(343, 150);
            this.textBoxTabNOxppmvdF1Answer.Name = "textBoxTabNOxppmvdF1Answer";
            this.textBoxTabNOxppmvdF1Answer.ReadOnly = true;
            this.textBoxTabNOxppmvdF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxppmvdF1Answer.TabIndex = 57;
            this.textBoxTabNOxppmvdF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxppmvdF1O2
            // 
            this.textBoxTabNOxppmvdF1O2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxppmvdF1O2.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabNOxppmvdF1O2.Name = "textBoxTabNOxppmvdF1O2";
            this.textBoxTabNOxppmvdF1O2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxppmvdF1O2.TabIndex = 181;
            this.textBoxTabNOxppmvdF1O2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabNOxppmvdF1NOx
            // 
            this.textBoxTabNOxppmvdF1NOx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabNOxppmvdF1NOx.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabNOxppmvdF1NOx.Name = "textBoxTabNOxppmvdF1NOx";
            this.textBoxTabNOxppmvdF1NOx.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabNOxppmvdF1NOx.TabIndex = 180;
            this.textBoxTabNOxppmvdF1NOx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label177
            // 
            this.label177.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label177.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label177.Location = new System.Drawing.Point(276, 124);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(58, 18);
            this.label177.TabIndex = 54;
            this.label177.Text = "O2 (%)  =";
            // 
            // label178
            // 
            this.label178.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label178.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label178.Location = new System.Drawing.Point(257, 97);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(80, 19);
            this.label178.TabIndex = 53;
            this.label178.Text = "NOx (ppm) =";
            // 
            // tabFuelFactor
            // 
            this.tabFuelFactor.BackColor = System.Drawing.Color.Ivory;
            this.tabFuelFactor.Controls.Add(this.buttonTabFuelFactorF1Clear);
            this.tabFuelFactor.Controls.Add(this.textBox22);
            this.tabFuelFactor.Controls.Add(this.textBox151);
            this.tabFuelFactor.Controls.Add(this.buttonTabFuelFactorF1Calculate);
            this.tabFuelFactor.Controls.Add(this.label190);
            this.tabFuelFactor.Controls.Add(this.textBoxTabFuelFactorF1Answer);
            this.tabFuelFactor.Controls.Add(this.textBoxTabFuelFactorF1HTIPGas);
            this.tabFuelFactor.Controls.Add(this.textBoxTabFuelFactorF1HTIPOil);
            this.tabFuelFactor.Controls.Add(this.label191);
            this.tabFuelFactor.Controls.Add(this.label192);
            this.tabFuelFactor.Controls.Add(this.label194);
            this.tabFuelFactor.Controls.Add(this.label203);
            this.tabFuelFactor.Location = new System.Drawing.Point(4, 24);
            this.tabFuelFactor.Name = "tabFuelFactor";
            this.tabFuelFactor.Size = new System.Drawing.Size(939, 514);
            this.tabFuelFactor.TabIndex = 13;
            this.tabFuelFactor.Text = "Fuel Factor";
            // 
            // buttonTabFuelFactorF1Clear
            // 
            this.buttonTabFuelFactorF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabFuelFactorF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabFuelFactorF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabFuelFactorF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabFuelFactorF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabFuelFactorF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabFuelFactorF1Clear.Location = new System.Drawing.Point(256, 179);
            this.buttonTabFuelFactorF1Clear.Name = "buttonTabFuelFactorF1Clear";
            this.buttonTabFuelFactorF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabFuelFactorF1Clear.TabIndex = 193;
            this.buttonTabFuelFactorF1Clear.Text = "Clear";
            this.buttonTabFuelFactorF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabFuelFactorF1Clear.Click += new System.EventHandler(this.buttonTabFuelFactorF1Clear_Click);
            // 
            // textBox22
            // 
            this.textBox22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox22.BackColor = System.Drawing.Color.Blue;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.ForeColor = System.Drawing.Color.White;
            this.textBox22.Location = new System.Drawing.Point(6, 7);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(927, 29);
            this.textBox22.TabIndex = 79;
            this.textBox22.Text = "Calculate the Apportionment of Heat Input ";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox151
            // 
            this.textBox151.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox151.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox151.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox151.ForeColor = System.Drawing.Color.White;
            this.textBox151.Location = new System.Drawing.Point(24, 65);
            this.textBox151.Name = "textBox151";
            this.textBox151.ReadOnly = true;
            this.textBox151.Size = new System.Drawing.Size(419, 22);
            this.textBox151.TabIndex = 60;
            this.textBox151.Text = "E = (HI_OIL * 1420 + HI_GAS * 1040) / (HI_GAS + HI_OIL)  Formula F-8";
            this.textBox151.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabFuelFactorF1Calculate
            // 
            this.buttonTabFuelFactorF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabFuelFactorF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabFuelFactorF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabFuelFactorF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabFuelFactorF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabFuelFactorF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabFuelFactorF1Calculate.Location = new System.Drawing.Point(368, 179);
            this.buttonTabFuelFactorF1Calculate.Name = "buttonTabFuelFactorF1Calculate";
            this.buttonTabFuelFactorF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabFuelFactorF1Calculate.TabIndex = 192;
            this.buttonTabFuelFactorF1Calculate.Text = "Calculate";
            this.buttonTabFuelFactorF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabFuelFactorF1Calculate.Click += new System.EventHandler(this.buttonTabFuelFactorF1Calculate_Click);
            // 
            // label190
            // 
            this.label190.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label190.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label190.Location = new System.Drawing.Point(158, 153);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(179, 20);
            this.label190.TabIndex = 58;
            this.label190.Text = " Apportioned Fuel Factor = ";
            // 
            // textBoxTabFuelFactorF1Answer
            // 
            this.textBoxTabFuelFactorF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabFuelFactorF1Answer.Location = new System.Drawing.Point(343, 151);
            this.textBoxTabFuelFactorF1Answer.Name = "textBoxTabFuelFactorF1Answer";
            this.textBoxTabFuelFactorF1Answer.ReadOnly = true;
            this.textBoxTabFuelFactorF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabFuelFactorF1Answer.TabIndex = 57;
            this.textBoxTabFuelFactorF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabFuelFactorF1HTIPGas
            // 
            this.textBoxTabFuelFactorF1HTIPGas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabFuelFactorF1HTIPGas.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabFuelFactorF1HTIPGas.Name = "textBoxTabFuelFactorF1HTIPGas";
            this.textBoxTabFuelFactorF1HTIPGas.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabFuelFactorF1HTIPGas.TabIndex = 191;
            this.textBoxTabFuelFactorF1HTIPGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabFuelFactorF1HTIPOil
            // 
            this.textBoxTabFuelFactorF1HTIPOil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabFuelFactorF1HTIPOil.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabFuelFactorF1HTIPOil.Name = "textBoxTabFuelFactorF1HTIPOil";
            this.textBoxTabFuelFactorF1HTIPOil.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabFuelFactorF1HTIPOil.TabIndex = 190;
            this.textBoxTabFuelFactorF1HTIPOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label191
            // 
            this.label191.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label191.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label191.Location = new System.Drawing.Point(221, 124);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(116, 18);
            this.label191.TabIndex = 54;
            this.label191.Text = "Heat Input of GAS = ";
            // 
            // label192
            // 
            this.label192.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label192.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label192.Location = new System.Drawing.Point(226, 97);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(111, 19);
            this.label192.TabIndex = 53;
            this.label192.Text = "Heat Input of OIL = ";
            // 
            // label194
            // 
            this.label194.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label194.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label194.Location = new System.Drawing.Point(24, 117);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(194, 19);
            this.label194.TabIndex = 51;
            this.label194.Text = "HI_GAS - Heat Input GAS mmBtu";
            // 
            // label203
            // 
            this.label203.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label203.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label203.Location = new System.Drawing.Point(24, 97);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(185, 20);
            this.label203.TabIndex = 50;
            this.label203.Text = "HI_OIL - Heat Input OIL mmBtu";
            // 
            // tabCoal
            // 
            this.tabCoal.BackColor = System.Drawing.Color.Ivory;
            this.tabCoal.Controls.Add(this.buttonTabCoalF3Clear);
            this.tabCoal.Controls.Add(this.buttonTabCoalF4Clear);
            this.tabCoal.Controls.Add(this.buttonTabCoalF2Clear);
            this.tabCoal.Controls.Add(this.buttonTabCoalF1Clear);
            this.tabCoal.Controls.Add(this.label161);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF4BAF);
            this.tabCoal.Controls.Add(this.label123);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF4Fc);
            this.tabCoal.Controls.Add(this.buttonTabCoalF4Calculate);
            this.tabCoal.Controls.Add(this.label125);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF4Answer);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF4CO2);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF4NOx);
            this.tabCoal.Controls.Add(this.label159);
            this.tabCoal.Controls.Add(this.label160);
            this.tabCoal.Controls.Add(this.label158);
            this.tabCoal.Controls.Add(this.label157);
            this.tabCoal.Controls.Add(this.label156);
            this.tabCoal.Controls.Add(this.label135);
            this.tabCoal.Controls.Add(this.label145);
            this.tabCoal.Controls.Add(this.label133);
            this.tabCoal.Controls.Add(this.label136);
            this.tabCoal.Controls.Add(this.textBox73);
            this.tabCoal.Controls.Add(this.label137);
            this.tabCoal.Controls.Add(this.textBox81);
            this.tabCoal.Controls.Add(this.buttonTabCoalF3Calculate);
            this.tabCoal.Controls.Add(this.label139);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF3Answer);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF3FuelFlow);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF3CO2Concentration);
            this.tabCoal.Controls.Add(this.label141);
            this.tabCoal.Controls.Add(this.label142);
            this.tabCoal.Controls.Add(this.buttonTabCoalF2Calculate);
            this.tabCoal.Controls.Add(this.label130);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF2Answer);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF2FuelFlow);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF2SO2Concentration);
            this.tabCoal.Controls.Add(this.label131);
            this.tabCoal.Controls.Add(this.label132);
            this.tabCoal.Controls.Add(this.label138);
            this.tabCoal.Controls.Add(this.label140);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF1FuelFactor);
            this.tabCoal.Controls.Add(this.label143);
            this.tabCoal.Controls.Add(this.label144);
            this.tabCoal.Controls.Add(this.textBox100);
            this.tabCoal.Controls.Add(this.textBox101);
            this.tabCoal.Controls.Add(this.label151);
            this.tabCoal.Controls.Add(this.textBox102);
            this.tabCoal.Controls.Add(this.buttonTabCoalF1Calculate);
            this.tabCoal.Controls.Add(this.label152);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF1Answer);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF1CO2Concentration);
            this.tabCoal.Controls.Add(this.textBoxTabCoalF1FuelFlow);
            this.tabCoal.Controls.Add(this.label153);
            this.tabCoal.Controls.Add(this.label154);
            this.tabCoal.Controls.Add(this.label155);
            this.tabCoal.Location = new System.Drawing.Point(4, 24);
            this.tabCoal.Name = "tabCoal";
            this.tabCoal.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoal.Size = new System.Drawing.Size(939, 514);
            this.tabCoal.TabIndex = 14;
            this.tabCoal.Text = "Coal Sites";
            // 
            // buttonTabCoalF3Clear
            // 
            this.buttonTabCoalF3Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCoalF3Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCoalF3Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCoalF3Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCoalF3Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCoalF3Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCoalF3Clear.Location = new System.Drawing.Point(256, 379);
            this.buttonTabCoalF3Clear.Name = "buttonTabCoalF3Clear";
            this.buttonTabCoalF3Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCoalF3Clear.TabIndex = 205;
            this.buttonTabCoalF3Clear.Text = "Clear";
            this.buttonTabCoalF3Clear.UseVisualStyleBackColor = false;
            this.buttonTabCoalF3Clear.Click += new System.EventHandler(this.buttonTabCoalF3Clear_Click);
            // 
            // buttonTabCoalF4Clear
            // 
            this.buttonTabCoalF4Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCoalF4Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCoalF4Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCoalF4Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCoalF4Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCoalF4Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCoalF4Clear.Location = new System.Drawing.Point(729, 433);
            this.buttonTabCoalF4Clear.Name = "buttonTabCoalF4Clear";
            this.buttonTabCoalF4Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCoalF4Clear.TabIndex = 211;
            this.buttonTabCoalF4Clear.Text = "Clear";
            this.buttonTabCoalF4Clear.UseVisualStyleBackColor = false;
            this.buttonTabCoalF4Clear.Click += new System.EventHandler(this.buttonTabCoalF4Clear_Click);
            // 
            // buttonTabCoalF2Clear
            // 
            this.buttonTabCoalF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCoalF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCoalF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCoalF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCoalF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCoalF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCoalF2Clear.Location = new System.Drawing.Point(727, 178);
            this.buttonTabCoalF2Clear.Name = "buttonTabCoalF2Clear";
            this.buttonTabCoalF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCoalF2Clear.TabIndex = 171;
            this.buttonTabCoalF2Clear.Text = "Clear";
            this.buttonTabCoalF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabCoalF2Clear.Click += new System.EventHandler(this.buttonTabCoalF2Clear_Click);
            // 
            // buttonTabCoalF1Clear
            // 
            this.buttonTabCoalF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCoalF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCoalF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCoalF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCoalF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCoalF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCoalF1Clear.Location = new System.Drawing.Point(255, 205);
            this.buttonTabCoalF1Clear.Name = "buttonTabCoalF1Clear";
            this.buttonTabCoalF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCoalF1Clear.TabIndex = 198;
            this.buttonTabCoalF1Clear.Text = "Clear";
            this.buttonTabCoalF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabCoalF1Clear.Click += new System.EventHandler(this.buttonTabCoalF1Clear_Click);
            // 
            // label161
            // 
            this.label161.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label161.Location = new System.Drawing.Point(730, 381);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(79, 18);
            this.label161.TabIndex = 169;
            this.label161.Text = "NOx B.A.F. =";
            // 
            // textBoxTabCoalF4BAF
            // 
            this.textBoxTabCoalF4BAF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF4BAF.Location = new System.Drawing.Point(814, 378);
            this.textBoxTabCoalF4BAF.Name = "textBoxTabCoalF4BAF";
            this.textBoxTabCoalF4BAF.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF4BAF.TabIndex = 209;
            this.textBoxTabCoalF4BAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label123
            // 
            this.label123.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123.Location = new System.Drawing.Point(727, 354);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(79, 18);
            this.label123.TabIndex = 167;
            this.label123.Text = "Fuel Factor = ";
            // 
            // textBoxTabCoalF4Fc
            // 
            this.textBoxTabCoalF4Fc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF4Fc.Location = new System.Drawing.Point(814, 351);
            this.textBoxTabCoalF4Fc.Name = "textBoxTabCoalF4Fc";
            this.textBoxTabCoalF4Fc.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF4Fc.TabIndex = 208;
            this.textBoxTabCoalF4Fc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonTabCoalF4Calculate
            // 
            this.buttonTabCoalF4Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCoalF4Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCoalF4Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCoalF4Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCoalF4Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCoalF4Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCoalF4Calculate.Location = new System.Drawing.Point(839, 433);
            this.buttonTabCoalF4Calculate.Name = "buttonTabCoalF4Calculate";
            this.buttonTabCoalF4Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCoalF4Calculate.TabIndex = 210;
            this.buttonTabCoalF4Calculate.Text = "Calculate";
            this.buttonTabCoalF4Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCoalF4Calculate.Click += new System.EventHandler(this.buttonTabCoalF4Calculate_Click);
            // 
            // label125
            // 
            this.label125.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label125.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label125.Location = new System.Drawing.Point(688, 407);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(120, 20);
            this.label125.TabIndex = 164;
            this.label125.Text = "NOx lbs/mmBtu =";
            // 
            // textBoxTabCoalF4Answer
            // 
            this.textBoxTabCoalF4Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF4Answer.Location = new System.Drawing.Point(814, 405);
            this.textBoxTabCoalF4Answer.Name = "textBoxTabCoalF4Answer";
            this.textBoxTabCoalF4Answer.ReadOnly = true;
            this.textBoxTabCoalF4Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF4Answer.TabIndex = 163;
            this.textBoxTabCoalF4Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCoalF4CO2
            // 
            this.textBoxTabCoalF4CO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF4CO2.Location = new System.Drawing.Point(814, 324);
            this.textBoxTabCoalF4CO2.Name = "textBoxTabCoalF4CO2";
            this.textBoxTabCoalF4CO2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF4CO2.TabIndex = 207;
            this.textBoxTabCoalF4CO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCoalF4NOx
            // 
            this.textBoxTabCoalF4NOx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF4NOx.Location = new System.Drawing.Point(814, 296);
            this.textBoxTabCoalF4NOx.Name = "textBoxTabCoalF4NOx";
            this.textBoxTabCoalF4NOx.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF4NOx.TabIndex = 206;
            this.textBoxTabCoalF4NOx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label159
            // 
            this.label159.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label159.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label159.Location = new System.Drawing.Point(742, 326);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(73, 18);
            this.label159.TabIndex = 160;
            this.label159.Text = "CO2 (%) =";
            // 
            // label160
            // 
            this.label160.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label160.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label160.Location = new System.Drawing.Point(728, 298);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(80, 19);
            this.label160.TabIndex = 159;
            this.label160.Text = "NOx (ppm) =";
            // 
            // label158
            // 
            this.label158.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label158.Location = new System.Drawing.Point(495, 400);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(168, 39);
            this.label158.TabIndex = 158;
            this.label158.Text = "B.A.F. - NOx Bias Adjustment Factor";
            // 
            // label157
            // 
            this.label157.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label157.Location = new System.Drawing.Point(495, 379);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(79, 15);
            this.label157.TabIndex = 157;
            this.label157.Text = "CO2 - % CO2";
            // 
            // label156
            // 
            this.label156.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label156.Location = new System.Drawing.Point(495, 358);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(135, 15);
            this.label156.TabIndex = 156;
            this.label156.Text = "Fc - Fuel Factor for CO2";
            // 
            // label135
            // 
            this.label135.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label135.Location = new System.Drawing.Point(495, 338);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(77, 15);
            this.label135.TabIndex = 155;
            this.label135.Text = "C - NOx ppm";
            // 
            // label145
            // 
            this.label145.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label145.Location = new System.Drawing.Point(24, 321);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(123, 15);
            this.label145.TabIndex = 154;
            this.label145.Text = "FF - Fuel Flow (kscfh)";
            // 
            // label133
            // 
            this.label133.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label133.Location = new System.Drawing.Point(495, 318);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(188, 15);
            this.label133.TabIndex = 151;
            this.label133.Text = "K - 1.194 X 10E-7 (lbs / scf) / ppm";
            // 
            // label136
            // 
            this.label136.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label136.Location = new System.Drawing.Point(24, 299);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(166, 15);
            this.label136.TabIndex = 148;
            this.label136.Text = "CO2 - CO2 Concentration (%)";
            // 
            // textBox73
            // 
            this.textBox73.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox73.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox73.ForeColor = System.Drawing.Color.White;
            this.textBox73.Location = new System.Drawing.Point(495, 266);
            this.textBox73.Name = "textBox73";
            this.textBox73.ReadOnly = true;
            this.textBox73.Size = new System.Drawing.Size(419, 22);
            this.textBox73.TabIndex = 147;
            this.textBox73.Text = "NOx lbs/mmBtu - E = K x C x Fc (100 / CO2) x B.A.F.              Formula F-6";
            this.textBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label137
            // 
            this.label137.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label137.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label137.Location = new System.Drawing.Point(495, 298);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(189, 20);
            this.label137.TabIndex = 146;
            this.label137.Text = "E - NOx lbs/mmBtu";
            // 
            // textBox81
            // 
            this.textBox81.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox81.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox81.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox81.ForeColor = System.Drawing.Color.White;
            this.textBox81.Location = new System.Drawing.Point(27, 266);
            this.textBox81.Name = "textBox81";
            this.textBox81.ReadOnly = true;
            this.textBox81.Size = new System.Drawing.Size(419, 22);
            this.textBox81.TabIndex = 145;
            this.textBox81.Text = "CO2 tons/hr - E = (5.7 / 10000000) x CO2 x FF x 1000      Formula F-11";
            this.textBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCoalF3Calculate
            // 
            this.buttonTabCoalF3Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCoalF3Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCoalF3Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCoalF3Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCoalF3Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCoalF3Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCoalF3Calculate.Location = new System.Drawing.Point(371, 379);
            this.buttonTabCoalF3Calculate.Name = "buttonTabCoalF3Calculate";
            this.buttonTabCoalF3Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCoalF3Calculate.TabIndex = 204;
            this.buttonTabCoalF3Calculate.Text = "Calculate";
            this.buttonTabCoalF3Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCoalF3Calculate.Click += new System.EventHandler(this.buttonTabCoalF3Calculate_Click);
            // 
            // label139
            // 
            this.label139.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label139.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label139.Location = new System.Drawing.Point(236, 353);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(105, 20);
            this.label139.TabIndex = 143;
            this.label139.Text = " CO2 tons/hr = ";
            // 
            // textBoxTabCoalF3Answer
            // 
            this.textBoxTabCoalF3Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF3Answer.Location = new System.Drawing.Point(346, 351);
            this.textBoxTabCoalF3Answer.Name = "textBoxTabCoalF3Answer";
            this.textBoxTabCoalF3Answer.ReadOnly = true;
            this.textBoxTabCoalF3Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF3Answer.TabIndex = 142;
            this.textBoxTabCoalF3Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCoalF3FuelFlow
            // 
            this.textBoxTabCoalF3FuelFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF3FuelFlow.Location = new System.Drawing.Point(346, 324);
            this.textBoxTabCoalF3FuelFlow.Name = "textBoxTabCoalF3FuelFlow";
            this.textBoxTabCoalF3FuelFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF3FuelFlow.TabIndex = 203;
            this.textBoxTabCoalF3FuelFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCoalF3CO2Concentration
            // 
            this.textBoxTabCoalF3CO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF3CO2Concentration.Location = new System.Drawing.Point(346, 296);
            this.textBoxTabCoalF3CO2Concentration.Name = "textBoxTabCoalF3CO2Concentration";
            this.textBoxTabCoalF3CO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF3CO2Concentration.TabIndex = 202;
            this.textBoxTabCoalF3CO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label141
            // 
            this.label141.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label141.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label141.Location = new System.Drawing.Point(214, 299);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(127, 18);
            this.label141.TabIndex = 139;
            this.label141.Text = "CO2 Concentration = ";
            // 
            // label142
            // 
            this.label142.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label142.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label142.Location = new System.Drawing.Point(264, 327);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(76, 19);
            this.label142.TabIndex = 138;
            this.label142.Text = "Fuel Flow = ";
            // 
            // buttonTabCoalF2Calculate
            // 
            this.buttonTabCoalF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCoalF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCoalF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCoalF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCoalF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCoalF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCoalF2Calculate.Location = new System.Drawing.Point(836, 178);
            this.buttonTabCoalF2Calculate.Name = "buttonTabCoalF2Calculate";
            this.buttonTabCoalF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCoalF2Calculate.TabIndex = 201;
            this.buttonTabCoalF2Calculate.Text = "Calculate";
            this.buttonTabCoalF2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCoalF2Calculate.Click += new System.EventHandler(this.buttonTabCoalF2Calculate_Click);
            // 
            // label130
            // 
            this.label130.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label130.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label130.Location = new System.Drawing.Point(651, 152);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(154, 20);
            this.label130.TabIndex = 135;
            this.label130.Text = "Mass Em. SO2 lbs/hr = ";
            // 
            // textBoxTabCoalF2Answer
            // 
            this.textBoxTabCoalF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF2Answer.Location = new System.Drawing.Point(811, 150);
            this.textBoxTabCoalF2Answer.Name = "textBoxTabCoalF2Answer";
            this.textBoxTabCoalF2Answer.ReadOnly = true;
            this.textBoxTabCoalF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF2Answer.TabIndex = 134;
            this.textBoxTabCoalF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCoalF2FuelFlow
            // 
            this.textBoxTabCoalF2FuelFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF2FuelFlow.Location = new System.Drawing.Point(811, 123);
            this.textBoxTabCoalF2FuelFlow.Name = "textBoxTabCoalF2FuelFlow";
            this.textBoxTabCoalF2FuelFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF2FuelFlow.TabIndex = 200;
            this.textBoxTabCoalF2FuelFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCoalF2SO2Concentration
            // 
            this.textBoxTabCoalF2SO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF2SO2Concentration.Location = new System.Drawing.Point(811, 95);
            this.textBoxTabCoalF2SO2Concentration.Name = "textBoxTabCoalF2SO2Concentration";
            this.textBoxTabCoalF2SO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF2SO2Concentration.TabIndex = 199;
            this.textBoxTabCoalF2SO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label131
            // 
            this.label131.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label131.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label131.Location = new System.Drawing.Point(734, 125);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(71, 18);
            this.label131.TabIndex = 131;
            this.label131.Text = "Fuel Flow = ";
            // 
            // label132
            // 
            this.label132.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label132.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label132.Location = new System.Drawing.Point(685, 97);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(120, 19);
            this.label132.TabIndex = 130;
            this.label132.Text = "SO2 Concentration = ";
            // 
            // label138
            // 
            this.label138.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label138.Location = new System.Drawing.Point(492, 117);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(123, 15);
            this.label138.TabIndex = 125;
            this.label138.Text = "FF - Fuel Flow (kscfh)";
            // 
            // label140
            // 
            this.label140.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label140.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label140.Location = new System.Drawing.Point(254, 153);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(79, 18);
            this.label140.TabIndex = 122;
            this.label140.Text = "Fuel Factor = ";
            // 
            // textBoxTabCoalF1FuelFactor
            // 
            this.textBoxTabCoalF1FuelFactor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF1FuelFactor.Location = new System.Drawing.Point(343, 150);
            this.textBoxTabCoalF1FuelFactor.Name = "textBoxTabCoalF1FuelFactor";
            this.textBoxTabCoalF1FuelFactor.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF1FuelFactor.TabIndex = 196;
            this.textBoxTabCoalF1FuelFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label143
            // 
            this.label143.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label143.Location = new System.Drawing.Point(24, 138);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(94, 15);
            this.label143.TabIndex = 118;
            this.label143.Text = "Fc - Fuel Factor ";
            // 
            // label144
            // 
            this.label144.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label144.Location = new System.Drawing.Point(24, 117);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(166, 15);
            this.label144.TabIndex = 117;
            this.label144.Text = "CO2 - CO2 Concentration (%)";
            // 
            // textBox100
            // 
            this.textBox100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox100.BackColor = System.Drawing.Color.Blue;
            this.textBox100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox100.ForeColor = System.Drawing.Color.White;
            this.textBox100.Location = new System.Drawing.Point(6, 7);
            this.textBox100.Name = "textBox100";
            this.textBox100.ReadOnly = true;
            this.textBox100.Size = new System.Drawing.Size(927, 29);
            this.textBox100.TabIndex = 116;
            this.textBox100.Text = "Coal Sites";
            this.textBox100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox101
            // 
            this.textBox101.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox101.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox101.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox101.ForeColor = System.Drawing.Color.White;
            this.textBox101.Location = new System.Drawing.Point(492, 65);
            this.textBox101.Name = "textBox101";
            this.textBox101.ReadOnly = true;
            this.textBox101.Size = new System.Drawing.Size(419, 22);
            this.textBox101.TabIndex = 115;
            this.textBox101.Text = "SO2 Mass Em. - E = 0.000000166 x SO2 x FF x 1000            Formula F-1";
            this.textBox101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label151
            // 
            this.label151.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label151.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label151.Location = new System.Drawing.Point(492, 97);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(189, 20);
            this.label151.TabIndex = 113;
            this.label151.Text = "SO2 - SO2 Concentration (ppm)";
            // 
            // textBox102
            // 
            this.textBox102.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox102.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox102.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox102.ForeColor = System.Drawing.Color.White;
            this.textBox102.Location = new System.Drawing.Point(24, 65);
            this.textBox102.Name = "textBox102";
            this.textBox102.ReadOnly = true;
            this.textBox102.Size = new System.Drawing.Size(419, 22);
            this.textBox102.TabIndex = 112;
            this.textBox102.Text = "Heat Input - E = (FF x 1000 x CO2) / (Fc x 100)     Formula F-15";
            this.textBox102.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCoalF1Calculate
            // 
            this.buttonTabCoalF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCoalF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCoalF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCoalF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCoalF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCoalF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCoalF1Calculate.Location = new System.Drawing.Point(368, 205);
            this.buttonTabCoalF1Calculate.Name = "buttonTabCoalF1Calculate";
            this.buttonTabCoalF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCoalF1Calculate.TabIndex = 197;
            this.buttonTabCoalF1Calculate.Text = "Calculate";
            this.buttonTabCoalF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCoalF1Calculate.Click += new System.EventHandler(this.buttonTabCoalF1Calculate_Click);
            // 
            // label152
            // 
            this.label152.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label152.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label152.Location = new System.Drawing.Point(225, 179);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(112, 20);
            this.label152.TabIndex = 110;
            this.label152.Text = " HTIP mm/Btu = ";
            // 
            // textBoxTabCoalF1Answer
            // 
            this.textBoxTabCoalF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF1Answer.Location = new System.Drawing.Point(343, 177);
            this.textBoxTabCoalF1Answer.Name = "textBoxTabCoalF1Answer";
            this.textBoxTabCoalF1Answer.ReadOnly = true;
            this.textBoxTabCoalF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF1Answer.TabIndex = 109;
            this.textBoxTabCoalF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCoalF1CO2Concentration
            // 
            this.textBoxTabCoalF1CO2Concentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF1CO2Concentration.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabCoalF1CO2Concentration.Name = "textBoxTabCoalF1CO2Concentration";
            this.textBoxTabCoalF1CO2Concentration.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF1CO2Concentration.TabIndex = 195;
            this.textBoxTabCoalF1CO2Concentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCoalF1FuelFlow
            // 
            this.textBoxTabCoalF1FuelFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCoalF1FuelFlow.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabCoalF1FuelFlow.Name = "textBoxTabCoalF1FuelFlow";
            this.textBoxTabCoalF1FuelFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCoalF1FuelFlow.TabIndex = 194;
            this.textBoxTabCoalF1FuelFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label153
            // 
            this.label153.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label153.Location = new System.Drawing.Point(212, 125);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(127, 18);
            this.label153.TabIndex = 106;
            this.label153.Text = "CO2 Concentration = ";
            // 
            // label154
            // 
            this.label154.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label154.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label154.Location = new System.Drawing.Point(261, 97);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(80, 19);
            this.label154.TabIndex = 105;
            this.label154.Text = "Fuel Flow = ";
            // 
            // label155
            // 
            this.label155.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label155.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label155.Location = new System.Drawing.Point(24, 97);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(173, 20);
            this.label155.TabIndex = 104;
            this.label155.Text = "FF - Fuel Flow (kscfh)";
            // 
            // tabColbsmmBtu
            // 
            this.tabColbsmmBtu.BackColor = System.Drawing.Color.Ivory;
            this.tabColbsmmBtu.Controls.Add(this.buttonCOlbsmmBtuF2Clear);
            this.tabColbsmmBtu.Controls.Add(this.buttonCOlbsmmBtuF1Clear);
            this.tabColbsmmBtu.Controls.Add(this.label168);
            this.tabColbsmmBtu.Controls.Add(this.textBoxTabCOlbsmmBtuF2FuelFactor);
            this.tabColbsmmBtu.Controls.Add(this.buttonCOlbsmmBtuF2Calculate);
            this.tabColbsmmBtu.Controls.Add(this.label169);
            this.tabColbsmmBtu.Controls.Add(this.textBoxTabCOlbsmmBtuF2Answer);
            this.tabColbsmmBtu.Controls.Add(this.textBoxTabCOlbsmmBtuF2O2);
            this.tabColbsmmBtu.Controls.Add(this.textBoxTabCOlbsmmBtuF2CO);
            this.tabColbsmmBtu.Controls.Add(this.label170);
            this.tabColbsmmBtu.Controls.Add(this.label171);
            this.tabColbsmmBtu.Controls.Add(this.label180);
            this.tabColbsmmBtu.Controls.Add(this.label181);
            this.tabColbsmmBtu.Controls.Add(this.label182);
            this.tabColbsmmBtu.Controls.Add(this.label183);
            this.tabColbsmmBtu.Controls.Add(this.label185);
            this.tabColbsmmBtu.Controls.Add(this.textBoxTabCOlbsmmBtuF1FuelFactor);
            this.tabColbsmmBtu.Controls.Add(this.label186);
            this.tabColbsmmBtu.Controls.Add(this.label187);
            this.tabColbsmmBtu.Controls.Add(this.label188);
            this.tabColbsmmBtu.Controls.Add(this.textBox134);
            this.tabColbsmmBtu.Controls.Add(this.textBox135);
            this.tabColbsmmBtu.Controls.Add(this.label189);
            this.tabColbsmmBtu.Controls.Add(this.textBox136);
            this.tabColbsmmBtu.Controls.Add(this.buttonCOlbsmmBtuF1Calculate);
            this.tabColbsmmBtu.Controls.Add(this.label193);
            this.tabColbsmmBtu.Controls.Add(this.textBoxTabCOlbsmmBtuF1Answer);
            this.tabColbsmmBtu.Controls.Add(this.textBoxTabCOlbsmmBtuF1CO2);
            this.tabColbsmmBtu.Controls.Add(this.textBoxTabCOlbsmmBtuF1CO);
            this.tabColbsmmBtu.Controls.Add(this.label199);
            this.tabColbsmmBtu.Controls.Add(this.label202);
            this.tabColbsmmBtu.Controls.Add(this.label204);
            this.tabColbsmmBtu.Location = new System.Drawing.Point(4, 24);
            this.tabColbsmmBtu.Name = "tabColbsmmBtu";
            this.tabColbsmmBtu.Padding = new System.Windows.Forms.Padding(3);
            this.tabColbsmmBtu.Size = new System.Drawing.Size(939, 514);
            this.tabColbsmmBtu.TabIndex = 15;
            this.tabColbsmmBtu.Text = "CO lbs/mmBtu";
            // 
            // buttonCOlbsmmBtuF2Clear
            // 
            this.buttonCOlbsmmBtuF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCOlbsmmBtuF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCOlbsmmBtuF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCOlbsmmBtuF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCOlbsmmBtuF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCOlbsmmBtuF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonCOlbsmmBtuF2Clear.Location = new System.Drawing.Point(718, 205);
            this.buttonCOlbsmmBtuF2Clear.Name = "buttonCOlbsmmBtuF2Clear";
            this.buttonCOlbsmmBtuF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonCOlbsmmBtuF2Clear.TabIndex = 221;
            this.buttonCOlbsmmBtuF2Clear.Text = "Clear";
            this.buttonCOlbsmmBtuF2Clear.UseVisualStyleBackColor = false;
            this.buttonCOlbsmmBtuF2Clear.Click += new System.EventHandler(this.buttonCOlbsmmBtuF2Clear_Click);
            // 
            // buttonCOlbsmmBtuF1Clear
            // 
            this.buttonCOlbsmmBtuF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCOlbsmmBtuF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCOlbsmmBtuF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCOlbsmmBtuF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCOlbsmmBtuF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCOlbsmmBtuF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonCOlbsmmBtuF1Clear.Location = new System.Drawing.Point(250, 205);
            this.buttonCOlbsmmBtuF1Clear.Name = "buttonCOlbsmmBtuF1Clear";
            this.buttonCOlbsmmBtuF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonCOlbsmmBtuF1Clear.TabIndex = 216;
            this.buttonCOlbsmmBtuF1Clear.Text = "Clear";
            this.buttonCOlbsmmBtuF1Clear.UseVisualStyleBackColor = false;
            this.buttonCOlbsmmBtuF1Clear.Click += new System.EventHandler(this.buttonCOlbsmmBtuF1Clear_Click);
            // 
            // label168
            // 
            this.label168.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label168.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label168.Location = new System.Drawing.Point(717, 153);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(79, 18);
            this.label168.TabIndex = 136;
            this.label168.Text = "Fuel Factor = ";
            // 
            // textBoxTabCOlbsmmBtuF2FuelFactor
            // 
            this.textBoxTabCOlbsmmBtuF2FuelFactor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbsmmBtuF2FuelFactor.Location = new System.Drawing.Point(811, 150);
            this.textBoxTabCOlbsmmBtuF2FuelFactor.Name = "textBoxTabCOlbsmmBtuF2FuelFactor";
            this.textBoxTabCOlbsmmBtuF2FuelFactor.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbsmmBtuF2FuelFactor.TabIndex = 219;
            this.textBoxTabCOlbsmmBtuF2FuelFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCOlbsmmBtuF2Calculate
            // 
            this.buttonCOlbsmmBtuF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCOlbsmmBtuF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCOlbsmmBtuF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCOlbsmmBtuF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCOlbsmmBtuF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCOlbsmmBtuF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonCOlbsmmBtuF2Calculate.Location = new System.Drawing.Point(836, 205);
            this.buttonCOlbsmmBtuF2Calculate.Name = "buttonCOlbsmmBtuF2Calculate";
            this.buttonCOlbsmmBtuF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonCOlbsmmBtuF2Calculate.TabIndex = 220;
            this.buttonCOlbsmmBtuF2Calculate.Text = "Calculate";
            this.buttonCOlbsmmBtuF2Calculate.UseVisualStyleBackColor = false;
            this.buttonCOlbsmmBtuF2Calculate.Click += new System.EventHandler(this.buttonCOlbsmmBtuF2Calculate_Click);
            // 
            // label169
            // 
            this.label169.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label169.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label169.Location = new System.Drawing.Point(685, 179);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(120, 20);
            this.label169.TabIndex = 133;
            this.label169.Text = "CO lbs/mmBtu =";
            // 
            // textBoxTabCOlbsmmBtuF2Answer
            // 
            this.textBoxTabCOlbsmmBtuF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbsmmBtuF2Answer.Location = new System.Drawing.Point(811, 177);
            this.textBoxTabCOlbsmmBtuF2Answer.Name = "textBoxTabCOlbsmmBtuF2Answer";
            this.textBoxTabCOlbsmmBtuF2Answer.ReadOnly = true;
            this.textBoxTabCOlbsmmBtuF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbsmmBtuF2Answer.TabIndex = 132;
            this.textBoxTabCOlbsmmBtuF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOlbsmmBtuF2O2
            // 
            this.textBoxTabCOlbsmmBtuF2O2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbsmmBtuF2O2.Location = new System.Drawing.Point(811, 123);
            this.textBoxTabCOlbsmmBtuF2O2.Name = "textBoxTabCOlbsmmBtuF2O2";
            this.textBoxTabCOlbsmmBtuF2O2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbsmmBtuF2O2.TabIndex = 218;
            this.textBoxTabCOlbsmmBtuF2O2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOlbsmmBtuF2CO
            // 
            this.textBoxTabCOlbsmmBtuF2CO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbsmmBtuF2CO.Location = new System.Drawing.Point(811, 95);
            this.textBoxTabCOlbsmmBtuF2CO.Name = "textBoxTabCOlbsmmBtuF2CO";
            this.textBoxTabCOlbsmmBtuF2CO.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbsmmBtuF2CO.TabIndex = 217;
            this.textBoxTabCOlbsmmBtuF2CO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label170
            // 
            this.label170.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label170.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label170.Location = new System.Drawing.Point(741, 125);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(55, 18);
            this.label170.TabIndex = 129;
            this.label170.Text = "O2 (%) =";
            // 
            // label171
            // 
            this.label171.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label171.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label171.Location = new System.Drawing.Point(726, 97);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(77, 19);
            this.label171.TabIndex = 128;
            this.label171.Text = "CO (ppm) =";
            // 
            // label180
            // 
            this.label180.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label180.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label180.Location = new System.Drawing.Point(492, 180);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(85, 19);
            this.label180.TabIndex = 126;
            this.label180.Text = "O2 - % O2";
            // 
            // label181
            // 
            this.label181.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label181.Location = new System.Drawing.Point(492, 158);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(127, 15);
            this.label181.TabIndex = 125;
            this.label181.Text = "Fc - Fuel Factor for O2";
            // 
            // label182
            // 
            this.label182.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label182.Location = new System.Drawing.Point(492, 138);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(77, 15);
            this.label182.TabIndex = 124;
            this.label182.Text = "C - CO ppm";
            // 
            // label183
            // 
            this.label183.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label183.Location = new System.Drawing.Point(492, 117);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(181, 15);
            this.label183.TabIndex = 123;
            this.label183.Text = "K - 7.263 X 10E-8 (lbs/scf) / ppm";
            // 
            // label185
            // 
            this.label185.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label185.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label185.Location = new System.Drawing.Point(250, 153);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(79, 18);
            this.label185.TabIndex = 120;
            this.label185.Text = "Fuel Factor = ";
            // 
            // textBoxTabCOlbsmmBtuF1FuelFactor
            // 
            this.textBoxTabCOlbsmmBtuF1FuelFactor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbsmmBtuF1FuelFactor.Location = new System.Drawing.Point(343, 150);
            this.textBoxTabCOlbsmmBtuF1FuelFactor.Name = "textBoxTabCOlbsmmBtuF1FuelFactor";
            this.textBoxTabCOlbsmmBtuF1FuelFactor.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbsmmBtuF1FuelFactor.TabIndex = 214;
            this.textBoxTabCOlbsmmBtuF1FuelFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label186
            // 
            this.label186.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label186.Location = new System.Drawing.Point(24, 158);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(79, 15);
            this.label186.TabIndex = 118;
            this.label186.Text = "CO2 - % CO2";
            // 
            // label187
            // 
            this.label187.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label187.Location = new System.Drawing.Point(24, 138);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(135, 15);
            this.label187.TabIndex = 117;
            this.label187.Text = "Fc - Fuel Factor for CO2";
            // 
            // label188
            // 
            this.label188.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label188.Location = new System.Drawing.Point(24, 117);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(200, 15);
            this.label188.TabIndex = 116;
            this.label188.Text = "K - 7.263 X 10E-8 (lbs/scf) / ppm";
            // 
            // textBox134
            // 
            this.textBox134.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox134.BackColor = System.Drawing.Color.Blue;
            this.textBox134.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox134.ForeColor = System.Drawing.Color.White;
            this.textBox134.Location = new System.Drawing.Point(6, 7);
            this.textBox134.Name = "textBox134";
            this.textBox134.ReadOnly = true;
            this.textBox134.Size = new System.Drawing.Size(927, 29);
            this.textBox134.TabIndex = 115;
            this.textBox134.Text = "Calculate CO Emission Rate (lbs/mmBtu)";
            this.textBox134.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox135
            // 
            this.textBox135.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox135.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox135.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox135.ForeColor = System.Drawing.Color.White;
            this.textBox135.Location = new System.Drawing.Point(492, 65);
            this.textBox135.Name = "textBox135";
            this.textBox135.ReadOnly = true;
            this.textBox135.Size = new System.Drawing.Size(419, 22);
            this.textBox135.TabIndex = 114;
            this.textBox135.Text = "E = K x C x Fc (20.9 / (20.9 - O2))";
            this.textBox135.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label189
            // 
            this.label189.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label189.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label189.Location = new System.Drawing.Point(492, 97);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(156, 15);
            this.label189.TabIndex = 113;
            this.label189.Text = "E - CO lbs/mmBtu";
            // 
            // textBox136
            // 
            this.textBox136.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox136.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox136.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox136.ForeColor = System.Drawing.Color.White;
            this.textBox136.Location = new System.Drawing.Point(24, 65);
            this.textBox136.Name = "textBox136";
            this.textBox136.ReadOnly = true;
            this.textBox136.Size = new System.Drawing.Size(419, 22);
            this.textBox136.TabIndex = 112;
            this.textBox136.Text = "E = K x C x Fc (100 / CO2)";
            this.textBox136.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCOlbsmmBtuF1Calculate
            // 
            this.buttonCOlbsmmBtuF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCOlbsmmBtuF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCOlbsmmBtuF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCOlbsmmBtuF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCOlbsmmBtuF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCOlbsmmBtuF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonCOlbsmmBtuF1Calculate.Location = new System.Drawing.Point(368, 205);
            this.buttonCOlbsmmBtuF1Calculate.Name = "buttonCOlbsmmBtuF1Calculate";
            this.buttonCOlbsmmBtuF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonCOlbsmmBtuF1Calculate.TabIndex = 215;
            this.buttonCOlbsmmBtuF1Calculate.Text = "Calculate";
            this.buttonCOlbsmmBtuF1Calculate.UseVisualStyleBackColor = false;
            this.buttonCOlbsmmBtuF1Calculate.Click += new System.EventHandler(this.buttonCOlbsmmBtuF1Calculate_Click);
            // 
            // label193
            // 
            this.label193.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label193.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label193.Location = new System.Drawing.Point(217, 179);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(120, 20);
            this.label193.TabIndex = 110;
            this.label193.Text = "CO lbs/mmBtu =";
            // 
            // textBoxTabCOlbsmmBtuF1Answer
            // 
            this.textBoxTabCOlbsmmBtuF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbsmmBtuF1Answer.Location = new System.Drawing.Point(343, 177);
            this.textBoxTabCOlbsmmBtuF1Answer.Name = "textBoxTabCOlbsmmBtuF1Answer";
            this.textBoxTabCOlbsmmBtuF1Answer.ReadOnly = true;
            this.textBoxTabCOlbsmmBtuF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbsmmBtuF1Answer.TabIndex = 109;
            this.textBoxTabCOlbsmmBtuF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOlbsmmBtuF1CO2
            // 
            this.textBoxTabCOlbsmmBtuF1CO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbsmmBtuF1CO2.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabCOlbsmmBtuF1CO2.Name = "textBoxTabCOlbsmmBtuF1CO2";
            this.textBoxTabCOlbsmmBtuF1CO2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbsmmBtuF1CO2.TabIndex = 213;
            this.textBoxTabCOlbsmmBtuF1CO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOlbsmmBtuF1CO
            // 
            this.textBoxTabCOlbsmmBtuF1CO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbsmmBtuF1CO.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabCOlbsmmBtuF1CO.Name = "textBoxTabCOlbsmmBtuF1CO";
            this.textBoxTabCOlbsmmBtuF1CO.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbsmmBtuF1CO.TabIndex = 212;
            this.textBoxTabCOlbsmmBtuF1CO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label199
            // 
            this.label199.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label199.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label199.Location = new System.Drawing.Point(265, 125);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(63, 18);
            this.label199.TabIndex = 106;
            this.label199.Text = "CO2 (%) =";
            // 
            // label202
            // 
            this.label202.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label202.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label202.Location = new System.Drawing.Point(259, 97);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(76, 19);
            this.label202.TabIndex = 105;
            this.label202.Text = "CO (ppm) =";
            // 
            // label204
            // 
            this.label204.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label204.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label204.Location = new System.Drawing.Point(24, 97);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(173, 20);
            this.label204.TabIndex = 104;
            this.label204.Text = "E - CO lbs/mmBtu";
            // 
            // tabCOlbshr
            // 
            this.tabCOlbshr.BackColor = System.Drawing.Color.Ivory;
            this.tabCOlbshr.Controls.Add(this.buttonTabCOlbshrF1Clear);
            this.tabCOlbshr.Controls.Add(this.textBox150);
            this.tabCOlbshr.Controls.Add(this.textBox156);
            this.tabCOlbshr.Controls.Add(this.buttonTabCOlbshrF1Calculate);
            this.tabCOlbshr.Controls.Add(this.label215);
            this.tabCOlbshr.Controls.Add(this.textBoxTabCOlbshrF1Answer);
            this.tabCOlbshr.Controls.Add(this.textBoxTabCOlbshrF1HTIP);
            this.tabCOlbshr.Controls.Add(this.textBoxTabCOlbshrF1CO);
            this.tabCOlbshr.Controls.Add(this.label216);
            this.tabCOlbshr.Controls.Add(this.label217);
            this.tabCOlbshr.Controls.Add(this.label218);
            this.tabCOlbshr.Controls.Add(this.label219);
            this.tabCOlbshr.Controls.Add(this.label220);
            this.tabCOlbshr.Location = new System.Drawing.Point(4, 24);
            this.tabCOlbshr.Name = "tabCOlbshr";
            this.tabCOlbshr.Padding = new System.Windows.Forms.Padding(3);
            this.tabCOlbshr.Size = new System.Drawing.Size(939, 514);
            this.tabCOlbshr.TabIndex = 16;
            this.tabCOlbshr.Text = "CO lbs/hr";
            // 
            // buttonTabCOlbshrF1Clear
            // 
            this.buttonTabCOlbshrF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCOlbshrF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCOlbshrF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCOlbshrF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCOlbshrF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCOlbshrF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCOlbshrF1Clear.Location = new System.Drawing.Point(257, 178);
            this.buttonTabCOlbshrF1Clear.Name = "buttonTabCOlbshrF1Clear";
            this.buttonTabCOlbshrF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCOlbshrF1Clear.TabIndex = 225;
            this.buttonTabCOlbshrF1Clear.Text = "Clear";
            this.buttonTabCOlbshrF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabCOlbshrF1Clear.Click += new System.EventHandler(this.buttonTabCOlbshrF1Clear_Click);
            // 
            // textBox150
            // 
            this.textBox150.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox150.BackColor = System.Drawing.Color.Blue;
            this.textBox150.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox150.ForeColor = System.Drawing.Color.White;
            this.textBox150.Location = new System.Drawing.Point(6, 7);
            this.textBox150.Name = "textBox150";
            this.textBox150.ReadOnly = true;
            this.textBox150.Size = new System.Drawing.Size(927, 29);
            this.textBox150.TabIndex = 112;
            this.textBox150.Text = "Calculate CO Mass Emission Rate (lbs/hr)";
            this.textBox150.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox156
            // 
            this.textBox156.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox156.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox156.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox156.ForeColor = System.Drawing.Color.White;
            this.textBox156.Location = new System.Drawing.Point(24, 65);
            this.textBox156.Name = "textBox156";
            this.textBox156.ReadOnly = true;
            this.textBox156.Size = new System.Drawing.Size(419, 22);
            this.textBox156.TabIndex = 110;
            this.textBox156.Text = "Mass CO = E(CO) x HI";
            this.textBox156.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCOlbshrF1Calculate
            // 
            this.buttonTabCOlbshrF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCOlbshrF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCOlbshrF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCOlbshrF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCOlbshrF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCOlbshrF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCOlbshrF1Calculate.Location = new System.Drawing.Point(368, 178);
            this.buttonTabCOlbshrF1Calculate.Name = "buttonTabCOlbshrF1Calculate";
            this.buttonTabCOlbshrF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCOlbshrF1Calculate.TabIndex = 224;
            this.buttonTabCOlbshrF1Calculate.Text = "Calculate";
            this.buttonTabCOlbshrF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCOlbshrF1Calculate.Click += new System.EventHandler(this.buttonTabCOlbshrF1Calculate_Click);
            // 
            // label215
            // 
            this.label215.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label215.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label215.Location = new System.Drawing.Point(255, 152);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(83, 20);
            this.label215.TabIndex = 108;
            this.label215.Text = "CO lbs/hr =";
            // 
            // textBoxTabCOlbshrF1Answer
            // 
            this.textBoxTabCOlbshrF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbshrF1Answer.Location = new System.Drawing.Point(343, 150);
            this.textBoxTabCOlbshrF1Answer.Name = "textBoxTabCOlbshrF1Answer";
            this.textBoxTabCOlbshrF1Answer.ReadOnly = true;
            this.textBoxTabCOlbshrF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbshrF1Answer.TabIndex = 107;
            this.textBoxTabCOlbshrF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOlbshrF1HTIP
            // 
            this.textBoxTabCOlbshrF1HTIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbshrF1HTIP.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabCOlbshrF1HTIP.Name = "textBoxTabCOlbshrF1HTIP";
            this.textBoxTabCOlbshrF1HTIP.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbshrF1HTIP.TabIndex = 223;
            this.textBoxTabCOlbshrF1HTIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOlbshrF1CO
            // 
            this.textBoxTabCOlbshrF1CO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOlbshrF1CO.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabCOlbshrF1CO.Name = "textBoxTabCOlbshrF1CO";
            this.textBoxTabCOlbshrF1CO.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOlbshrF1CO.TabIndex = 222;
            this.textBoxTabCOlbshrF1CO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label216
            // 
            this.label216.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label216.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label216.Location = new System.Drawing.Point(260, 125);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(83, 18);
            this.label216.TabIndex = 104;
            this.label216.Text = "Heat Input =";
            // 
            // label217
            // 
            this.label217.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label217.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label217.Location = new System.Drawing.Point(234, 97);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(107, 19);
            this.label217.TabIndex = 103;
            this.label217.Text = "CO (lb/mmBtu) =";
            // 
            // label218
            // 
            this.label218.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label218.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label218.Location = new System.Drawing.Point(24, 136);
            this.label218.Name = "label218";
            this.label218.Size = new System.Drawing.Size(211, 17);
            this.label218.TabIndex = 102;
            this.label218.Text = "HI - Heat Input Rate (mmBtu/hr)";
            // 
            // label219
            // 
            this.label219.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label219.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label219.Location = new System.Drawing.Point(24, 117);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(167, 19);
            this.label219.TabIndex = 101;
            this.label219.Text = "E(CO) - CO Rate (lbs/mmBtu)";
            // 
            // label220
            // 
            this.label220.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label220.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label220.Location = new System.Drawing.Point(24, 97);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(173, 20);
            this.label220.TabIndex = 100;
            this.label220.Text = "Mass CO - CO Mass lbs/hr";
            // 
            // tabCOppmvd
            // 
            this.tabCOppmvd.BackColor = System.Drawing.Color.Ivory;
            this.tabCOppmvd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCOppmvd.Controls.Add(this.buttonTabCOppmvdF2Clear);
            this.tabCOppmvd.Controls.Add(this.buttonTabCOppmvdF1Clear);
            this.tabCOppmvd.Controls.Add(this.comboBoxTabCOppmvdF2XCO2);
            this.tabCOppmvd.Controls.Add(this.label167);
            this.tabCOppmvd.Controls.Add(this.buttonTabCOppmvdF2Calculate);
            this.tabCOppmvd.Controls.Add(this.label179);
            this.tabCOppmvd.Controls.Add(this.textBoxTabCOppmvdF2Answer);
            this.tabCOppmvd.Controls.Add(this.textBoxTabCOppmvdF2CO2);
            this.tabCOppmvd.Controls.Add(this.textBoxTabCOppmvdF2CO);
            this.tabCOppmvd.Controls.Add(this.label184);
            this.tabCOppmvd.Controls.Add(this.label205);
            this.tabCOppmvd.Controls.Add(this.label209);
            this.tabCOppmvd.Controls.Add(this.textBox155);
            this.tabCOppmvd.Controls.Add(this.textBox160);
            this.tabCOppmvd.Controls.Add(this.label214);
            this.tabCOppmvd.Controls.Add(this.textBox161);
            this.tabCOppmvd.Controls.Add(this.buttonTabCOppmvdF1Calculate);
            this.tabCOppmvd.Controls.Add(this.label221);
            this.tabCOppmvd.Controls.Add(this.textBoxTabCOppmvdF1Answer);
            this.tabCOppmvd.Controls.Add(this.textBoxTabCOppmvdF1O2);
            this.tabCOppmvd.Controls.Add(this.textBoxTabCOppmvdF1CO);
            this.tabCOppmvd.Controls.Add(this.label222);
            this.tabCOppmvd.Controls.Add(this.label223);
            this.tabCOppmvd.Controls.Add(this.label224);
            this.tabCOppmvd.Location = new System.Drawing.Point(4, 24);
            this.tabCOppmvd.Name = "tabCOppmvd";
            this.tabCOppmvd.Padding = new System.Windows.Forms.Padding(3);
            this.tabCOppmvd.Size = new System.Drawing.Size(939, 514);
            this.tabCOppmvd.TabIndex = 17;
            this.tabCOppmvd.Text = "CO ppmvd";
            // 
            // buttonTabCOppmvdF2Clear
            // 
            this.buttonTabCOppmvdF2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCOppmvdF2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCOppmvdF2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCOppmvdF2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCOppmvdF2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCOppmvdF2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCOppmvdF2Clear.Location = new System.Drawing.Point(717, 206);
            this.buttonTabCOppmvdF2Clear.Name = "buttonTabCOppmvdF2Clear";
            this.buttonTabCOppmvdF2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCOppmvdF2Clear.TabIndex = 234;
            this.buttonTabCOppmvdF2Clear.Text = "Clear";
            this.buttonTabCOppmvdF2Clear.UseVisualStyleBackColor = false;
            this.buttonTabCOppmvdF2Clear.Click += new System.EventHandler(this.buttonTabCOppmvdF2Clear_Click);
            // 
            // buttonTabCOppmvdF1Clear
            // 
            this.buttonTabCOppmvdF1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCOppmvdF1Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCOppmvdF1Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabCOppmvdF1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCOppmvdF1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCOppmvdF1Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabCOppmvdF1Clear.Location = new System.Drawing.Point(256, 177);
            this.buttonTabCOppmvdF1Clear.Name = "buttonTabCOppmvdF1Clear";
            this.buttonTabCOppmvdF1Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCOppmvdF1Clear.TabIndex = 229;
            this.buttonTabCOppmvdF1Clear.Text = "Clear";
            this.buttonTabCOppmvdF1Clear.UseVisualStyleBackColor = false;
            this.buttonTabCOppmvdF1Clear.Click += new System.EventHandler(this.buttonTabCOppmvdF1Clear_Click);
            // 
            // comboBoxTabCOppmvdF2XCO2
            // 
            this.comboBoxTabCOppmvdF2XCO2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTabCOppmvdF2XCO2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTabCOppmvdF2XCO2.FormattingEnabled = true;
            this.comboBoxTabCOppmvdF2XCO2.Items.AddRange(new object[] {
            "SELECT XCO2",
            "3.3707",
            "4.3619"});
            this.comboBoxTabCOppmvdF2XCO2.Location = new System.Drawing.Point(811, 150);
            this.comboBoxTabCOppmvdF2XCO2.Name = "comboBoxTabCOppmvdF2XCO2";
            this.comboBoxTabCOppmvdF2XCO2.Size = new System.Drawing.Size(100, 23);
            this.comboBoxTabCOppmvdF2XCO2.TabIndex = 232;
            // 
            // label167
            // 
            this.label167.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label167.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label167.Location = new System.Drawing.Point(745, 153);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(53, 18);
            this.label167.TabIndex = 166;
            this.label167.Text = "XCO2 =";
            // 
            // buttonTabCOppmvdF2Calculate
            // 
            this.buttonTabCOppmvdF2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCOppmvdF2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCOppmvdF2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCOppmvdF2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCOppmvdF2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCOppmvdF2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCOppmvdF2Calculate.Location = new System.Drawing.Point(835, 206);
            this.buttonTabCOppmvdF2Calculate.Name = "buttonTabCOppmvdF2Calculate";
            this.buttonTabCOppmvdF2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCOppmvdF2Calculate.TabIndex = 233;
            this.buttonTabCOppmvdF2Calculate.Text = "Calculate";
            this.buttonTabCOppmvdF2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCOppmvdF2Calculate.Click += new System.EventHandler(this.buttonTabCOppmvdF2Calculate_Click);
            // 
            // label179
            // 
            this.label179.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label179.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label179.Location = new System.Drawing.Point(684, 180);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(120, 20);
            this.label179.TabIndex = 163;
            this.label179.Text = "CO lbs/mmBtu =";
            // 
            // textBoxTabCOppmvdF2Answer
            // 
            this.textBoxTabCOppmvdF2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOppmvdF2Answer.Location = new System.Drawing.Point(810, 178);
            this.textBoxTabCOppmvdF2Answer.Name = "textBoxTabCOppmvdF2Answer";
            this.textBoxTabCOppmvdF2Answer.ReadOnly = true;
            this.textBoxTabCOppmvdF2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOppmvdF2Answer.TabIndex = 162;
            this.textBoxTabCOppmvdF2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOppmvdF2CO2
            // 
            this.textBoxTabCOppmvdF2CO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOppmvdF2CO2.Location = new System.Drawing.Point(810, 122);
            this.textBoxTabCOppmvdF2CO2.Name = "textBoxTabCOppmvdF2CO2";
            this.textBoxTabCOppmvdF2CO2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOppmvdF2CO2.TabIndex = 231;
            this.textBoxTabCOppmvdF2CO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOppmvdF2CO
            // 
            this.textBoxTabCOppmvdF2CO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOppmvdF2CO.Location = new System.Drawing.Point(810, 94);
            this.textBoxTabCOppmvdF2CO.Name = "textBoxTabCOppmvdF2CO";
            this.textBoxTabCOppmvdF2CO.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOppmvdF2CO.TabIndex = 230;
            this.textBoxTabCOppmvdF2CO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label184
            // 
            this.label184.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label184.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label184.Location = new System.Drawing.Point(731, 124);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(67, 18);
            this.label184.TabIndex = 159;
            this.label184.Text = "CO2 (%) =";
            // 
            // label205
            // 
            this.label205.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label205.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label205.Location = new System.Drawing.Point(725, 96);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(77, 19);
            this.label205.TabIndex = 158;
            this.label205.Text = "CO (ppm) =";
            // 
            // label209
            // 
            this.label209.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label209.Location = new System.Drawing.Point(491, 116);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(182, 15);
            this.label209.TabIndex = 154;
            this.label209.Text = "XCO2 = 4.3619 for OIL";
            // 
            // textBox155
            // 
            this.textBox155.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox155.BackColor = System.Drawing.Color.Blue;
            this.textBox155.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox155.ForeColor = System.Drawing.Color.White;
            this.textBox155.Location = new System.Drawing.Point(5, 6);
            this.textBox155.Name = "textBox155";
            this.textBox155.ReadOnly = true;
            this.textBox155.Size = new System.Drawing.Size(927, 29);
            this.textBox155.TabIndex = 148;
            this.textBox155.Text = "Calculate CO ppmvd (Parts Per Million by Volume, Dry)";
            this.textBox155.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox160
            // 
            this.textBox160.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox160.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox160.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox160.ForeColor = System.Drawing.Color.White;
            this.textBox160.Location = new System.Drawing.Point(491, 64);
            this.textBox160.Name = "textBox160";
            this.textBox160.ReadOnly = true;
            this.textBox160.Size = new System.Drawing.Size(419, 22);
            this.textBox160.TabIndex = 147;
            this.textBox160.Text = "E = (CO * XCO2) / (CO2)";
            this.textBox160.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label214
            // 
            this.label214.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label214.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label214.Location = new System.Drawing.Point(491, 96);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(156, 15);
            this.label214.TabIndex = 146;
            this.label214.Text = "XCO2 = 3.3707 for GAS";
            // 
            // textBox161
            // 
            this.textBox161.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox161.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox161.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox161.ForeColor = System.Drawing.Color.White;
            this.textBox161.Location = new System.Drawing.Point(23, 64);
            this.textBox161.Name = "textBox161";
            this.textBox161.ReadOnly = true;
            this.textBox161.Size = new System.Drawing.Size(419, 22);
            this.textBox161.TabIndex = 145;
            this.textBox161.Text = "E = ((20.9 - 15) * CO) / (20.9 - O2)";
            this.textBox161.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabCOppmvdF1Calculate
            // 
            this.buttonTabCOppmvdF1Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabCOppmvdF1Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabCOppmvdF1Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabCOppmvdF1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCOppmvdF1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabCOppmvdF1Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabCOppmvdF1Calculate.Location = new System.Drawing.Point(367, 177);
            this.buttonTabCOppmvdF1Calculate.Name = "buttonTabCOppmvdF1Calculate";
            this.buttonTabCOppmvdF1Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabCOppmvdF1Calculate.TabIndex = 228;
            this.buttonTabCOppmvdF1Calculate.Text = "Calculate";
            this.buttonTabCOppmvdF1Calculate.UseVisualStyleBackColor = false;
            this.buttonTabCOppmvdF1Calculate.Click += new System.EventHandler(this.buttonTabCOppmvdF1Calculate_Click);
            // 
            // label221
            // 
            this.label221.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label221.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label221.Location = new System.Drawing.Point(250, 151);
            this.label221.Name = "label221";
            this.label221.Size = new System.Drawing.Size(86, 20);
            this.label221.TabIndex = 143;
            this.label221.Text = "CO ppmvd =";
            // 
            // textBoxTabCOppmvdF1Answer
            // 
            this.textBoxTabCOppmvdF1Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOppmvdF1Answer.Location = new System.Drawing.Point(342, 149);
            this.textBoxTabCOppmvdF1Answer.Name = "textBoxTabCOppmvdF1Answer";
            this.textBoxTabCOppmvdF1Answer.ReadOnly = true;
            this.textBoxTabCOppmvdF1Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOppmvdF1Answer.TabIndex = 142;
            this.textBoxTabCOppmvdF1Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOppmvdF1O2
            // 
            this.textBoxTabCOppmvdF1O2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOppmvdF1O2.Location = new System.Drawing.Point(342, 122);
            this.textBoxTabCOppmvdF1O2.Name = "textBoxTabCOppmvdF1O2";
            this.textBoxTabCOppmvdF1O2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOppmvdF1O2.TabIndex = 227;
            this.textBoxTabCOppmvdF1O2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabCOppmvdF1CO
            // 
            this.textBoxTabCOppmvdF1CO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabCOppmvdF1CO.Location = new System.Drawing.Point(342, 94);
            this.textBoxTabCOppmvdF1CO.Name = "textBoxTabCOppmvdF1CO";
            this.textBoxTabCOppmvdF1CO.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabCOppmvdF1CO.TabIndex = 226;
            this.textBoxTabCOppmvdF1CO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label222
            // 
            this.label222.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label222.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label222.Location = new System.Drawing.Point(279, 124);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(60, 18);
            this.label222.TabIndex = 139;
            this.label222.Text = "O2 (%) =";
            // 
            // label223
            // 
            this.label223.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label223.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label223.Location = new System.Drawing.Point(263, 96);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(78, 19);
            this.label223.TabIndex = 138;
            this.label223.Text = "CO (ppm) =";
            // 
            // label224
            // 
            this.label224.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label224.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label224.Location = new System.Drawing.Point(23, 96);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(173, 20);
            this.label224.TabIndex = 137;
            this.label224.Text = "Corrected to 15% Oxygen";
            // 
            // tabPage4_20ma
            // 
            this.tabPage4_20ma.BackColor = System.Drawing.Color.Ivory;
            this.tabPage4_20ma.Controls.Add(this.label226);
            this.tabPage4_20ma.Controls.Add(this.label225);
            this.tabPage4_20ma.Controls.Add(this.label206);
            this.tabPage4_20ma.Controls.Add(this.textBoxTab420LowScale);
            this.tabPage4_20ma.Controls.Add(this.textBoxTab420HighScale);
            this.tabPage4_20ma.Controls.Add(this.textBoxTab42020ma);
            this.tabPage4_20ma.Controls.Add(this.buttonTab420Clear);
            this.tabPage4_20ma.Controls.Add(this.textBox4);
            this.tabPage4_20ma.Controls.Add(this.textBox6);
            this.tabPage4_20ma.Controls.Add(this.buttonTab420Calculate);
            this.tabPage4_20ma.Controls.Add(this.label2);
            this.tabPage4_20ma.Controls.Add(this.textBoxTab420Answer);
            this.tabPage4_20ma.Controls.Add(this.textBoxTab4204ma);
            this.tabPage4_20ma.Controls.Add(this.textBoxTab420ActualCount);
            this.tabPage4_20ma.Controls.Add(this.label3);
            this.tabPage4_20ma.Controls.Add(this.label4);
            this.tabPage4_20ma.Location = new System.Drawing.Point(4, 24);
            this.tabPage4_20ma.Name = "tabPage4_20ma";
            this.tabPage4_20ma.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4_20ma.Size = new System.Drawing.Size(939, 514);
            this.tabPage4_20ma.TabIndex = 18;
            this.tabPage4_20ma.Text = "4-20ma";
            // 
            // label226
            // 
            this.label226.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label226.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label226.Location = new System.Drawing.Point(243, 208);
            this.label226.Name = "label226";
            this.label226.Size = new System.Drawing.Size(82, 18);
            this.label226.TabIndex = 250;
            this.label226.Text = "Low Scale =";
            // 
            // label225
            // 
            this.label225.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label225.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label225.Location = new System.Drawing.Point(240, 181);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(85, 18);
            this.label225.TabIndex = 249;
            this.label225.Text = "High Scale =";
            // 
            // label206
            // 
            this.label206.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label206.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label206.Location = new System.Drawing.Point(196, 154);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(129, 18);
            this.label206.TabIndex = 248;
            this.label206.Text = "High Count (20mA) =";
            // 
            // textBoxTab420LowScale
            // 
            this.textBoxTab420LowScale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTab420LowScale.Location = new System.Drawing.Point(336, 205);
            this.textBoxTab420LowScale.Name = "textBoxTab420LowScale";
            this.textBoxTab420LowScale.Size = new System.Drawing.Size(100, 21);
            this.textBoxTab420LowScale.TabIndex = 241;
            this.textBoxTab420LowScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTab420HighScale
            // 
            this.textBoxTab420HighScale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTab420HighScale.Location = new System.Drawing.Point(336, 178);
            this.textBoxTab420HighScale.Name = "textBoxTab420HighScale";
            this.textBoxTab420HighScale.Size = new System.Drawing.Size(100, 21);
            this.textBoxTab420HighScale.TabIndex = 240;
            this.textBoxTab420HighScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTab42020ma
            // 
            this.textBoxTab42020ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTab42020ma.Location = new System.Drawing.Point(336, 151);
            this.textBoxTab42020ma.Name = "textBoxTab42020ma";
            this.textBoxTab42020ma.Size = new System.Drawing.Size(100, 21);
            this.textBoxTab42020ma.TabIndex = 239;
            this.textBoxTab42020ma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonTab420Clear
            // 
            this.buttonTab420Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTab420Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTab420Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTab420Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTab420Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab420Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTab420Clear.Location = new System.Drawing.Point(250, 260);
            this.buttonTab420Clear.Name = "buttonTab420Clear";
            this.buttonTab420Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTab420Clear.TabIndex = 243;
            this.buttonTab420Clear.Text = "Clear";
            this.buttonTab420Clear.UseVisualStyleBackColor = false;
            this.buttonTab420Clear.Click += new System.EventHandler(this.buttonTab420Clear_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.Blue;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(-1, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(927, 29);
            this.textBox4.TabIndex = 236;
            this.textBox4.Text = "Calculate Output Reading for 4-20mA Loop";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(17, 65);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(425, 22);
            this.textBox6.TabIndex = 235;
            this.textBox6.Text = "Value = (Actual Count - 4mA) / (20mA - 4mA) * (High Scale - Low Scale)";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTab420Calculate
            // 
            this.buttonTab420Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTab420Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTab420Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTab420Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTab420Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab420Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTab420Calculate.Location = new System.Drawing.Point(361, 260);
            this.buttonTab420Calculate.Name = "buttonTab420Calculate";
            this.buttonTab420Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTab420Calculate.TabIndex = 242;
            this.buttonTab420Calculate.Text = "Calculate";
            this.buttonTab420Calculate.UseVisualStyleBackColor = false;
            this.buttonTab420Calculate.Click += new System.EventHandler(this.buttonTab420Calculate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 234;
            this.label2.Text = "Analog Reading =";
            // 
            // textBoxTab420Answer
            // 
            this.textBoxTab420Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTab420Answer.Location = new System.Drawing.Point(336, 232);
            this.textBoxTab420Answer.Name = "textBoxTab420Answer";
            this.textBoxTab420Answer.ReadOnly = true;
            this.textBoxTab420Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTab420Answer.TabIndex = 233;
            this.textBoxTab420Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTab4204ma
            // 
            this.textBoxTab4204ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTab4204ma.Location = new System.Drawing.Point(336, 123);
            this.textBoxTab4204ma.Name = "textBoxTab4204ma";
            this.textBoxTab4204ma.Size = new System.Drawing.Size(100, 21);
            this.textBoxTab4204ma.TabIndex = 238;
            this.textBoxTab4204ma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTab420ActualCount
            // 
            this.textBoxTab420ActualCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTab420ActualCount.Location = new System.Drawing.Point(336, 95);
            this.textBoxTab420ActualCount.Name = "textBoxTab420ActualCount";
            this.textBoxTab420ActualCount.Size = new System.Drawing.Size(100, 21);
            this.textBoxTab420ActualCount.TabIndex = 237;
            this.textBoxTab420ActualCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 232;
            this.label3.Text = "Low Count (4mA) =";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 231;
            this.label4.Text = "Actual Count =";
            // 
            // tabPageHg
            // 
            this.tabPageHg.BackColor = System.Drawing.Color.Ivory;
            this.tabPageHg.Controls.Add(this.buttonTabHglbhrConvert);
            this.tabPageHg.Controls.Add(this.buttonTabHgHGREConvert);
            this.tabPageHg.Controls.Add(this.buttonTabHgHGRHConvert);
            this.tabPageHg.Controls.Add(this.textBoxTabHglbhrHg);
            this.tabPageHg.Controls.Add(this.textBoxTabHglbhrFlow);
            this.tabPageHg.Controls.Add(this.label239);
            this.tabPageHg.Controls.Add(this.label240);
            this.tabPageHg.Controls.Add(this.label246);
            this.tabPageHg.Controls.Add(this.label241);
            this.tabPageHg.Controls.Add(this.buttonTabHglbhrClear);
            this.tabPageHg.Controls.Add(this.textBox35);
            this.tabPageHg.Controls.Add(this.buttonTabHglbhrAnswer);
            this.tabPageHg.Controls.Add(this.label242);
            this.tabPageHg.Controls.Add(this.textBoxTabHglbhrAnswer);
            this.tabPageHg.Controls.Add(this.label245);
            this.tabPageHg.Controls.Add(this.textBoxTabHgHGREMW);
            this.tabPageHg.Controls.Add(this.label5);
            this.tabPageHg.Controls.Add(this.label237);
            this.tabPageHg.Controls.Add(this.label236);
            this.tabPageHg.Controls.Add(this.textBoxTabHgHGRHCO2);
            this.tabPageHg.Controls.Add(this.label235);
            this.tabPageHg.Controls.Add(this.label234);
            this.tabPageHg.Controls.Add(this.label233);
            this.tabPageHg.Controls.Add(this.label232);
            this.tabPageHg.Controls.Add(this.buttonTabHgHGREClear);
            this.tabPageHg.Controls.Add(this.buttonTabHgHGRHClear);
            this.tabPageHg.Controls.Add(this.buttonTabHgHGREAnswer);
            this.tabPageHg.Controls.Add(this.label6);
            this.tabPageHg.Controls.Add(this.textBoxTabHgHGREAnswer);
            this.tabPageHg.Controls.Add(this.textBoxTabHgHGREHg);
            this.tabPageHg.Controls.Add(this.textBoxTabHgHGREFlow);
            this.tabPageHg.Controls.Add(this.label7);
            this.tabPageHg.Controls.Add(this.label8);
            this.tabPageHg.Controls.Add(this.label9);
            this.tabPageHg.Controls.Add(this.textBox24);
            this.tabPageHg.Controls.Add(this.textBox25);
            this.tabPageHg.Controls.Add(this.label227);
            this.tabPageHg.Controls.Add(this.textBox26);
            this.tabPageHg.Controls.Add(this.buttonTabHgHGRHAnswer);
            this.tabPageHg.Controls.Add(this.label228);
            this.tabPageHg.Controls.Add(this.textBoxTabHgHGRHAnswer);
            this.tabPageHg.Controls.Add(this.textBoxTabHgHGRHFc);
            this.tabPageHg.Controls.Add(this.textBoxTabHgHGRHHg);
            this.tabPageHg.Controls.Add(this.label229);
            this.tabPageHg.Controls.Add(this.label230);
            this.tabPageHg.Controls.Add(this.label231);
            this.tabPageHg.Location = new System.Drawing.Point(4, 24);
            this.tabPageHg.Name = "tabPageHg";
            this.tabPageHg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHg.Size = new System.Drawing.Size(939, 514);
            this.tabPageHg.TabIndex = 19;
            this.tabPageHg.Text = "Hg Rate";
            // 
            // buttonTabHglbhrConvert
            // 
            this.buttonTabHglbhrConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHglbhrConvert.BackColor = System.Drawing.Color.Transparent;
            this.buttonTabHglbhrConvert.FlatAppearance.BorderSize = 0;
            this.buttonTabHglbhrConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHglbhrConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHglbhrConvert.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonTabHglbhrConvert.Location = new System.Drawing.Point(449, 349);
            this.buttonTabHglbhrConvert.Name = "buttonTabHglbhrConvert";
            this.buttonTabHglbhrConvert.Size = new System.Drawing.Size(14, 21);
            this.buttonTabHglbhrConvert.TabIndex = 289;
            this.buttonTabHglbhrConvert.Text = "D";
            this.toolTip1.SetToolTip(this.buttonTabHglbhrConvert, "Convert to Decimal");
            this.buttonTabHglbhrConvert.UseVisualStyleBackColor = false;
            this.buttonTabHglbhrConvert.Click += new System.EventHandler(this.buttonTabHglbhrConvert_Click);
            // 
            // buttonTabHgHGREConvert
            // 
            this.buttonTabHgHGREConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHgHGREConvert.BackColor = System.Drawing.Color.Transparent;
            this.buttonTabHgHGREConvert.FlatAppearance.BorderSize = 0;
            this.buttonTabHgHGREConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHgHGREConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHgHGREConvert.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTabHgHGREConvert.Location = new System.Drawing.Point(917, 178);
            this.buttonTabHgHGREConvert.Name = "buttonTabHgHGREConvert";
            this.buttonTabHgHGREConvert.Size = new System.Drawing.Size(14, 21);
            this.buttonTabHgHGREConvert.TabIndex = 288;
            this.buttonTabHgHGREConvert.Text = "D";
            this.toolTip1.SetToolTip(this.buttonTabHgHGREConvert, "Convert to Decimal");
            this.buttonTabHgHGREConvert.UseVisualStyleBackColor = false;
            this.buttonTabHgHGREConvert.Click += new System.EventHandler(this.buttonTabHgHGREConvert_Click);
            // 
            // buttonTabHgHGRHConvert
            // 
            this.buttonTabHgHGRHConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHgHGRHConvert.BackColor = System.Drawing.Color.Transparent;
            this.buttonTabHgHGRHConvert.FlatAppearance.BorderSize = 0;
            this.buttonTabHgHGRHConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHgHGRHConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHgHGRHConvert.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonTabHgHGRHConvert.Location = new System.Drawing.Point(449, 177);
            this.buttonTabHgHGRHConvert.Name = "buttonTabHgHGRHConvert";
            this.buttonTabHgHGRHConvert.Size = new System.Drawing.Size(14, 21);
            this.buttonTabHgHGRHConvert.TabIndex = 286;
            this.buttonTabHgHGRHConvert.Text = "D";
            this.toolTip1.SetToolTip(this.buttonTabHgHGRHConvert, "Convert to Decimal");
            this.buttonTabHgHGRHConvert.UseVisualStyleBackColor = false;
            this.buttonTabHgHGRHConvert.Click += new System.EventHandler(this.buttonTabHgHGRHConvert_Click);
            // 
            // textBoxTabHglbhrHg
            // 
            this.textBoxTabHglbhrHg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHglbhrHg.Location = new System.Drawing.Point(343, 322);
            this.textBoxTabHglbhrHg.Name = "textBoxTabHglbhrHg";
            this.textBoxTabHglbhrHg.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHglbhrHg.TabIndex = 261;
            this.textBoxTabHglbhrHg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHglbhrFlow
            // 
            this.textBoxTabHglbhrFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHglbhrFlow.Location = new System.Drawing.Point(343, 294);
            this.textBoxTabHglbhrFlow.Name = "textBoxTabHglbhrFlow";
            this.textBoxTabHglbhrFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHglbhrFlow.TabIndex = 260;
            this.textBoxTabHglbhrFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label239
            // 
            this.label239.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label239.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label239.Location = new System.Drawing.Point(249, 324);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(86, 18);
            this.label239.TabIndex = 285;
            this.label239.Text = "Hg (ug/scm) = ";
            // 
            // label240
            // 
            this.label240.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label240.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label240.Location = new System.Drawing.Point(258, 296);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(77, 19);
            this.label240.TabIndex = 284;
            this.label240.Text = "Flow (scfh) = ";
            // 
            // label246
            // 
            this.label246.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label246.Location = new System.Drawing.Point(24, 337);
            this.label246.Name = "label246";
            this.label246.Size = new System.Drawing.Size(182, 15);
            this.label246.TabIndex = 283;
            this.label246.Text = "F - Unbiased Stack Flow (scfh)";
            // 
            // label241
            // 
            this.label241.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label241.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label241.Location = new System.Drawing.Point(24, 318);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(156, 15);
            this.label241.TabIndex = 278;
            this.label241.Text = "Hg - Hg in ug/scm";
            // 
            // buttonTabHglbhrClear
            // 
            this.buttonTabHglbhrClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHglbhrClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHglbhrClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabHglbhrClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHglbhrClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHglbhrClear.ForeColor = System.Drawing.Color.White;
            this.buttonTabHglbhrClear.Location = new System.Drawing.Point(257, 377);
            this.buttonTabHglbhrClear.Name = "buttonTabHglbhrClear";
            this.buttonTabHglbhrClear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHglbhrClear.TabIndex = 263;
            this.buttonTabHglbhrClear.Text = "Clear";
            this.buttonTabHglbhrClear.UseVisualStyleBackColor = false;
            this.buttonTabHglbhrClear.Click += new System.EventHandler(this.buttonTabHglbhrClear_Click);
            // 
            // textBox35
            // 
            this.textBox35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox35.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox35.ForeColor = System.Drawing.Color.White;
            this.textBox35.Location = new System.Drawing.Point(24, 266);
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(419, 22);
            this.textBox35.TabIndex = 273;
            this.textBox35.Text = "(lb/hr)   E = Hg * F * 6.243E-11";
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabHglbhrAnswer
            // 
            this.buttonTabHglbhrAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHglbhrAnswer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHglbhrAnswer.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabHglbhrAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHglbhrAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHglbhrAnswer.ForeColor = System.Drawing.Color.White;
            this.buttonTabHglbhrAnswer.Location = new System.Drawing.Point(368, 377);
            this.buttonTabHglbhrAnswer.Name = "buttonTabHglbhrAnswer";
            this.buttonTabHglbhrAnswer.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHglbhrAnswer.TabIndex = 262;
            this.buttonTabHglbhrAnswer.Text = "Calculate";
            this.buttonTabHglbhrAnswer.UseVisualStyleBackColor = false;
            this.buttonTabHglbhrAnswer.Click += new System.EventHandler(this.buttonTabHglbhrAnswer_Click);
            // 
            // label242
            // 
            this.label242.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label242.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label242.Location = new System.Drawing.Point(228, 352);
            this.label242.Name = "label242";
            this.label242.Size = new System.Drawing.Size(109, 25);
            this.label242.TabIndex = 272;
            this.label242.Text = "Hg Rate lb/hr = ";
            // 
            // textBoxTabHglbhrAnswer
            // 
            this.textBoxTabHglbhrAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHglbhrAnswer.Location = new System.Drawing.Point(343, 349);
            this.textBoxTabHglbhrAnswer.Name = "textBoxTabHglbhrAnswer";
            this.textBoxTabHglbhrAnswer.ReadOnly = true;
            this.textBoxTabHglbhrAnswer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHglbhrAnswer.TabIndex = 271;
            this.textBoxTabHglbhrAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label245
            // 
            this.label245.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label245.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label245.Location = new System.Drawing.Point(24, 298);
            this.label245.Name = "label245";
            this.label245.Size = new System.Drawing.Size(128, 20);
            this.label245.TabIndex = 268;
            this.label245.Text = "E - Hg Rate in lb/hr";
            // 
            // textBoxTabHgHGREMW
            // 
            this.textBoxTabHgHGREMW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHgHGREMW.Location = new System.Drawing.Point(811, 150);
            this.textBoxTabHgHGREMW.Name = "textBoxTabHgHGREMW";
            this.textBoxTabHgHGREMW.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHgHGREMW.TabIndex = 257;
            this.textBoxTabHgHGREMW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(761, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 266;
            this.label5.Text = "MW = ";
            // 
            // label237
            // 
            this.label237.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label237.Location = new System.Drawing.Point(489, 170);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(182, 15);
            this.label237.TabIndex = 265;
            this.label237.Text = "MW - MATS Load";
            // 
            // label236
            // 
            this.label236.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label236.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label236.Location = new System.Drawing.Point(489, 97);
            this.label236.Name = "label236";
            this.label236.Size = new System.Drawing.Size(209, 35);
            this.label236.TabIndex = 264;
            this.label236.Text = "E - Hg Electrical Output Based Emissions Rate (lb/GWh)";
            // 
            // textBoxTabHgHGRHCO2
            // 
            this.textBoxTabHgHGRHCO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHgHGRHCO2.Location = new System.Drawing.Point(343, 150);
            this.textBoxTabHgHGRHCO2.Name = "textBoxTabHgHGRHCO2";
            this.textBoxTabHgHGRHCO2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHgHGRHCO2.TabIndex = 252;
            this.textBoxTabHgHGRHCO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label235
            // 
            this.label235.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label235.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label235.Location = new System.Drawing.Point(279, 152);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(55, 18);
            this.label235.TabIndex = 262;
            this.label235.Text = "CO2% = ";
            // 
            // label234
            // 
            this.label234.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label234.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label234.Location = new System.Drawing.Point(24, 170);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(91, 19);
            this.label234.TabIndex = 261;
            this.label234.Text = "CO2 - CO2%";
            // 
            // label233
            // 
            this.label233.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label233.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label233.Location = new System.Drawing.Point(24, 151);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(209, 19);
            this.label233.TabIndex = 260;
            this.label233.Text = "Fc - Fc Factor (Default 1800 for Coal)";
            // 
            // label232
            // 
            this.label232.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label232.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label232.Location = new System.Drawing.Point(24, 132);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(156, 15);
            this.label232.TabIndex = 259;
            this.label232.Text = "Hg - Hg in ug/scm";
            // 
            // buttonTabHgHGREClear
            // 
            this.buttonTabHgHGREClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHgHGREClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHgHGREClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabHgHGREClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHgHGREClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHgHGREClear.ForeColor = System.Drawing.Color.White;
            this.buttonTabHgHGREClear.Location = new System.Drawing.Point(718, 205);
            this.buttonTabHgHGREClear.Name = "buttonTabHgHGREClear";
            this.buttonTabHgHGREClear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHgHGREClear.TabIndex = 259;
            this.buttonTabHgHGREClear.Text = "Clear";
            this.buttonTabHgHGREClear.UseVisualStyleBackColor = false;
            this.buttonTabHgHGREClear.Click += new System.EventHandler(this.buttonTabHgHGREClear_Click);
            // 
            // buttonTabHgHGRHClear
            // 
            this.buttonTabHgHGRHClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHgHGRHClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHgHGRHClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabHgHGRHClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHgHGRHClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHgHGRHClear.ForeColor = System.Drawing.Color.White;
            this.buttonTabHgHGRHClear.Location = new System.Drawing.Point(257, 205);
            this.buttonTabHgHGRHClear.Name = "buttonTabHgHGRHClear";
            this.buttonTabHgHGRHClear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHgHGRHClear.TabIndex = 254;
            this.buttonTabHgHGRHClear.Text = "Clear";
            this.buttonTabHgHGRHClear.UseVisualStyleBackColor = false;
            this.buttonTabHgHGRHClear.Click += new System.EventHandler(this.buttonTabHgHGRHClear_Click);
            // 
            // buttonTabHgHGREAnswer
            // 
            this.buttonTabHgHGREAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHgHGREAnswer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHgHGREAnswer.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabHgHGREAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHgHGREAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHgHGREAnswer.ForeColor = System.Drawing.Color.White;
            this.buttonTabHgHGREAnswer.Location = new System.Drawing.Point(836, 205);
            this.buttonTabHgHGREAnswer.Name = "buttonTabHgHGREAnswer";
            this.buttonTabHgHGREAnswer.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHgHGREAnswer.TabIndex = 258;
            this.buttonTabHgHGREAnswer.Text = "Calculate";
            this.buttonTabHgHGREAnswer.UseVisualStyleBackColor = false;
            this.buttonTabHgHGREAnswer.Click += new System.EventHandler(this.buttonTabHgHGREAnswer_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(677, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 248;
            this.label6.Text = "Hg Rate lb/GWh = ";
            // 
            // textBoxTabHgHGREAnswer
            // 
            this.textBoxTabHgHGREAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHgHGREAnswer.Location = new System.Drawing.Point(811, 177);
            this.textBoxTabHgHGREAnswer.Name = "textBoxTabHgHGREAnswer";
            this.textBoxTabHgHGREAnswer.ReadOnly = true;
            this.textBoxTabHgHGREAnswer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHgHGREAnswer.TabIndex = 247;
            this.textBoxTabHgHGREAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHgHGREHg
            // 
            this.textBoxTabHgHGREHg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHgHGREHg.Location = new System.Drawing.Point(811, 123);
            this.textBoxTabHgHGREHg.Name = "textBoxTabHgHGREHg";
            this.textBoxTabHgHGREHg.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHgHGREHg.TabIndex = 256;
            this.textBoxTabHgHGREHg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHgHGREFlow
            // 
            this.textBoxTabHgHGREFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHgHGREFlow.Location = new System.Drawing.Point(811, 95);
            this.textBoxTabHgHGREFlow.Name = "textBoxTabHgHGREFlow";
            this.textBoxTabHgHGREFlow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHgHGREFlow.TabIndex = 255;
            this.textBoxTabHgHGREFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(717, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 246;
            this.label7.Text = "Hg (ug/scm) = ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(726, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 245;
            this.label8.Text = "Flow (scfh) = ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Location = new System.Drawing.Point(489, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 15);
            this.label9.TabIndex = 244;
            this.label9.Text = "F - Unbiased Stack Flow (scfh)";
            // 
            // textBox24
            // 
            this.textBox24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox24.BackColor = System.Drawing.Color.Blue;
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.ForeColor = System.Drawing.Color.White;
            this.textBox24.Location = new System.Drawing.Point(6, 7);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(927, 29);
            this.textBox24.TabIndex = 243;
            this.textBox24.Text = "Hg Rate lb/hr, lb/TBtu (HGRH), and lb/GWh (HGRE)";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox25.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.ForeColor = System.Drawing.Color.White;
            this.textBox25.Location = new System.Drawing.Point(492, 65);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(419, 22);
            this.textBox25.TabIndex = 242;
            this.textBox25.Text = "(HGRE)  E = H * F * 6.243E-11 / (M / 1000)";
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label227
            // 
            this.label227.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label227.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label227.Location = new System.Drawing.Point(489, 132);
            this.label227.Name = "label227";
            this.label227.Size = new System.Drawing.Size(156, 15);
            this.label227.TabIndex = 241;
            this.label227.Text = "Hg - Hg in ug/scm";
            // 
            // textBox26
            // 
            this.textBox26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox26.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.ForeColor = System.Drawing.Color.White;
            this.textBox26.Location = new System.Drawing.Point(24, 65);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(419, 22);
            this.textBox26.TabIndex = 240;
            this.textBox26.Text = "(HGRH)   E = 6.24E-11 * Hg * Fc * (100 / CO2) * 1000000";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabHgHGRHAnswer
            // 
            this.buttonTabHgHGRHAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabHgHGRHAnswer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabHgHGRHAnswer.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabHgHGRHAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabHgHGRHAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabHgHGRHAnswer.ForeColor = System.Drawing.Color.White;
            this.buttonTabHgHGRHAnswer.Location = new System.Drawing.Point(368, 205);
            this.buttonTabHgHGRHAnswer.Name = "buttonTabHgHGRHAnswer";
            this.buttonTabHgHGRHAnswer.Size = new System.Drawing.Size(75, 30);
            this.buttonTabHgHGRHAnswer.TabIndex = 253;
            this.buttonTabHgHGRHAnswer.Text = "Calculate";
            this.buttonTabHgHGRHAnswer.UseVisualStyleBackColor = false;
            this.buttonTabHgHGRHAnswer.Click += new System.EventHandler(this.buttonTabHgHGRHAnswer_Click);
            // 
            // label228
            // 
            this.label228.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label228.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label228.Location = new System.Drawing.Point(210, 180);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(127, 25);
            this.label228.TabIndex = 239;
            this.label228.Text = "Hg Rate lb/TBtu = ";
            // 
            // textBoxTabHgHGRHAnswer
            // 
            this.textBoxTabHgHGRHAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHgHGRHAnswer.Location = new System.Drawing.Point(343, 177);
            this.textBoxTabHgHGRHAnswer.Name = "textBoxTabHgHGRHAnswer";
            this.textBoxTabHgHGRHAnswer.ReadOnly = true;
            this.textBoxTabHgHGRHAnswer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHgHGRHAnswer.TabIndex = 238;
            this.textBoxTabHgHGRHAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHgHGRHFc
            // 
            this.textBoxTabHgHGRHFc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHgHGRHFc.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabHgHGRHFc.Name = "textBoxTabHgHGRHFc";
            this.textBoxTabHgHGRHFc.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHgHGRHFc.TabIndex = 251;
            this.textBoxTabHgHGRHFc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabHgHGRHHg
            // 
            this.textBoxTabHgHGRHHg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabHgHGRHHg.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabHgHGRHHg.Name = "textBoxTabHgHGRHHg";
            this.textBoxTabHgHGRHHg.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabHgHGRHHg.TabIndex = 250;
            this.textBoxTabHgHGRHHg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label229
            // 
            this.label229.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label229.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label229.Location = new System.Drawing.Point(264, 126);
            this.label229.Name = "label229";
            this.label229.Size = new System.Drawing.Size(70, 18);
            this.label229.TabIndex = 237;
            this.label229.Text = "Fc Factor = ";
            // 
            // label230
            // 
            this.label230.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label230.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label230.Location = new System.Drawing.Point(254, 98);
            this.label230.Name = "label230";
            this.label230.Size = new System.Drawing.Size(78, 19);
            this.label230.TabIndex = 236;
            this.label230.Text = "Hg ug/scm =";
            // 
            // label231
            // 
            this.label231.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label231.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label231.Location = new System.Drawing.Point(24, 97);
            this.label231.Name = "label231";
            this.label231.Size = new System.Drawing.Size(209, 35);
            this.label231.TabIndex = 235;
            this.label231.Text = "E - Hg Heat Input Based Emissions Rate (lb/TBtu)";
            // 
            // tabPageLME_HI
            // 
            this.tabPageLME_HI.BackColor = System.Drawing.Color.Ivory;
            this.tabPageLME_HI.Controls.Add(this.buttonTabLMEHIHourClear);
            this.tabPageLME_HI.Controls.Add(this.buttonTabLMEHIQuarterClear);
            this.tabPageLME_HI.Controls.Add(this.label238);
            this.tabPageLME_HI.Controls.Add(this.textBoxTabLMEHIHourH);
            this.tabPageLME_HI.Controls.Add(this.buttonTabLMEHIHourCalculate);
            this.tabPageLME_HI.Controls.Add(this.label243);
            this.tabPageLME_HI.Controls.Add(this.textBoxTabLMEHIHourAnswer);
            this.tabPageLME_HI.Controls.Add(this.textBoxTabLMEHIHourQL);
            this.tabPageLME_HI.Controls.Add(this.textBoxTabLMEHIHourL);
            this.tabPageLME_HI.Controls.Add(this.label244);
            this.tabPageLME_HI.Controls.Add(this.label247);
            this.tabPageLME_HI.Controls.Add(this.label249);
            this.tabPageLME_HI.Controls.Add(this.label250);
            this.tabPageLME_HI.Controls.Add(this.label251);
            this.tabPageLME_HI.Controls.Add(this.label254);
            this.tabPageLME_HI.Controls.Add(this.label255);
            this.tabPageLME_HI.Controls.Add(this.textBox31);
            this.tabPageLME_HI.Controls.Add(this.textBox32);
            this.tabPageLME_HI.Controls.Add(this.label256);
            this.tabPageLME_HI.Controls.Add(this.textBox33);
            this.tabPageLME_HI.Controls.Add(this.buttonTabLMEHIQuarterCalculate);
            this.tabPageLME_HI.Controls.Add(this.label257);
            this.tabPageLME_HI.Controls.Add(this.textBoxTabLMEHIQuarterAnswer);
            this.tabPageLME_HI.Controls.Add(this.textBoxTabLMEHIQuarterGCV);
            this.tabPageLME_HI.Controls.Add(this.textBoxTabLMEHIQuarterFF);
            this.tabPageLME_HI.Controls.Add(this.label258);
            this.tabPageLME_HI.Controls.Add(this.label259);
            this.tabPageLME_HI.Controls.Add(this.label260);
            this.tabPageLME_HI.Location = new System.Drawing.Point(4, 24);
            this.tabPageLME_HI.Name = "tabPageLME_HI";
            this.tabPageLME_HI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLME_HI.Size = new System.Drawing.Size(939, 514);
            this.tabPageLME_HI.TabIndex = 20;
            this.tabPageLME_HI.Text = "LME Heat Input";
            // 
            // buttonTabLMEHIHourClear
            // 
            this.buttonTabLMEHIHourClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHIHourClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHIHourClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabLMEHIHourClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHIHourClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHIHourClear.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHIHourClear.Location = new System.Drawing.Point(718, 205);
            this.buttonTabLMEHIHourClear.Name = "buttonTabLMEHIHourClear";
            this.buttonTabLMEHIHourClear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHIHourClear.TabIndex = 253;
            this.buttonTabLMEHIHourClear.Text = "Clear";
            this.buttonTabLMEHIHourClear.UseVisualStyleBackColor = false;
            this.buttonTabLMEHIHourClear.Click += new System.EventHandler(this.buttonTabLMEHIHourClear_Click);
            // 
            // buttonTabLMEHIQuarterClear
            // 
            this.buttonTabLMEHIQuarterClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHIQuarterClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHIQuarterClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabLMEHIQuarterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHIQuarterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHIQuarterClear.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHIQuarterClear.Location = new System.Drawing.Point(250, 194);
            this.buttonTabLMEHIQuarterClear.Name = "buttonTabLMEHIQuarterClear";
            this.buttonTabLMEHIQuarterClear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHIQuarterClear.TabIndex = 248;
            this.buttonTabLMEHIQuarterClear.Text = "Clear";
            this.buttonTabLMEHIQuarterClear.UseVisualStyleBackColor = false;
            this.buttonTabLMEHIQuarterClear.Click += new System.EventHandler(this.buttonTabLMEHIQuarterClear_Click);
            // 
            // label238
            // 
            this.label238.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label238.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label238.Location = new System.Drawing.Point(770, 153);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(27, 18);
            this.label238.TabIndex = 243;
            this.label238.Text = "H = ";
            // 
            // textBoxTabLMEHIHourH
            // 
            this.textBoxTabLMEHIHourH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHIHourH.Location = new System.Drawing.Point(811, 150);
            this.textBoxTabLMEHIHourH.Name = "textBoxTabLMEHIHourH";
            this.textBoxTabLMEHIHourH.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHIHourH.TabIndex = 251;
            this.textBoxTabLMEHIHourH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonTabLMEHIHourCalculate
            // 
            this.buttonTabLMEHIHourCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHIHourCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHIHourCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabLMEHIHourCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHIHourCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHIHourCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHIHourCalculate.Location = new System.Drawing.Point(836, 205);
            this.buttonTabLMEHIHourCalculate.Name = "buttonTabLMEHIHourCalculate";
            this.buttonTabLMEHIHourCalculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHIHourCalculate.TabIndex = 252;
            this.buttonTabLMEHIHourCalculate.Text = "Calculate";
            this.buttonTabLMEHIHourCalculate.UseVisualStyleBackColor = false;
            this.buttonTabLMEHIHourCalculate.Click += new System.EventHandler(this.buttonTabLMEHIHourCalculate_Click);
            // 
            // label243
            // 
            this.label243.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label243.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label243.Location = new System.Drawing.Point(605, 179);
            this.label243.Name = "label243";
            this.label243.Size = new System.Drawing.Size(191, 20);
            this.label243.TabIndex = 242;
            this.label243.Text = "Hourly Heat Input (mmBtu) = ";
            // 
            // textBoxTabLMEHIHourAnswer
            // 
            this.textBoxTabLMEHIHourAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHIHourAnswer.Location = new System.Drawing.Point(811, 177);
            this.textBoxTabLMEHIHourAnswer.Name = "textBoxTabLMEHIHourAnswer";
            this.textBoxTabLMEHIHourAnswer.ReadOnly = true;
            this.textBoxTabLMEHIHourAnswer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHIHourAnswer.TabIndex = 241;
            this.textBoxTabLMEHIHourAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHIHourQL
            // 
            this.textBoxTabLMEHIHourQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHIHourQL.Location = new System.Drawing.Point(811, 123);
            this.textBoxTabLMEHIHourQL.Name = "textBoxTabLMEHIHourQL";
            this.textBoxTabLMEHIHourQL.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHIHourQL.TabIndex = 250;
            this.textBoxTabLMEHIHourQL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHIHourL
            // 
            this.textBoxTabLMEHIHourL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHIHourL.Location = new System.Drawing.Point(811, 95);
            this.textBoxTabLMEHIHourL.Name = "textBoxTabLMEHIHourL";
            this.textBoxTabLMEHIHourL.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHIHourL.TabIndex = 249;
            this.textBoxTabLMEHIHourL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label244
            // 
            this.label244.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label244.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label244.Location = new System.Drawing.Point(763, 125);
            this.label244.Name = "label244";
            this.label244.Size = new System.Drawing.Size(37, 18);
            this.label244.TabIndex = 240;
            this.label244.Text = "QL = ";
            // 
            // label247
            // 
            this.label247.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label247.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label247.Location = new System.Drawing.Point(772, 97);
            this.label247.Name = "label247";
            this.label247.Size = new System.Drawing.Size(29, 19);
            this.label247.TabIndex = 239;
            this.label247.Text = "L = ";
            // 
            // label249
            // 
            this.label249.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label249.Location = new System.Drawing.Point(492, 158);
            this.label249.Name = "label249";
            this.label249.Size = new System.Drawing.Size(127, 15);
            this.label249.TabIndex = 237;
            this.label249.Text = "H - Total Heat Input";
            // 
            // label250
            // 
            this.label250.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label250.Location = new System.Drawing.Point(492, 138);
            this.label250.Name = "label250";
            this.label250.Size = new System.Drawing.Size(156, 21);
            this.label250.TabIndex = 236;
            this.label250.Text = "QL - Total Load for Quarter";
            // 
            // label251
            // 
            this.label251.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label251.Location = new System.Drawing.Point(492, 117);
            this.label251.Name = "label251";
            this.label251.Size = new System.Drawing.Size(181, 15);
            this.label251.TabIndex = 235;
            this.label251.Text = "L - Hour Load";
            // 
            // label254
            // 
            this.label254.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label254.Location = new System.Drawing.Point(24, 138);
            this.label254.Name = "label254";
            this.label254.Size = new System.Drawing.Size(135, 15);
            this.label254.TabIndex = 232;
            this.label254.Text = "GCV - Gross Caloric Value";
            // 
            // label255
            // 
            this.label255.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label255.Location = new System.Drawing.Point(24, 117);
            this.label255.Name = "label255";
            this.label255.Size = new System.Drawing.Size(200, 15);
            this.label255.TabIndex = 231;
            this.label255.Text = "FF - Fuel Flow";
            // 
            // textBox31
            // 
            this.textBox31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox31.BackColor = System.Drawing.Color.Blue;
            this.textBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox31.ForeColor = System.Drawing.Color.White;
            this.textBox31.Location = new System.Drawing.Point(6, 7);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(927, 29);
            this.textBox31.TabIndex = 230;
            this.textBox31.Text = "LME - Quarterly and Hourly Heat Input";
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox32
            // 
            this.textBox32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox32.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox32.ForeColor = System.Drawing.Color.White;
            this.textBox32.Location = new System.Drawing.Point(492, 65);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(419, 22);
            this.textBox32.TabIndex = 229;
            this.textBox32.Text = "E = L / QL * H";
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label256
            // 
            this.label256.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label256.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label256.Location = new System.Drawing.Point(492, 97);
            this.label256.Name = "label256";
            this.label256.Size = new System.Drawing.Size(156, 15);
            this.label256.TabIndex = 228;
            this.label256.Text = "E - Hourly Heat Input";
            // 
            // textBox33
            // 
            this.textBox33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox33.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox33.ForeColor = System.Drawing.Color.White;
            this.textBox33.Location = new System.Drawing.Point(24, 65);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(419, 22);
            this.textBox33.TabIndex = 227;
            this.textBox33.Text = "E = FF * GCV / 1000000.0";
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabLMEHIQuarterCalculate
            // 
            this.buttonTabLMEHIQuarterCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHIQuarterCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHIQuarterCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabLMEHIQuarterCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHIQuarterCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHIQuarterCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHIQuarterCalculate.Location = new System.Drawing.Point(368, 194);
            this.buttonTabLMEHIQuarterCalculate.Name = "buttonTabLMEHIQuarterCalculate";
            this.buttonTabLMEHIQuarterCalculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHIQuarterCalculate.TabIndex = 247;
            this.buttonTabLMEHIQuarterCalculate.Text = "Calculate";
            this.buttonTabLMEHIQuarterCalculate.UseVisualStyleBackColor = false;
            this.buttonTabLMEHIQuarterCalculate.Click += new System.EventHandler(this.buttonTabLMEHIQuarterCalculate_Click);
            // 
            // label257
            // 
            this.label257.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label257.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label257.Location = new System.Drawing.Point(195, 150);
            this.label257.Name = "label257";
            this.label257.Size = new System.Drawing.Size(142, 41);
            this.label257.TabIndex = 226;
            this.label257.Text = "Quarterly Total Heat Input (mmBtu) =";
            // 
            // textBoxTabLMEHIQuarterAnswer
            // 
            this.textBoxTabLMEHIQuarterAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHIQuarterAnswer.Location = new System.Drawing.Point(343, 161);
            this.textBoxTabLMEHIQuarterAnswer.Name = "textBoxTabLMEHIQuarterAnswer";
            this.textBoxTabLMEHIQuarterAnswer.ReadOnly = true;
            this.textBoxTabLMEHIQuarterAnswer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHIQuarterAnswer.TabIndex = 225;
            this.textBoxTabLMEHIQuarterAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHIQuarterGCV
            // 
            this.textBoxTabLMEHIQuarterGCV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHIQuarterGCV.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabLMEHIQuarterGCV.Name = "textBoxTabLMEHIQuarterGCV";
            this.textBoxTabLMEHIQuarterGCV.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHIQuarterGCV.TabIndex = 245;
            this.textBoxTabLMEHIQuarterGCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHIQuarterFF
            // 
            this.textBoxTabLMEHIQuarterFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHIQuarterFF.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabLMEHIQuarterFF.Name = "textBoxTabLMEHIQuarterFF";
            this.textBoxTabLMEHIQuarterFF.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHIQuarterFF.TabIndex = 244;
            this.textBoxTabLMEHIQuarterFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label258
            // 
            this.label258.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label258.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label258.Location = new System.Drawing.Point(293, 125);
            this.label258.Name = "label258";
            this.label258.Size = new System.Drawing.Size(46, 18);
            this.label258.TabIndex = 224;
            this.label258.Text = "GCV = ";
            // 
            // label259
            // 
            this.label259.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label259.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label259.Location = new System.Drawing.Point(302, 97);
            this.label259.Name = "label259";
            this.label259.Size = new System.Drawing.Size(32, 19);
            this.label259.TabIndex = 223;
            this.label259.Text = "FF =";
            // 
            // label260
            // 
            this.label260.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label260.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label260.Location = new System.Drawing.Point(24, 97);
            this.label260.Name = "label260";
            this.label260.Size = new System.Drawing.Size(173, 20);
            this.label260.TabIndex = 222;
            this.label260.Text = "E - Quarterly Total Heat Input";
            // 
            // tabPageLME_Mass
            // 
            this.tabPageLME_Mass.BackColor = System.Drawing.Color.Ivory;
            this.tabPageLME_Mass.Controls.Add(this.buttonTabLMEHourCo2Clear);
            this.tabPageLME_Mass.Controls.Add(this.label248);
            this.tabPageLME_Mass.Controls.Add(this.label262);
            this.tabPageLME_Mass.Controls.Add(this.textBox8);
            this.tabPageLME_Mass.Controls.Add(this.buttonTabLMEHourCo2Calculate);
            this.tabPageLME_Mass.Controls.Add(this.label272);
            this.tabPageLME_Mass.Controls.Add(this.textBoxTabLMEHourCo2Answer);
            this.tabPageLME_Mass.Controls.Add(this.textBoxTabLMEHourCo2Co2);
            this.tabPageLME_Mass.Controls.Add(this.textBoxTabLMEHourCo2H);
            this.tabPageLME_Mass.Controls.Add(this.label273);
            this.tabPageLME_Mass.Controls.Add(this.label274);
            this.tabPageLME_Mass.Controls.Add(this.label275);
            this.tabPageLME_Mass.Controls.Add(this.buttonTabLMEHourSo2Clear);
            this.tabPageLME_Mass.Controls.Add(this.buttonTabLMEHourNoxClear);
            this.tabPageLME_Mass.Controls.Add(this.buttonTabLMEHourSo2Calculate);
            this.tabPageLME_Mass.Controls.Add(this.label252);
            this.tabPageLME_Mass.Controls.Add(this.textBoxTabLMEHourSo2Answer);
            this.tabPageLME_Mass.Controls.Add(this.textBoxTabLMEHourSo2So2);
            this.tabPageLME_Mass.Controls.Add(this.textBoxTabLMEHourSo2H);
            this.tabPageLME_Mass.Controls.Add(this.label253);
            this.tabPageLME_Mass.Controls.Add(this.label261);
            this.tabPageLME_Mass.Controls.Add(this.label263);
            this.tabPageLME_Mass.Controls.Add(this.label264);
            this.tabPageLME_Mass.Controls.Add(this.label265);
            this.tabPageLME_Mass.Controls.Add(this.label266);
            this.tabPageLME_Mass.Controls.Add(this.textBox29);
            this.tabPageLME_Mass.Controls.Add(this.textBox34);
            this.tabPageLME_Mass.Controls.Add(this.label267);
            this.tabPageLME_Mass.Controls.Add(this.textBox36);
            this.tabPageLME_Mass.Controls.Add(this.buttonTabLMEHourNoxCalculate);
            this.tabPageLME_Mass.Controls.Add(this.label268);
            this.tabPageLME_Mass.Controls.Add(this.textBoxTabLMEHourNoxAnswer);
            this.tabPageLME_Mass.Controls.Add(this.textBoxTabLMEHourNoxNox);
            this.tabPageLME_Mass.Controls.Add(this.textBoxTabLMEHourNoxH);
            this.tabPageLME_Mass.Controls.Add(this.label269);
            this.tabPageLME_Mass.Controls.Add(this.label270);
            this.tabPageLME_Mass.Controls.Add(this.label271);
            this.tabPageLME_Mass.Location = new System.Drawing.Point(4, 24);
            this.tabPageLME_Mass.Name = "tabPageLME_Mass";
            this.tabPageLME_Mass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLME_Mass.Size = new System.Drawing.Size(939, 514);
            this.tabPageLME_Mass.TabIndex = 21;
            this.tabPageLME_Mass.Text = "LME Mass";
            // 
            // buttonTabLMEHourCo2Clear
            // 
            this.buttonTabLMEHourCo2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHourCo2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHourCo2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabLMEHourCo2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHourCo2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHourCo2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHourCo2Clear.Location = new System.Drawing.Point(250, 359);
            this.buttonTabLMEHourCo2Clear.Name = "buttonTabLMEHourCo2Clear";
            this.buttonTabLMEHourCo2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHourCo2Clear.TabIndex = 293;
            this.buttonTabLMEHourCo2Clear.Text = "Clear";
            this.buttonTabLMEHourCo2Clear.UseVisualStyleBackColor = false;
            this.buttonTabLMEHourCo2Clear.Click += new System.EventHandler(this.buttonTabLMEHourCo2Clear_Click);
            // 
            // label248
            // 
            this.label248.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label248.Location = new System.Drawing.Point(24, 318);
            this.label248.Name = "label248";
            this.label248.Size = new System.Drawing.Size(149, 21);
            this.label248.TabIndex = 289;
            this.label248.Text = "NOx - CO2 Rate Constant";
            // 
            // label262
            // 
            this.label262.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label262.Location = new System.Drawing.Point(24, 298);
            this.label262.Name = "label262";
            this.label262.Size = new System.Drawing.Size(200, 15);
            this.label262.TabIndex = 288;
            this.label262.Text = "H - Hourly Heat Input";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(24, 246);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(419, 22);
            this.textBox8.TabIndex = 287;
            this.textBox8.Text = "(Hourly CO2 Mass)  E = H * CO2";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabLMEHourCo2Calculate
            // 
            this.buttonTabLMEHourCo2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHourCo2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHourCo2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabLMEHourCo2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHourCo2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHourCo2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHourCo2Calculate.Location = new System.Drawing.Point(368, 359);
            this.buttonTabLMEHourCo2Calculate.Name = "buttonTabLMEHourCo2Calculate";
            this.buttonTabLMEHourCo2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHourCo2Calculate.TabIndex = 292;
            this.buttonTabLMEHourCo2Calculate.Text = "Calculate";
            this.buttonTabLMEHourCo2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabLMEHourCo2Calculate.Click += new System.EventHandler(this.buttonTabLMEHourCo2Calculate_Click);
            // 
            // label272
            // 
            this.label272.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label272.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label272.Location = new System.Drawing.Point(158, 334);
            this.label272.Name = "label272";
            this.label272.Size = new System.Drawing.Size(170, 20);
            this.label272.TabIndex = 286;
            this.label272.Text = "Hourly CO2 Mass (tons) =";
            // 
            // textBoxTabLMEHourCo2Answer
            // 
            this.textBoxTabLMEHourCo2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHourCo2Answer.Location = new System.Drawing.Point(343, 331);
            this.textBoxTabLMEHourCo2Answer.Name = "textBoxTabLMEHourCo2Answer";
            this.textBoxTabLMEHourCo2Answer.ReadOnly = true;
            this.textBoxTabLMEHourCo2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHourCo2Answer.TabIndex = 285;
            this.textBoxTabLMEHourCo2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHourCo2Co2
            // 
            this.textBoxTabLMEHourCo2Co2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHourCo2Co2.Location = new System.Drawing.Point(343, 304);
            this.textBoxTabLMEHourCo2Co2.Name = "textBoxTabLMEHourCo2Co2";
            this.textBoxTabLMEHourCo2Co2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHourCo2Co2.TabIndex = 291;
            this.textBoxTabLMEHourCo2Co2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHourCo2H
            // 
            this.textBoxTabLMEHourCo2H.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHourCo2H.Location = new System.Drawing.Point(343, 276);
            this.textBoxTabLMEHourCo2H.Name = "textBoxTabLMEHourCo2H";
            this.textBoxTabLMEHourCo2H.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHourCo2H.TabIndex = 290;
            this.textBoxTabLMEHourCo2H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label273
            // 
            this.label273.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label273.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label273.Location = new System.Drawing.Point(286, 306);
            this.label273.Name = "label273";
            this.label273.Size = new System.Drawing.Size(46, 18);
            this.label273.TabIndex = 284;
            this.label273.Text = "CO2 = ";
            // 
            // label274
            // 
            this.label274.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label274.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label274.Location = new System.Drawing.Point(302, 278);
            this.label274.Name = "label274";
            this.label274.Size = new System.Drawing.Size(32, 19);
            this.label274.TabIndex = 283;
            this.label274.Text = "H =";
            // 
            // label275
            // 
            this.label275.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label275.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label275.Location = new System.Drawing.Point(24, 278);
            this.label275.Name = "label275";
            this.label275.Size = new System.Drawing.Size(173, 20);
            this.label275.TabIndex = 282;
            this.label275.Text = "E - Hourly CO2 Mass (tons)";
            // 
            // buttonTabLMEHourSo2Clear
            // 
            this.buttonTabLMEHourSo2Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHourSo2Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHourSo2Clear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabLMEHourSo2Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHourSo2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHourSo2Clear.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHourSo2Clear.Location = new System.Drawing.Point(718, 178);
            this.buttonTabLMEHourSo2Clear.Name = "buttonTabLMEHourSo2Clear";
            this.buttonTabLMEHourSo2Clear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHourSo2Clear.TabIndex = 281;
            this.buttonTabLMEHourSo2Clear.Text = "Clear";
            this.buttonTabLMEHourSo2Clear.UseVisualStyleBackColor = false;
            this.buttonTabLMEHourSo2Clear.Click += new System.EventHandler(this.buttonTabLMEHourSo2Clear_Click);
            // 
            // buttonTabLMEHourNoxClear
            // 
            this.buttonTabLMEHourNoxClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHourNoxClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHourNoxClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTabLMEHourNoxClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHourNoxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHourNoxClear.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHourNoxClear.Location = new System.Drawing.Point(250, 178);
            this.buttonTabLMEHourNoxClear.Name = "buttonTabLMEHourNoxClear";
            this.buttonTabLMEHourNoxClear.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHourNoxClear.TabIndex = 276;
            this.buttonTabLMEHourNoxClear.Text = "Clear";
            this.buttonTabLMEHourNoxClear.UseVisualStyleBackColor = false;
            this.buttonTabLMEHourNoxClear.Click += new System.EventHandler(this.buttonTabLMEHourNoxClear_Click);
            // 
            // buttonTabLMEHourSo2Calculate
            // 
            this.buttonTabLMEHourSo2Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHourSo2Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHourSo2Calculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabLMEHourSo2Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHourSo2Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHourSo2Calculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHourSo2Calculate.Location = new System.Drawing.Point(836, 178);
            this.buttonTabLMEHourSo2Calculate.Name = "buttonTabLMEHourSo2Calculate";
            this.buttonTabLMEHourSo2Calculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHourSo2Calculate.TabIndex = 280;
            this.buttonTabLMEHourSo2Calculate.Text = "Calculate";
            this.buttonTabLMEHourSo2Calculate.UseVisualStyleBackColor = false;
            this.buttonTabLMEHourSo2Calculate.Click += new System.EventHandler(this.buttonTabLMEHourSo2Calculate_Click);
            // 
            // label252
            // 
            this.label252.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label252.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label252.Location = new System.Drawing.Point(641, 152);
            this.label252.Name = "label252";
            this.label252.Size = new System.Drawing.Size(155, 20);
            this.label252.TabIndex = 271;
            this.label252.Text = "Hourly SO2 Mass (lb) = ";
            // 
            // textBoxTabLMEHourSo2Answer
            // 
            this.textBoxTabLMEHourSo2Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHourSo2Answer.Location = new System.Drawing.Point(811, 150);
            this.textBoxTabLMEHourSo2Answer.Name = "textBoxTabLMEHourSo2Answer";
            this.textBoxTabLMEHourSo2Answer.ReadOnly = true;
            this.textBoxTabLMEHourSo2Answer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHourSo2Answer.TabIndex = 270;
            this.textBoxTabLMEHourSo2Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHourSo2So2
            // 
            this.textBoxTabLMEHourSo2So2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHourSo2So2.Location = new System.Drawing.Point(811, 123);
            this.textBoxTabLMEHourSo2So2.Name = "textBoxTabLMEHourSo2So2";
            this.textBoxTabLMEHourSo2So2.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHourSo2So2.TabIndex = 278;
            this.textBoxTabLMEHourSo2So2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHourSo2H
            // 
            this.textBoxTabLMEHourSo2H.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHourSo2H.Location = new System.Drawing.Point(811, 95);
            this.textBoxTabLMEHourSo2H.Name = "textBoxTabLMEHourSo2H";
            this.textBoxTabLMEHourSo2H.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHourSo2H.TabIndex = 277;
            this.textBoxTabLMEHourSo2H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label253
            // 
            this.label253.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label253.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label253.Location = new System.Drawing.Point(757, 125);
            this.label253.Name = "label253";
            this.label253.Size = new System.Drawing.Size(43, 18);
            this.label253.TabIndex = 269;
            this.label253.Text = "SO2 = ";
            // 
            // label261
            // 
            this.label261.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label261.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label261.Location = new System.Drawing.Point(772, 97);
            this.label261.Name = "label261";
            this.label261.Size = new System.Drawing.Size(29, 19);
            this.label261.TabIndex = 268;
            this.label261.Text = "H = ";
            // 
            // label263
            // 
            this.label263.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label263.Location = new System.Drawing.Point(492, 138);
            this.label263.Name = "label263";
            this.label263.Size = new System.Drawing.Size(156, 21);
            this.label263.TabIndex = 266;
            this.label263.Text = "SO2 - SO2 Rate Contsant";
            // 
            // label264
            // 
            this.label264.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label264.Location = new System.Drawing.Point(492, 117);
            this.label264.Name = "label264";
            this.label264.Size = new System.Drawing.Size(181, 15);
            this.label264.TabIndex = 265;
            this.label264.Text = "H - Hourly Heat Input";
            // 
            // label265
            // 
            this.label265.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label265.Location = new System.Drawing.Point(24, 137);
            this.label265.Name = "label265";
            this.label265.Size = new System.Drawing.Size(149, 21);
            this.label265.TabIndex = 264;
            this.label265.Text = "NOx - NOx Rate Constant";
            // 
            // label266
            // 
            this.label266.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label266.Location = new System.Drawing.Point(24, 117);
            this.label266.Name = "label266";
            this.label266.Size = new System.Drawing.Size(200, 15);
            this.label266.TabIndex = 263;
            this.label266.Text = "H - Hourly Heat Input";
            // 
            // textBox29
            // 
            this.textBox29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox29.BackColor = System.Drawing.Color.Blue;
            this.textBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox29.ForeColor = System.Drawing.Color.White;
            this.textBox29.Location = new System.Drawing.Point(6, 7);
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(927, 29);
            this.textBox29.TabIndex = 262;
            this.textBox29.Text = "LME - Hourly Mass for NOx, SO2, and CO2";
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox34
            // 
            this.textBox34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox34.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox34.ForeColor = System.Drawing.Color.White;
            this.textBox34.Location = new System.Drawing.Point(492, 65);
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(419, 22);
            this.textBox34.TabIndex = 261;
            this.textBox34.Text = "(Hourly SO2 Mass)  E = H * SO2";
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label267
            // 
            this.label267.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label267.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label267.Location = new System.Drawing.Point(492, 97);
            this.label267.Name = "label267";
            this.label267.Size = new System.Drawing.Size(156, 15);
            this.label267.TabIndex = 260;
            this.label267.Text = "E - Hourly SO2 Mass (lb)";
            // 
            // textBox36
            // 
            this.textBox36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox36.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox36.ForeColor = System.Drawing.Color.White;
            this.textBox36.Location = new System.Drawing.Point(24, 65);
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            this.textBox36.Size = new System.Drawing.Size(419, 22);
            this.textBox36.TabIndex = 259;
            this.textBox36.Text = "(Hourly NOx Mass)  E = H * NOx";
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTabLMEHourNoxCalculate
            // 
            this.buttonTabLMEHourNoxCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTabLMEHourNoxCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabLMEHourNoxCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTabLMEHourNoxCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabLMEHourNoxCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabLMEHourNoxCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonTabLMEHourNoxCalculate.Location = new System.Drawing.Point(368, 178);
            this.buttonTabLMEHourNoxCalculate.Name = "buttonTabLMEHourNoxCalculate";
            this.buttonTabLMEHourNoxCalculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTabLMEHourNoxCalculate.TabIndex = 275;
            this.buttonTabLMEHourNoxCalculate.Text = "Calculate";
            this.buttonTabLMEHourNoxCalculate.UseVisualStyleBackColor = false;
            this.buttonTabLMEHourNoxCalculate.Click += new System.EventHandler(this.buttonTabLMEHourNoxCalculate_Click);
            // 
            // label268
            // 
            this.label268.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label268.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label268.Location = new System.Drawing.Point(172, 153);
            this.label268.Name = "label268";
            this.label268.Size = new System.Drawing.Size(156, 20);
            this.label268.TabIndex = 258;
            this.label268.Text = "Hourly NOx Mass (lb) =";
            // 
            // textBoxTabLMEHourNoxAnswer
            // 
            this.textBoxTabLMEHourNoxAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHourNoxAnswer.Location = new System.Drawing.Point(343, 150);
            this.textBoxTabLMEHourNoxAnswer.Name = "textBoxTabLMEHourNoxAnswer";
            this.textBoxTabLMEHourNoxAnswer.ReadOnly = true;
            this.textBoxTabLMEHourNoxAnswer.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHourNoxAnswer.TabIndex = 257;
            this.textBoxTabLMEHourNoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHourNoxNox
            // 
            this.textBoxTabLMEHourNoxNox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHourNoxNox.Location = new System.Drawing.Point(343, 123);
            this.textBoxTabLMEHourNoxNox.Name = "textBoxTabLMEHourNoxNox";
            this.textBoxTabLMEHourNoxNox.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHourNoxNox.TabIndex = 274;
            this.textBoxTabLMEHourNoxNox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTabLMEHourNoxH
            // 
            this.textBoxTabLMEHourNoxH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTabLMEHourNoxH.Location = new System.Drawing.Point(343, 95);
            this.textBoxTabLMEHourNoxH.Name = "textBoxTabLMEHourNoxH";
            this.textBoxTabLMEHourNoxH.Size = new System.Drawing.Size(100, 21);
            this.textBoxTabLMEHourNoxH.TabIndex = 273;
            this.textBoxTabLMEHourNoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label269
            // 
            this.label269.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label269.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label269.Location = new System.Drawing.Point(286, 125);
            this.label269.Name = "label269";
            this.label269.Size = new System.Drawing.Size(46, 18);
            this.label269.TabIndex = 256;
            this.label269.Text = "NOx = ";
            // 
            // label270
            // 
            this.label270.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label270.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label270.Location = new System.Drawing.Point(302, 97);
            this.label270.Name = "label270";
            this.label270.Size = new System.Drawing.Size(32, 19);
            this.label270.TabIndex = 255;
            this.label270.Text = "H =";
            // 
            // label271
            // 
            this.label271.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label271.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label271.Location = new System.Drawing.Point(24, 97);
            this.label271.Name = "label271";
            this.label271.Size = new System.Drawing.Size(173, 20);
            this.label271.TabIndex = 254;
            this.label271.Text = "E - Hourly NOx Mass (lb)";
            // 
            // tabTime
            // 
            this.tabTime.Controls.Add(this.buttonTimeCopy);
            this.tabTime.Controls.Add(this.textBoxHourlyDecimal);
            this.tabTime.Controls.Add(this.label291);
            this.tabTime.Controls.Add(this.buttonTimeClear);
            this.tabTime.Controls.Add(this.buttonTimeCalculate);
            this.tabTime.Controls.Add(this.textBoxSeconds);
            this.tabTime.Controls.Add(this.textBoxMinutes);
            this.tabTime.Controls.Add(this.textBoxHours);
            this.tabTime.Controls.Add(this.textBoxDays);
            this.tabTime.Controls.Add(this.label290);
            this.tabTime.Controls.Add(this.label289);
            this.tabTime.Controls.Add(this.label288);
            this.tabTime.Controls.Add(this.label287);
            this.tabTime.Controls.Add(this.label284);
            this.tabTime.Controls.Add(this.label281);
            this.tabTime.Controls.Add(this.textBoxss2);
            this.tabTime.Controls.Add(this.label282);
            this.tabTime.Controls.Add(this.textBoxmm2);
            this.tabTime.Controls.Add(this.label283);
            this.tabTime.Controls.Add(this.textBoxHH2);
            this.tabTime.Controls.Add(this.label280);
            this.tabTime.Controls.Add(this.textBoxss1);
            this.tabTime.Controls.Add(this.label279);
            this.tabTime.Controls.Add(this.textBoxmm1);
            this.tabTime.Controls.Add(this.label278);
            this.tabTime.Controls.Add(this.textBoxHH1);
            this.tabTime.Controls.Add(this.label277);
            this.tabTime.Controls.Add(this.dateTimePicker2);
            this.tabTime.Controls.Add(this.label276);
            this.tabTime.Controls.Add(this.dateTimePicker1);
            this.tabTime.Controls.Add(this.textBox42);
            this.tabTime.Controls.Add(this.textBox44);
            this.tabTime.Location = new System.Drawing.Point(4, 24);
            this.tabTime.Name = "tabTime";
            this.tabTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabTime.Size = new System.Drawing.Size(939, 514);
            this.tabTime.TabIndex = 22;
            this.tabTime.Text = "Time";
            this.tabTime.UseVisualStyleBackColor = true;
            // 
            // buttonTimeCopy
            // 
            this.buttonTimeCopy.BackColor = System.Drawing.Color.Green;
            this.buttonTimeCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeCopy.ForeColor = System.Drawing.Color.White;
            this.buttonTimeCopy.Location = new System.Drawing.Point(238, 340);
            this.buttonTimeCopy.Name = "buttonTimeCopy";
            this.buttonTimeCopy.Size = new System.Drawing.Size(44, 23);
            this.buttonTimeCopy.TabIndex = 336;
            this.buttonTimeCopy.Text = "Copy";
            this.toolTip1.SetToolTip(this.buttonTimeCopy, "Copy To Clipboard");
            this.buttonTimeCopy.UseVisualStyleBackColor = false;
            this.buttonTimeCopy.Click += new System.EventHandler(this.buttonTimeCopy_Click);
            // 
            // textBoxHourlyDecimal
            // 
            this.textBoxHourlyDecimal.Location = new System.Drawing.Point(238, 312);
            this.textBoxHourlyDecimal.Name = "textBoxHourlyDecimal";
            this.textBoxHourlyDecimal.ReadOnly = true;
            this.textBoxHourlyDecimal.Size = new System.Drawing.Size(91, 21);
            this.textBoxHourlyDecimal.TabIndex = 335;
            this.textBoxHourlyDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label291
            // 
            this.label291.AutoSize = true;
            this.label291.Location = new System.Drawing.Point(239, 294);
            this.label291.Name = "label291";
            this.label291.Size = new System.Drawing.Size(91, 15);
            this.label291.TabIndex = 334;
            this.label291.Text = "Hourly Decimal";
            // 
            // buttonTimeClear
            // 
            this.buttonTimeClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTimeClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTimeClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTimeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeClear.ForeColor = System.Drawing.Color.White;
            this.buttonTimeClear.Location = new System.Drawing.Point(471, 308);
            this.buttonTimeClear.Name = "buttonTimeClear";
            this.buttonTimeClear.Size = new System.Drawing.Size(75, 30);
            this.buttonTimeClear.TabIndex = 312;
            this.buttonTimeClear.Text = "Clear";
            this.buttonTimeClear.UseVisualStyleBackColor = false;
            this.buttonTimeClear.Click += new System.EventHandler(this.buttonTimeClear_Click);
            // 
            // buttonTimeCalculate
            // 
            this.buttonTimeCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTimeCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTimeCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTimeCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonTimeCalculate.Location = new System.Drawing.Point(589, 308);
            this.buttonTimeCalculate.Name = "buttonTimeCalculate";
            this.buttonTimeCalculate.Size = new System.Drawing.Size(75, 30);
            this.buttonTimeCalculate.TabIndex = 311;
            this.buttonTimeCalculate.Text = "Calculate";
            this.buttonTimeCalculate.UseVisualStyleBackColor = false;
            this.buttonTimeCalculate.Click += new System.EventHandler(this.buttonTimeCalculate_Click);
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(455, 255);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.ReadOnly = true;
            this.textBoxSeconds.Size = new System.Drawing.Size(66, 21);
            this.textBoxSeconds.TabIndex = 331;
            this.textBoxSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(383, 255);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.ReadOnly = true;
            this.textBoxMinutes.Size = new System.Drawing.Size(66, 21);
            this.textBoxMinutes.TabIndex = 330;
            this.textBoxMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(311, 255);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.ReadOnly = true;
            this.textBoxHours.Size = new System.Drawing.Size(66, 21);
            this.textBoxHours.TabIndex = 329;
            this.textBoxHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(239, 255);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.ReadOnly = true;
            this.textBoxDays.Size = new System.Drawing.Size(66, 21);
            this.textBoxDays.TabIndex = 328;
            this.textBoxDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label290
            // 
            this.label290.AutoSize = true;
            this.label290.Location = new System.Drawing.Point(462, 237);
            this.label290.Name = "label290";
            this.label290.Size = new System.Drawing.Size(55, 15);
            this.label290.TabIndex = 325;
            this.label290.Text = "Seconds";
            // 
            // label289
            // 
            this.label289.AutoSize = true;
            this.label289.Location = new System.Drawing.Point(392, 237);
            this.label289.Name = "label289";
            this.label289.Size = new System.Drawing.Size(51, 15);
            this.label289.TabIndex = 324;
            this.label289.Text = "Minutes";
            // 
            // label288
            // 
            this.label288.AutoSize = true;
            this.label288.Location = new System.Drawing.Point(324, 237);
            this.label288.Name = "label288";
            this.label288.Size = new System.Drawing.Size(40, 15);
            this.label288.TabIndex = 323;
            this.label288.Text = "Hours";
            // 
            // label287
            // 
            this.label287.AutoSize = true;
            this.label287.Location = new System.Drawing.Point(255, 237);
            this.label287.Name = "label287";
            this.label287.Size = new System.Drawing.Size(34, 15);
            this.label287.TabIndex = 322;
            this.label287.Text = "Days";
            // 
            // label284
            // 
            this.label284.AutoSize = true;
            this.label284.Location = new System.Drawing.Point(239, 217);
            this.label284.Name = "label284";
            this.label284.Size = new System.Drawing.Size(54, 15);
            this.label284.TabIndex = 321;
            this.label284.Text = "Duration";
            // 
            // label281
            // 
            this.label281.AutoSize = true;
            this.label281.Location = new System.Drawing.Point(529, 141);
            this.label281.Name = "label281";
            this.label281.Size = new System.Drawing.Size(19, 15);
            this.label281.TabIndex = 320;
            this.label281.Text = "ss";
            // 
            // textBoxss2
            // 
            this.textBoxss2.Location = new System.Drawing.Point(526, 160);
            this.textBoxss2.Name = "textBoxss2";
            this.textBoxss2.Size = new System.Drawing.Size(28, 21);
            this.textBoxss2.TabIndex = 310;
            this.textBoxss2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label282
            // 
            this.label282.AutoSize = true;
            this.label282.Location = new System.Drawing.Point(492, 141);
            this.label282.Name = "label282";
            this.label282.Size = new System.Drawing.Size(29, 15);
            this.label282.TabIndex = 319;
            this.label282.Text = "mm";
            // 
            // textBoxmm2
            // 
            this.textBoxmm2.Location = new System.Drawing.Point(492, 160);
            this.textBoxmm2.Name = "textBoxmm2";
            this.textBoxmm2.Size = new System.Drawing.Size(28, 21);
            this.textBoxmm2.TabIndex = 309;
            this.textBoxmm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label283
            // 
            this.label283.AutoSize = true;
            this.label283.Location = new System.Drawing.Point(460, 141);
            this.label283.Name = "label283";
            this.label283.Size = new System.Drawing.Size(25, 15);
            this.label283.TabIndex = 318;
            this.label283.Text = "HH";
            // 
            // textBoxHH2
            // 
            this.textBoxHH2.Location = new System.Drawing.Point(458, 160);
            this.textBoxHH2.Name = "textBoxHH2";
            this.textBoxHH2.Size = new System.Drawing.Size(28, 21);
            this.textBoxHH2.TabIndex = 308;
            this.textBoxHH2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label280
            // 
            this.label280.AutoSize = true;
            this.label280.Location = new System.Drawing.Point(310, 141);
            this.label280.Name = "label280";
            this.label280.Size = new System.Drawing.Size(19, 15);
            this.label280.TabIndex = 317;
            this.label280.Text = "ss";
            // 
            // textBoxss1
            // 
            this.textBoxss1.Location = new System.Drawing.Point(307, 160);
            this.textBoxss1.Name = "textBoxss1";
            this.textBoxss1.Size = new System.Drawing.Size(28, 21);
            this.textBoxss1.TabIndex = 306;
            this.textBoxss1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label279
            // 
            this.label279.AutoSize = true;
            this.label279.Location = new System.Drawing.Point(272, 141);
            this.label279.Name = "label279";
            this.label279.Size = new System.Drawing.Size(29, 15);
            this.label279.TabIndex = 316;
            this.label279.Text = "mm";
            // 
            // textBoxmm1
            // 
            this.textBoxmm1.Location = new System.Drawing.Point(273, 160);
            this.textBoxmm1.Name = "textBoxmm1";
            this.textBoxmm1.Size = new System.Drawing.Size(28, 21);
            this.textBoxmm1.TabIndex = 305;
            this.textBoxmm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label278
            // 
            this.label278.AutoSize = true;
            this.label278.Location = new System.Drawing.Point(242, 141);
            this.label278.Name = "label278";
            this.label278.Size = new System.Drawing.Size(25, 15);
            this.label278.TabIndex = 315;
            this.label278.Text = "HH";
            // 
            // textBoxHH1
            // 
            this.textBoxHH1.Location = new System.Drawing.Point(239, 160);
            this.textBoxHH1.Name = "textBoxHH1";
            this.textBoxHH1.Size = new System.Drawing.Size(28, 21);
            this.textBoxHH1.TabIndex = 304;
            this.textBoxHH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label277
            // 
            this.label277.AutoSize = true;
            this.label277.Location = new System.Drawing.Point(458, 95);
            this.label277.Name = "label277";
            this.label277.Size = new System.Drawing.Size(58, 15);
            this.label277.TabIndex = 314;
            this.label277.Text = "Date End";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(458, 114);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 307;
            // 
            // label276
            // 
            this.label276.AutoSize = true;
            this.label276.Location = new System.Drawing.Point(239, 95);
            this.label276.Name = "label276";
            this.label276.Size = new System.Drawing.Size(61, 15);
            this.label276.TabIndex = 313;
            this.label276.Text = "Date Start";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 303;
            // 
            // textBox42
            // 
            this.textBox42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox42.BackColor = System.Drawing.Color.Blue;
            this.textBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox42.ForeColor = System.Drawing.Color.White;
            this.textBox42.Location = new System.Drawing.Point(6, 7);
            this.textBox42.Name = "textBox42";
            this.textBox42.ReadOnly = true;
            this.textBox42.Size = new System.Drawing.Size(927, 29);
            this.textBox42.TabIndex = 302;
            this.textBox42.Text = "Time Duration Calculator and Hourly Converter";
            this.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox44
            // 
            this.textBox44.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox44.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox44.ForeColor = System.Drawing.Color.White;
            this.textBox44.Location = new System.Drawing.Point(239, 55);
            this.textBox44.Name = "textBox44";
            this.textBox44.ReadOnly = true;
            this.textBox44.Size = new System.Drawing.Size(419, 22);
            this.textBox44.TabIndex = 299;
            this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPart75
            // 
            this.buttonPart75.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPart75.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPart75.BackColor = System.Drawing.Color.Blue;
            this.buttonPart75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPart75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPart75.ForeColor = System.Drawing.Color.White;
            this.buttonPart75.Location = new System.Drawing.Point(43, 257);
            this.buttonPart75.Name = "buttonPart75";
            this.buttonPart75.Size = new System.Drawing.Size(110, 42);
            this.buttonPart75.TabIndex = 128;
            this.buttonPart75.Text = "Part 75";
            this.toolTip1.SetToolTip(this.buttonPart75, "Part 75");
            this.buttonPart75.UseVisualStyleBackColor = false;
            this.buttonPart75.Click += new System.EventHandler(this.buttonPart75_Click);
            // 
            // textBoxSectionHeading
            // 
            this.textBoxSectionHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSectionHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSectionHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSectionHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSectionHeading.ForeColor = System.Drawing.Color.White;
            this.textBoxSectionHeading.Location = new System.Drawing.Point(200, 9);
            this.textBoxSectionHeading.Multiline = true;
            this.textBoxSectionHeading.Name = "textBoxSectionHeading";
            this.textBoxSectionHeading.ReadOnly = true;
            this.textBoxSectionHeading.Size = new System.Drawing.Size(942, 41);
            this.textBoxSectionHeading.TabIndex = 127;
            this.textBoxSectionHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDefinitions
            // 
            this.buttonDefinitions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDefinitions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDefinitions.BackColor = System.Drawing.Color.Blue;
            this.buttonDefinitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefinitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefinitions.ForeColor = System.Drawing.Color.White;
            this.buttonDefinitions.Location = new System.Drawing.Point(43, 353);
            this.buttonDefinitions.Name = "buttonDefinitions";
            this.buttonDefinitions.Size = new System.Drawing.Size(110, 42);
            this.buttonDefinitions.TabIndex = 2;
            this.buttonDefinitions.Text = "Definitions";
            this.toolTip1.SetToolTip(this.buttonDefinitions, "Definitions");
            this.buttonDefinitions.UseVisualStyleBackColor = false;
            this.buttonDefinitions.Click += new System.EventHandler(this.buttonDefinitions_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.Image")));
            this.pictureBoxMain.Location = new System.Drawing.Point(200, 130);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(947, 545);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 126;
            this.pictureBoxMain.TabStop = false;
            // 
            // textBoxDefinitions
            // 
            this.textBoxDefinitions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDefinitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefinitions.Location = new System.Drawing.Point(200, 129);
            this.textBoxDefinitions.Multiline = true;
            this.textBoxDefinitions.Name = "textBoxDefinitions";
            this.textBoxDefinitions.ReadOnly = true;
            this.textBoxDefinitions.Size = new System.Drawing.Size(947, 547);
            this.textBoxDefinitions.TabIndex = 125;
            this.textBoxDefinitions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTechQuestions
            // 
            this.buttonTechQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTechQuestions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTechQuestions.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonTechQuestions.Enabled = false;
            this.buttonTechQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTechQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTechQuestions.ForeColor = System.Drawing.Color.White;
            this.buttonTechQuestions.Location = new System.Drawing.Point(43, 612);
            this.buttonTechQuestions.Name = "buttonTechQuestions";
            this.buttonTechQuestions.Size = new System.Drawing.Size(110, 42);
            this.buttonTechQuestions.TabIndex = 10;
            this.buttonTechQuestions.Text = "Tech Questions";
            this.toolTip1.SetToolTip(this.buttonTechQuestions, "Technical Test Questions");
            this.buttonTechQuestions.UseVisualStyleBackColor = false;
            // 
            // buttonSoftwareQuestions
            // 
            this.buttonSoftwareQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSoftwareQuestions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSoftwareQuestions.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSoftwareQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoftwareQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoftwareQuestions.ForeColor = System.Drawing.Color.White;
            this.buttonSoftwareQuestions.Location = new System.Drawing.Point(43, 564);
            this.buttonSoftwareQuestions.Name = "buttonSoftwareQuestions";
            this.buttonSoftwareQuestions.Size = new System.Drawing.Size(110, 42);
            this.buttonSoftwareQuestions.TabIndex = 9;
            this.buttonSoftwareQuestions.Text = "Software Questions";
            this.toolTip1.SetToolTip(this.buttonSoftwareQuestions, "Software Test Questions");
            this.buttonSoftwareQuestions.UseVisualStyleBackColor = false;
            this.buttonSoftwareQuestions.Click += new System.EventHandler(this.buttonSoftwareQuestions_Click);
            // 
            // labelSectionSubHeading
            // 
            this.labelSectionSubHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSectionSubHeading.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelSectionSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionSubHeading.ForeColor = System.Drawing.Color.White;
            this.labelSectionSubHeading.Location = new System.Drawing.Point(199, 53);
            this.labelSectionSubHeading.MaximumSize = new System.Drawing.Size(947, 58);
            this.labelSectionSubHeading.Name = "labelSectionSubHeading";
            this.labelSectionSubHeading.Size = new System.Drawing.Size(943, 46);
            this.labelSectionSubHeading.TabIndex = 122;
            this.labelSectionSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdmin.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Location = new System.Drawing.Point(43, 660);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(110, 42);
            this.buttonAdmin.TabIndex = 16;
            this.buttonAdmin.Text = "Admin";
            this.toolTip1.SetToolTip(this.buttonAdmin, "Admin Functions");
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonUnitsOfMeasure
            // 
            this.buttonUnitsOfMeasure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUnitsOfMeasure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUnitsOfMeasure.BackColor = System.Drawing.Color.Blue;
            this.buttonUnitsOfMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnitsOfMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnitsOfMeasure.ForeColor = System.Drawing.Color.White;
            this.buttonUnitsOfMeasure.Location = new System.Drawing.Point(43, 496);
            this.buttonUnitsOfMeasure.Name = "buttonUnitsOfMeasure";
            this.buttonUnitsOfMeasure.Size = new System.Drawing.Size(110, 42);
            this.buttonUnitsOfMeasure.TabIndex = 8;
            this.buttonUnitsOfMeasure.Text = "Units of Measure";
            this.toolTip1.SetToolTip(this.buttonUnitsOfMeasure, "Units of Measure");
            this.buttonUnitsOfMeasure.UseVisualStyleBackColor = false;
            this.buttonUnitsOfMeasure.Click += new System.EventHandler(this.buttonUnitsOfMeasure_Click);
            // 
            // buttonPart75PlainEnglish
            // 
            this.buttonPart75PlainEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPart75PlainEnglish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPart75PlainEnglish.BackColor = System.Drawing.Color.Blue;
            this.buttonPart75PlainEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPart75PlainEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPart75PlainEnglish.ForeColor = System.Drawing.Color.White;
            this.buttonPart75PlainEnglish.Location = new System.Drawing.Point(43, 209);
            this.buttonPart75PlainEnglish.Name = "buttonPart75PlainEnglish";
            this.buttonPart75PlainEnglish.Size = new System.Drawing.Size(110, 42);
            this.buttonPart75PlainEnglish.TabIndex = 7;
            this.buttonPart75PlainEnglish.Text = "Part 75\r\nPlain English";
            this.toolTip1.SetToolTip(this.buttonPart75PlainEnglish, "Part 75 Plain English Version");
            this.buttonPart75PlainEnglish.UseVisualStyleBackColor = false;
            this.buttonPart75PlainEnglish.Click += new System.EventHandler(this.buttonPart75PlainEnglish_Click);
            // 
            // buttonPart63SubUUUUU
            // 
            this.buttonPart63SubUUUUU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPart63SubUUUUU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPart63SubUUUUU.BackColor = System.Drawing.Color.Blue;
            this.buttonPart63SubUUUUU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPart63SubUUUUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPart63SubUUUUU.ForeColor = System.Drawing.Color.White;
            this.buttonPart63SubUUUUU.Location = new System.Drawing.Point(43, 161);
            this.buttonPart63SubUUUUU.Name = "buttonPart63SubUUUUU";
            this.buttonPart63SubUUUUU.Size = new System.Drawing.Size(110, 42);
            this.buttonPart63SubUUUUU.TabIndex = 6;
            this.buttonPart63SubUUUUU.Text = "Part 63\r\nSub. UUUUU";
            this.toolTip1.SetToolTip(this.buttonPart63SubUUUUU, "Part 63 Subpart UUUUU");
            this.buttonPart63SubUUUUU.UseVisualStyleBackColor = false;
            this.buttonPart63SubUUUUU.Click += new System.EventHandler(this.buttonPart63SubUUUUU_Click);
            // 
            // button60AppBF
            // 
            this.button60AppBF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button60AppBF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button60AppBF.BackColor = System.Drawing.Color.Blue;
            this.button60AppBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button60AppBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button60AppBF.ForeColor = System.Drawing.Color.White;
            this.button60AppBF.Location = new System.Drawing.Point(43, 114);
            this.button60AppBF.Name = "button60AppBF";
            this.button60AppBF.Size = new System.Drawing.Size(110, 42);
            this.button60AppBF.TabIndex = 5;
            this.button60AppBF.Text = "Part 60\r\nApp. B and F";
            this.toolTip1.SetToolTip(this.button60AppBF, "Part 60 Appendix B and F");
            this.button60AppBF.UseVisualStyleBackColor = false;
            this.button60AppBF.Click += new System.EventHandler(this.button60AppBF_Click);
            // 
            // buttonChemicalFormulas
            // 
            this.buttonChemicalFormulas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChemicalFormulas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChemicalFormulas.BackColor = System.Drawing.Color.Blue;
            this.buttonChemicalFormulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChemicalFormulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChemicalFormulas.ForeColor = System.Drawing.Color.White;
            this.buttonChemicalFormulas.Location = new System.Drawing.Point(43, 448);
            this.buttonChemicalFormulas.Name = "buttonChemicalFormulas";
            this.buttonChemicalFormulas.Size = new System.Drawing.Size(110, 42);
            this.buttonChemicalFormulas.TabIndex = 4;
            this.buttonChemicalFormulas.Text = "Elements and Gas Types";
            this.toolTip1.SetToolTip(this.buttonChemicalFormulas, "\'How To\' Documentation");
            this.buttonChemicalFormulas.UseVisualStyleBackColor = false;
            this.buttonChemicalFormulas.Click += new System.EventHandler(this.buttonChemicalFormulas_Click);
            // 
            // buttonFormulas
            // 
            this.buttonFormulas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFormulas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFormulas.BackColor = System.Drawing.Color.Blue;
            this.buttonFormulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormulas.ForeColor = System.Drawing.Color.White;
            this.buttonFormulas.Location = new System.Drawing.Point(43, 400);
            this.buttonFormulas.Name = "buttonFormulas";
            this.buttonFormulas.Size = new System.Drawing.Size(110, 42);
            this.buttonFormulas.TabIndex = 3;
            this.buttonFormulas.Text = "Formulas / Equations";
            this.toolTip1.SetToolTip(this.buttonFormulas, "Formulas");
            this.buttonFormulas.UseVisualStyleBackColor = false;
            this.buttonFormulas.Click += new System.EventHandler(this.buttonFormulas_Click);
            // 
            // buttonAcronyms
            // 
            this.buttonAcronyms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAcronyms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAcronyms.BackColor = System.Drawing.Color.Blue;
            this.buttonAcronyms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcronyms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcronyms.ForeColor = System.Drawing.Color.White;
            this.buttonAcronyms.Location = new System.Drawing.Point(43, 305);
            this.buttonAcronyms.Name = "buttonAcronyms";
            this.buttonAcronyms.Size = new System.Drawing.Size(110, 42);
            this.buttonAcronyms.TabIndex = 1;
            this.buttonAcronyms.Text = "Acronyms";
            this.toolTip1.SetToolTip(this.buttonAcronyms, "Acronyms");
            this.buttonAcronyms.UseVisualStyleBackColor = false;
            this.buttonAcronyms.Click += new System.EventHandler(this.buttonAcronyms_Click);
            // 
            // webBrowserPdf
            // 
            this.webBrowserPdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBrowserPdf.Location = new System.Drawing.Point(200, 129);
            this.webBrowserPdf.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPdf.Name = "webBrowserPdf";
            this.webBrowserPdf.Size = new System.Drawing.Size(947, 545);
            this.webBrowserPdf.TabIndex = 112;
            // 
            // comboBoxSectionNumber
            // 
            this.comboBoxSectionNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSectionNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxSectionNumber.DisplayMember = "Part_60_Number";
            this.comboBoxSectionNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSectionNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSectionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSectionNumber.FormattingEnabled = true;
            this.comboBoxSectionNumber.Location = new System.Drawing.Point(200, 104);
            this.comboBoxSectionNumber.Name = "comboBoxSectionNumber";
            this.comboBoxSectionNumber.Size = new System.Drawing.Size(947, 28);
            this.comboBoxSectionNumber.TabIndex = 11;
            this.comboBoxSectionNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxSectionNumber_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1072, 688);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Tag = "Exit Application";
            this.buttonExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.buttonExit, "Exit Application");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonToggle
            // 
            this.buttonToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonToggle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonToggle.BackColor = System.Drawing.Color.Blue;
            this.buttonToggle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToggle.ForeColor = System.Drawing.Color.White;
            this.buttonToggle.Location = new System.Drawing.Point(362, 688);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(75, 23);
            this.buttonToggle.TabIndex = 14;
            this.buttonToggle.Tag = "Click to toggle Answer";
            this.buttonToggle.Text = "Show";
            this.toolTip1.SetToolTip(this.buttonToggle, "Show / Hide");
            this.buttonToggle.UseVisualStyleBackColor = false;
            this.buttonToggle.Visible = false;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNext.BackColor = System.Drawing.Color.Black;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(281, 688);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Tag = "Next Question";
            this.buttonNext.Text = ">>";
            this.toolTip1.SetToolTip(this.buttonNext, "Next");
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(200, 688);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Tag = "Previous Question";
            this.buttonBack.Text = "<<";
            this.toolTip1.SetToolTip(this.buttonBack, "Previous");
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1224, 760);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1240, 799);
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFormulas.ResumeLayout(false);
            this.tabFormulasMain.ResumeLayout(false);
            this.tabOilFlow.ResumeLayout(false);
            this.tabOilFlow.PerformLayout();
            this.tabCO2Gas.ResumeLayout(false);
            this.tabCO2Gas.PerformLayout();
            this.tabCO2Oil.ResumeLayout(false);
            this.tabCO2Oil.PerformLayout();
            this.tabCO2Flow.ResumeLayout(false);
            this.tabCO2Flow.PerformLayout();
            this.tabHeatInputGas.ResumeLayout(false);
            this.tabHeatInputGas.PerformLayout();
            this.tabHeatInputOil.ResumeLayout(false);
            this.tabHeatInputOil.PerformLayout();
            this.tabHeatInputFlow.ResumeLayout(false);
            this.tabHeatInputFlow.PerformLayout();
            this.tabSO2Gas.ResumeLayout(false);
            this.tabSO2Gas.PerformLayout();
            this.tabSO2Oil.ResumeLayout(false);
            this.tabSO2Oil.PerformLayout();
            this.tabSO2Flow.ResumeLayout(false);
            this.tabSO2Flow.PerformLayout();
            this.tabNOxlbsmmBtu.ResumeLayout(false);
            this.tabNOxlbsmmBtu.PerformLayout();
            this.tabNOxlbshr.ResumeLayout(false);
            this.tabNOxlbshr.PerformLayout();
            this.tabNOxppmvd.ResumeLayout(false);
            this.tabNOxppmvd.PerformLayout();
            this.tabFuelFactor.ResumeLayout(false);
            this.tabFuelFactor.PerformLayout();
            this.tabCoal.ResumeLayout(false);
            this.tabCoal.PerformLayout();
            this.tabColbsmmBtu.ResumeLayout(false);
            this.tabColbsmmBtu.PerformLayout();
            this.tabCOlbshr.ResumeLayout(false);
            this.tabCOlbshr.PerformLayout();
            this.tabCOppmvd.ResumeLayout(false);
            this.tabCOppmvd.PerformLayout();
            this.tabPage4_20ma.ResumeLayout(false);
            this.tabPage4_20ma.PerformLayout();
            this.tabPageHg.ResumeLayout(false);
            this.tabPageHg.PerformLayout();
            this.tabPageLME_HI.ResumeLayout(false);
            this.tabPageLME_HI.PerformLayout();
            this.tabPageLME_Mass.ResumeLayout(false);
            this.tabPageLME_Mass.PerformLayout();
            this.tabTime.ResumeLayout(false);
            this.tabTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonDefinitions;
        private PictureBox pictureBoxMain;
        private TextBox textBoxDefinitions;
        private Button buttonTechQuestions;
        private Button buttonSoftwareQuestions;
        private Label labelSectionSubHeading;
        private PictureBox pictureBox1;
        private Button buttonAdmin;
        private Button buttonUnitsOfMeasure;
        private Button buttonPart75PlainEnglish;
        private Button buttonPart63SubUUUUU;
        private Button button60AppBF;
        private Button buttonChemicalFormulas;
        private Button buttonFormulas;
        private Button buttonAcronyms;
        private WebBrowser webBrowserPdf;
        private ComboBox comboBoxSectionNumber;
        private Button buttonExit;
        private Button buttonToggle;
        private Button buttonNext;
        private Button buttonBack;
        private TextBox textBoxSectionHeading;
        private ToolTip toolTip1;
        private Button buttonPart75;
        private Panel panelFormulas;
        private TabControl tabFormulasMain;
        private TabPage tabOilFlow;
        private TabPage tabCO2Gas;
        private TabPage tabCO2Oil;
        private TabPage tabCO2Flow;
        private TabPage tabHeatInputGas;
        private TabPage tabHeatInputOil;
        private TabPage tabHeatInputFlow;
        private TabPage tabSO2Gas;
        private TextBox textBox2;
        private Button buttonTabCO2GasF1Calculate;
        private Label label1;
        private TextBox textBoxTabCO2F1Answer;
        private TextBox textBoxTabCO2GasF1GasFlow;
        private TextBox textBoxTabCO2GasF1CarbonContent;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox7;
        private Button buttonTabCO2GasF3Calculate;
        private Label label21;
        private TextBox textBoxTabCO2GasF3Answer;
        private TextBox textBoxTabCO2GasF3GasFlow;
        private TextBox textBoxTabCO2GasF3CO2Concentration;
        private Label label22;
        private Label label23;
        private Label label25;
        private Label label26;
        private TextBox textBox3;
        private Button buttonTabCO2GasF2Calculate;
        private Label label15;
        private TextBox textBoxTabCO2GasF2Answer;
        private TextBox textBoxTabCO2GasF2HTIP;
        private Label label17;
        private Label label19;
        private Label label20;
        private TabPage tabSO2Oil;
        private TextBox textBox5;
        private TabPage tabSO2Flow;
        private TabPage tabNOxlbsmmBtu;
        private TabPage tabNOxlbshr;
        private TabPage tabNOxppmvd;
        private TabPage tabFuelFactor;
        private TextBox textBox11;
        private TextBox textBox23;
        private Button buttonTabCO2OilF3Calculate;
        private Label label16;
        private TextBox textBoxTabCO2OilF3Answer;
        private TextBox textBoxTabCO2OilF3MassOfOil;
        private TextBox textBoxTabCO2OilF3CO2Concentration;
        private Label label18;
        private Label label24;
        private Label label27;
        private Label label28;
        private TextBox textBox27;
        private Button buttonTabCO2OilF2Calculate;
        private Label label29;
        private TextBox textBoxTabCO2OilF2Answer;
        private TextBox textBoxTabCO2OilF2HTIP;
        private Label label30;
        private Label label31;
        private Label label32;
        private TextBox textBox30;
        private Button buttonTabCO2OilF1Calculate;
        private Label label33;
        private TextBox textBoxTabCO2OilF1Answer;
        private TextBox textBoxTabCO2OilF1MassOil;
        private TextBox textBoxTabCO2OilF1CarbonContent;
        private Label label34;
        private Label label35;
        private Label label37;
        private Label label38;
        private TextBox textBox12;
        private TextBox textBox41;
        private Button buttonTabCO2FlowF1CO2Calculate;
        private Label label48;
        private TextBox textBoxTabCO2FlowF1Answer;
        private TextBox textBoxTabCO2FlowF1Flow;
        private TextBox textBoxTabCO2FlowF1CO2Concentration;
        private Label label49;
        private Label label50;
        private Label label52;
        private Label label53;
        private TextBox textBox13;
        private TextBox textBoxTabHTIPGasF2FuelFactor;
        private TextBox textBoxTabHTIPGasF2CO2Concentration;
        private Label label56;
        private TextBox textBox49;
        private Button buttonTabHTIPGasF2Answer;
        private Label label59;
        private TextBox textBoxTabHTIPGasF2Answer;
        private TextBox textBoxTabHTIPGasF2GasFlow;
        private Label label60;
        private Label label61;
        private Label label62;
        private TextBox textBox52;
        private Button buttonTabHTIPGasF1Calculate;
        private TextBox textBoxTabHTIPGasF1Answer;
        private TextBox textBoxTabHTIPGasF1GasFlow;
        private TextBox textBoxTabHTIPGasF1GCV;
        private Label label64;
        private Label label65;
        private Label label67;
        private Label label68;
        private TextBox textBox14;
        private TextBox textBox60;
        private Button buttonTabHTIPOilF2Calculate;
        private Label label74;
        private TextBox textBoxTabHTIPOilF2Answer;
        private TextBox textBoxTabHTIPOilF2MassOfOil;
        private Label label75;
        private Label label76;
        private Label label77;
        private TextBox textBox63;
        private Button buttonTabHTIPOilF1Calculate;
        private Label label78;
        private TextBox textBoxTabHTIPOilF1Answer;
        private TextBox textBoxTabHTIPOilF1MassOfOil;
        private TextBox textBoxTabHTIPOilF1GCV;
        private Label label79;
        private Label label80;
        private Label label82;
        private Label label195;
        private TextBox textBox15;
        private TextBox textBox74;
        private Button buttonTabHTIPFlowF1Calculate;
        private Label label92;
        private TextBox textBoxTabHTIPFlowF1Answer;
        private TextBox textBoxTabHTIPFlowF1CO2Concentration;
        private TextBox textBoxTabHTIPFlowF1Flow;
        private Label label93;
        private Label label94;
        private Label label95;
        private Label label96;
        private Label label196;
        private TextBox textBox16;
        private TextBox textBox82;
        private Button buttonTabSO2GasF2Calculate;
        private Label label102;
        private TextBox textBoxTabSO2GasF2Answer;
        private TextBox textBoxTabSO2GasF2SO2Concentration;
        private Label label103;
        private Label label104;
        private Label label105;
        private TextBox textBox85;
        private Button buttonTabSO2GasF1Calculate;
        private Label label106;
        private TextBox textBoxTabSO2GasF1Answer;
        private TextBox textBoxTabSO2GasF1HTIP;
        private Label label108;
        private Label label197;
        private TextBox textBox17;
        private TextBox textBox89;
        private Button buttonTabSO2OilF3Calculate;
        private Label label111;
        private TextBox textBoxTabSO2OilF3Answer;
        private TextBox textBoxTabSO2OilF3MassOfOil;
        private TextBox textBoxTabSO2OilF3SO2Concentration;
        private Label label112;
        private Label label113;
        private Label label114;
        private Label label115;
        private TextBox textBox93;
        private Button buttonTabSO2OilF2Calculate;
        private Label label116;
        private TextBox textBoxTabSO2OilF2Answer;
        private TextBox textBoxTabSO2OilF2MassOfOil;
        private Label label117;
        private Label label118;
        private Label label119;
        private TextBox textBox96;
        private Button buttonTabSO2OilF1Calculate;
        private Label label120;
        private TextBox textBoxTabSO2OilF1Answer;
        private TextBox textBoxTabSO2OilF1SulfurContent;
        private TextBox textBoxTabSO2OilF1MassOfOil;
        private Label label121;
        private Label label122;
        private Label label124;
        private Label label198;
        private TextBox textBox18;
        private Label label126;
        private Label label127;
        private Label label128;
        private Label label129;
        private TextBox textBox107;
        private Button buttonTabSO2FlowF1Calculate;
        private Label label134;
        private TextBox textBoxTabSO2FlowF1Answer;
        private TextBox textBoxTabSO2FlowF1Flow;
        private TextBox textBoxTabSO2FlowF1SO2Concentration;
        private TextBox textBox19;
        private TextBox textBox115;
        private Label label146;
        private Label label147;
        private TextBox textBox118;
        private Button buttonTabNOxlbsmmBtuF1Calculate;
        private Label label148;
        private TextBox textBoxTabNOxlbsmmBtuF1Answer;
        private TextBox textBoxTabNOxlbsmmBtuF1CO2;
        private TextBox textBoxTabNOxlbsmmBtuF1NOx;
        private Label label149;
        private Label label150;
        private Label label200;
        private TextBox textBox20;
        private TextBox textBox126;
        private TextBox textBox129;
        private Button buttonTabNOxlbshrF1Calculate;
        private Label label162;
        private TextBox textBoxTabNOxlbshrF1Answer;
        private TextBox textBoxTabNOxlbshrF1Fc;
        private TextBox textBoxTabNOxlbshrF1NOx;
        private Label label163;
        private Label label164;
        private Label label165;
        private Label label166;
        private Label label201;
        private TextBox textBox21;
        private TextBox textBox137;
        private Button buttonTabNOxppmvdF2Calculate;
        private Label label172;
        private TextBox textBoxTabNOxppmvdF2Answer;
        private TextBox textBoxTabNOxppmvdF2NOx;
        private Label label173;
        private Label label174;
        private Label label175;
        private TextBox textBox140;
        private Button buttonTabNOxppmvdF1Calculate;
        private Label label176;
        private TextBox textBoxTabNOxppmvdF1Answer;
        private TextBox textBoxTabNOxppmvdF1O2;
        private TextBox textBoxTabNOxppmvdF1NOx;
        private Label label177;
        private Label label178;
        private TextBox textBox22;
        private TextBox textBox151;
        private Button buttonTabFuelFactorF1Calculate;
        private Label label190;
        private TextBox textBoxTabFuelFactorF1Answer;
        private TextBox textBoxTabFuelFactorF1HTIPGas;
        private TextBox textBoxTabFuelFactorF1HTIPOil;
        private Label label191;
        private Label label192;
        private Label label194;
        private Label label203;
        private Label label40;
        private Label label39;
        private Label label36;
        private Label label43;
        private TextBox textBoxTabHTIPOilF2FuelFactor;
        private TextBox textBoxTabHTIPOilF2CO2Concentration;
        private Label label42;
        private Label label41;
        private Label label44;
        private TextBox textBoxTabHTIPFlowF1FuelFactor;
        private Label label46;
        private TextBox textBoxTabSO2GasF2GasFlow;
        private TextBox textBoxTabSO2OilF2SulfurContent;
        private Label label45;
        private Label label72;
        private TextBox textBoxTabNOxlbsmmBtuF2BAF;
        private Label label73;
        private TextBox textBoxTabNOxlbsmmBtuF2Fc;
        private Button buttonTabNOxlbsmmBtuF2Calculate;
        private Label label81;
        private TextBox textBoxTabNOxlbsmmBtuF2Answer;
        private TextBox textBoxTabNOxlbsmmBtuF2O2;
        private TextBox textBoxTabNOxlbsmmBtuF2NOx;
        private Label label83;
        private Label label84;
        private Label label71;
        private Label label70;
        private Label label69;
        private Label label66;
        private Label label63;
        private Label label58;
        private TextBox textBoxTabNOxlbsmmBtuF1BAF;
        private Label label57;
        private TextBox textBoxTabNOxlbsmmBtuF1Fc;
        private Label label55;
        private Label label54;
        private Label label51;
        private Label label47;
        private Label label89;
        private TextBox textBoxTabNOxlbshrF2OT;
        private Label label90;
        private Label label97;
        private Button buttonTabNOxlbshrF2Answer;
        private Label label98;
        private TextBox textBoxTabNOxlbshrF2Answer;
        private TextBox textBoxTabNOxlbshrF2HTIP;
        private TextBox textBoxTabNOxlbshrF2NOx;
        private Label label99;
        private Label label100;
        private Label label101;
        private Label label107;
        private Label label109;
        private Label label88;
        private TextBox textBoxTabNOxlbshrF1OT;
        private Label label87;
        private Label label86;
        private Label label85;
        private ComboBox comboBoxTabNOxppmvdF2XCO2;
        private TextBox textBoxTabNOxppmvdF2CO2;
        private Label label110;
        private Label label91;
        private TabPage tabCoal;
        private Label label161;
        private TextBox textBoxTabCoalF4BAF;
        private Label label123;
        private TextBox textBoxTabCoalF4Fc;
        private Button buttonTabCoalF4Calculate;
        private Label label125;
        private TextBox textBoxTabCoalF4Answer;
        private TextBox textBoxTabCoalF4CO2;
        private TextBox textBoxTabCoalF4NOx;
        private Label label159;
        private Label label160;
        private Label label158;
        private Label label157;
        private Label label156;
        private Label label135;
        private Label label145;
        private Label label133;
        private Label label136;
        private TextBox textBox73;
        private Label label137;
        private TextBox textBox81;
        private Button buttonTabCoalF3Calculate;
        private Label label139;
        private TextBox textBoxTabCoalF3Answer;
        private TextBox textBoxTabCoalF3FuelFlow;
        private TextBox textBoxTabCoalF3CO2Concentration;
        private Label label141;
        private Label label142;
        private Button buttonTabCoalF2Calculate;
        private Label label130;
        private TextBox textBoxTabCoalF2Answer;
        private TextBox textBoxTabCoalF2FuelFlow;
        private TextBox textBoxTabCoalF2SO2Concentration;
        private Label label131;
        private Label label132;
        private Label label138;
        private Label label140;
        private TextBox textBoxTabCoalF1FuelFactor;
        private Label label143;
        private Label label144;
        private TextBox textBox100;
        private TextBox textBox101;
        private Label label151;
        private TextBox textBox102;
        private Button buttonTabCoalF1Calculate;
        private Label label152;
        private TextBox textBoxTabCoalF1Answer;
        private TextBox textBoxTabCoalF1CO2Concentration;
        private TextBox textBoxTabCoalF1FuelFlow;
        private Label label153;
        private Label label154;
        private Label label155;
        private TabPage tabColbsmmBtu;
        private Label label168;
        private TextBox textBoxTabCOlbsmmBtuF2FuelFactor;
        private Button buttonCOlbsmmBtuF2Calculate;
        private Label label169;
        private TextBox textBoxTabCOlbsmmBtuF2Answer;
        private TextBox textBoxTabCOlbsmmBtuF2O2;
        private TextBox textBoxTabCOlbsmmBtuF2CO;
        private Label label170;
        private Label label171;
        private Label label180;
        private Label label181;
        private Label label182;
        private Label label183;
        private Label label185;
        private TextBox textBoxTabCOlbsmmBtuF1FuelFactor;
        private Label label186;
        private Label label187;
        private Label label188;
        private TextBox textBox134;
        private TextBox textBox135;
        private Label label189;
        private TextBox textBox136;
        private Button buttonCOlbsmmBtuF1Calculate;
        private Label label193;
        private TextBox textBoxTabCOlbsmmBtuF1Answer;
        private TextBox textBoxTabCOlbsmmBtuF1CO2;
        private TextBox textBoxTabCOlbsmmBtuF1CO;
        private Label label199;
        private Label label202;
        private Label label204;
        private TextBox textBoxTabOilFlowMassF1OilFlow;
        private TextBox textBoxTabOilFlowF1Density;
        private TextBox textBoxTabOilFlowF1OilFlow;
        private TextBox textBox1;
        private TextBox textBox170;
        private Button buttonTabOilFlowF1Calculate;
        private Label label207;
        private Label label208;
        private Label label210;
        private Label label211;
        private Label label212;
        private Label label213;
        private TabPage tabCOlbshr;
        private TextBox textBox150;
        private TextBox textBox156;
        private Button buttonTabCOlbshrF1Calculate;
        private Label label215;
        private TextBox textBoxTabCOlbshrF1Answer;
        private TextBox textBoxTabCOlbshrF1HTIP;
        private TextBox textBoxTabCOlbshrF1CO;
        private Label label216;
        private Label label217;
        private Label label218;
        private Label label219;
        private Label label220;
        private TabPage tabCOppmvd;
        private ComboBox comboBoxTabCOppmvdF2XCO2;
        private Label label167;
        private Button buttonTabCOppmvdF2Calculate;
        private Label label179;
        private TextBox textBoxTabCOppmvdF2Answer;
        private TextBox textBoxTabCOppmvdF2CO2;
        private TextBox textBoxTabCOppmvdF2CO;
        private Label label184;
        private Label label205;
        private Label label209;
        private TextBox textBox155;
        private TextBox textBox160;
        private Label label214;
        private TextBox textBox161;
        private Button buttonTabCOppmvdF1Calculate;
        private Label label221;
        private TextBox textBoxTabCOppmvdF1Answer;
        private TextBox textBoxTabCOppmvdF1O2;
        private TextBox textBoxTabCOppmvdF1CO;
        private Label label222;
        private Label label223;
        private Label label224;
        private Button buttonTabOilFlowF1Clear;
        private Button buttonTabCO2GasF3Clear;
        private Button buttonTabCO2GasF2Clear;
        private Button buttonTabCO2GasF1Clear;
        private Button buttonTabCO2OilF3Clear;
        private Button buttonTabCO2OilF2Clear;
        private Button buttonTabCO2OilF1Clear;
        private Button buttonTabCO2FlowF1CO2Clear;
        private Button buttonTabHTIPGasF2Clear;
        private Button buttonTabHTIPGasF1Clear;
        private Button buttonTabHTIPOilF2Clear;
        private Button buttonTabHTIPOilF1Clear;
        private Button buttonTabHTIPFlowF1Clear;
        private Button buttonTabSO2GasF2Clear;
        private Button buttonTabSO2GasF1Clear;
        private Button buttonTabSO2OilF3Clear;
        private Button buttonTabSO2OilF2Clear;
        private Button buttonTabSO2OilF1Clear;
        private Button buttonTabSO2FlowF1Clear;
        private Button buttonTabNOxlbsmmBtuF2Clear;
        private Button buttonTabNOxlbsmmBtuF1Clear;
        private Button buttonTabNOxlbshrF2Clear;
        private Button buttonTabNOxlbshrF1Clear;
        private Button buttonTabNOxppmvdF2Clear;
        private Button buttonTabNOxppmvdF1Clear;
        private Button buttonTabFuelFactorF1Clear;
        private Button buttonTabCoalF3Clear;
        private Button buttonTabCoalF4Clear;
        private Button buttonTabCoalF2Clear;
        private Button buttonTabCoalF1Clear;
        private Button buttonCOlbsmmBtuF2Clear;
        private Button buttonCOlbsmmBtuF1Clear;
        private Button buttonTabCOlbshrF1Clear;
        private Button buttonTabCOppmvdF2Clear;
        private Button buttonTabCOppmvdF1Clear;
        private Button buttonRandom;
        private Label labelVersion;
        private TabPage tabPage4_20ma;
        private Label label226;
        private Label label225;
        private Label label206;
        private TextBox textBoxTab420LowScale;
        private TextBox textBoxTab420HighScale;
        private TextBox textBoxTab42020ma;
        private Button buttonTab420Clear;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button buttonTab420Calculate;
        private Label label2;
        private TextBox textBoxTab420Answer;
        private TextBox textBoxTab4204ma;
        private TextBox textBoxTab420ActualCount;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxSearch;
        private TabPage tabPageHg;
        private Label label233;
        private Label label232;
        private Button buttonTabHgHGREClear;
        private Button buttonTabHgHGRHClear;
        private Button buttonTabHgHGREAnswer;
        private Label label6;
        private TextBox textBoxTabHgHGREAnswer;
        private TextBox textBoxTabHgHGREHg;
        private TextBox textBoxTabHgHGREFlow;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox24;
        private TextBox textBox25;
        private Label label227;
        private TextBox textBox26;
        private Button buttonTabHgHGRHAnswer;
        private Label label228;
        private TextBox textBoxTabHgHGRHAnswer;
        private TextBox textBoxTabHgHGRHFc;
        private TextBox textBoxTabHgHGRHHg;
        private Label label229;
        private Label label230;
        private Label label231;
        private TextBox textBoxTabHgHGRHCO2;
        private Label label235;
        private Label label234;
        private TextBox textBoxTabHglbhrHg;
        private TextBox textBoxTabHglbhrFlow;
        private Label label239;
        private Label label240;
        private Label label246;
        private Label label241;
        private Button buttonTabHglbhrClear;
        private TextBox textBox35;
        private Button buttonTabHglbhrAnswer;
        private Label label242;
        private TextBox textBoxTabHglbhrAnswer;
        private Label label245;
        private TextBox textBoxTabHgHGREMW;
        private Label label5;
        private Label label237;
        private Label label236;
        private Button buttonTabHglbhrConvert;
        private Button buttonTabHgHGREConvert;
        private Button buttonTabHgHGRHConvert;
        private TabPage tabPageLME_HI;
        private Button buttonTabLMEHIHourClear;
        private Button buttonTabLMEHIQuarterClear;
        private Label label238;
        private TextBox textBoxTabLMEHIHourH;
        private Button buttonTabLMEHIHourCalculate;
        private Label label243;
        private TextBox textBoxTabLMEHIHourAnswer;
        private TextBox textBoxTabLMEHIHourQL;
        private TextBox textBoxTabLMEHIHourL;
        private Label label244;
        private Label label247;
        private Label label249;
        private Label label250;
        private Label label251;
        private Label label254;
        private Label label255;
        private TextBox textBox31;
        private TextBox textBox32;
        private Label label256;
        private TextBox textBox33;
        private Button buttonTabLMEHIQuarterCalculate;
        private Label label257;
        private TextBox textBoxTabLMEHIQuarterAnswer;
        private TextBox textBoxTabLMEHIQuarterGCV;
        private TextBox textBoxTabLMEHIQuarterFF;
        private Label label258;
        private Label label259;
        private Label label260;
        private TabPage tabPageLME_Mass;
        private Button buttonTabLMEHourSo2Clear;
        private Button buttonTabLMEHourNoxClear;
        private Button buttonTabLMEHourSo2Calculate;
        private Label label252;
        private TextBox textBoxTabLMEHourSo2Answer;
        private TextBox textBoxTabLMEHourSo2So2;
        private TextBox textBoxTabLMEHourSo2H;
        private Label label253;
        private Label label261;
        private Label label263;
        private Label label264;
        private Label label265;
        private Label label266;
        private TextBox textBox29;
        private TextBox textBox34;
        private Label label267;
        private TextBox textBox36;
        private Button buttonTabLMEHourNoxCalculate;
        private Label label268;
        private TextBox textBoxTabLMEHourNoxAnswer;
        private TextBox textBoxTabLMEHourNoxNox;
        private TextBox textBoxTabLMEHourNoxH;
        private Label label269;
        private Label label270;
        private Label label271;
        private Button buttonTabLMEHourCo2Clear;
        private Label label248;
        private Label label262;
        private TextBox textBox8;
        private Button buttonTabLMEHourCo2Calculate;
        private Label label272;
        private TextBox textBoxTabLMEHourCo2Answer;
        private TextBox textBoxTabLMEHourCo2Co2;
        private TextBox textBoxTabLMEHourCo2H;
        private Label label273;
        private Label label274;
        private Label label275;
        private TabPage tabTime;
        private Label label277;
        private DateTimePicker dateTimePicker2;
        private Label label276;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox42;
        private TextBox textBox44;
        private TextBox textBoxHourlyDecimal;
        private Label label291;
        private Button buttonTimeClear;
        private Button buttonTimeCalculate;
        private TextBox textBoxSeconds;
        private TextBox textBoxMinutes;
        private TextBox textBoxHours;
        private TextBox textBoxDays;
        private Label label290;
        private Label label289;
        private Label label288;
        private Label label287;
        private Label label284;
        private Label label281;
        private TextBox textBoxss2;
        private Label label282;
        private TextBox textBoxmm2;
        private Label label283;
        private TextBox textBoxHH2;
        private Label label280;
        private TextBox textBoxss1;
        private Label label279;
        private TextBox textBoxmm1;
        private Label label278;
        private TextBox textBoxHH1;
        private Button buttonTimeCopy;
    }
}