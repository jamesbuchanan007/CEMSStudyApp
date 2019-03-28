namespace CEMSStudyApp
{
    partial class SectionEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSectionNumber = new System.Windows.Forms.TextBox();
            this.comboBoxSiteNavigation = new System.Windows.Forms.ComboBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxSectionNumber = new System.Windows.Forms.ComboBox();
            this.buttonNewPart75 = new System.Windows.Forms.Button();
            this.buttonNewPart60 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section Edit";
            // 
            // textBoxSectionNumber
            // 
            this.textBoxSectionNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxSectionNumber.Enabled = false;
            this.textBoxSectionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSectionNumber.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSectionNumber.Location = new System.Drawing.Point(17, 149);
            this.textBoxSectionNumber.Name = "textBoxSectionNumber";
            this.textBoxSectionNumber.ReadOnly = true;
            this.textBoxSectionNumber.Size = new System.Drawing.Size(305, 26);
            this.textBoxSectionNumber.TabIndex = 2;
            this.textBoxSectionNumber.Text = "Section";
            this.textBoxSectionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxSiteNavigation
            // 
            this.comboBoxSiteNavigation.AllowDrop = true;
            this.comboBoxSiteNavigation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxSiteNavigation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSiteNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSiteNavigation.FormattingEnabled = true;
            this.comboBoxSiteNavigation.Items.AddRange(new object[] {
            "-- Select Section --"});
            this.comboBoxSiteNavigation.Location = new System.Drawing.Point(201, 82);
            this.comboBoxSiteNavigation.Name = "comboBoxSiteNavigation";
            this.comboBoxSiteNavigation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSiteNavigation.TabIndex = 4;
            this.comboBoxSiteNavigation.SelectedIndexChanged += new System.EventHandler(this.comboBoxSiteNavigation_SelectedIndexChanged);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxQuestion.Enabled = false;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxQuestion.Location = new System.Drawing.Point(17, 181);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(305, 195);
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
            this.textBoxAnswer.Location = new System.Drawing.Point(328, 18);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(460, 358);
            this.textBoxAnswer.TabIndex = 6;
            this.textBoxAnswer.Text = "\r\n\r\n\r\n\r\n\r\nAnswer";
            this.textBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(713, 382);
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
            this.comboBoxSectionNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSectionNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSectionNumber.FormattingEnabled = true;
            this.comboBoxSectionNumber.Items.AddRange(new object[] {
            "-- Select Section --"});
            this.comboBoxSectionNumber.Location = new System.Drawing.Point(17, 82);
            this.comboBoxSectionNumber.Name = "comboBoxSectionNumber";
            this.comboBoxSectionNumber.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSectionNumber.TabIndex = 12;
            // 
            // buttonNewPart75
            // 
            this.buttonNewPart75.Location = new System.Drawing.Point(40, 109);
            this.buttonNewPart75.Name = "buttonNewPart75";
            this.buttonNewPart75.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPart75.TabIndex = 13;
            this.buttonNewPart75.Text = "New";
            this.buttonNewPart75.UseVisualStyleBackColor = true;
            // 
            // buttonNewPart60
            // 
            this.buttonNewPart60.Location = new System.Drawing.Point(224, 109);
            this.buttonNewPart60.Name = "buttonNewPart60";
            this.buttonNewPart60.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPart60.TabIndex = 14;
            this.buttonNewPart60.Text = "New";
            this.buttonNewPart60.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Part 75";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(231, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Part 60";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(17, 382);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Blue;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(247, 382);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // SectionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonNewPart60);
            this.Controls.Add(this.buttonNewPart75);
            this.Controls.Add(this.comboBoxSectionNumber);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.comboBoxSiteNavigation);
            this.Controls.Add(this.textBoxSectionNumber);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SectionEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSectionNumber;
        private System.Windows.Forms.ComboBox comboBoxSiteNavigation;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxSectionNumber;
        private System.Windows.Forms.Button buttonNewPart75;
        private System.Windows.Forms.Button buttonNewPart60;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
    }
}