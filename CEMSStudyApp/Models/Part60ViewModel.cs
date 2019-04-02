using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMSStudyApp.Models
{
    class Part60ViewModel
    {
        public int Part60Id { get; set; }
        public string Part60Number { get; set; }
        public string Part60Question { get; set; }
        public string Part60Answer { get; set; }
        public string Part60Name { get; set; }
        public int PagesId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateEdited { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
