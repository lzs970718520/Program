using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
    public class GetMsgDAL
    {
        public DataTable GridMsgDAL() {
            string sql = @"select *,case when TaskState='1' then '未完成'
			                             when TaskState='2' then '已完成'end as RWZT,
                                    case when TaskPriority='1' then '高'
	                                     when TaskPriority='2' then '中'
	                                     when TaskPriority='3' then '低'end as RWYXJ
                                    from Task a,Project b where a.ProjectID=b.ProjectID";
            return new DBhelper().Get(sql);
        }
        public DataTable DpdMsgDAL() {
            return new DBhelper().Get("select * from Project");
        }
        public DataTable CheckGrid(TaskInfo t) {
            string sql = @"select *,case when TaskState='1' then '未完成'
			                             when TaskState='2' then '已完成'end as RWZT,
                                    case when TaskPriority='1' then '高'
	                                     when TaskPriority='2' then '中'
	                                     when TaskPriority='3' then '低'end as RWYXJ
                                    from Task a,Project b where a.ProjectID=b.ProjectID ";
            if (t.ProjectID != 0) { 
                sql += string.Format("and a.ProjectID ='{0}'",t.ProjectID);
            }
            if (t.Content != "") {
                sql += string.Format("and Content like '%{0}%'",t.Content);
            }
            if (t.TaskState != 0) {
                sql += string.Format("and TaskState={0}",t.TaskState);
            }
            return new DBhelper().Get(sql);
        }
        public bool finnish(TaskInfo t) {
            string sql = string.Format(" update Task set TaskState='2', FinishedTime=getdate() where TaskID='{0}'",t.TaskID);
            return new DBhelper().Excute(sql);
        }
        public bool DelGridDAL(TaskInfo t)
        {
            return new DBhelper().Excute(string.Format("delete Task where TaskID='{0}'",t.TaskID));
        }
        public bool AddMsg(TaskInfo t) {
            return new DBhelper().Excute(string.Format("insert into Task values('{0}', '{1}', default, '1', null, '2')",t.TaskPriority,t.Content,t.ProjectID));
        }
    }
}
