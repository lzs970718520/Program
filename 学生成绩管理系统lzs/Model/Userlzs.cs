using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Userlzs
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPsw { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int rid { get; set; }
        public int Sid { get; set; }
        public int Chinese { get; set; }
        public int Math { get; set; }
        public int English { get; set; }
        public int Computer { get; set; }
        public DateTime Etime { get; set; }
        public int TScore { get; set; }
        public int IfPass { get; set; }
        public int Rlevel { get; set; }
        public int sClassId { get; set; }
    }
}
