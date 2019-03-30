namespace CEMSStudyApp.Pages
{
    partial class Acronyms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acronyms));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxAcronym = new System.Windows.Forms.ComboBox();
            this.comboBoxSiteNavigation = new System.Windows.Forms.ComboBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acronyms";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAnswer.Location = new System.Drawing.Point(45, 263);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(1334, 628);
            this.textBoxAnswer.TabIndex = 6;
            this.textBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(45, 194);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(200, 55);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Tag = "Previous Question";
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Black;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(261, 194);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(200, 55);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Tag = "Next Question";
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = false;
            // 
            // buttonToggle
            // 
            this.buttonToggle.BackColor = System.Drawing.Color.Blue;
            this.buttonToggle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToggle.ForeColor = System.Drawing.Color.White;
            this.buttonToggle.Location = new System.Drawing.Point(1179, 123);
            this.buttonToggle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(200, 55);
            this.buttonToggle.TabIndex = 9;
            this.buttonToggle.Tag = "Click to toggle Answer";
            this.buttonToggle.Text = "Toggle";
            this.buttonToggle.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1179, 911);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 55);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Tag = "Exit Application";
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxAcronym
            // 
            this.comboBoxAcronym.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxAcronym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcronym.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAcronym.FormattingEnabled = true;
            this.comboBoxAcronym.Items.AddRange(new object[] {
            "-- Select Acronym --"});
            this.comboBoxAcronym.Location = new System.Drawing.Point(540, 132);
            this.comboBoxAcronym.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxAcronym.Name = "comboBoxAcronym";
            this.comboBoxAcronym.Size = new System.Drawing.Size(623, 39);
            this.comboBoxAcronym.TabIndex = 12;
            // 
            // comboBoxSiteNavigation
            // 
            this.comboBoxSiteNavigation.FormattingEnabled = true;
            this.comboBoxSiteNavigation.Items.AddRange(new object[] {
            "-- Site Navigation --"});
            this.comboBoxSiteNavigation.Location = new System.Drawing.Point(857, 62);
            this.comboBoxSiteNavigation.Name = "comboBoxSiteNavigation";
            this.comboBoxSiteNavigation.Size = new System.Drawing.Size(441, 39);
            this.comboBoxSiteNavigation.TabIndex = 13;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.Green;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.ForeColor = System.Drawing.Color.White;
            this.buttonGo.Location = new System.Drawing.Point(1304, 62);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 39);
            this.buttonGo.TabIndex = 14;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = false;
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
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Tag = "Next Question";
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
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
            this.buttonNew.TabIndex = 16;
            this.buttonNew.Tag = "Next Question";
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
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
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Tag = "Next Question";
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
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
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Tag = "Next Question";
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // Acronyms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1411, 999);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.comboBoxSiteNavigation);
            this.Controls.Add(this.comboBoxAcronym);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Acronyms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxAcronym;
        private System.Windows.Forms.ComboBox comboBoxSiteNavigation;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}