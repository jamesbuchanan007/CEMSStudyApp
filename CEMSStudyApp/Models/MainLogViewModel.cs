using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMSStudyApp.Models
{
    class MainLogViewModel
    {
        public int MainLogId { get; set; }
        public string UserName { get; set; }
        public DateTime DateChanged { get; set; }
        public string PriorData { get; set; }
        public string NewData { get; set; }
        public int PagesId { get; set; }
    }
}
