using System.ComponentModel;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    partial class PasswordsLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordsLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewPassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(183, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Green;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(12, 256);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(93, 135);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(149, 20);
            this.textBoxUserName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "User Name";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(93, 161);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(149, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword1
            // 
            this.textBoxNewPassword1.Location = new System.Drawing.Point(93, 187);
            this.textBoxNewPassword1.Name = "textBoxNewPassword1";
            this.textBoxNewPassword1.Size = new System.Drawing.Size(149, 20);
            this.textBoxNewPassword1.TabIndex = 3;
            this.textBoxNewPassword1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "New Password";
            // 
            // textBoxNewPassword2
            // 
            this.textBoxNewPassword2.Location = new System.Drawing.Point(93, 213);
            this.textBoxNewPassword2.Name = "textBoxNewPassword2";
            this.textBoxNewPassword2.Size = new System.Drawing.Size(149, 20);
            this.textBoxNewPassword2.TabIndex = 4;
            this.textBoxNewPassword2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Confirm";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Blue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(99, 256);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDatabase
            // 
            this.buttonDatabase.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatabase.ForeColor = System.Drawing.Color.White;
            this.buttonDatabase.Location = new System.Drawing.Point(167, 97);
            this.buttonDatabase.Name = "buttonDatabase";
            this.buttonDatabase.Size = new System.Drawing.Size(75, 23);
            this.buttonDatabase.TabIndex = 8;
            this.buttonDatabase.Text = "Database";
            this.buttonDatabase.UseVisualStyleBackColor = false;
            this.buttonDatabase.Click += new System.EventHandler(this.buttonDatabase_Click);
            // 
            // PasswordsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 297);
            this.Controls.Add(this.buttonDatabase);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewPassword1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordsLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEMS Study App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonCancel;
        private Button buttonSubmit;
        private TextBox textBoxUserName;
        private Label label4;
        private TextBox textBoxPassword;
        private TextBox textBoxNewPassword1;
        private Label label1;
        private Label label2;
        private TextBox textBoxNewPassword2;
        private Label label3;
        private Button buttonUpdate;
        private Button buttonDatabase;
    }
}

