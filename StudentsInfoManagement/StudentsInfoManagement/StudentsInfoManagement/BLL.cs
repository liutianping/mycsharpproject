using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace StudentsInfoManagement
{
    class BLL
    {
        DB DBManagement = new DB();
        #region //����б���е���
        public DataSet addComboxItem(string strSql)
        {
            return DBManagement.fillTable(strSql, "classInfo");
        }
       #endregion
        #region //DataGridView��ʾ������
        public DataSet firstLoadDataGridView(string cNo, string tableName)
        {
            return DBManagement.fillDataGridView(cNo,tableName);
        }
        #endregion

        #region //����б���е���
        public DataTable addCmbItem(string colunm_id,string column_name,string tableName)
        {
           return DBManagement.fillComboboxItem(colunm_id,column_name,tableName);
        }
        #endregion


        #region //��ҵ�����ִ����ɾ�ĵķ���
        public int OperationInfo(string strSql)
        {
            return DBManagement.executeNoQuery(strSql);
        }
        #endregion

    }
}
