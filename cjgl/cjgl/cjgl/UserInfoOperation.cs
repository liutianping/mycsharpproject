using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace cjgl
{
   class UserInfoOperation
    {
       private static DataAccess dataAccess = new DataAccess();
       public static bool insertUserInfo(UserInfoData data)
       {//数据插入
           string sql = "insert into Userinfo(Userid,userpwd,userlevel) values ("+
               "'"+data.Userid+"',"+
               "'"+data.Userpwd+"',"+
               "'"+data.Userlevel+"'";
           return dataAccess.ExecuteSQL(sql);//执行sql语句
       }
       public static bool updateUserInfo(UserInfoData data)
       {
           string sql = "update UserInfo set Userpwd='"+data.Userpwd+
               "' "+"where Userid='"+data.Userid+"'";
           return dataAccess.ExecuteSQL(sql);
       }
       public static bool deleteUserInfo(string userid)
       {
           string sql = string.Format("delete UserInfo where Userid='{0}'",userid);
           return dataAccess.ExecuteSQL(sql);
       }
       public static DataSet getUserInfo(UserInfoData data)
       {
           string confition = "";//查询条件
           if (data.Userid != null && data.Userid != "")
           {
               confition+="Userid='"+data.Userid+"'";
           }
           if (data.Userlevel != null && data.Userlevel != "")
           {
               confition += " and Userlevel='" + data.Userlevel + "'";
           }
           string sql = "select Userid,Userlevel,Userpwd from UserInfo where "+confition;
           return dataAccess.GetDataSet(sql,"UserInfo");//执行sql语句
       }
    }
}
