﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALlzs;
using Modellzs;

namespace BLLlzs
{
    public class UserInfoBLLlzs
    {
        public DataTable LonginBLLlzs(UserInfolzs u)
        {
            return new UserInfoDALlzs().LonginDALlzs(u);
        }
        public DataTable LoadGrid()
        {
            return new UserInfoDALlzs().LoadGrid();
        }
        public DataTable CheckGridlzs(NewsInfolzs n)
        {
            return new UserInfoDALlzs().CheckGridlzs(n);
        }
        public bool AddNewslzs(NewsInfolzs n)
        {
            return new UserInfoDALlzs().AddNewslzs(n);
        }
    }
}
