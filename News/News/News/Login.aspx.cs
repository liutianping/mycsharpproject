using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace News
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=news;integrated Security=true";
            con = new SqlConnection(connectionString);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from tb_admin where username='"+this.TextBox1.Text+"' and userpassword= ' "+
                this.TextBox2.Text+"' ";
            con.Open();
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            if (a == 1)
            {
                Session["Name"] = this.TextBox1.Text.ToString();
                this.Response.Redirect("admin/QueryNews.aspx");
            }
            else
            {
                this.Label1.Visible = true;
                this.Label1.Text = "登录失败，请重新登录.....";

            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}
