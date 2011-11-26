using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace StudentsInfoManagement
{
    class BLL
    {
        DB DBManagement = new DB();
        #region //添加列表框中的项
        public DataSet addComboxItem(string strSql)
        {
            return DBManagement.fillTable(strSql, "classInfo");
        }
       #endregion
        #region //DataGridView显示的数据
        public DataSet firstLoadDataGridView(string cNo, string tableName)
        {
            return DBManagement.fillDataGridView(cNo,tableName);
        }
        #endregion

        #region //添加列表框中的项
        public DataTable addCmbItem(string colunm_id,string column_name,string tableName)
        {
           return DBManagement.fillComboboxItem(colunm_id,column_name,tableName);
        }
        #endregion


        #region //在业务层中执行增删改的方法
        public int OperationInfo(string strSql)
        {
            return DBManagement.executeNoQuery(strSql);
        }
        #endregion

    }
}
