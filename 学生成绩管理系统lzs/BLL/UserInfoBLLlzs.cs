using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using DAL;

namespace BLL
{
    public class UserInfoBLLlzs
    {
        public DataTable LoginBLLlzs(Userlzs u)
        {
            return new UserInfoDALlzs().LoginDALlzs(u);
        }
        public DataTable ShowGridlzs(Userlzs u)
        {
            return new UserInfoDALlzs().ShowGridlzs(u);
        }
        public DataTable LoadDpdlzs()
        {
            return new UserInfoDALlzs().LoadDpdlzs();
        }
        public bool AddMsglzs(Userlzs u)
        {
            return new UserInfoDALlzs().AddMsglzs(u);
        }
        public bool DelGridlzs(Userlzs u)
        {
            return new UserInfoDALlzs().DelGridlzs(u);
        }
        public bool UpdateGridlzs(Userlzs u)
        {
            return new UserInfoDALlzs().UpdateGridlzs(u);
        }
        public bool JieSuanBLL(Userlzs u)
        {
            return new UserInfoDALlzs().JieSuanDAL(u);
        }
    }
}
