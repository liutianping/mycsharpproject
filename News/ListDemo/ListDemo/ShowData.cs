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
    //���������ӣ��ҾͲ������������ȥ���ˣ�
    //����������÷���List��������������
    //�������Ū��������ӣ����㽫�����յĸ���
    /// 
    /// 
    /// ����:����ƽ
    /// ʱ��:2011-4-27
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