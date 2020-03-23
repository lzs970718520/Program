using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Leave
    {
        public int LeaveID { get; set; }
        public string Title { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveReason { get; set; }
        public DateTime ApplyTime { get; set; }
        public int ApproveState { get; set; }
        public DateTime ApproveTime { get; set; }
        public string ApproveResult { get; set; }
        public int UserID { get; set; }
    }
}
