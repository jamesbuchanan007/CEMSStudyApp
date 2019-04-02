using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMSStudyApp.Models
{
    class AcronymsViewModel
    {
        public int AcronymsId { get; set; }
        public string Acronyms_Name { get; set; }
        public string Acronyms_Description { get; set; }
        public int Pages_Id { get; set; }
        public DateTime Date_Added { get; set; }
        public DateTime Date_Edited { get; set; }
        public DateTime Date_Deleted { get; set; }
    }
}
