using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace cjgl
{
    public partial class Frmcjgl : Form
    {
        DataSet ds = new DataSet();
        public Frmcjgl()
        {
            InitializeComponent();
            UserInfoData data = new UserInfoData();
            data.Userid = Constants.Username;
            ds = UserInfoOperation.getUserInfo(data);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Constants.Userlevel = ds.Tables[0].Rows[0]["Userlevel"].ToString();
                if (Constants.Userlevel == "学生")
                {//登录身份为学生，设置某些功能不可调用
                    this.MenuItemyhcx.Enabled = false;
                    this.MenuItembjxxtj.Enabled = false;
                    this.MenuItembjxxxg.Enabled = false;
                    this.MenuItemcjlr.Enabled = false;
                    this.MenuItemcjsc.Enabled = false;
                    this.MenuItemcjxg.Enabled = false;
                    this.MenuItemjsxxcx.Enabled = false;
                    this.MenuItemjsxxtj.Enabled = false;
                    this.MenuItemjsxxsc.Enabled = false;
                    this.MenuItemjsxxxg.Enabled = false;
                    this.MenuItemkcbsc.Enabled = false;
                    this.MenuItemkcbtj.Enabled = false;
                    this.MenuItemkcbxg.Enabled = false;
                    this.MenuItemkcxxsc.Enabled = false;
                    this.MenuItemkcxxtj.Enabled = false;
                    this.MenuItemkcxxxg.Enabled = false;
                    this.MenuItemsjkbf.Enabled = false;
                    this.MenuItemsjkhf.Enabled = false;
                    this.MenuItemxsxxgl.Enabled = false;
                    this.MenuItemxsxxsc.Enabled = false;
                    this.MenuItemxsxxtj.Enabled = false;
                    this.MenuItemxsxxxg.Enabled = false;
                    this.MenuItemyhsc.Enabled = false;
                    this.MenuItemyhtj.Enabled = false;
                    this.MenuItemyhxg.Enabled = true;
                    this.MenuItemzyxxtj.Enabled = false;
                    this.MenuItemzyxxsc.Enabled = false;
                    this.MenuItemzyxxxg.Enabled = false;
                    this.MenuItembjxxsc.Enabled = false;
                    this.MenuItembjxxsc.Enabled = false;
                }
                else if (Constants.Userlevel == "代课教师")
                {
                    this.MenuItembjxxtj.Enabled = false;
                    this.MenuItembjxxxg.Enabled = false;
                    this.MenuItemcjlr.Enabled = true;
                    this.MenuItemcjsc.Enabled = false;
                    this.MenuItemcjxg.Enabled = false;
                    this.MenuItemjsxxcx.Enabled = true;
                    this.MenuItemjsxxtj.Enabled = false;
                    this.MenuItemjsxxsc.Enabled = false;
                    this.MenuItemjsxxxg.Enabled = false;
                    this.MenuItemkcbsc.Enabled = false;
                    this.MenuItemkcbtj.Enabled = false;
                    this.MenuItemkcbxg.Enabled = false;
                    this.MenuItemkcxxsc.Enabled = false;
                    this.MenuItemkcxxtj.Enabled = false;
                    this.MenuItemkcxxxg.Enabled = false;
                    this.MenuItemsjkbf.Enabled = false;
                    this.MenuItemsjkhf.Enabled = false;
                    this.MenuItemxsxxgl.Enabled = false;
                    this.MenuItemxsxxsc.Enabled = false;
                    this.MenuItemxsxxtj.Enabled = false;
                    this.MenuItemxsxxxg.Enabled = false;

                    this.MenuItemsjkhf.Enabled = false;
                    this.MenuItemxsxxgl.Enabled = false;
                    this.MenuItemxsxxsc.Enabled = true;
                    this.MenuItemxsxxtj.Enabled = false;
                    this.MenuItemxsxxxg.Enabled = true;
                    this.MenuItemyhsc.Enabled = false;
                    this.MenuItemyhtj.Enabled = false;
                    this.MenuItemyhxg.Enabled = true;
                    this.MenuItemzyxxtj.Enabled = false;
                    this.MenuItemzyxxsc.Enabled = false;
                    this.MenuItemzyxxxg.Enabled = false;
                    this.MenuItembjxxsc.Enabled = false;
                    this.MenuItembjxxsc.Enabled = false;
                }
                else
                {
                    this.MenuItembjxxtj.Enabled = true;
                    this.MenuItembjxxxg.Enabled = true;
                    this.MenuItemcjlr.Enabled = true;
                    this.MenuItemcjsc.Enabled = true;
                    this.MenuItemcjxg.Enabled = true;
                    this.MenuItemjsxxcx.Enabled = true;
                    this.MenuItemjsxxtj.Enabled = true;
                    this.MenuItemjsxxsc.Enabled = true;
                    this.MenuItemjsxxxg.Enabled = true;
                    this.MenuItemkcbsc.Enabled = true;
                    this.MenuItemkcbtj.Enabled = true;
                    this.MenuItemkcbxg.Enabled = true;
                    this.MenuItemkcxxsc.Enabled = true;
                    this.MenuItemkcxxtj.Enabled = true;
                    this.MenuItemkcxxxg.Enabled = true;
                    this.MenuItemsjkbf.Enabled = true;
                    this.MenuItemsjkhf.Enabled = true;
                    this.MenuItemxsxxgl.Enabled = true;
                    this.MenuItemxsxxsc.Enabled = true;
                    this.MenuItemxsxxtj.Enabled = true;
                    this.MenuItemxsxxxg.Enabled = true;
                    this.MenuItemyhsc.Enabled = true;
                    this.MenuItemyhtj.Enabled = true;
                    this.MenuItemyhxg.Enabled = true;
                    this.MenuItemzyxxtj.Enabled = true;
                    this.MenuItemzyxxsc.Enabled = true;
                    this.MenuItemzyxxxg.Enabled = true;
                    this.MenuItembjxxsc.Enabled = true;
                }
            }
        }

        private void Frmcjgl_Load(object sender, EventArgs e)
        {

        }

        private void MenuItemyhcx_Click(object sender, EventArgs e)
        {

        }

        private void MenuItembzzt_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "cjglxtchm.chm");
        }

        private void menuItemtc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemyhxg_Click(object sender, EventArgs e)
        {
            Frmmmxg objchild = new Frmmmxg(Constants.Username);
            this.IsMdiContainer = true;
            objchild.Show();
        }

        private void MenuItemcjcx_Click(object sender, EventArgs e)
        {
            Frmcjcx frmcjcx = new Frmcjcx("");
            this.IsMdiContainer = true;
            frmcjcx.Show();
        }

        private void MenuItemcjlr_Click(object sender, EventArgs e)
        {
            Frmaddcj frmaddcj = new Frmaddcj("","");
            this.IsMdiContainer = true;
            frmaddcj.Show();
        }

        private void MenuItemcjxg_Click(object sender, EventArgs e)
        {
            Frmcjcx frmmodcj = new Frmcjcx("mod");
            this.IsMdiContainer = true;
            frmmodcj.Show();
        }

        private void MenuItemcjsc_Click(object sender, EventArgs e)
        {
            Frmcjcx frmdelcj = new Frmcjcx("del");
            this.IsMdiContainer = true;
            frmdelcj.Show();
        }

        private void MenuItemzyxxcx_Click(object sender, EventArgs e)
        {

        }

        private void MenuItembjxxcx_Click(object sender, EventArgs e)
        {

        }

    }
}