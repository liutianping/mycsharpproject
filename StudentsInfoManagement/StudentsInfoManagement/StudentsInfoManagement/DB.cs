using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StudentsInfoManagement
{
    class DB
    {
        DataSet ds = new DataSet();
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda;
        #region//执行ExecuteSclare
        public string exexuteSclare(string strSql)
        {
            openConn();
            cmd.Connection = cn;
            cmd.CommandText = strSql;
            string s = Convert.ToString(cmd.ExecuteScalar());
            return s;
        }
        #endregion

        #region //执行增删改的方法
        /// <summary>
        /// 执行增删改的方法
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public int executeNoQuery(string strSql)
        {
            openConn();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            int result=cmd.ExecuteNonQuery();
            clearConn();
            return result;
        }
        #endregion

        #region //填充dataGridview的方法(无参)
        public DataSet fillTable(string strSql,string tableName)
        {
            DataSet ds = new DataSet();
            sda = new SqlDataAdapter(strSql, cn);
            openConn();
            sda.Fill(ds, tableName);
            return ds;
        }
        #endregion

        #region //根据cNo来填充dataGridView
        public DataSet fillDataGridView(string cNo,string tableName)
        {
            openConn();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pc_classInfo_c_id";
            cmd.Parameters.Add("@c_No", SqlDbType.VarChar);
            cmd.Parameters["@c_No"].Value = cNo;
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            sda = new SqlDataAdapter(cmd);
            ds.Tables.Clear();
            sda.Fill(ds, tableName);
            sda.Dispose();
            cmd.Dispose();
            clearConn();
            return ds;
        }
        #endregion

        #region //根据column_id,和column_name，返回查询出来的结果，并与ds.tables[]返回    
        /// <summary>
        /// 根据column_id,和column_name，返回查询出来的结果，并与ds.tables[]返回    
        /// </summary>
        /// <param name="column_id">表主键</param>
        /// <param name="column_name">要在列表框中显示的列名</param>
        /// <param name="tableName">源表名</param>
        /// <returns>ds.tables[源表名]</returns>
        public DataTable fillComboboxItem(string column_id, string column_name, string tableName)
        {
            string strSql = "select " + column_id + "," + column_name + " from " + tableName;
            cn = openConn();
            sda = new SqlDataAdapter(strSql, cn);
            sda.Fill(ds, tableName);
            return ds.Tables[tableName];
        }
        #endregion

        #region //打开连接
        /// <summary>
        /// //打开连接
        /// </summary>
        /// <returns>返回Sqlconnection</returns>
        public SqlConnection openConn()
        {
            Properties.Settings config = Properties.Settings.Default;
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.ConnectionString = config.Conn;
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }
        #endregion

        #region //关闭连接
        public void clearConn()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
        #endregion
    }
}
