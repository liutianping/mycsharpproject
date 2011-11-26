using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Threetires.DAO
{
    class ConnectionFactory
    {
        private static SqlConnection cn;

        private ConnectionFactory() 
        {
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            cn.Open();
        }

        public static SqlConnection OpenConn()
        {
            cn = new SqlConnection();
            return cn;
        }
        public static void CloseConn()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}
