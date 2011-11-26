using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Configuration;

namespace DALFactory
{
    public class ProductAccess
    {
        private static readonly string path=ConfigurationManager.AppSettings["DAL"];
        public static IDAL.IProduct GetProduct()
        {
           return (IDAL.IProduct)Assembly.Load(path).CreateInstance("SQLServerDAL.SQLServerProduct");
        }
    }
}
