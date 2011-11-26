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

            //��ȡdbName
            string dbName=ConfigurationSettings.AppSettings["dbName"];

            //��ȡ���ݱ��ַ�������ת��������
            string tbName = ConfigurationSettings.AppSettings["tbStrs"];

            string[] tables = tbName.Split('|');
            
            //ѭ�����飬����SqlCacheDependency
            foreach (string tableName in tables)
            {
                dep.Add(new SqlCacheDependency(dbName,tableName));
            }
            
            return dep;
        }
    }
}
