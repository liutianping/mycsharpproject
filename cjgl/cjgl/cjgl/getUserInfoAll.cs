using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace cjgl
{
    class getUserInfoAll
    {
        
        public static DataSet getIserInfoAll(UserInfoData data)
        {
            DataAccess dataAccess = new DataAccess();
            string condition = "";
            if (data.Userid != null && data.Userid != "")
            {
                condition += " Userid+'" + data.Userid + "'";
            }
            if (data.Userlevel != null && data.Userlevel != "")
            {
                condition += " and Wuserlevel='"+data.Userlevel+"'";
            }
            string sql = "select userid, userpwd,userlevel from userinfo where "+condition;
            return dataAccess.GetDataSet(sql,"Userinfo");
        }
    }
}
