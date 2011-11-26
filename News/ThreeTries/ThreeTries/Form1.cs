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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        User user = new User();
        private void button1_Click(object sender, EventArgs e)
        {
            user.Password = this.textBox2.Text;
            user.Username = this.textBox1.Text;

        }
    }
}