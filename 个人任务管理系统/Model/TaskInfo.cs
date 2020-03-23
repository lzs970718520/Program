using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TaskInfo
    {
        public int TaskID { get; set; }
        public int TaskPriority { get; set; }
        public string Content { get; set; }
        public DateTime AddTime { get; set; }
        public int TaskState { get; set; }
        public DateTime FinishedTime { get; set; }
        public int ProjectID { get; set; }

    }
}
