using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBhelper
    {
        private SqlConnection conn = null;
        private string ConnStr = "server=.;database=CarInfo;integrated security=true";

        public DBhelper() {
            conn = new SqlConnection(ConnStr);
        }

        public bool Excute(string sql) {
            try {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                int i = cmd.ExecuteNonQuery();
                return i > 0 ? true : false;
            }
            catch(Exception e) {
                throw new Exception(e.Message.ToString());
            }
            finally {
                conn.Close();
            }
        }

        public DataTable Get(string sql){
            try {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                return ds.Tables[0];
            }
            catch(Exception e) {
                throw new Exception(e.Message.ToString());
            }
            finally {
                conn.Close();
            }
        }
    }
}
