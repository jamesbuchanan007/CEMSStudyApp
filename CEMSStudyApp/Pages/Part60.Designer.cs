namespace CEMSStudyApp.Pages
{
    partial class Part60
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Part60));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSectionName = new System.Windows.Forms.TextBox();
            this.comboBoxSiteNavigation = new System.Windows.Forms.ComboBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxSectionNumber = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxSectionNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "40 CFR Part 60";
            // 
            // textBoxSectionName
            // 
            this.textBoxSectionName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxSectionName.Enabled = false;
            this.textBoxSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSectionName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSectionName.Location = new System.Drawing.Point(45, 465);
            this.textBoxSectionName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxSectionName.Name = "textBoxSectionName";
            this.textBoxSectionName.ReadOnly = true;
            this.textBoxSectionName.Size = new System.Drawing.Size(848, 53);
            this.textBoxSectionName.TabIndex = 2;
            this.textBoxSectionName.Text = "Section Name";
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
            this.comboBoxSiteNavigation.Location = new System.Drawing.Point(577, 160);
            this.comboBoxSiteNavigation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxSiteNavigation.Name = "comboBoxSiteNavigation";
            this.comboBoxSiteNavigation.Size = new System.Drawing.Size(316, 39);
            this.comboBoxSiteNavigation.TabIndex = 4;
            this.comboBoxSiteNavigation.SelectedIndexChanged += new System.EventHandler(this.comboBoxSiteNavigation_SelectedIndexChanged);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxQuestion.Enabled = false;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxQuestion.Location = new System.Drawing.Point(45, 532);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(848, 359);
            this.textBoxQuestion.TabIndex = 5;
            this.textBoxQuestion.Text = "\r\n\r\nQuestion";
            this.textBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAnswer.Location = new System.Drawing.Point(909, 112);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(1186, 779);
            this.textBoxAnswer.TabIndex = 6;
            this.textBoxAnswer.Text = "\r\n\r\n\r\n\r\n\r\nAnswer";
            this.textBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(45, 286);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(200, 55);
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
            this.buttonNext.Location = new System.Drawing.Point(261, 286);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(200, 55);
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
            this.buttonToggle.Location = new System.Drawing.Point(1895, 43);
            this.buttonToggle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(200, 55);
            this.buttonToggle.TabIndex = 9;
            this.buttonToggle.Tag = "Click to toggle Answer";
            this.buttonToggle.Text = "Hide";
            this.buttonToggle.UseVisualStyleBackColor = false;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1901, 911);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 55);
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
            this.comboBoxSectionNumber.FormattingEnabled = true;
            this.comboBoxSectionNumber.Location = new System.Drawing.Point(45, 160);
            this.comboBoxSectionNumber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxSectionNumber.Name = "comboBoxSectionNumber";
            this.comboBoxSectionNumber.Size = new System.Drawing.Size(316, 39);
            this.comboBoxSectionNumber.TabIndex = 12;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(693, 911);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 55);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Tag = "";
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Black;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(45, 911);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(200, 55);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Tag = "Next Question";
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.Black;
            this.buttonNew.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.ForeColor = System.Drawing.Color.White;
            this.buttonNew.Location = new System.Drawing.Point(261, 911);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(200, 55);
            this.buttonNew.TabIndex = 20;
            this.buttonNew.Tag = "Next Question";
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Black;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(477, 911);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 55);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Tag = "";
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Black;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(909, 911);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 55);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Tag = "";
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxSectionNumber
            // 
            this.textBoxSectionNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxSectionNumber.Enabled = false;
            this.textBoxSectionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSectionNumber.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSectionNumber.Location = new System.Drawing.Point(45, 398);
            this.textBoxSectionNumber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxSectionNumber.Name = "textBoxSectionNumber";
            this.textBoxSectionNumber.ReadOnly = true;
            this.textBoxSectionNumber.Size = new System.Drawing.Size(848, 53);
            this.textBoxSectionNumber.TabIndex = 24;
            this.textBoxSectionNumber.Text = "Section Number";
            this.textBoxSectionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Part60
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(2133, 999);
            this.Controls.Add(this.textBoxSectionNumber);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxSectionNumber);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.comboBoxSiteNavigation);
            this.Controls.Add(this.textBoxSectionName);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Part60";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSectionName;
        private System.Windows.Forms.ComboBox comboBoxSiteNavigation;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxSectionNumber;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxSectionNumber;
    }
}