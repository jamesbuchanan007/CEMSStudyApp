using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CEMSStudyApp.Properties;

namespace CEMSStudyApp.Pages
{
    public partial class ExportDb : Form
    {
        public ExportDb()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit Export/Import Process?", "CEMS Study App", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Export Database??", "CEMS Study App", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            //EXPORT
            if (answer == DialogResult.OK)
            {
                string connectionString = null;
                SqlConnection connection;
                SqlCommand command;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;

                connectionString = Settings.Default.LocalDb;
                connection = new SqlConnection(connectionString);

                //GET LIST OF TABLES
                sql = "Select * From sys.Tables";

                try
                {
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    adapter.Dispose();
                    command.Dispose();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                var DbTables = new List<string>();


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DbTables.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                //WHERE TO SAVE
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                var filePath = "";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    filePath = fbd.SelectedPath;
                }
                else
                {
                    filePath = string.Empty;
                    MessageBox.Show("No Path Selected. Aborting Process", "CEMS Study App", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                ExportToFile(DbTables, filePath);
            }
            else
            {
                Hide();
                var pw = new PasswordsLogin(false);
                pw.Show();
            }
        }

        //GETS TABLES FROM DB
        private void ExportToFile(List<string> DbTables, string filePath)
        {
            foreach (var table in DbTables)
            {
                string connectionString = null;
                SqlConnection connection;
                SqlCommand command;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;

                connectionString = Settings.Default.LocalDb;
                connection = new SqlConnection(connectionString);

                //GET LIST OF TABLES
                sql = "Select * From " + table;

                try
                {
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    adapter.Dispose();
                    command.Dispose();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could Not Download " + table + " Table!!", @"CEMS Study App", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                fileExportFunctionByTable(ds, table, filePath);
            }

            MessageBox.Show(@"DB Table Files Downloaded to " + filePath, @"CEMS Study App", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //OPENS FOLDERS WHERE FILES ARE SAVED
            var psi = new ProcessStartInfo();
            psi.FileName = @"c:\windows\system32\explorer.exe";
            psi.Arguments = filePath;
            Process.Start(psi);


            Hide();
            PasswordsLogin pl = new PasswordsLogin(false);
            pl.Show();
        }

        //EXPORTS TO FILE BY TABLE
        private void fileExportFunctionByTable(DataSet dt, string tableName, string path)
        {
            //Build the CSV file data as a Comma separated string.
            var file = string.Empty;

            foreach (DataColumn column in dt.Tables[0].Columns)
            {
                //Add the Header row for CSV file.
                file += column.ColumnName + ',';
            }

            //Add new line.
            file += "\r\n";

            foreach (DataRow row in dt.Tables[0].Rows)
            {
                foreach (DataColumn column in dt.Tables[0].Columns)
                {
                    //Add the Data rows.
                    file += row[column.ColumnName].ToString().Replace(",", ";") + ',';
                }

                //Add new line.
                file += "\r\n";
            }

            //EXPORT
            var filePathExcel = path + "\\" + tableName + "Table.csv";
            //var filePathTxt = path + "\\" + tableName + "Table.txt";

            try
            {
                File.WriteAllText(filePathExcel, file);
                //File.WriteAllText(filePathTxt, file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "OOPS !! Could not Export", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }



        }
       
    }
}
