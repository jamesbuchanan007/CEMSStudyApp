using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            string connectionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dtPages = new DataTable("Pages");
            DataTable dtAcronyms = new DataTable("Acronyms");
            int i;
            string sql = null;

            //SET CONNECTION STRING IN PROJECT > APP PROPERTIES > SETTINGS
            connectionString = Properties.Settings.Default.LocalDb;
           
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "Select * from Pages";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, dtPages.ToString());

                sql = "Select * from Acronyms";
                adapter.SelectCommand.CommandText = sql;
                adapter.Fill(ds, dtAcronyms.ToString());

                adapter.Dispose();
                command.Dispose();
                connection.Close();

                //for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                //{
                //    MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1]);

                //}

                //for (i = 0; i <= ds.Tables[1].Rows.Count - 1; i++)
                //{
                //    MessageBox.Show(ds.Tables[1].Rows[i].ItemArray[0] + " -- " + ds.Tables[1].Rows[i].ItemArray[1]);

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Part75 part75 = new Part75();
            part75.Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Part60 part60 = new Part60();
            part60.Show();
        }

        private void buttonFormulas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulas formulas = new Formulas();
            formulas.Show();
        }

        private void buttonAcronyms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acronyms acronyms = new Acronyms();
            acronyms.Show();
        }

        private void buttonHowTos_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowTos howTos = new HowTos();
            howTos.Show();
        }
    }
}
