using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Caching;
using System.Configuration;

namespace TableCacheDependency
{
    public class CacheDependency:ICacheDependency.ICacheDependency
    {
        public AggregateCacheDependency GetDependency()
        {
            AggregateCacheDependency dep = new AggregateCacheDependency();

            //获取dbName
            string dbName=ConfigurationSettings.AppSettings["dbName"];

            //获取数据表字符串，并转换成数组
            string tbName = ConfigurationSettings.AppSettings["tbStrs"];

            string[] tables = tbName.Split('|');
            
            //循环数组，创建SqlCacheDependency
            foreach (string tableName in tables)
            {
                dep.Add(new SqlCacheDependency(dbName,tableName));
            }
            
            return dep;
        }
    }
}
