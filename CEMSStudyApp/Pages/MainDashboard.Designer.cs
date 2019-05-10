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
            this.buttonHowTos = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.buttonHowTos);
            this.panel1.Controls.Add(this.buttonFormulas);
            this.panel1.Controls.Add(this.buttonAcronyms);
            this.panel1.Controls.Add(this.webBrowserPdf);
            this.panel1.Controls.Add(this.comboBoxSectionNumber);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonToggle);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 775);
            this.panel1.TabIndex = 0;
            // 
            // buttonPart75
            // 
            this.buttonPart75.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPart75.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPart75.BackColor = System.Drawing.Color.Blue;
            this.buttonPart75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPart75.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPart75.ForeColor = System.Drawing.Color.White;
            this.buttonPart75.Location = new System.Drawing.Point(43, 264);
            this.buttonPart75.Name = "buttonPart75";
            this.buttonPart75.Size = new System.Drawing.Size(110, 47);
            this.buttonPart75.TabIndex = 128;
            this.buttonPart75.Text = "Part 75";
            this.toolTip1.SetToolTip(this.buttonPart75, "Part 75 Plain English Version");
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
            this.textBoxSectionHeading.Location = new System.Drawing.Point(200, 5);
            this.textBoxSectionHeading.Multiline = true;
            this.textBoxSectionHeading.Name = "textBoxSectionHeading";
            this.textBoxSectionHeading.ReadOnly = true;
            this.textBoxSectionHeading.Size = new System.Drawing.Size(942, 58);
            this.textBoxSectionHeading.TabIndex = 127;
            this.textBoxSectionHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDefinitions
            // 
            this.buttonDefinitions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDefinitions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDefinitions.BackColor = System.Drawing.Color.Blue;
            this.buttonDefinitions.Enabled = false;
            this.buttonDefinitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefinitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefinitions.ForeColor = System.Drawing.Color.White;
            this.buttonDefinitions.Location = new System.Drawing.Point(43, 370);
            this.buttonDefinitions.Name = "buttonDefinitions";
            this.buttonDefinitions.Size = new System.Drawing.Size(110, 47);
            this.buttonDefinitions.TabIndex = 2;
            this.buttonDefinitions.Text = "Definitions";
            this.toolTip1.SetToolTip(this.buttonDefinitions, "Definitions");
            this.buttonDefinitions.UseVisualStyleBackColor = false;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.Image")));
            this.pictureBoxMain.Location = new System.Drawing.Point(200, 152);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(947, 566);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 126;
            this.pictureBoxMain.TabStop = false;
            // 
            // textBoxDefinitions
            // 
            this.textBoxDefinitions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDefinitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefinitions.Location = new System.Drawing.Point(200, 152);
            this.textBoxDefinitions.Multiline = true;
            this.textBoxDefinitions.Name = "textBoxDefinitions";
            this.textBoxDefinitions.ReadOnly = true;
            this.textBoxDefinitions.Size = new System.Drawing.Size(947, 566);
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
            this.buttonTechQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTechQuestions.ForeColor = System.Drawing.Color.White;
            this.buttonTechQuestions.Location = new System.Drawing.Point(43, 647);
            this.buttonTechQuestions.Name = "buttonTechQuestions";
            this.buttonTechQuestions.Size = new System.Drawing.Size(110, 47);
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
            this.buttonSoftwareQuestions.Enabled = false;
            this.buttonSoftwareQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoftwareQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoftwareQuestions.ForeColor = System.Drawing.Color.White;
            this.buttonSoftwareQuestions.Location = new System.Drawing.Point(43, 594);
            this.buttonSoftwareQuestions.Name = "buttonSoftwareQuestions";
            this.buttonSoftwareQuestions.Size = new System.Drawing.Size(110, 47);
            this.buttonSoftwareQuestions.TabIndex = 9;
            this.buttonSoftwareQuestions.Text = "Software Questions";
            this.toolTip1.SetToolTip(this.buttonSoftwareQuestions, "Software Test Questions");
            this.buttonSoftwareQuestions.UseVisualStyleBackColor = false;
            // 
            // labelSectionSubHeading
            // 
            this.labelSectionSubHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSectionSubHeading.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelSectionSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionSubHeading.ForeColor = System.Drawing.Color.White;
            this.labelSectionSubHeading.Location = new System.Drawing.Point(199, 66);
            this.labelSectionSubHeading.MaximumSize = new System.Drawing.Size(947, 58);
            this.labelSectionSubHeading.Name = "labelSectionSubHeading";
            this.labelSectionSubHeading.Size = new System.Drawing.Size(943, 36);
            this.labelSectionSubHeading.TabIndex = 122;
            this.labelSectionSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 16);
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
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Location = new System.Drawing.Point(43, 711);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(110, 47);
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
            this.buttonUnitsOfMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnitsOfMeasure.ForeColor = System.Drawing.Color.White;
            this.buttonUnitsOfMeasure.Location = new System.Drawing.Point(43, 529);
            this.buttonUnitsOfMeasure.Name = "buttonUnitsOfMeasure";
            this.buttonUnitsOfMeasure.Size = new System.Drawing.Size(110, 47);
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
            this.buttonPart75PlainEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPart75PlainEnglish.ForeColor = System.Drawing.Color.White;
            this.buttonPart75PlainEnglish.Location = new System.Drawing.Point(43, 211);
            this.buttonPart75PlainEnglish.Name = "buttonPart75PlainEnglish";
            this.buttonPart75PlainEnglish.Size = new System.Drawing.Size(110, 47);
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
            this.buttonPart63SubUUUUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPart63SubUUUUU.ForeColor = System.Drawing.Color.White;
            this.buttonPart63SubUUUUU.Location = new System.Drawing.Point(43, 158);
            this.buttonPart63SubUUUUU.Name = "buttonPart63SubUUUUU";
            this.buttonPart63SubUUUUU.Size = new System.Drawing.Size(110, 47);
            this.buttonPart63SubUUUUU.TabIndex = 6;
            this.buttonPart63SubUUUUU.Text = "Part 63\r\nSubpart UUUUU";
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
            this.button60AppBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button60AppBF.ForeColor = System.Drawing.Color.White;
            this.button60AppBF.Location = new System.Drawing.Point(43, 105);
            this.button60AppBF.Name = "button60AppBF";
            this.button60AppBF.Size = new System.Drawing.Size(110, 47);
            this.button60AppBF.TabIndex = 5;
            this.button60AppBF.Text = "Part 60\r\nAppendix B and F";
            this.toolTip1.SetToolTip(this.button60AppBF, "Part 60 Appendix B and F");
            this.button60AppBF.UseVisualStyleBackColor = false;
            this.button60AppBF.Click += new System.EventHandler(this.button60AppBF_Click);
            // 
            // buttonHowTos
            // 
            this.buttonHowTos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHowTos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHowTos.BackColor = System.Drawing.Color.Blue;
            this.buttonHowTos.Enabled = false;
            this.buttonHowTos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHowTos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHowTos.ForeColor = System.Drawing.Color.White;
            this.buttonHowTos.Location = new System.Drawing.Point(43, 476);
            this.buttonHowTos.Name = "buttonHowTos";
            this.buttonHowTos.Size = new System.Drawing.Size(110, 47);
            this.buttonHowTos.TabIndex = 4;
            this.buttonHowTos.Text = "How To\'s";
            this.toolTip1.SetToolTip(this.buttonHowTos, "\'How To\' Documentation");
            this.buttonHowTos.UseVisualStyleBackColor = false;
            // 
            // buttonFormulas
            // 
            this.buttonFormulas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFormulas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFormulas.BackColor = System.Drawing.Color.Blue;
            this.buttonFormulas.Enabled = false;
            this.buttonFormulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormulas.ForeColor = System.Drawing.Color.White;
            this.buttonFormulas.Location = new System.Drawing.Point(43, 423);
            this.buttonFormulas.Name = "buttonFormulas";
            this.buttonFormulas.Size = new System.Drawing.Size(110, 47);
            this.buttonFormulas.TabIndex = 3;
            this.buttonFormulas.Text = "Formulas";
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
            this.buttonAcronyms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcronyms.ForeColor = System.Drawing.Color.White;
            this.buttonAcronyms.Location = new System.Drawing.Point(43, 317);
            this.buttonAcronyms.Name = "buttonAcronyms";
            this.buttonAcronyms.Size = new System.Drawing.Size(110, 47);
            this.buttonAcronyms.TabIndex = 1;
            this.buttonAcronyms.Text = "Acronyms";
            this.toolTip1.SetToolTip(this.buttonAcronyms, "Acronyms");
            this.buttonAcronyms.UseVisualStyleBackColor = false;
            this.buttonAcronyms.Click += new System.EventHandler(this.buttonAcronyms_Click);
            // 
            // webBrowserPdf
            // 
            this.webBrowserPdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBrowserPdf.Location = new System.Drawing.Point(200, 152);
            this.webBrowserPdf.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPdf.Name = "webBrowserPdf";
            this.webBrowserPdf.Size = new System.Drawing.Size(947, 566);
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
            this.comboBoxSectionNumber.Location = new System.Drawing.Point(200, 118);
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
            this.buttonExit.Location = new System.Drawing.Point(1072, 724);
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
            this.buttonToggle.Location = new System.Drawing.Point(363, 724);
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
            this.buttonNext.Location = new System.Drawing.Point(282, 724);
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
            this.buttonBack.Location = new System.Drawing.Point(201, 724);
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
            this.ClientSize = new System.Drawing.Size(1227, 809);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Button buttonHowTos;
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
    }
}