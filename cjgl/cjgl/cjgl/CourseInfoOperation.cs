using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace cjgl
{
    class CourseInfoOperation
    {
        private static DataAccess dataAccess = new DataAccess();
        public static bool insertCourserinfo(CourseInfoData couserinfoData)
        {//向数据库中的couserinfo表插入课程信息数据 
            string sql = "insert into courseinfo(kcid,kcname,periodexpriment,periodteacheing,credit,cousertype) values ("+
                "'"+couserinfoData.Kcid+"',"+
                "'"+couserinfoData.Kcname+"',"+
                "'"+couserinfoData.Periodexpriment+"',"+
                "'"+couserinfoData.Periodteaching+"',"+
                "'"+couserinfoData.Credit+"',"+
                "'"+couserinfoData.Coursetype+"')";
            return dataAccess.ExecuteSQL(sql);
        }
        public static bool updateCouserINfo(CourseInfoData couserinfodata)
        {
            string sql = "update couserinfo set kcname='"+
                couserinfodata.Kcname+"',"+
                "periodexpriment='"+couserinfodata.Periodexpriment+"',"+
                "periodteaching='"+couserinfodata.Periodteaching+"',"+
                "credit='"+couserinfodata.Credit+"',"+
                "coursetype='"+couserinfodata.Coursetype+"' "+
                "where kcid='"+couserinfodata.Kcid+"'";
            return dataAccess.ExecuteSQL(sql);
        }
        public static bool deleteCouserInfo(string kcid)
        {
            string sql = string.Format("delete courseinfo where kcid='{0}'",kcid);
            return dataAccess.ExecuteSQL(sql);
        }
        public static DataSet getCourseInfo(CourseInfoData couserinfodata)
        {
            string condition = "";
            if (couserinfodata.Kcid != null && couserinfodata.Kcid != "")
            {
                condition += " kcid='"+couserinfodata.Kcid+"'";
            }
            if (couserinfodata.Kcname != null && couserinfodata.Kcname != "")
            {
                condition += " and kcname='"+couserinfodata.Kcname+"'";
            }
            if (couserinfodata.Coursetype != "" && couserinfodata.Coursetype != null)
            {
                condition += " and coursetype="+couserinfodata.Coursetype;
            }
            if (couserinfodata.Credit != null && couserinfodata.Credit != "")
            {
                condition += " and credit="+couserinfodata.Credit;
            }
            string sql = "select kcid,kcname,periodexpriment,periodteaching,credit,coursetype from courseinfo where "+condition;
            return dataAccess.GetDataSet(sql, "courseinfo");
        }
    }
}
