using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Threetries.model;

namespace ThreeTries
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != "" && txtPassword.Text.Trim() != null && txtUserId.Text.Trim() != null && txtUserId.Text.Trim() != "" && txtUserName.Text.Trim() != "" && txtUserName.Text.Trim() != null)
            {
                User user = new User();
                user.Userid =Convert.ToInt32(txtUserId.Text);
                user.Username = txtUserName.Text;
                user.Password = txtPassword.Text;
            }

        }
    }
}