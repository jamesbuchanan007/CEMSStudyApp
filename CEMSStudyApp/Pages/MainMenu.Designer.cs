using System.ComponentModel;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPart75 = new System.Windows.Forms.Button();
            this.buttonPart63 = new System.Windows.Forms.Button();
            this.buttonFormulas = new System.Windows.Forms.Button();
            this.buttonAcronyms = new System.Windows.Forms.Button();
            this.buttonHowTos = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUnlock = new System.Windows.Forms.Button();
            this.buttonUoM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDT = new System.Windows.Forms.Button();
            this.buttonPart60 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPart75
            // 
            this.buttonPart75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonPart75.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPart75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPart75.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPart75.Location = new System.Drawing.Point(58, 106);
            this.buttonPart75.Name = "buttonPart75";
            this.buttonPart75.Size = new System.Drawing.Size(75, 23);
            this.buttonPart75.TabIndex = 1;
            this.buttonPart75.Text = "Part 75*";
            this.buttonPart75.UseVisualStyleBackColor = false;
            this.buttonPart75.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPart63
            // 
            this.buttonPart63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonPart63.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPart63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPart63.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPart63.Location = new System.Drawing.Point(58, 135);
            this.buttonPart63.Name = "buttonPart63";
            this.buttonPart63.Size = new System.Drawing.Size(75, 23);
            this.buttonPart63.TabIndex = 2;
            this.buttonPart63.Text = "Part 63**";
            this.buttonPart63.UseVisualStyleBackColor = false;
            this.buttonPart63.Click += new System.EventHandler(this.buttonPart63_Click);
            // 
            // buttonFormulas
            // 
            this.buttonFormulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonFormulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormulas.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFormulas.Location = new System.Drawing.Point(139, 106);
            this.buttonFormulas.Name = "buttonFormulas";
            this.buttonFormulas.Size = new System.Drawing.Size(75, 23);
            this.buttonFormulas.TabIndex = 3;
            this.buttonFormulas.Text = "Formulas";
            this.buttonFormulas.UseVisualStyleBackColor = false;
            this.buttonFormulas.Click += new System.EventHandler(this.buttonFormulas_Click);
            // 
            // buttonAcronyms
            // 
            this.buttonAcronyms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAcronyms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcronyms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcronyms.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAcronyms.Location = new System.Drawing.Point(139, 135);
            this.buttonAcronyms.Name = "buttonAcronyms";
            this.buttonAcronyms.Size = new System.Drawing.Size(75, 23);
            this.buttonAcronyms.TabIndex = 4;
            this.buttonAcronyms.Text = "Acronyms";
            this.buttonAcronyms.UseVisualStyleBackColor = false;
            this.buttonAcronyms.Click += new System.EventHandler(this.buttonAcronyms_Click);
            // 
            // buttonHowTos
            // 
            this.buttonHowTos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonHowTos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHowTos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHowTos.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHowTos.Location = new System.Drawing.Point(58, 193);
            this.buttonHowTos.Name = "buttonHowTos";
            this.buttonHowTos.Size = new System.Drawing.Size(75, 23);
            this.buttonHowTos.TabIndex = 5;
            this.buttonHowTos.Text = "How To\'s";
            this.buttonHowTos.UseVisualStyleBackColor = false;
            this.buttonHowTos.Click += new System.EventHandler(this.buttonHowTos_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(183, 294);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUnlock
            // 
            this.buttonUnlock.BackColor = System.Drawing.Color.Green;
            this.buttonUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnlock.ForeColor = System.Drawing.Color.White;
            this.buttonUnlock.Location = new System.Drawing.Point(12, 294);
            this.buttonUnlock.Name = "buttonUnlock";
            this.buttonUnlock.Size = new System.Drawing.Size(75, 23);
            this.buttonUnlock.TabIndex = 7;
            this.buttonUnlock.Text = "Admin";
            this.buttonUnlock.UseVisualStyleBackColor = false;
            this.buttonUnlock.Click += new System.EventHandler(this.buttonUnlock_Click);
            // 
            // buttonUoM
            // 
            this.buttonUoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonUoM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUoM.ForeColor = System.Drawing.Color.Transparent;
            this.buttonUoM.Location = new System.Drawing.Point(139, 164);
            this.buttonUoM.Name = "buttonUoM";
            this.buttonUoM.Size = new System.Drawing.Size(75, 23);
            this.buttonUoM.TabIndex = 8;
            this.buttonUoM.Text = "UoM";
            this.buttonUoM.UseVisualStyleBackColor = false;
            this.buttonUoM.Click += new System.EventHandler(this.buttonUoM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "* Plain English Guide";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "** Subpart UUUUU";
            // 
            // buttonDT
            // 
            this.buttonDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDT.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDT.Location = new System.Drawing.Point(139, 193);
            this.buttonDT.Name = "buttonDT";
            this.buttonDT.Size = new System.Drawing.Size(75, 23);
            this.buttonDT.TabIndex = 11;
            this.buttonDT.Text = "Diagrams";
            this.buttonDT.UseVisualStyleBackColor = false;
            this.buttonDT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonPart60
            // 
            this.buttonPart60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonPart60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPart60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPart60.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPart60.Location = new System.Drawing.Point(58, 164);
            this.buttonPart60.Name = "buttonPart60";
            this.buttonPart60.Size = new System.Drawing.Size(75, 23);
            this.buttonPart60.TabIndex = 12;
            this.buttonPart60.Text = "Part 60***";
            this.buttonPart60.UseVisualStyleBackColor = false;
            this.buttonPart60.Click += new System.EventHandler(this.buttonPart60_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "*** Appendix B and F";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPart60);
            this.Controls.Add(this.buttonDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUoM);
            this.Controls.Add(this.buttonUnlock);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHowTos);
            this.Controls.Add(this.buttonAcronyms);
            this.Controls.Add(this.buttonFormulas);
            this.Controls.Add(this.buttonPart63);
            this.Controls.Add(this.buttonPart75);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonPart75;
        private Button buttonPart63;
        private Button buttonFormulas;
        private Button buttonAcronyms;
        private Button buttonHowTos;
        private Button buttonExit;
        private Button buttonUnlock;
        private Button buttonUoM;
        private Label label1;
        private Label label2;
        private Button buttonDT;
        private Button buttonPart60;
        private Label label3;
    }
}

