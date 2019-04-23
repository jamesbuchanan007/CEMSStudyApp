using System.ComponentModel;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    partial class RemovePdfLinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemovePdfLinks));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInputPath = new System.Windows.Forms.Button();
            this.buttonOutputPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(261, 301);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Green;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(12, 301);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(32, 170);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(212, 20);
            this.textBoxInput.TabIndex = 8;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(32, 214);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(212, 20);
            this.textBoxOutput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Folder Input Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Folder Output Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Removes All PDF Links from a Folder";
            // 
            // buttonInputPath
            // 
            this.buttonInputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInputPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInputPath.ForeColor = System.Drawing.Color.White;
            this.buttonInputPath.Location = new System.Drawing.Point(250, 168);
            this.buttonInputPath.Name = "buttonInputPath";
            this.buttonInputPath.Size = new System.Drawing.Size(75, 23);
            this.buttonInputPath.TabIndex = 13;
            this.buttonInputPath.Text = "Choose";
            this.buttonInputPath.UseVisualStyleBackColor = false;
            this.buttonInputPath.Click += new System.EventHandler(this.buttonInputPath_Click);
            // 
            // buttonOutputPath
            // 
            this.buttonOutputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOutputPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutputPath.ForeColor = System.Drawing.Color.White;
            this.buttonOutputPath.Location = new System.Drawing.Point(250, 212);
            this.buttonOutputPath.Name = "buttonOutputPath";
            this.buttonOutputPath.Size = new System.Drawing.Size(75, 23);
            this.buttonOutputPath.TabIndex = 14;
            this.buttonOutputPath.Text = "Choose";
            this.buttonOutputPath.UseVisualStyleBackColor = false;
            this.buttonOutputPath.Click += new System.EventHandler(this.buttonOutputPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Note - Cannot choose the same folder";
            // 
            // RemovePdfLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 336);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOutputPath);
            this.Controls.Add(this.buttonInputPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemovePdfLinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonExit;
        private Button buttonSubmit;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonInputPath;
        private Button buttonOutputPath;
        private Label label4;
    }
}

