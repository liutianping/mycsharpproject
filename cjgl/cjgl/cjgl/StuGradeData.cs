using System;
using System.Collections.Generic;
using System.Text;

namespace cjgl
{
    public class StuGradeData
    {
        private string sno = "";

        public string Sno//ѧ����ѧ��
        {
            get { return sno; }
            set { sno = value; }
        }
        private string cno = "";

        public string Cno//�γ̺�
        {
            get { return cno; }
            set { cno = value; }
        }
        private string gradepeacetime = "";

        public string Gradepeacetime//ƽʱ�ɼ�
        {
            get { return gradepeacetime; }
            set { gradepeacetime = value; }
        }
        private string gradeexpriment = "";

        public string Gradeexpriment//ʵ��ɼ�
        {
            get { return gradeexpriment; }
            set { gradeexpriment = value; }
        }
        private string gradelast = "";//��ĩ�ɼ�

        public string Gradelast
        {
            get { return gradelast; }
            set { gradelast = value; }
        }
        private string grade = "";//�ܳɼ�

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

    }
}
