using System;
using System.Configuration;
using System.Reflection;

namespace PetShop.DALFactory
{
    public class Access
    {
        private static string path = ConfigurationSettings.AppSettings["DAL"].ToString();
        public static PetShop.IDAL.IOrder GetOrder()
        {
            string classname = path + ".Order";
            return (PetShop.IDAL.IOrder)Assembly.Load(path).CreateInstance(classname);
        }
    }
}
