using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace News
{
    public partial class ShowMoreNews : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=news;integrated Security=true";
            if (!Page.IsPostBack)
            {
                bind();
            }
        }

        private void bind()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ID,title,submintDate FROM news ORDER BY submitDate DESC",con);
            DataSet ds = new DataSet();
            sda.Fill(ds,"news");
            this.GridView1.DataSource = ds;
            this.GridView1.DataKeyNames = new string[] { "ID" };
            this.GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            bind();
        }
    }
}
