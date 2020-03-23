using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserInfo
    {
        public int UserID { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public int UserRole { get; set; }
    }
}
