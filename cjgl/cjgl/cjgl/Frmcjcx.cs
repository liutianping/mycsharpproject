using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cjgl
{
    public partial class Frmcjcx : Form
    {
        public Frmcjcx()
        {
            InitializeComponent();
        }
        public Frmcjcx(string flag)
        {
            InitializeComponent();
            if (Constants.Userlevel == "ѧ��")
            {
                this.txtStuid.Text = Constants.Username;
                this.txtStuid.Enabled = false;
            }
            if (flag == "mod")
            {
                this.btnMod.Visible = true;
            }
            else if (flag == "del")
            {
                this.btnDelete.Visible = true;
            }
        }
        private void Frmcjcx_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindDataGrid();
        }
        DataSet ds = new DataSet();
        private void bindDataGrid()
        {
            string sno = this.txtStuid.Text.Trim();
            string cno = this.txtKcid.Text.Trim();
            StuGradeData data = new StuGradeData();
            data.Sno = sno;
            data.Cno = cno;
            try
            {
                ds = StuGradeOperation.getStuGrade(data);
                this.dataGrid1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("��ʾʧ��");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int index = this.dataGrid1.CurrentRowIndex;
            if (index < 0)
            {
                MessageBox.Show("��ѡ��Ҫ�޸ĵļ�¼", "��ʾ");
                return;
            }
            else
            {
                string sno = ds.Tables[0].Rows[index]["sno"].ToString();
                string cno = ds.Tables[0].Rows[index]["cno"].ToString();
                Frmaddcj modcj = new Frmaddcj(sno,cno);
                modcj.ShowDialog(this);
            }
            bindDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = this.dataGrid1.CurrentRowIndex;
            if (index < 0)
            {
                MessageBox.Show("��ѡ��Ҫ�޸ĵļ�¼", "��ʾ");
                return;
            }
            else
            {
                if (MessageBox.Show("ȷ��Ҫɾ����", "ɾ��", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sno = ds.Tables[0].Rows[index]["sno"].ToString();
                    string cno = ds.Tables[0].Rows[index]["cno"].ToString();
                    try
                    {
                        if (StuGradeOperation.deleteStuGrade(sno, cno))
                        {
                            MessageBox.Show("ɾ���ɹ�", "��ʾ");
                            bindDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("ɾ��ʧ��","����");
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                        MessageBox.Show("ɾ��ʧ��","����");
                    }
                }
            }
        }
    }
}