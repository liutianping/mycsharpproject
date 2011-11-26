using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace cjgl
{
    public class StuGradeOperation
    {
        private static DataAccess dataAccess = new DataAccess();
        public static bool insertStuGrade(StuGradeData stuGrade)
        {
            string sql = "insert into StuGrade(sno,cno,Gradepeacetime,gradeexpriment,gradelast,grade) values ("+
                "'"+stuGrade.Sno+"',"+
                "'"+stuGrade.Cno+"',"+
                "'"+stuGrade.Gradepeacetime+"',"+
                "'"+stuGrade.Gradeexpriment+"',"+
                "'"+stuGrade.Gradelast+"',"+
                "'"+stuGrade.Grade+"')";
            return dataAccess.ExecuteSQL(sql);
        }
        public static bool updataStuGrade(StuGradeData stuGrade)
        {
            string sql = "update StuGrade set Gradepeacetime='" +
                stuGrade.Gradepeacetime + "'," +
                "Gradeexpriment='" + stuGrade.Gradeexpriment + "'," +
                "Gradelast='" + stuGrade.Gradelast + "'," +
                "Grade='" + stuGrade.Grade + "' " +
                "where Sno='" + stuGrade.Sno + "' and " +
                "Cno='" + stuGrade.Cno + "'";
            return dataAccess.ExecuteSQL(sql);
        }
        public static bool deleteStuGrade(string sno, string cno)
        {
            string sql = string.Format("delete StuGrade where Sno='{0}' and Cno='{1}'",sno,cno);
            return dataAccess.ExecuteSQL(sql);
        }
        public static DataSet getStuGrade(StuGradeData stuGrade)
        {
            string condition = "";
            if (stuGrade.Sno != null && stuGrade.Sno != "")
            {
                condition += " and a.Sno='"+stuGrade.Sno+"'";
            }
            if (stuGrade.Cno != null && stuGrade.Cno != "")
            {
                condition += " and b.Kcid='"+stuGrade.Cno+"'";
            }
            string sql = "select a.sno,a.sname,c.cno,b.kcname,c.Gradepeacetime,c.gradeexpriment,c.gradelast,c.grade" +
                " from studentinfo a,courseinfo b,stugrade c where "+
                "c.sno=a.sno and b.kcid=c.cno "+condition;
            return dataAccess.GetDataSet(sql, "StuGrade");
        }
    }
}
