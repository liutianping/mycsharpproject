using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentsInfoManagement
{
    public partial class OpertionStudentInfo : Form
    {
        MainFrom mf = new MainFrom();
        string flag2 = "";
        BLL BLL = new BLL();
        public OpertionStudentInfo()
        {
            InitializeComponent();
        }
        public OpertionStudentInfo(string flag)
        {
            InitializeComponent();
            flag2 = flag;
            if (flag == "add")
            {
                this.btnAdd.Enabled = false;
                this.Text = "学生信息--添加";
            }
            if (flag == "mod")
            {
                this.Text = "学生信息--修改";
            }
        }
        private void OpertionStudentInfo_Load(object sender, EventArgs e)
        {
            this.cmbAName.DataSource = BLL.addCmbItem("a_no","a_name","addressInfo");
            distextfiled("a_no", "a_name",cmbAName);
            this.cmbCName.DataSource = BLL.addCmbItem("c_no","c_name","classinfo");
            distextfiled("c_no", "c_name", cmbCName);
            this.cmbNName.DataSource = BLL.addCmbItem("n_no","n_name","nation");
            distextfiled("n_no", "n_name", cmbNName);
            this.cmbPName.DataSource = BLL.addCmbItem("p_no","p_name","politics");
            distextfiled("p_no", "p_name", cmbPName);
            this.cmbSCName.DataSource = BLL.addCmbItem("sc_no","sc_name","studentcard");
            distextfiled("sc_no", "sc_name", cmbSCName);


            
        }
        private void distextfiled(string disColumn, string apperCloumn,ComboBox cmd)
        {
            cmd.DisplayMember =apperCloumn ;
            cmd.ValueMember = disColumn;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = insertInfo();
            if (BLL.OperationInfo(strSql) == 1)
            {
                MessageBox.Show("添加成功！请刷新");
            }
            this.txtSID.Text = "";
            this.txtSName.Text = "";
            this.txtSNo.Text = "";
        }
        public string insertInfo()
        {
            string sNo = this.txtSNo.Text.Trim();
            string sGender = this.cmbGender.SelectedItem.ToString();
            string sName = this.txtSName.Text.Trim();
            string cName = this.cmbCName.SelectedValue.ToString();
            string sID = this.txtSID.Text.Trim();
            string scName = this.cmbSCName.SelectedValue.ToString();
            string pName = this.cmbPName.SelectedValue.ToString();
            string aName = this.cmbAName.SelectedValue.ToString();
            string nName = this.cmbNName.SelectedValue.ToString();
            string strSql = "insert into studentsInfo values('" + sNo + "','" + sName + "','" + sGender + "','" + sID + "','" +
                cName + "','" + aName + "','" + scName + "','" + pName + "','" + nName + "')";
            return strSql;
        }
    }
}