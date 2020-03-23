using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modellzs;


namespace DALlzs
{
    public class UserInfoDALlzs
    {
        public DataTable LonginDALlzs(UserInfolzs u) {
            return new DBhelper().Get(string.Format("select * from UserInfo where UserName='{0}' and Psswd='{1}'",u.UserName,u.Psswd));
        }
        public DataTable LoadGrid() {
            string sql = @"select *,case when N_type='1' then '体育新闻'
                          when N_type = '2' then '娱乐新闻'
                          when N_type = '3' then '财经新闻'
                          when N_type = '4' then '时事新闻'
                          when N_type = '5' then '其他新闻' end as XWLX
		            ,case when n_state = '1' then '未审核'
                          when n_state = '2' then '已审核' end as SHZT
                        from NewsInfo";

            return new DBhelper().Get(sql);
        }
        public DataTable CheckGridlzs(NewsInfolzs n) {
            string sql = @"select *,case when N_type='1' then '体育新闻'
                          when N_type = '2' then '娱乐新闻'
                          when N_type = '3' then '财经新闻'
                          when N_type = '4' then '时事新闻'
                          when N_type = '5' then '其他新闻' end as XWLX
		            ,case when n_state = '1' then '未审核'
                          when n_state = '2' then '已审核' end as SHZT
                        from NewsInfo where 1=1 ";
            if (n.N_type != 0) {
                sql += string.Format("and N_type='{0}'",n.N_type);
            }
            if (n.n_title != "") {
                sql += string.Format("and n_title like '{0}'",n.n_title);
            }
            if (n.n_content != "")
            {
                sql += string.Format("and n_content like '{0}'", n.n_content);
            }
            return new DBhelper().Get(sql);
        }
    }
}
