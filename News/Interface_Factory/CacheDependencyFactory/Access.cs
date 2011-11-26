using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Reflection;

namespace CacheDependencyFactory
{
    public class Access
    {
        private static readonly string path = ConfigurationSettings.AppSettings["CacheDependency"];

        public static ICacheDependency.ICacheDependency CreateDependendcy()
        {
            string className = path + ".CacheDependency";
            return (ICacheDependency.ICacheDependency)Assembly.Load(path).CreateInstance(className);
        }
    }
}
