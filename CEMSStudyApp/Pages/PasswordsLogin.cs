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
        public static bool editPassword { get; set; }

        public PasswordsLogin()
        {
            InitializeComponent();
            DisableTextboxes();
            appIsLocked = true;

            textBoxPassword.Enabled = true;
            textBoxPassword.ReadOnly = false;

            buttonUpdate.Enabled = true;

            //EDIT PASSWORD BUTTON TOGGLES THIS
            var editPassword = 0;

        }

        public void buttonExit_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void buttonSubmit_Click(object sender, EventArgs e)
        {
            //IF UPDATING DB
            if (!editPassword)
            {
                var ds = GetPassword();
                var dbPassword = ds.Tables[0].Rows[0]["Password"].ToString();

                if (textBoxPassword.Text.Trim() == dbPassword)
                {
                    MessageBox.Show("App is Unlocked", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Hide();

                    appIsLocked = false;
                }
                else
                {
                    MessageBox.Show("Not Unlocked !!", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Hide();

                    appIsLocked = true;
                }
            }
            //IF ONLY ENTERING PASSWORD
            else
            {
                EnableTextboxes();
                GetPassword();

                var ds = GetPassword();
                var dbPassword = ds.Tables[0].Rows[0]["Password"].ToString();

                PasswordsLoginViewModel vm = new PasswordsLoginViewModel
                {
                    UserName = textBoxUserName.Text,
                    Password = textBoxPassword.Text,
                    DateAdded = DateTime.Now,
                    IsActive = 1
                };

                if (textBoxPassword.Text.Trim() == dbPassword)
                {
                    var format = "yyyy-MM-dd HH:mm:ss";

                    SqlConnection connection;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    var sql = "INSERT into PasswordsLogin (Password,Date_Added,Is_Active,User_Name) Values('" +
                        vm.Password + "'" + "," + "'" +
                        vm.DateAdded.ToString(format) + "'" + "," +
                        vm.IsActive + "," + ",'" +
                        vm.UserName + "'";

                    //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
                    var connectionString = Settings.Default.LocalDb;

                    connection = new SqlConnection(connectionString);

                    try
                    {
                        connection.Open();
                        adapter.UpdateCommand = connection.CreateCommand();
                        adapter.UpdateCommand.CommandText = sql;
                        adapter.UpdateCommand.ExecuteNonQuery();

                        MessageBox.Show("App is Unlocked", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        appIsLocked = false;
                        Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Original Passwords Do Not Match !!", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    appIsLocked = true;
                    Hide();
                }
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
            editPassword = true;
            buttonUpdate.Hide();
            EnableTextboxes();
        }
    }
}
