using System;

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
        public int IsActive { get; set; }
    }
}
