using System.ComponentModel;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    partial class DiagramsAndTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagramsAndTables));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxDiagramsAndTables_Id = new System.Windows.Forms.ComboBox();
            this.comboBoxSiteNavigation = new System.Windows.Forms.ComboBox();
            this.textBoxDiagramsAndTables_Name = new System.Windows.Forms.TextBox();
            this.textBoxDiagramsAndTables_Description = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowserPdf = new System.Windows.Forms.WebBrowser();
            this.pictureBoxDiagramsAndTables_Image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagramsAndTables_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diagrams and Tables";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(17, 81);
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
            this.buttonNext.Location = new System.Drawing.Point(98, 81);
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
            this.buttonToggle.Location = new System.Drawing.Point(179, 81);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(75, 23);
            this.buttonToggle.TabIndex = 9;
            this.buttonToggle.Tag = "Click to toggle Answer";
            this.buttonToggle.Text = "Show";
            this.buttonToggle.UseVisualStyleBackColor = false;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(780, 948);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Tag = "Exit Application";
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxDiagramsAndTables_Id
            // 
            this.comboBoxDiagramsAndTables_Id.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxDiagramsAndTables_Id.DisplayMember = "DiagramsAndTables_Name";
            this.comboBoxDiagramsAndTables_Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiagramsAndTables_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDiagramsAndTables_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDiagramsAndTables_Id.FormattingEnabled = true;
            this.comboBoxDiagramsAndTables_Id.Location = new System.Drawing.Point(284, 53);
            this.comboBoxDiagramsAndTables_Id.Name = "comboBoxDiagramsAndTables_Id";
            this.comboBoxDiagramsAndTables_Id.Size = new System.Drawing.Size(571, 24);
            this.comboBoxDiagramsAndTables_Id.TabIndex = 12;
            this.comboBoxDiagramsAndTables_Id.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcronym_SelectedIndexChanged);
            // 
            // comboBoxSiteNavigation
            // 
            this.comboBoxSiteNavigation.DisplayMember = "Pages_Name";
            this.comboBoxSiteNavigation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSiteNavigation.FormattingEnabled = true;
            this.comboBoxSiteNavigation.Location = new System.Drawing.Point(687, 27);
            this.comboBoxSiteNavigation.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxSiteNavigation.Name = "comboBoxSiteNavigation";
            this.comboBoxSiteNavigation.Size = new System.Drawing.Size(168, 21);
            this.comboBoxSiteNavigation.TabIndex = 13;
            this.comboBoxSiteNavigation.SelectedIndexChanged += new System.EventHandler(this.comboBoxSiteNavigation_SelectedIndexChanged_1);
            // 
            // textBoxDiagramsAndTables_Name
            // 
            this.textBoxDiagramsAndTables_Name.BackColor = System.Drawing.Color.White;
            this.textBoxDiagramsAndTables_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiagramsAndTables_Name.Location = new System.Drawing.Point(284, 81);
            this.textBoxDiagramsAndTables_Name.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxDiagramsAndTables_Name.Name = "textBoxDiagramsAndTables_Name";
            this.textBoxDiagramsAndTables_Name.ReadOnly = true;
            this.textBoxDiagramsAndTables_Name.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDiagramsAndTables_Name.Size = new System.Drawing.Size(571, 22);
            this.textBoxDiagramsAndTables_Name.TabIndex = 20;
            this.textBoxDiagramsAndTables_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDiagramsAndTables_Description
            // 
            this.textBoxDiagramsAndTables_Description.BackColor = System.Drawing.Color.White;
            this.textBoxDiagramsAndTables_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiagramsAndTables_Description.Location = new System.Drawing.Point(17, 110);
            this.textBoxDiagramsAndTables_Description.Multiline = true;
            this.textBoxDiagramsAndTables_Description.Name = "textBoxDiagramsAndTables_Description";
            this.textBoxDiagramsAndTables_Description.ReadOnly = true;
            this.textBoxDiagramsAndTables_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDiagramsAndTables_Description.Size = new System.Drawing.Size(838, 70);
            this.textBoxDiagramsAndTables_Description.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.webBrowserPdf);
            this.panel1.Controls.Add(this.pictureBoxDiagramsAndTables_Image);
            this.panel1.Location = new System.Drawing.Point(17, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 735);
            this.panel1.TabIndex = 22;
            // 
            // webBrowserPdf
            // 
            this.webBrowserPdf.Location = new System.Drawing.Point(3, 3);
            this.webBrowserPdf.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPdf.Name = "webBrowserPdf";
            this.webBrowserPdf.Size = new System.Drawing.Size(832, 719);
            this.webBrowserPdf.TabIndex = 25;
            // 
            // pictureBoxDiagramsAndTables_Image
            // 
            this.pictureBoxDiagramsAndTables_Image.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBoxDiagramsAndTables_Image.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDiagramsAndTables_Image.Name = "pictureBoxDiagramsAndTables_Image";
            this.pictureBoxDiagramsAndTables_Image.Size = new System.Drawing.Size(832, 719);
            this.pictureBoxDiagramsAndTables_Image.TabIndex = 24;
            this.pictureBoxDiagramsAndTables_Image.TabStop = false;
            this.pictureBoxDiagramsAndTables_Image.UseWaitCursor = true;
            this.pictureBoxDiagramsAndTables_Image.Visible = false;
            // 
            // DiagramsAndTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(867, 993);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxDiagramsAndTables_Description);
            this.Controls.Add(this.textBoxDiagramsAndTables_Name);
            this.Controls.Add(this.comboBoxSiteNavigation);
            this.Controls.Add(this.comboBoxDiagramsAndTables_Id);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiagramsAndTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagramsAndTables_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private Button buttonNext;
        private Button buttonToggle;
        private Button buttonExit;
        private ComboBox comboBoxDiagramsAndTables_Id;
        private ComboBox comboBoxSiteNavigation;
        private TextBox textBoxDiagramsAndTables_Name;
        private TextBox textBoxDiagramsAndTables_Description;
        private Panel panel1;
        private PictureBox pictureBoxDiagramsAndTables_Image;
        private WebBrowser webBrowserPdf;
    }
}