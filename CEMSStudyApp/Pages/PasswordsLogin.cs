using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using CEMSStudyApp.Models;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class PasswordsLogin : Form
    {
        public static bool appIsLocked { get; set; }
        public static bool wantsToEditPassword { get; set; }

        public PasswordsLogin()
        {
            InitializeComponent();

            //SETS SAVE BUTTON TO WHEN USER PRESSES ENTER
            AcceptButton = buttonSubmit;

            DisableTextboxes();

            if (appIsLocked)
            {
                textBoxPassword.Enabled = true;
                textBoxPassword.ReadOnly = false;
            }
            else
            {
                textBoxPassword.Enabled = false;
                textBoxPassword.ReadOnly = true;
            }

            //appIsLocked = true;

            buttonUpdate.Enabled = true;

            //EDIT PASSWORD BUTTON TOGGLES THIS
            var wantsToEditPassword = false;

        }

        public void buttonExit_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Exit Admin?", "CEMS Study App", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                Hide();
                MainMenu mm = new MainMenu();
                mm.Show();
            }
        }

        public void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Visible == false) return;

            //IF ENTERING ONLY PASSWORD
            if (!wantsToEditPassword)
            {
                var ds = GetPassword();
                var dbPassword = ds.Tables[0].Rows[0]["Password"].ToString();

                if (textBoxPassword.Text.Trim() == dbPassword)
                {
                    MessageBox.Show("Edit Mode", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Hide();
                    appIsLocked = false;

                }
                else
                {
                    MessageBox.Show("Incorrect Password !!", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Hide();
                    appIsLocked = true;
                }
            }
            //IF UPDATING DB
            else
            {
                var ds = GetPassword();
                var dbPassword = ds.Tables[0].Rows[0]["Password"].ToString();

                if (textBoxPassword.Text.Trim() != dbPassword)
                {
                    MessageBox.Show("Incorrect Password !!", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Hide();
                    appIsLocked = true;
                    return;
                }

                if (textBoxNewPassword1.Text != textBoxNewPassword2.Text)
                {
                    MessageBox.Show("New Passwords Do Not Match !!", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Hide();
                    appIsLocked = true;
                    return;
                }

                PasswordsLoginViewModel vm = new PasswordsLoginViewModel
                {
                    UserName = textBoxUserName.Text,
                    Password = textBoxNewPassword1.Text,
                    DateAdded = DateTime.Now,
                    IsActive = 1
                };

                var format = "yyyy-MM-dd HH:mm:ss";

                SqlConnection connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                var sql = "INSERT into PasswordsLogin (Password,Date_Added,Is_Active,User_Name) Values('" +
                    vm.Password + "'" + "," + "'" +
                    vm.DateAdded.ToString(format) + "'" + "," +
                    vm.IsActive + "," + "'" +
                    vm.UserName + "')";

                //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
                var connectionString = Settings.Default.LocalDb;

                connection = new SqlConnection(connectionString);

                try
                {
                    connection.Open();
                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Password Updated", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    appIsLocked = false;
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                wantsToEditPassword = false;
            }


        }

        public DataSet GetPassword()
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql;

            var connectionString = Settings.Default.LocalDb;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "Select TOP 1 * from PasswordsLogin ORDER BY Passwords_Id Desc";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "PasswordsLogin");
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ds;
        }

        private void DisableTextboxes()
        {
            textBoxPassword.Enabled = false;
            textBoxPassword.ReadOnly = true;
            textBoxNewPassword1.Enabled = false;
            textBoxNewPassword1.ReadOnly = true;
            textBoxNewPassword2.Enabled = false;
            textBoxNewPassword2.ReadOnly = true;
            textBoxUserName.Enabled = false;
            textBoxUserName.ReadOnly = true;
        }
        private void EnableTextboxes()
        {
            textBoxPassword.Enabled = true;
            textBoxPassword.ReadOnly = false;
            textBoxNewPassword1.Enabled = true;
            textBoxNewPassword1.ReadOnly = false;
            textBoxNewPassword2.Enabled = true;
            textBoxNewPassword2.ReadOnly = false;
            textBoxUserName.Enabled = true;
            textBoxUserName.ReadOnly = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            wantsToEditPassword = true;
            buttonUpdate.Hide();
            EnableTextboxes();
        }

        private void buttonDatabase_Click(object sender, EventArgs e)
        {
            Hide();
            var dbp = new DbPassword();
            dbp.Show();
        }
    }
}
