using System;

namespace CEMSStudyApp.Models
{
    class PasswordsLogin
    {
        public int PasswordsLoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }
    }
}
