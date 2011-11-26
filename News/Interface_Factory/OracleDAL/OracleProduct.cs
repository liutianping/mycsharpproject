using System;
using System.Collections.Generic;
using System.Text;

namespace OracleDAL
{
    public class OracleProduct:IDAL.IProduct
    {
        public string GetProduct()
        {
            return "Form Oracle DataBase Product";
        }

        public string GetProductIdName(int id)
        {
            return "dog";
        }
    }
}
