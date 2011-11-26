using System;
using System.Collections.Generic;
using System.Text;

namespace cjgl
{
    public class StuGradeData
    {
        private string sno = "";

        public string Sno//学生的学号
        {
            get { return sno; }
            set { sno = value; }
        }
        private string cno = "";

        public string Cno//课程号
        {
            get { return cno; }
            set { cno = value; }
        }
        private string gradepeacetime = "";

        public string Gradepeacetime//平时成绩
        {
            get { return gradepeacetime; }
            set { gradepeacetime = value; }
        }
        private string gradeexpriment = "";

        public string Gradeexpriment//实验成绩
        {
            get { return gradeexpriment; }
            set { gradeexpriment = value; }
        }
        private string gradelast = "";//期末成绩

        public string Gradelast
        {
            get { return gradelast; }
            set { gradelast = value; }
        }
        private string grade = "";//总成绩

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

    }
}
