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
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=news;integrated Security=true";
            conn.ConnectionString = connectionString;
            if (!IsPostBack)
            {
                Label1.Visible = false;
                Label2.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandText = "insert into tb_admin values(@name,@password,@email,@question,@answer)";

            cm.Parameters.Add("@name",SqlDbType.NVarChar);
            cm.Parameters.Add("@password", SqlDbType.NVarChar);
            cm.Parameters.Add("@email", SqlDbType.NVarChar);
            cm.Parameters.Add("@question", SqlDbType.NVarChar);
            cm.Parameters.Add("@answer", SqlDbType.NVarChar);

            cm.Parameters["@name"].Value = this.txtname.Text.Trim();

            cm.Parameters["@password"].Value = this.txtpwd.Text.Trim();

            cm.Parameters["@email"].Value = this.txtemail.Text.Trim();

            cm.Parameters["@question"].Value = this.txtquestion.Text.Trim();

            cm.Parameters["@answer"].Value = this.txtanswer.Text.Trim();

            try
            {
                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();
                Session["Name"] = this.txtname.Text.Trim();
                this.Response.Redirect("admin/QueryNews.aspx");
            }
            catch (Exception)
            {

                Response.Write("<script>alert('很遗憾注册失败'):location='javascript:history.go(-1)'</script>");

            }
         
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandText = "select username from tb_admin where username='@name'";
            cm.Parameters.Add("@name",SqlDbType.NVarChar);
            cm.Parameters["@name"].Value = this.txtname.Text.Trim();
            conn.Open();
            SqlDataReader read = cm.ExecuteReader();

            read.Read();

            if (read.HasRows)
            {
                if (this.txtname.Text == read["UserName"].ToString())
                {
                    Label1.Visible = true;
                    Label2.Visible = false;
                }
                else
                {
                    Label2.Visible = true;
                    Label1.Visible=true;
                }
                    
            }
        }
    }
}
