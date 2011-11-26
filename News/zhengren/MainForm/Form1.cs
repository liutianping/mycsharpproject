using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace MainForm
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        #region 关闭某进程
        public static void KillProcess(string processName)
        {
            System.Diagnostics.Process myproc = new System.Diagnostics.Process();
            try
            {
                foreach (Process thisproc in Process.GetProcessesByName(processName))
                {
                    if (!thisproc.CloseMainWindow())
                    {
                        if (thisproc != null)
                            thisproc.Kill();
                    }
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show("非常悲哀，你没有上Q，否则有更好玩的！！");
                throw Exc;
            }
        }
        #endregion 

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        [DllImport(@"native.dll", EntryPoint = "FuckSysKey")]
        private extern static bool FuckSysKey(bool enAble);

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("make by -----09ATA2(ltp)");
            button1.Visible = false;
            this.SetVisibleCore(false);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.SetVisibleCore(true); 

            
        }

        private void execute()
        {
            for (int i = 0; i < 1000; i++)
            {

                MessageBox.Show("你点击了" + i + "次确定了，还要继续吗？？");

                if (i == 500)
                {
                    MessageBox.Show("不知不觉你已经点击了500次确定了！！继续加油");
                }
                if (i == 999)
                {
                    MessageBox.Show("哇，你点了1000次啊，佩服！！！");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey && e.KeyCode == Keys.Alt && e.KeyCode == Keys.Delete)
            {    //弹出对话框
                MessageBox.Show("最好别再按 ctrl+alt+delete，否则将自动关机！！！");
            }

            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < 100; i++)
                {
                    MessageBox.Show("无聊的你，按下了enter。加100次");
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {    //弹出对话框
                MessageBox.Show("最好别再按 ctrl+alt+delete，否则将自动关机！！！");
            }
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < 100; i++)
                {
                    MessageBox.Show("无聊的你，按下了enter。加100次");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FuckSysKey(false);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FuckSysKey(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            KillProcess("taskmgr");
           // KillProcess("explorer");
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if ((MessageBox.Show("恭喜你，马上就可以退出了！！------------by 仰天","提示", MessageBoxButtons.OKCancel)) == DialogResult.OK)
            {
                MessageBox.Show("你点了Cancel，那就继续吧！！下次记得点确定啊！！！！！");
                MessageBox.Show("-------------------------下次记得要点取消，否则退出不的---------------------------------");
                execute();
            }
            else
            {
                MessageBox.Show("退出啦，下次见！！！");
                Application.Exit();
            }
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text == "我是笨蛋")
            {
                MessageBox.Show("点击“确定”游戏现在开始！！！");
                KillProcess("QQ");
                MessageBox.Show("------------游戏开始前要先，关闭了你的QQ--------------，拜拜！！");
                execute();
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("你不说是吧，让你点1000次确定！！！！！！");
                execute();
                MessageBox.Show("惩罚完了！！！！，请在文本框输入正确的文字");
            }
        }
    }
}