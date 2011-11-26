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
            if (Constants.Userlevel == "学生")
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
                MessageBox.Show("显示失败");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int index = this.dataGrid1.CurrentRowIndex;
            if (index < 0)
            {
                MessageBox.Show("请选择要修改的记录", "提示");
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
                MessageBox.Show("请选择要修改的记录", "提示");
                return;
            }
            else
            {
                if (MessageBox.Show("确认要删除？", "删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sno = ds.Tables[0].Rows[index]["sno"].ToString();
                    string cno = ds.Tables[0].Rows[index]["cno"].ToString();
                    try
                    {
                        if (StuGradeOperation.deleteStuGrade(sno, cno))
                        {
                            MessageBox.Show("删除成功", "提示");
                            bindDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("删除失败","错误");
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                        MessageBox.Show("删除失败","错误");
                    }
                }
            }
        }
    }
}