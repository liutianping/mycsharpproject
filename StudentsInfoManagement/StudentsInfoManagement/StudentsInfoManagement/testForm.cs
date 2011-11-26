using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentsInfoManagement
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }
        DB DBManagement = new DB();
        SqlConnection cn = null;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = null;
        DataSet ds = new DataSet();
        string c_No = "";
        private void testForm_Load(object sender, EventArgs e)
        {
           
            ds = addComboxItem("select distinct  c_No,c_Name from classInfo");
            comboBox1.DataSource = ds.Tables["classInfo"];
            comboBox1.DisplayMember = "c_Name";
            comboBox1.ValueMember = "c_No";
            firstLoad("2003030201");
        }
        //private void firstLoad()
        //{
        //    cn = new SqlConnection();
        //    if (cn.State == ConnectionState.Open)
        //        DBManagement.clearConn();
        //    cn = DBManagement.openConn();
        //    cmd = new SqlCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "pc_classInfo_c_id";
        //    cmd.Parameters.Add("@c_No", SqlDbType.VarChar);
        //    cmd.Parameters["@c_No"].Value = "2003030201";
        //    if (cn.State == ConnectionState.Closed)
        //        cn.Open();
        //    sda = new SqlDataAdapter(cmd);
        //    sda.Fill(ds, "firstStudentInfo");
        //    dataGridView1.DataSource = ds.Tables["firstStudentInfo"];
        //    label1.Text = "记录条数为：" + ds.Tables["firstStudentInfo"].Rows.Count;
        //}
        private void firstLoad(string cNo)
        {
            cn = new SqlConnection();
            if (cn.State == ConnectionState.Open)
                DBManagement.clearConn();
            cn = DBManagement.openConn();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pc_classInfo_c_id";
            cmd.Parameters.Add("@c_No", SqlDbType.VarChar);
            cmd.Parameters["@c_No"].Value = cNo;
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "firstStudentInfo");
            dataGridView1.DataSource = ds.Tables["firstStudentInfo"];
            label1.Text = "记录条数为：" + ds.Tables["firstStudentInfo"].Rows.Count;
        }
        private DataSet addComboxItem(string strSql)
        {
            cn = new SqlConnection();
            if(cn.State==ConnectionState.Closed)
            cn=DBManagement.openConn();
            sda = new SqlDataAdapter(strSql,cn);
            sda.Fill(ds,"classInfo");
            return ds;
        }
        //private void fillDataGridView(string cNo)
        //{
        //    cn = new SqlConnection();
        //    if (cn.State == ConnectionState.Open)
        //       DBManagement.clearConn();
        //    cn = DBManagement.openConn();
        //    cmd = new SqlCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "pc_classInfo_c_id";
        //    cmd.Parameters.Add("@c_No", SqlDbType.VarChar);
        //    cmd.Parameters["@c_No"].Value =cNo;
        //    if (cn.State == ConnectionState.Closed)
        //        cn.Open();
        //    sda = new SqlDataAdapter(cmd);
        //    ds.Tables.Clear();
        //    sda.Fill(ds,"studentInfo");
        //    dataGridView1.DataSource = ds.Tables["studentInfo"];
        //    label1.Text = "记录条数为：" + ds.Tables["studentInfo"].Rows.Count;
        //}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            c_No = this.comboBox1.SelectedValue.ToString();
            firstLoad(c_No);
        }
    }
}