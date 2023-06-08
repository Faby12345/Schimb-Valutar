using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainApp
{
    public class UserClass
    {
        public UserClass() { }

        public string UserName { get; set; }
        public string USerPassword { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime LogedInTime { get; set; }
    }
}
