using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class CardinfoBLL
    {
        public DataTable ShowGrid()
        {
            return new cardinfoDAL().ShowGrid();
        }
        public bool AddCardBLL(GameCard g)
        {
            return new cardinfoDAL().AddCardDAL(g);
        }
        public DataTable checkGrid(GameCard g)
        {
            return new cardinfoDAL().checkGrid(g);
        }
        public bool delMsg(GameCard g)
        {
            return new CardinfoBLL().delMsg(g);
        }
    }
}
 