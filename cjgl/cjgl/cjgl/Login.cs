using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cjgl
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            if (Username.Text.Trim() != "" && Password.Text.Trim() != "")
            {
                username = Username.Text.Trim();
                password = Password.Text.Trim();
                DataAccess data = new DataAccess();
                Constants.Username = this.Username.Text.Trim();
                if (data.CheckAdmin(username, password))
                {
                    Frmcjgl winmain = new Frmcjgl();
                    winmain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("��������˺Ż������������������룡");
                    Username.Text = "";
                    Password.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}