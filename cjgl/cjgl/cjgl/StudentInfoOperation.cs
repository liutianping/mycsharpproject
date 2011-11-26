using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace cjgl
{
   public class StudentInfoOperation
    {
       private static DataAccess dataAccess = new DataAccess();
       public static bool insertStudentInfo(StudentInfoData studentInfoData)
       {
           //数据插入
           string sql = "insert into StudentInfo(sno,sname,sex,Birthday,address,tel,Calssid) values("+
               "'"+studentInfoData.Sno+"',"+
               "'"+studentInfoData.Sname+"',"+
               "'"+studentInfoData.Sex+"',"+
               "'"+studentInfoData.Birthday+"',"+
               "'"+studentInfoData.Address+"',"+
               "'"+studentInfoData.Tel+"',"+
               "'"+studentInfoData.Classid+"') ";
           return dataAccess.ExecuteSQL(sql);
       }
       public static bool updateStudentInfo(StudentInfoData studentInfoData)
       {
           //数据修改
           string sql = "update StudentInfo set "+
               "sname='"+studentInfoData.Sname+"',"+
               "sex='"+studentInfoData.Sex+"',"+
               "birthday='"+studentInfoData.Birthday+"',"+
               "address='"+studentInfoData.Address+"',"+
               "tel='"+studentInfoData.Tel+"',"+
               "classid='"+studentInfoData.Classid+"' where sno='"+
               studentInfoData.Sno+"'";
           return dataAccess.ExecuteSQL(sql);

       }
       public static bool deleteStudentInfo(string sno)
       {
           string sql = string.Format("delete studentinfo where sno='{0}'",sno);
           return dataAccess.ExecuteSQL(sql);
       }
       public static DataSet getStudentInfo(StudentInfoData studentInfoData)
       {
           string condition = "";
           if (studentInfoData.Sno != null && studentInfoData.Sno != "")
           {
               condition += " sno='"+studentInfoData.Sno+"'";
           }
           if (studentInfoData.Sname != null && studentInfoData.Sname != "")
           {
               condition += " and sname like '%"+studentInfoData.Sname+"%'";
           }
           if (studentInfoData.Sex != null && studentInfoData.Sex != "")
           {
               condition += " and sex='"+studentInfoData.Sex+"'";
           }
           if (studentInfoData.Classid != null && studentInfoData.Classid != "")
           {
               condition += " and classid='"+studentInfoData.Classid+"'";
           }
           string sql = "select Sno ,sname,sex,brithday, address,tel,classid from studentinfo where "+condition;
           return dataAccess.GetDataSet(sql,"studentinfo");
       }
    }
}
