using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cjgl
{
    public partial class Frmaddzyxx : Form
    {
        public Frmaddzyxx()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string id = this.TxtId.Text;
            string name = this.txtName.Text;
            if (id == null || id.Trim() == "")
            {
                MessageBox.Show("������רҵid!","��ʾ");
                this.TxtId.Focus();
                return;
            }
            if (name == null || name.Trim() == "")
            {
                MessageBox.Show("������רҵ����","��ʾ");
                this.txtName.Focus();
                return;
            }
            SpecialtyInfoData data = new SpecialtyInfoData();
            data.Specialtyid = id;
            data.Specialtymc = name;
            string o_id="";
            try
            {
                if (o_id == "")
                {
                    if (SpecialtyOperation.insertSpecialty(data))
                    {
                        MessageBox.Show("��ӳɹ���", "��ʾ");
                        this.TxtId.Text = "";
                        this.txtName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("���ʧ�ܣ�", "����");
                    }
                }
                else
                {
                    if (SpecialtyOperation.updataSpecialty(data))
                    {
                        MessageBox.Show("�޸ĳɹ���", "��ʾ");
                        ((Frmzyxxcx)this.Parent).bindDataGrid();
                        this.Dispose();
                    }
                    else
                    {
 
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}