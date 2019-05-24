using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class PasswordsLogin : Form
    {
        public bool appIsLocked { get; set; }
        public bool wantsToEditPassword { get; set; }
        public string userName { get; set; }

        public PasswordsLogin()
        {
            InitializeComponent();

            //SETS SAVE BUTTON TO WHEN USER PRESSES ENTER
            AcceptButton = buttonSubmit;

            DisableTextboxes();

            buttonUpdate.Enabled = true;

            //EDIT PASSWORD BUTTON TOGGLES THIS
            var wantsToEditPassword = false;

        }

        public void buttonExit_Click(object sender, EventArgs e)
        {
            appIsLocked = true;
            Close();
        }

        public void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Enabled == false) return;

            //IF ENTERING ONLY PASSWORD
            if (!wantsToEditPassword)
            {
                var ds = GetPassword();
                var dbPassword = ds.Tables[0].Rows[0]["Password"].ToString();

                if (textBoxPassword.Text.Trim() == dbPassword)
                {
                    MessageBox.Show("Edit Mode", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    appIsLocked = false;
                    Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Password !!", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    appIsLocked = true;
                    Close();
                }
            }
            //IF UPDATING DB
            else
            {
                var ds = GetPassword();
                var dbPassword = ds.Tables[0].Rows[0]["Password"].ToString();

                if (textBoxPassword.Text.Trim() != dbPassword)
                {
                    MessageBox.Show("Incorrect Password !!", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    appIsLocked = true;
                    Close();
                    return;
                }

                if (textBoxNewPassword1.Text != textBoxNewPassword2.Text)
                {
                    MessageBox.Show("New Passwords Do Not Match !!", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    appIsLocked = true;
                    Close();
                    return;
                }

                userName = textBoxUserName.Text;

                var format = "yyyy-MM-dd HH:mm:ss";

                SqlConnection connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                var sql = "INSERT into PasswordsLogin (Password,Date_Added,Is_Active,User_Name) Values('" +
                          textBoxNewPassword1.Text + "'" + "," + "'" +
                          DateTime.Now.ToString(format) + "'" + "," +
                          1 + "," + "'" +
                          textBoxUserName.Text + "')";

                //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
                var connectionString = Settings.Default.LocalDb;

                connection = new SqlConnection(connectionString);

                try
                {
                    connection.Open();
                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Password Updated", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    appIsLocked = false;
                    Close();
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
            buttonUpdate.Hide();
            EnableTextboxes();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            var dbp = new DbPassword();
            dbp.ShowDialog();
        }
    }
}
