using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace cjgl
{
    
    class DataAccess
    {
        Properties.Settings config = Properties.Settings.Default;
        public bool ExecuteSQL(string sql)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = config.conn;
            SqlCommand cmd = new SqlCommand(sql,cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
            }
        }
        public SqlDataReader GetReader(string sql)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = config.conn;
            SqlCommand cmd=new SqlCommand(sql,cn);
            SqlDataReader dr = null;
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                dr.Close();
                cn.Dispose();
                cmd.Dispose();
                throw new Exception(ex.ToString());
            }
            return dr;
        }
        public DataSet GetDataSet(string sql, string tablename)
        {//执行sql语句，返回dataset
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = config.conn;
            SqlDataAdapter da = new SqlDataAdapter(sql,cn);
            try
            {
                da.Fill(ds, tablename);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
            finally
            {
                cn.Close();
                cn.Dispose();
                ds.Dispose();
            }
            return ds;
        }
        public int GetCount(string sql)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = config.conn;
            SqlCommand cmd=new SqlCommand(sql,cn);
            try
            {
                cn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
            catch (Exception)
            {
                return 0;

            }
            finally
            {
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
            }
        }
        public bool CheckAdmin(string strname, string strpwd)
        {//验证用户是否合法登录
            string sql;
            sql = "select count(1) from UserInfo where Userid='" + strname + "' and userpwd='" + strpwd + "'";
            if (GetCount(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
