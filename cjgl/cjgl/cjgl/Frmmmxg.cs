using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cjgl
{
    public partial class Frmmmxg : Form
    {
        public Frmmmxg()
        {
            InitializeComponent();
        }
        DataSet ds = null;
        public Frmmmxg(string userid)
        {
            
            InitializeComponent();
            UserInfoData data = new UserInfoData();
            data.Userid = userid;
            ds = UserInfoOperation.getUserInfo(data);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.txtUserid.Text = ds.Tables[0].Rows[0]["Userid"].ToString();
            }
        }
        private void Frmmmxg_Load(object sender, EventArgs e)
        {
           
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (this.txtOpwd.Text != ds.Tables[0].Rows[0]["Userpwd"].ToString())
            {
                MessageBox.Show("原密码不正确","提示");
                this.txtOpwd.Focus();
                return;
            }
            if (this.txtNpwd.Text != this.txtQNpwd.Text)
            {
                MessageBox.Show("确认密码不正确","提示");
                this.txtNpwd.Focus();
                return;
            }
            try
            {
                UserInfoData data = new UserInfoData();
                data.Userid = this.txtUserid.Text;
                data.Userpwd = this.txtNpwd.Text;
                data.Userlevel = ds.Tables[0].Rows[0]["Userlevel"].ToString();
                if (UserInfoOperation.updateUserInfo(data))
                {
                    MessageBox.Show("修改成功", "提示");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("修改失败", "错误");
                    return;
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
                MessageBox.Show("修改失败", "错误");
            }
        }
    }
}