using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ListDemo
{
    /// ////////////////////////
    /// 作者:刘天平
    /// 最后修改时间:2011-4-27
    /// ////////////////////////
   public class DBHelp
    {
       private SqlConnection cn;
       private List<UserInfo> list;
       private UserInfo userInfo;
       public SqlConnection GetConn()
       {
           cn = new SqlConnection();
           string connstring = @"data source=.\sqlexpress;initial catalog=threetirestest;integrated security=true";
         cn.ConnectionString =connstring;
          
           cn.Open();
           return cn;
       }
       public void Close()
       {
           if (cn.State == ConnectionState.Open)
           {
               cn.Close();
           }
       }
       /// <summary>
       /// 最主要的是这个方法
       /// </summary>
       /// <param name="strSql">SQL语句</param>
       /// <returns>返回泛型的List对象</returns>
       
       public List<UserInfo> GetUserInfo(string strSql)
       {
           /////////////////////////////////////////////
           /////返回List的泛型对象，主要是不在业务逻辑层导入 using System.Data;也是为了更好的
           /////封装数据，对于这些只在界面显示而不涉及修改的数据就可以用List对象去封装。
           //////
           using (SqlCommand cmd = new SqlCommand(strSql, GetConn()))
           {
               
               list = new List<UserInfo>();//这里才实例化List对象，这是让list的作用域仅仅限于这个方法
                                            
               SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               while (sdr.Read())
               {
                   userInfo = new UserInfo();//这个实例化后的userinfo代表的是数据库中的一条数据

                   //----------------------------------------
                   userInfo.UserId = sdr[0].ToString();//数据库中某一个表的第一个字段
                   userInfo.UserName = sdr[1].ToString();//数据库中某一个表的第2个字段
                   userInfo.UserPassword = sdr[2].ToString();//数据库中某一个表的第3个字段
                   //-----------------------------------------
                   list.Add(userInfo);//将这条记录放到list里
               }
           }
           Close();
           return list;
       }
    }
}
