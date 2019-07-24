using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class AddDefinitions : Form
    {


        public AddDefinitions()
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
            txtDefinitionMeaning.ReadOnly = true;
            txtDefinition.ReadOnly = true;
            buttonSave.Enabled = false;
            buttonNew.Enabled = true;
        }

        private void EnableTextboxes()
        {
            txtDefinitionMeaning.Clear();
            txtDefinition.Clear();
            txtDefinitionMeaning.ReadOnly = false;
            txtDefinition.ReadOnly = false;
            buttonSave.Enabled = true;
            buttonNew.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var definition = txtDefinition.Text.Trim();
            var meaning = txtDefinitionMeaning.Text.Trim();

            var result = MessageBox.Show("Save?", "CEMS Study", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = "INSERT into Definitions (Part75_Word,Part75_Regulation,Part75_Section,Part75_Section_Name,Part75_Section_Number,Part75_Section_Sub_Name,Part75_Definition) Values('" +
                      definition + "'" + "," +
                      "'NULL'," + "'" +
                      "'NULL'," + "'" +
                      "'NULL'," + "'" +
                      "'NULL'," + "'" +
                      "'NULL'," + "'" +
                      meaning + "')";

            //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
            var connectionString = Settings.Default.LocalDb;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("'" + definition + "' Added", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DisableTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Cancel?", "CEMS Study", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
