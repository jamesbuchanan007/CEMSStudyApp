namespace CEMSStudyApp.Pages
{
    partial class HowTos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowTos));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.howTosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEMS_Study_App_dbDataSet = new CEMSStudyApp.CEMS_Study_App_dbDataSet();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxHowTo = new System.Windows.Forms.ComboBox();
            this.comboBoxSiteNavigation = new System.Windows.Forms.ComboBox();
            this.pagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pagesTableAdapter = new CEMSStudyApp.CEMS_Study_App_dbDataSetTableAdapters.PagesTableAdapter();
            this.howTosTableAdapter = new CEMSStudyApp.CEMS_Study_App_dbDataSetTableAdapters.HowTosTableAdapter();
            this.textBoxHowTos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.howTosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEMS_Study_App_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "How To\'s";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxAnswer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.howTosBindingSource, "Description", true));
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAnswer.Location = new System.Drawing.Point(45, 237);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(2049, 848);
            this.textBoxAnswer.TabIndex = 6;
            this.textBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // howTosBindingSource
            // 
            this.howTosBindingSource.DataMember = "HowTos";
            this.howTosBindingSource.DataSource = this.cEMS_Study_App_dbDataSet;
            // 
            // cEMS_Study_App_dbDataSet
            // 
            this.cEMS_Study_App_dbDataSet.DataSetName = "CEMS_Study_App_dbDataSet";
            this.cEMS_Study_App_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(45, 168);
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
            this.buttonNext.Location = new System.Drawing.Point(261, 168);
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
            this.buttonToggle.Location = new System.Drawing.Point(1894, 106);
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
            this.buttonExit.Location = new System.Drawing.Point(1894, 1099);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 55);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Tag = "Exit Application";
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxHowTo
            // 
            this.comboBoxHowTo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxHowTo.DataSource = this.howTosBindingSource;
            this.comboBoxHowTo.DisplayMember = "Name";
            this.comboBoxHowTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHowTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxHowTo.FormattingEnabled = true;
            this.comboBoxHowTo.Location = new System.Drawing.Point(533, 115);
            this.comboBoxHowTo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxHowTo.Name = "comboBoxHowTo";
            this.comboBoxHowTo.Size = new System.Drawing.Size(1345, 39);
            this.comboBoxHowTo.TabIndex = 12;
            // 
            // comboBoxSiteNavigation
            // 
            this.comboBoxSiteNavigation.DataSource = this.pagesBindingSource;
            this.comboBoxSiteNavigation.DisplayMember = "Pages_Name";
            this.comboBoxSiteNavigation.FormattingEnabled = true;
            this.comboBoxSiteNavigation.Location = new System.Drawing.Point(1653, 52);
            this.comboBoxSiteNavigation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxSiteNavigation.Name = "comboBoxSiteNavigation";
            this.comboBoxSiteNavigation.Size = new System.Drawing.Size(441, 39);
            this.comboBoxSiteNavigation.TabIndex = 13;
            this.comboBoxSiteNavigation.SelectedIndexChanged += new System.EventHandler(this.comboBoxSiteNavigation_SelectedIndexChanged);
            // 
            // pagesBindingSource
            // 
            this.pagesBindingSource.DataMember = "Pages";
            this.pagesBindingSource.DataSource = this.cEMS_Study_App_dbDataSet;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(705, 1099);
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
            this.buttonEdit.Location = new System.Drawing.Point(57, 1099);
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
            this.buttonNew.Location = new System.Drawing.Point(273, 1099);
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
            this.buttonSave.Location = new System.Drawing.Point(489, 1099);
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
            this.buttonCancel.Location = new System.Drawing.Point(921, 1099);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 55);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Tag = "";
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pagesTableAdapter
            // 
            this.pagesTableAdapter.ClearBeforeFill = true;
            // 
            // howTosTableAdapter
            // 
            this.howTosTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxHowTos
            // 
            this.textBoxHowTos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.howTosBindingSource, "Name", true));
            this.textBoxHowTos.Enabled = false;
            this.textBoxHowTos.Location = new System.Drawing.Point(533, 177);
            this.textBoxHowTos.Name = "textBoxHowTos";
            this.textBoxHowTos.ReadOnly = true;
            this.textBoxHowTos.Size = new System.Drawing.Size(1561, 38);
            this.textBoxHowTos.TabIndex = 24;
            this.textBoxHowTos.Text = "How To";
            this.textBoxHowTos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HowTos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(2152, 1195);
            this.Controls.Add(this.textBoxHowTos);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxSiteNavigation);
            this.Controls.Add(this.comboBoxHowTo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "HowTos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            this.Load += new System.EventHandler(this.HowTos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.howTosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEMS_Study_App_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxHowTo;
        private System.Windows.Forms.ComboBox comboBoxSiteNavigation;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private CEMS_Study_App_dbDataSet cEMS_Study_App_dbDataSet;
        private System.Windows.Forms.BindingSource pagesBindingSource;
        private CEMS_Study_App_dbDataSetTableAdapters.PagesTableAdapter pagesTableAdapter;
        private System.Windows.Forms.BindingSource howTosBindingSource;
        private CEMS_Study_App_dbDataSetTableAdapters.HowTosTableAdapter howTosTableAdapter;
        private System.Windows.Forms.TextBox textBoxHowTos;
    }
}