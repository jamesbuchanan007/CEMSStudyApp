using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMSStudyApp.Models
{
    class PasswordsLoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateAdded { get; set; }
        public int IsActive { get; set; }
    }
}
