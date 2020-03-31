using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class CarInfoBLL
    {
        public DataTable GetGridBLL(CarDetailinfo c)
        {
            return new CarInfoDAL().GetGridDAL(c);
        }
        public bool DelGridBLL(CarDetailinfo c)
        {
            return new CarInfoDAL().DelGridDAL(c);
        }
        public DataTable ShowDpdBLL()
        {
            return new CarInfoDAL().ShowDpdDAL();
        }
        public bool AddCarBLL(CarDetailinfo c)
        {
            return new CarInfoDAL().AddCarDAL(c);
        }
        public bool UpdateGridBLL(CarDetailinfo c)
        {
            return new CarInfoDAL().UpdateGridDAL(c);
        }
    }
}
