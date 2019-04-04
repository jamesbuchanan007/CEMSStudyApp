using System;

namespace CEMSStudyApp.Models
{
    class FormulasViewModel
    {
        public int FormulasId { get; set; }
        public string FormulasName { get; set; }
        public string FormulasDescription { get; set; }
        public int PagesId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateEdited { get; set; }
        public DateTime DateDelete  { get; set; }
        public bool IsActive { get; set; }
    }
}
