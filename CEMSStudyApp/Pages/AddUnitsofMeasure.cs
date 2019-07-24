using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class AddUnitsofMeasure : Form
    {


        public AddUnitsofMeasure()
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
            txtUoMMeaning.ReadOnly = true;
            txtUoM.ReadOnly = true;
            buttonSave.Enabled = false;
            buttonNew.Enabled = true;
        }

        private void EnableTextboxes()
        {
            txtUoMMeaning.Clear();
            txtUoM.Clear();
            txtUoMMeaning.ReadOnly = false;
            txtUoM.ReadOnly = false;
            buttonSave.Enabled = false;
            buttonNew.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var unit = txtUoM.Text.Trim();
            var meaning = txtUoMMeaning.Text.Trim();

            var result = MessageBox.Show("Save?", "CEMS Study", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = "INSERT into UnitOfMeasure (UnitOfMeasure_Name,UnitOfMeasure_Description,Section_Heading) Values('" +
                      unit + "','" +
                      meaning + "','" +
                      "Units of Measure')";

            //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
            var connectionString = Settings.Default.LocalDb;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("'" + unit + "' Added", "CEMS Study", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
