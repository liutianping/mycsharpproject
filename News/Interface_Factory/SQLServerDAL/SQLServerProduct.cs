using System;
using System.Collections.Generic;
using System.Text;

namespace SQLServerDAL
{
    public class SQLServerProduct:IDAL.IProduct
    {
        public string GetProduct()
        {
            return "From SQLServer DataBase Product";
        }
    }
}
