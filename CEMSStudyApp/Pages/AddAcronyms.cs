using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class AddAcronyms : Form
    {


        public AddAcronyms()
        {
            InitializeComponent();

            //SETS SAVE BUTTON TO WHEN USER PRESSES ENTER
            AcceptButton = buttonSave;

            DisableTextboxes();

            buttonNew.Enabled = true;
        }

        public void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            EnableTextboxes();
            buttonNew.Enabled = false;
        }

        private void DisableTextboxes()
        {
            txtAcronymMeaning.ReadOnly = true;
            txtAcronymn.ReadOnly = true;
            buttonSave.Enabled = false;
            buttonNew.Enabled = true;
        }

        private void EnableTextboxes()
        {
            txtAcronymMeaning.Clear();
            txtAcronymn.Clear();
            txtAcronymMeaning.ReadOnly = false;
            txtAcronymn.ReadOnly = false;
            buttonSave.Enabled = true;
            buttonNew.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var acronym = txtAcronymn.Text.Trim();
            var meaning = txtAcronymMeaning.Text.Trim();

            var result = MessageBox.Show("Save?", "CEMS Study", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            SqlConnection connection;

            var sql = "INSERT into Acronyms (Acronyms_Name,Acronyms_Description,Pages_Id,Section_Heading) Values('" +
                      acronym + "'" + "," + "'" +
                      meaning + "'" + "," +
                      4 + "," + "'Acronyms')";

            //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
            var connectionString = Settings.Default.LocalDb;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                connection.Close();

                MessageBox.Show("'" + acronym + "' Added", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DisableTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
