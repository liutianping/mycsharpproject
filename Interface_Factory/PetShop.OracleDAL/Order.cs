using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.OracleDAL
{
    public class Order:PetShop.IDAL.IOrder
    {
        public string GetOrder()
        {
            return "GetOrder from OracleDALs";
        }
    }
}
