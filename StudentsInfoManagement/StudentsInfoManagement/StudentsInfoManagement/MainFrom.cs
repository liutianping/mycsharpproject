using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace StudentsInfoManagement
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        BLL bll = new BLL();
        BindingSource bs = new BindingSource();
        string c_No = "";
        private void MainFrom_Load(object sender, EventArgs e)
        {
            ds = bll.addComboxItem("select distinct  c_No,c_Name from classInfo");
            comboBox1.DataSource = ds.Tables["classInfo"];
            comboBox1.DisplayMember = "c_Name";
            comboBox1.ValueMember = "c_No";
            LoadDataGridView("2003030201");

            
        }
        public void LoadDataGridView(string cNo)
        {
            ds = bll.firstLoadDataGridView(cNo, "firstLoadDataGridView");
            bs.DataSource = ds.Tables["firstLoadDataGridView"];
            this.dataGridView1.DataSource = bs;
            label5.Text = "记录条数为：" + ds.Tables["firstLoadDataGridView"].Rows.Count;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_No = this.comboBox1.SelectedValue.ToString();
            ds = bll.firstLoadDataGridView(c_No, "firstLoadDataGridView");
            bs.DataSource = ds.Tables["firstLoadDataGridView"];
            this.dataGridView1.DataSource = bs;
            label5.Text = "记录条数为：" + ds.Tables["firstLoadDataGridView"].Rows.Count;
            label5.Text = "记录条数为：" + ds.Tables["firstLoadDataGridView"].Rows.Count;
        }
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //移到第一条记录
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                bs.MoveFirst();
        }
        //移到前一条记录
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (bs.Position != 0)
                bs.MovePrevious();
            else
                MessageBox.Show("已经是第一行了", "提示");

        }
        //移到后一条记录
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (bs.Position != bs.Count - 1)
                bs.MoveNext();
            else
                MessageBox.Show("已经是最后一条记录了","提示");
        }
        //移到最后一条记录
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            StudentsInfoManagement.OpertionStudentInfo Osi= new OpertionStudentInfo("add");
            Osi.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            StudentsInfoManagement.OpertionStudentInfo Osi = new OpertionStudentInfo("mod");
            Osi.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            string cNo = this.comboBox1.SelectedValue.ToString();
            string sNo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            string strSql = "delete from studentsInfo where s_no='"+sNo+"'";
            ;
            if (MessageBox.Show("确认要删除此记录？", "提示", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (bll.OperationInfo(strSql) == 1)
                {
                    MessageBox.Show("删除成功");
                    ds = bll.firstLoadDataGridView(cNo, "firstLoadDataGridView");
                    bs.DataSource = ds.Tables["firstLoadDataGridView"];
                    this.dataGridView1.DataSource = bs;
                    label5.Text = "记录条数为：" + ds.Tables["firstLoadDataGridView"].Rows.Count;
                }
            }
        }
        public string getCombox1Value()
        {
            string s = this.comboBox1.SelectedValue.ToString();
            return s;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string cNo = this.comboBox1.SelectedValue.ToString();
            ds = bll.firstLoadDataGridView(cNo, "firstLoadDataGridView");
            bs.DataSource = ds.Tables["firstLoadDataGridView"];
            this.dataGridView1.DataSource = bs;
            label5.Text = "记录条数为：" + ds.Tables["firstLoadDataGridView"].Rows.Count;
        }
    }
}