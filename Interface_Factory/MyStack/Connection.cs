using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MyStack
{
    public class Connection
    {
        static SqlConnection cn;
        const string CONNECTIONSTRING = "data source=.;initial catalog=test;integrated security=true";
        public static SqlConnection GetConnection()
        {
            cn = new SqlConnection(CONNECTIONSTRING);
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                cn = null;
            }
            return cn;
        }

        public static void CloseConn()
        {
            if (cn != null)
            {
                cn.Close();
            }
        }
    }
}
