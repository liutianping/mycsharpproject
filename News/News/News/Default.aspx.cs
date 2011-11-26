using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace News
{
    public partial class _Default : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=news;integrated Security=true";
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "SELECT TOP 10 id,titile submitDate FROM news ORDER BY submitDate DESC";
            cm.Connection = cn;
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            this.GridView1.DataSource = dr;
            this.GridView1.DataBind();
            dr.Close();
            cn.Close();
        }
    }
}
