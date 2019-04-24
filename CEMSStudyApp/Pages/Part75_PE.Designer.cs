using System.ComponentModel;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    partial class Part75_PE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Part75_PE));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSectionName = new System.Windows.Forms.TextBox();
            this.comboBoxSiteNavigation = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxSectionNumber = new System.Windows.Forms.ComboBox();
            this.webBrowserPdf = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "40 CFR Part 73 Plain English Version";
            // 
            // textBoxSectionName
            // 
            this.textBoxSectionName.BackColor = System.Drawing.Color.White;
            this.textBoxSectionName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSectionName.ForeColor = System.Drawing.Color.Black;
            this.textBoxSectionName.Location = new System.Drawing.Point(17, 50);
            this.textBoxSectionName.Name = "textBoxSectionName";
            this.textBoxSectionName.ReadOnly = true;
            this.textBoxSectionName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSectionName.Size = new System.Drawing.Size(885, 21);
            this.textBoxSectionName.TabIndex = 2;
            this.textBoxSectionName.Text = "Section Heading";
            this.textBoxSectionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxSiteNavigation
            // 
            this.comboBoxSiteNavigation.AllowDrop = true;
            this.comboBoxSiteNavigation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxSiteNavigation.DisplayMember = "Pages_Name";
            this.comboBoxSiteNavigation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSiteNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSiteNavigation.FormattingEnabled = true;
            this.comboBoxSiteNavigation.Location = new System.Drawing.Point(781, 23);
            this.comboBoxSiteNavigation.Name = "comboBoxSiteNavigation";
            this.comboBoxSiteNavigation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSiteNavigation.TabIndex = 4;
            this.comboBoxSiteNavigation.SelectedIndexChanged += new System.EventHandler(this.comboBoxSiteNavigation_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(17, 716);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Tag = "Previous Question";
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Black;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(98, 716);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Tag = "Next Question";
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonToggle
            // 
            this.buttonToggle.BackColor = System.Drawing.Color.Blue;
            this.buttonToggle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToggle.ForeColor = System.Drawing.Color.White;
            this.buttonToggle.Location = new System.Drawing.Point(179, 716);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(75, 23);
            this.buttonToggle.TabIndex = 9;
            this.buttonToggle.Tag = "Click to toggle Answer";
            this.buttonToggle.Text = "Show";
            this.buttonToggle.UseVisualStyleBackColor = false;
            this.buttonToggle.Visible = false;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(827, 716);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Tag = "Exit Application";
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxSectionNumber
            // 
            this.comboBoxSectionNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxSectionNumber.DisplayMember = "Part_60_Number";
            this.comboBoxSectionNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSectionNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSectionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSectionNumber.FormattingEnabled = true;
            this.comboBoxSectionNumber.Location = new System.Drawing.Point(18, 79);
            this.comboBoxSectionNumber.Name = "comboBoxSectionNumber";
            this.comboBoxSectionNumber.Size = new System.Drawing.Size(884, 24);
            this.comboBoxSectionNumber.TabIndex = 12;
            this.comboBoxSectionNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxSectionNumber_SelectedIndexChanged);
            // 
            // webBrowserPdf
            // 
            this.webBrowserPdf.Location = new System.Drawing.Point(17, 109);
            this.webBrowserPdf.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPdf.Name = "webBrowserPdf";
            this.webBrowserPdf.Size = new System.Drawing.Size(885, 601);
            this.webBrowserPdf.TabIndex = 25;
            // 
            // Part75_PE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(923, 807);
            this.Controls.Add(this.webBrowserPdf);
            this.Controls.Add(this.comboBoxSectionNumber);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxSiteNavigation);
            this.Controls.Add(this.textBoxSectionName);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Part75_PE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxSectionName;
        private ComboBox comboBoxSiteNavigation;
        private Button buttonBack;
        private Button buttonNext;
        private Button buttonToggle;
        private Button buttonExit;
        private ComboBox comboBoxSectionNumber;
        private WebBrowser webBrowserPdf;
    }
}