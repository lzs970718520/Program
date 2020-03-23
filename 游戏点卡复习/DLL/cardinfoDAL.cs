using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class cardinfoDAL
    {
        public DataTable ShowGrid() {
            string sql = "select * from GameCard";
            DataTable dt = new DBhelper().Get(sql);
            return dt;
        }
        public bool AddCardDAL(GameCard g) {
            string sql = string.Format("insert into GameCard values('{0}','{1}','{2}','{3}')", g.gamename, g.company, g.lastDay, g.price);
            bool flag = new DBhelper().Excute(sql);
            return flag;
        }
        public DataTable checkGrid(GameCard g)
        {
            string sql = "select * from GameCard where 1=1 ";
            if (g.gamename != "" && g.gamename != null)
            {
                sql += string.Format("and gamename like '%{0}%'", g.gamename);
            }
            if (g.company != "" && g.company != null)
            {
                sql += string.Format("and company like '%{0}%'", g.company);

            }
            return new DBhelper().Get(sql);
        }
        public bool delMsg(GameCard g) {
            return new DBhelper().Excute(string.Format("delete GameCard where Cardid='{0}'",g.cardid));
        }
    }
}
