using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMSStudyApp.Models
{
    class HowTosViewModel
    {
        public int HowTosId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PagesId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateEdited { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
