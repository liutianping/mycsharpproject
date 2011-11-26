using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Threetries.model;
using System.Data.SqlClient;

namespace Threetires.DAO
{
    public class DBHelp
    {
        
        SqlConnection cn = null;

        public SqlConnection GetConn() 
        {
            if (cn.State ==ConnectionState.Open)
            {
                cn = null;
            }                
            cn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=threetirestest;Integrited Security=true");
            return cn;
        }

        public void CloseConnection()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }

        public int Login(string strSql)
        {
            int result = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = GetConn();
                cmd.CommandText = strSql;
                result=Convert.ToInt32(cmd.ExecuteScalar());
            }
            return result;
        }

        public int RegisterUser(string strSql)
        {
            SqlCommand cmd = new SqlCommand(strSql, GetConn());
            int result = cmd.ExecuteNonQuery();
            return result;
        }
    }
}
