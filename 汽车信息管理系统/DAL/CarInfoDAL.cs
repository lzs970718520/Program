using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;


namespace DAL
{
    public class CarInfoDAL
    {
        public DataTable GetGridDAL(CarDetailinfo c) {
            string sql = "select * from CarDetail a,CarBrand b where a.BrandId=b.BrandId ";
            if (c != null)
            {
                if (c.cname != "")
                {
                    sql += string.Format("and cname like '%{0}%'", c.cname);
                }
                if (c.Price != 0 && c.Price2 != 0)
                {
                    sql += string.Format("and Price > '{0}' and Price < '{1}'", c.Price, c.Price2);
                }
            }
            return new DBhelper().Get(sql);
        }
        public bool DelGridDAL(CarDetailinfo c) {
            string sql = string.Format("delete CarDetail where cid='{0}'", c.cid);
            return new DBhelper().Excute(sql);
        }
        public DataTable ShowDpdDAL() {
            return new DBhelper().Get("select * from CarBrand");
        }
        public bool AddCarDAL(CarDetailinfo c) {
            string sql = string.Format(@"insert into CarDetail 
                                values('{0}','{1}','{2}','{3}',default,'{4}')"
                                , c.cname,c.Content,c.Price,c.ImageUrl,c.BrandId);
            return new DBhelper().Excute(sql);
        }
        public bool UpdateGridDAL(CarDetailinfo c) {
            string sql = string.Format("update CarDetail set Content='{0}',Price='{1}' where cid='{2}'",c.Content,c.Price,c.cid);
            return new DBhelper().Excute(sql);
        }
        public DataTable FindById(string id) {
            string sql = string.Format("select BrandId from CarBrand");
        }
    }
}
