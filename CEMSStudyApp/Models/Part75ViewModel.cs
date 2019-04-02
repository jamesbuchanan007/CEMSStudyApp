using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMSStudyApp.Models
{
    class Part75ViewModel
    {
        public int Part75Id { get; set; }
        public string Part75Number { get; set; }
        public string Question { get; set; }
        public string Part75Answer { get; set; }
        public string Part75Name { get; set; }
        public int PagesId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateEdited { get; set; }
        public DateTime DateDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
