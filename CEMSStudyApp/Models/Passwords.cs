using System;

namespace CEMSStudyApp.Models
{
    class Passwords
    {
        public int PasswordsId { get; set; }
        public string Password { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
