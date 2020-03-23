using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class GetMsgBLL
    {
        public DataTable GridMsgBLL()
        {
            return new GetMsgDAL().GridMsgDAL();
        }
        public DataTable DpdMsgBLL()
        {
            return new GetMsgDAL().DpdMsgDAL();
        }
        public DataTable CheckGrid(TaskInfo t)
        {
            return new GetMsgDAL().CheckGrid(t);
        }
        public bool finnish(TaskInfo t)
        {
            return new GetMsgDAL().finnish(t);
        }
        public bool DelGridBLL(TaskInfo t)
        {
            return new GetMsgDAL().DelGridDAL(t);
        }
        public bool AddMsg(TaskInfo t)
        {
            return new GetMsgDAL().AddMsg(t);
        }
    }
}
