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
        #region//ִ��ExecuteSclare
        public string exexuteSclare(string strSql)
        {
            openConn();
            cmd.Connection = cn;
            cmd.CommandText = strSql;
            string s = Convert.ToString(cmd.ExecuteScalar());
            return s;
        }
        #endregion

        #region //ִ����ɾ�ĵķ���
        /// <summary>
        /// ִ����ɾ�ĵķ���
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

        #region //���dataGridview�ķ���(�޲�)
        public DataSet fillTable(string strSql,string tableName)
        {
            DataSet ds = new DataSet();
            sda = new SqlDataAdapter(strSql, cn);
            openConn();
            sda.Fill(ds, tableName);
            return ds;
        }
        #endregion

        #region //����cNo�����dataGridView
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

        #region //����column_id,��column_name�����ز�ѯ�����Ľ��������ds.tables[]����    
        /// <summary>
        /// ����column_id,��column_name�����ز�ѯ�����Ľ��������ds.tables[]����    
        /// </summary>
        /// <param name="column_id">������</param>
        /// <param name="column_name">Ҫ���б������ʾ������</param>
        /// <param name="tableName">Դ����</param>
        /// <returns>ds.tables[Դ����]</returns>
        public DataTable fillComboboxItem(string column_id, string column_name, string tableName)
        {
            string strSql = "select " + column_id + "," + column_name + " from " + tableName;
            cn = openConn();
            sda = new SqlDataAdapter(strSql, cn);
            sda.Fill(ds, tableName);
            return ds.Tables[tableName];
        }
        #endregion

        #region //������
        /// <summary>
        /// //������
        /// </summary>
        /// <returns>����Sqlconnection</returns>
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

        #region //�ر�����
        public void clearConn()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
        #endregion
    }
}
