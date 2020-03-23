using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class LoginBLL
    {
        public DataTable LonginBLL(UserInfo u)
        {
            return new LoginDAL().LonginDAL(u);
        }
        public bool QingjiaBLL(Leave L)
        {
            return new LoginDAL().QingjiaDAL(L);
        }
        public DataTable DplMsgDAL()
        { return new LoginDAL().DplMsgDAL(); }
        public DataTable LoadGridBLL()
        {
            return new LoginDAL().LoadGridDAL();
        }
        public DataTable ckagainGrid(Leave L)
        {
            return new LoginDAL().ckagainGrid(L);
        }
        public bool DelGrid(Leave L)
        {
            return new LoginDAL().DelGrid(L);
        }
    }
}
