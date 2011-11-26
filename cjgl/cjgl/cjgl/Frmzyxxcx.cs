using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cjgl
{
    public partial class Frmzyxxcx : Form
    {
        public Frmzyxxcx()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            bindDataGrid();
        }
        public void bindDataGrid()
        {
            string id = this.txtId.Text.Trim();
            string name = this.TxtName.Text.Trim();
            SpecialtyInfoData data = new SpecialtyInfoData();
            data.Specialtyid = id;
            data.Specialtymc = name;
            try
            {
                ds = SpecialtyOperation.getSpeicalty(data);
                this.dataGrid1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }
    }
}