using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
    public class UserInfoDALlzs
    {
        public DataTable LoginDALlzs(Userlzs u)
        {
            return new DBhelper().Get(string.Format("select * from UserInfolzs where UserName='{0}' and UserPsw='{1}'", u.UserName, u.UserPsw));
        }
        public DataTable ShowGridlzs(Userlzs u)
        {
            string sql = @"select *,case when IfPass='0' then '未统计'
			                        when IfPass='1' then '及格'
			                        when IfPass='2' then '不及格' end as IFPAS,
		                    case when Rlevel='0' then '未统计'
			                        when Rlevel='1' then '差'
			                        when Rlevel='2' then '一般'
			                        when Rlevel='3' then '良好'
			                        when Rlevel='4' then '优秀' end as CJDJ
                    from StudentResultlzs a,ClassInfolzs b,UserInfolzs c where a.Sid=c.UserId and a.ClassId=b.ClassId ";
            if (u != null)
            {
                if (u.UserName != "")
                {
                    sql += string.Format("and UserName like '%{0}%'", u.UserName);
                }
                if (u.sClassId != 0)
                {
                    sql += string.Format("and a.ClassId = '{0}'", u.sClassId);
                }
                if (u.IfPass != 9 && u.IfPass != 0)
                {
                    sql += string.Format("and IfPass = '{0}'", u.IfPass);
                }
                if (u.Rlevel != 9 && u.Rlevel != 0)
                {
                    sql += string.Format("and Rlevel = '{0}'", u.Rlevel);
                }
                if (u.rid != 0) {
                    sql += string.Format("and rid='{0}'",u.rid);
                }
            }
            return new DBhelper().Get(sql);
        }
        public DataTable LoadDpdlzs()
        {
            return new DBhelper().Get("select * from ClassInfolzs");
        }
        public DataTable getSid() {
            return new DBhelper().Get("select max(UserId) from UserInfolzs");
        }
        public bool AddMsglzs(Userlzs u) {
            string sql = "";
            int sid = 0;
            if (u.sClassId != 0)
            {
                sid =Convert.ToInt32( getSid().Rows[0][0].ToString());
                sql = string.Format(" insert into StudentResultlzs values('{0}','{1}','{2}','{3}','{4}',default,null,default,default,'{5}')"
                    , sid, u.Chinese, u.Math, u.English, u.Computer, u.sClassId);
            }
            else { 
                sql = string.Format("insert into UserInfolzs values('{0}','123456')",u.UserName);
            }
            return new DBhelper().Excute(sql);
        }
        public bool DelGridlzs(Userlzs u) {
            return new DBhelper().Excute(string.Format("delete StudentResultlzs where rid='{0}'",u.rid));
        }
        public bool UpdateGridlzs(Userlzs u) {
            string sql = string.Format("update StudentResultlzs set Chinese='{0}',Math='{1}',English='{2}',Computer='{3}' where rid='{4}'"
                                       , u.Chinese,u.Math,u.English,u.Computer,u.rid);
            return new DBhelper().Excute(sql);
        }
        public bool JieSuanDAL(Userlzs u)
        {
            string sql = string.Format(" update StudentResultlzs set TScore=Chinese+Math+English+Computer where rid ='{0}'", u.rid);
            bool flag = new DBhelper().Excute(sql);
            if (flag)
            {
                int TScore = Convert.ToInt32(new DBhelper().Get(string.Format("select TScore from StudentResultlzs where rid ='{0}'", u.rid)).Rows[0][0].ToString());
                u.IfPass = TScore >= 240 ? 1 : 2;
                u.Rlevel = TScore < 240 ? 1 : TScore < 320 ? 2 : TScore < 360 ? 3 : 4;
                flag = new DBhelper().Excute(string.Format("update StudentResultlzs set IfPass='{0}',Rlevel='{1}' where rid ='{2}'", u.IfPass,u.Rlevel,u.rid));
                return flag;
            }
            else
            {
                return false;
            }
        }
    }
}
