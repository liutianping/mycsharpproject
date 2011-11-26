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
    public partial class NewsDetail : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString=@"Data Source=.\sqlexpress;Initial Catalog=news;integrated Security=true";
            if (Session["name"] == null)
            {
                this.Response.Redirect("login.aspx");
            }
            if (!Page.IsPostBack)
            {
                SqlCommand cm = new SqlCommand();
                cm.CommandText = "SELECT ID,title,content,attachment,submitDate,picture FROM news WHERE ID=@ID";
                cm.Parameters.Add("@ID",SqlDbType.Int);
                cm.Parameters["@ID"].Value = Request.QueryString["id"];//接收超链接传过来的参数id
                cm.Connection = con;
                con.Open();
                SqlDataReader dr = cm.ExecuteReader();

                this.FormView1.DataSource = dr;
                this.Page.DataBind();
                dr.Close();
                con.Close();
            }
        }
    }
}
