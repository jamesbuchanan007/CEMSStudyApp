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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.labelSectionHeading = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.labelSectionHeading);
            this.panel1.Location = new System.Drawing.Point(29, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 946);
            this.panel1.TabIndex = 0;
            // 
            // buttonDefinitions
            // 
            this.buttonDefinitions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDefinitions.BackColor = System.Drawing.Color.Blue;
            this.buttonDefinitions.Enabled = false;
            this.buttonDefinitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefinitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefinitions.ForeColor = System.Drawing.Color.White;
            this.buttonDefinitions.Location = new System.Drawing.Point(30, 232);
            this.buttonDefinitions.Name = "buttonDefinitions";
            this.buttonDefinitions.Size = new System.Drawing.Size(156, 57);
            this.buttonDefinitions.TabIndex = 61;
            this.buttonDefinitions.Text = "Definitions";
            this.buttonDefinitions.UseVisualStyleBackColor = false;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.Image")));
            this.pictureBoxMain.Location = new System.Drawing.Point(221, 168);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(993, 731);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 60;
            this.pictureBoxMain.TabStop = false;
            // 
            // textBoxDefinitions
            // 
            this.textBoxDefinitions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDefinitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefinitions.Location = new System.Drawing.Point(221, 168);
            this.textBoxDefinitions.Multiline = true;
            this.textBoxDefinitions.Name = "textBoxDefinitions";
            this.textBoxDefinitions.ReadOnly = true;
            this.textBoxDefinitions.Size = new System.Drawing.Size(993, 731);
            this.textBoxDefinitions.TabIndex = 59;
            this.textBoxDefinitions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTechQuestions
            // 
            this.buttonTechQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTechQuestions.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonTechQuestions.Enabled = false;
            this.buttonTechQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTechQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTechQuestions.ForeColor = System.Drawing.Color.White;
            this.buttonTechQuestions.Location = new System.Drawing.Point(30, 779);
            this.buttonTechQuestions.Name = "buttonTechQuestions";
            this.buttonTechQuestions.Size = new System.Drawing.Size(156, 57);
            this.buttonTechQuestions.TabIndex = 58;
            this.buttonTechQuestions.Text = "Tech Questions";
            this.buttonTechQuestions.UseVisualStyleBackColor = false;
            // 
            // buttonSoftwareQuestions
            // 
            this.buttonSoftwareQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSoftwareQuestions.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSoftwareQuestions.Enabled = false;
            this.buttonSoftwareQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoftwareQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoftwareQuestions.ForeColor = System.Drawing.Color.White;
            this.buttonSoftwareQuestions.Location = new System.Drawing.Point(30, 716);
            this.buttonSoftwareQuestions.Name = "buttonSoftwareQuestions";
            this.buttonSoftwareQuestions.Size = new System.Drawing.Size(156, 57);
            this.buttonSoftwareQuestions.TabIndex = 57;
            this.buttonSoftwareQuestions.Text = "Software Questions";
            this.buttonSoftwareQuestions.UseVisualStyleBackColor = false;
            // 
            // labelSectionSubHeading
            // 
            this.labelSectionSubHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSectionSubHeading.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelSectionSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionSubHeading.ForeColor = System.Drawing.Color.White;
            this.labelSectionSubHeading.Location = new System.Drawing.Point(221, 78);
            this.labelSectionSubHeading.MaximumSize = new System.Drawing.Size(993, 58);
            this.labelSectionSubHeading.Name = "labelSectionSubHeading";
            this.labelSectionSubHeading.Size = new System.Drawing.Size(993, 46);
            this.labelSectionSubHeading.TabIndex = 56;
            this.labelSectionSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdmin.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Location = new System.Drawing.Point(30, 842);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(156, 57);
            this.buttonAdmin.TabIndex = 54;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonUnitsOfMeasure
            // 
            this.buttonUnitsOfMeasure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUnitsOfMeasure.BackColor = System.Drawing.Color.Blue;
            this.buttonUnitsOfMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnitsOfMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnitsOfMeasure.ForeColor = System.Drawing.Color.White;
            this.buttonUnitsOfMeasure.Location = new System.Drawing.Point(30, 610);
            this.buttonUnitsOfMeasure.Name = "buttonUnitsOfMeasure";
            this.buttonUnitsOfMeasure.Size = new System.Drawing.Size(156, 57);
            this.buttonUnitsOfMeasure.TabIndex = 53;
            this.buttonUnitsOfMeasure.Text = "Units of Measure";
            this.buttonUnitsOfMeasure.UseVisualStyleBackColor = false;
            this.buttonUnitsOfMeasure.Click += new System.EventHandler(this.buttonUnitsOfMeasure_Click);
            // 
            // buttonPart75PlainEnglish
            // 
            this.buttonPart75PlainEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPart75PlainEnglish.BackColor = System.Drawing.Color.Blue;
            this.buttonPart75PlainEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPart75PlainEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPart75PlainEnglish.ForeColor = System.Drawing.Color.White;
            this.buttonPart75PlainEnglish.Location = new System.Drawing.Point(30, 547);
            this.buttonPart75PlainEnglish.Name = "buttonPart75PlainEnglish";
            this.buttonPart75PlainEnglish.Size = new System.Drawing.Size(156, 57);
            this.buttonPart75PlainEnglish.TabIndex = 52;
            this.buttonPart75PlainEnglish.Text = "Part 75\r\nPlain English";
            this.buttonPart75PlainEnglish.UseVisualStyleBackColor = false;
            this.buttonPart75PlainEnglish.Click += new System.EventHandler(this.buttonPart75PlainEnglish_Click);
            // 
            // buttonPart63SubUUUUU
            // 
            this.buttonPart63SubUUUUU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPart63SubUUUUU.BackColor = System.Drawing.Color.Blue;
            this.buttonPart63SubUUUUU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPart63SubUUUUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPart63SubUUUUU.ForeColor = System.Drawing.Color.White;
            this.buttonPart63SubUUUUU.Location = new System.Drawing.Point(30, 484);
            this.buttonPart63SubUUUUU.Name = "buttonPart63SubUUUUU";
            this.buttonPart63SubUUUUU.Size = new System.Drawing.Size(156, 57);
            this.buttonPart63SubUUUUU.TabIndex = 51;
            this.buttonPart63SubUUUUU.Text = "Part 63\r\nSubpart UUUUU";
            this.buttonPart63SubUUUUU.UseVisualStyleBackColor = false;
            this.buttonPart63SubUUUUU.Click += new System.EventHandler(this.buttonPart63SubUUUUU_Click);
            // 
            // button60AppBF
            // 
            this.button60AppBF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button60AppBF.BackColor = System.Drawing.Color.Blue;
            this.button60AppBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button60AppBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button60AppBF.ForeColor = System.Drawing.Color.White;
            this.button60AppBF.Location = new System.Drawing.Point(30, 421);
            this.button60AppBF.Name = "button60AppBF";
            this.button60AppBF.Size = new System.Drawing.Size(156, 57);
            this.button60AppBF.TabIndex = 50;
            this.button60AppBF.Text = "Part 60\r\nAppendix B and F";
            this.button60AppBF.UseVisualStyleBackColor = false;
            this.button60AppBF.Click += new System.EventHandler(this.button60AppBF_Click);
            // 
            // buttonHowTos
            // 
            this.buttonHowTos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHowTos.BackColor = System.Drawing.Color.Blue;
            this.buttonHowTos.Enabled = false;
            this.buttonHowTos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHowTos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHowTos.ForeColor = System.Drawing.Color.White;
            this.buttonHowTos.Location = new System.Drawing.Point(30, 358);
            this.buttonHowTos.Name = "buttonHowTos";
            this.buttonHowTos.Size = new System.Drawing.Size(156, 57);
            this.buttonHowTos.TabIndex = 49;
            this.buttonHowTos.Text = "How To\'s";
            this.buttonHowTos.UseVisualStyleBackColor = false;
            // 
            // buttonFormulas
            // 
            this.buttonFormulas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFormulas.BackColor = System.Drawing.Color.Blue;
            this.buttonFormulas.Enabled = false;
            this.buttonFormulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormulas.ForeColor = System.Drawing.Color.White;
            this.buttonFormulas.Location = new System.Drawing.Point(30, 295);
            this.buttonFormulas.Name = "buttonFormulas";
            this.buttonFormulas.Size = new System.Drawing.Size(156, 57);
            this.buttonFormulas.TabIndex = 48;
            this.buttonFormulas.Text = "Formulas";
            this.buttonFormulas.UseVisualStyleBackColor = false;
            this.buttonFormulas.Click += new System.EventHandler(this.buttonFormulas_Click);
            // 
            // buttonAcronyms
            // 
            this.buttonAcronyms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAcronyms.BackColor = System.Drawing.Color.Blue;
            this.buttonAcronyms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcronyms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcronyms.ForeColor = System.Drawing.Color.White;
            this.buttonAcronyms.Location = new System.Drawing.Point(30, 168);
            this.buttonAcronyms.Name = "buttonAcronyms";
            this.buttonAcronyms.Size = new System.Drawing.Size(156, 57);
            this.buttonAcronyms.TabIndex = 47;
            this.buttonAcronyms.Text = "Acronyms";
            this.buttonAcronyms.UseVisualStyleBackColor = false;
            this.buttonAcronyms.Click += new System.EventHandler(this.buttonAcronyms_Click);
            // 
            // webBrowserPdf
            // 
            this.webBrowserPdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBrowserPdf.Location = new System.Drawing.Point(221, 168);
            this.webBrowserPdf.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPdf.Name = "webBrowserPdf";
            this.webBrowserPdf.Size = new System.Drawing.Size(993, 731);
            this.webBrowserPdf.TabIndex = 46;
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
            this.comboBoxSectionNumber.Location = new System.Drawing.Point(221, 134);
            this.comboBoxSectionNumber.Name = "comboBoxSectionNumber";
            this.comboBoxSectionNumber.Size = new System.Drawing.Size(993, 28);
            this.comboBoxSectionNumber.TabIndex = 45;
            this.comboBoxSectionNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxSectionNumber_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1139, 905);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 44;
            this.buttonExit.Tag = "Exit Application";
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonToggle
            // 
            this.buttonToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonToggle.BackColor = System.Drawing.Color.Blue;
            this.buttonToggle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToggle.ForeColor = System.Drawing.Color.White;
            this.buttonToggle.Location = new System.Drawing.Point(383, 905);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(75, 23);
            this.buttonToggle.TabIndex = 43;
            this.buttonToggle.Tag = "Click to toggle Answer";
            this.buttonToggle.Text = "Show";
            this.buttonToggle.UseVisualStyleBackColor = false;
            this.buttonToggle.Visible = false;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.BackColor = System.Drawing.Color.Black;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(302, 905);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 42;
            this.buttonNext.Tag = "Next Question";
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(221, 905);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 41;
            this.buttonBack.Tag = "Previous Question";
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSectionHeading
            // 
            this.labelSectionHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSectionHeading.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelSectionHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionHeading.ForeColor = System.Drawing.Color.White;
            this.labelSectionHeading.Location = new System.Drawing.Point(221, 20);
            this.labelSectionHeading.MaximumSize = new System.Drawing.Size(993, 58);
            this.labelSectionHeading.Name = "labelSectionHeading";
            this.labelSectionHeading.Size = new System.Drawing.Size(993, 58);
            this.labelSectionHeading.TabIndex = 40;
            this.labelSectionHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1297, 989);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
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
        private Label labelSectionHeading;
        private PictureBox pictureBoxMain;
        private Button buttonDefinitions;
    }
}