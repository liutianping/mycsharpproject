using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ListDemo
{
    /// ////////////////////////
    /// ����:����ƽ
    /// ����޸�ʱ��:2011-4-27
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
       /// ����Ҫ�����������
       /// </summary>
       /// <param name="strSql">SQL���</param>
       /// <returns>���ط��͵�List����</returns>
       
       public List<UserInfo> GetUserInfo(string strSql)
       {
           /////////////////////////////////////////////
           /////����List�ķ��Ͷ�����Ҫ�ǲ���ҵ���߼��㵼�� using System.Data;Ҳ��Ϊ�˸��õ�
           /////��װ���ݣ�������Щֻ�ڽ�����ʾ�����漰�޸ĵ����ݾͿ�����List����ȥ��װ��
           //////
           using (SqlCommand cmd = new SqlCommand(strSql, GetConn()))
           {
               
               list = new List<UserInfo>();//�����ʵ����List����������list����������������������
                                            
               SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               while (sdr.Read())
               {
                   userInfo = new UserInfo();//���ʵ�������userinfo����������ݿ��е�һ������

                   //----------------------------------------
                   userInfo.UserId = sdr[0].ToString();//���ݿ���ĳһ����ĵ�һ���ֶ�
                   userInfo.UserName = sdr[1].ToString();//���ݿ���ĳһ����ĵ�2���ֶ�
                   userInfo.UserPassword = sdr[2].ToString();//���ݿ���ĳһ����ĵ�3���ֶ�
                   //-----------------------------------------
                   list.Add(userInfo);//��������¼�ŵ�list��
               }
           }
           Close();
           return list;
       }
    }
}
