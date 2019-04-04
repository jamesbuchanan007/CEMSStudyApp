using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using CEMSStudyApp.Models;

namespace CEMSStudyApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pages.MainMenu());

           // 1.Open connection to db
           // 2.Create DataAdapter object
           // 3.Declare and Create an instance of DataSet
           // 4.Use FillSchema and Fill
           // 5. 4.Use FillSchema and Fill

           //CONNECT TO DB
           // var connectionString = "data source=local host; initial catalog=CEMS_Study_App_db; integrated security=true";

           // SqlConnection db_connection = new SqlConnection(connectionString);

           // OPEN CONNECTION
           // db_connection.Open();

           // SQL COMMAND
           // SqlCommand command;

           // DataSet
           //  DataSet dsAcronyms = new DataSet("Acronyms");

           // DataAdapter
           // SqlDataAdapter daAcronyms = new SqlDataAdapter();
           // daAcronyms.FillSchema(dsAcronyms, schemaType: SchemaType.Source, "Acronyms");
           // daAcronyms.Fill(dsAcronyms, "Acronyms");

           // dsAcronyms.Tables["Acronyms"].Select();

           // Acronyms DataSet Query
           // var query = from dsAcr in dsAcronyms
           //             where dsAcr.

           // AcronymsViewModel acronymsViewModel = new AcronymsViewModel
           // {
           //     AcronymsId =
           // };

        }
    }
}
