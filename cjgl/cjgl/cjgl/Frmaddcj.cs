using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cjgl
{
    public partial class Frmaddcj : Form
    {
        public Frmaddcj()
        {
            InitializeComponent();
        }
        public string o_sno = "";
        public string o_cno = "";
        public Frmaddcj(string sno,string cno)
        {
            InitializeComponent();
            this.o_cno = cno;
            this.o_sno = sno;
            if (o_sno != "" && o_cno != "")
            {
                //ѧ�ſγ̺Ŷ���������ſ���¼�������Ϣ
                StuGradeData info = new StuGradeData();
                info.Sno = sno;
                info.Cno = cno;
                DataSet ds = StuGradeOperation.getStuGrade(info);
                this.TxtStuid.Text = ds.Tables[0].Rows[0]["sno"].ToString();
                this.TxtStuname.Text = ds.Tables[0].Rows[0]["sname"].ToString();
                this.TxtKcid.Text = ds.Tables[0].Rows[0]["cno"].ToString();
                this.TxtKcname.Text = ds.Tables[0].Rows[0]["kcname"].ToString();
                this.TxtGradepeacetime.Text = ds.Tables[0].Rows[0]["Gradepeacetime"].ToString();
                this.TxtGradeexpriment.Text = ds.Tables[0].Rows[0]["Gradeexpriment"].ToString();
                this.TxtGradelast.Text = ds.Tables[0].Rows[0]["Gradelast"].ToString();
                this.TxtGrade.Text = ds.Tables[0].Rows[0]["Grade"].ToString();
                this.TxtStuid.Enabled = false;
                this.TxtKcid.Enabled = false;
            }
        }
        private void Frmaddcj_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string sno = this.TxtStuid.Text;
            string cno = this.TxtKcid.Text;
            string gradepeacetime = this.TxtGradepeacetime.Text;
            string gradeexpriment = this.TxtGradeexpriment.Text;
            string gradelast = this.TxtGradelast.Text;
            string grade = this.TxtGrade.Text;
            if (sno == null || sno.Trim() == "")
            {
                MessageBox.Show("������ѧ��","��ʾ");
                this.TxtStuid.Focus();
                return;
            }
            if (cno == null || cno.Trim() == "")
            {
                MessageBox.Show("������γ̱��","��ʾ");
                this.TxtKcid.Focus();
                return;
            }
            if (gradepeacetime != null || gradepeacetime.Trim() != "")
            {
                try
                {
                    Decimal.Parse(gradepeacetime);
                }
                catch (Exception ex)
                {

                    ex.ToString();
                    MessageBox.Show("ƽʱ�ɼ�����������","��ʾ");
                    this.TxtGradepeacetime.Focus();
                    return;
                }
            }
            if (gradeexpriment != null && gradeexpriment.Trim() != "")
            {
                try
                {
                    Decimal.Parse(gradeexpriment);
                }
                catch (Exception ex)
                {

                    ex.ToString();
                    MessageBox.Show("ʵ��ɼ�����������", "��ʾ");
                    this.TxtGradeexpriment.Focus();
                    return;
                }
            }
            if (gradelast != null && gradelast.Trim() != "")
            {
                try
                {
                    Decimal.Parse(gradelast);
                }
                catch (Exception ex)
                {

                    ex.ToString();
                    MessageBox.Show("��ĩ�ɼ�����������", "��ʾ");
                    this.TxtGradelast.Focus();
                    return;
                }
            }
            StuGradeData data = new StuGradeData();
            data.Sno = sno;
            data.Cno = cno;
            data.Gradepeacetime = gradepeacetime;
            data.Gradeexpriment = gradeexpriment;
            data.Gradelast = gradelast;
            data.Grade = grade;
            try
            {
                if (o_sno == "" || o_cno == "")
                {
                    if (StuGradeOperation.insertStuGrade(data))
                    {
                        MessageBox.Show("��ӳɹ�", "��ʾ");
                        this.TxtStuid.Text = "";
                        this.TxtGradeexpriment.Text = "";
                        this.TxtGradepeacetime.Text = "";
                        this.TxtGradelast.Text = "";
                        this.TxtGrade.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("���ʧ��", "����");
                    }
                }
                else
                {
                    if (StuGradeOperation.updataStuGrade(data))
                    {
                        MessageBox.Show("�޸ĳɹ�", "��ʾ");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("�޸�ʧ��","����");
                    }
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
                MessageBox.Show("����ʧ��","����");
            }
        }

        private void TxtStuid_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtStuid.Text.Trim() != "")
            {
                StudentInfoData data = new StudentInfoData();
                data.Sno = this.TxtStuid.Text;
                DataSet dsStu = StudentInfoOperation.getStudentInfo(data);
                if (dsStu.Tables[0].Rows.Count > 0)
                {
                    this.TxtStuname.Text = dsStu.Tables[0].Rows[0]["sname"].ToString();
                }
            }
        }

        private void TxtKcid_TextChanged(object sender, EventArgs e)
        {
            CourseInfoData data = new CourseInfoData();
            data.Kcid = this.TxtKcid.Text;
            DataSet dsKc = CourseInfoOperation.getCourseInfo(data);
            if (dsKc.Tables[0].Rows.Count > 0)
            {
                this.TxtKcname.Text = dsKc.Tables[0].Rows[0]["kcname"].ToString();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}