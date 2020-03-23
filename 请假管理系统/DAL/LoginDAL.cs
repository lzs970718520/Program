using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
    public class LoginDAL
    {
        public DataTable LonginDAL(UserInfo u) {
            return new DBhelper().Get(string.Format("select * from UserInfo where LoginName='{0}' and Password='{1}'",u.LoginName,u.Password));
        }
        public bool QingjiaDAL(Leave L) {
            string sql = string.Format("insert into Leave values('{0}','{1}','{2}','{3}',default,'1',default,default,'{4}')",
                                        L.Title, L.BeginDate, L.EndDate, L.LeaveReason,L.UserID);
            return new DBhelper().Excute(sql);
        }
        public DataTable DplMsgDAL()
        {
            return new DBhelper().Get("select UserID,LoginName from UserInfo");
        }
        public DataTable LoadGridDAL() {
            string sql = @"select *,case when ApproveState = '1' then '未审批'
			              when ApproveState = '2' then '已审批'end
			              as SPZT
                          from Leave a ,UserInfo b where a.UserID=b.UserID ";
            return new DBhelper().Get(sql);
        }
        public DataTable ckagainGrid(Leave L) {
            string sql = @"select *,case when ApproveState = '1' then '未审批'
			              when ApproveState = '2' then '已审批'end
			              as SPZT
                          from Leave a ,UserInfo b where a.UserID=b.UserID ";
            if (L.UserID != 0)
            {
                sql += string.Format("and a.UserID='{0}'", L.UserID);
            }
            if (L.Title != "")
            {
                sql += string.Format("and a.Title like '%{0}%'", L.Title);
            }
            if (L.ApproveState != 0)
            {
                sql += string.Format("and a.ApproveState='{0}'", L.ApproveState);
            }
            return new DBhelper().Get(sql);
        }
        public bool DelGrid(Leave L) {
            return new DBhelper().Excute(string.Format("delete Leave where LeaveID='{0}'",L.LeaveID));
        }
    }
}
