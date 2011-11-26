using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace ListDemo
{
    /////////////////////////////
    //由于是例子，我就不用正规的三层去建了，
    //这个例子是用泛型List对象来传递数据
    //如果可以弄懂这个例子，三层将会掌握的更好
    /// 
    /// 
    /// 作者:刘天平
    /// 时间:2011-4-27
    /// /////////////////////////
    
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
        }
        UserInfoService uiService=new UserInfoService();
        private void ShowData_Load(object sender, EventArgs e)
        {
            
            this.dgvUserInfo.DataSource = uiService.GetUserInfo();
        }
    }
}