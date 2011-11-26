using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace News.admin
{
    public partial class AddNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] == null)
            {
                this.Response.Redirect("../login.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=news;integrated Security=true";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlDataAdapter ods = new SqlDataAdapter("SELECT title,content,submitdate,picture,attachement FROM news",conn);
                DataSet ds = new DataSet();
                ods.Fill(ds,"news");
                conn.Close();
                DataRow dr = ds.Tables["news"].NewRow();

                string fileAttention = System.IO.Path.GetExtension(fupPicture.PostedFile.FileName);
                DateTime submitDate = System.DateTime.Now;
                string currnetDate = submitDate.ToString("yyyyMMddHHmmssFFFF");
                string pictureFileName = "~/picture/"+currnetDate+fileAttention;

                fileAttention = System.IO.Path.GetExtension(fupAttachment.PostedFile.FileName);
                string attachmentFileNa = "~/attachment/"+currnetDate+fileAttention;
                dr["title"] = txtTitle.Text;
                dr["content"] = txtContent.Text;
                dr["submitDate"] = submitDate.ToString();
                if (fupPicture.HasFile)
                {
                    dr["picture"] = pictureFileName;
                }
                if (fupAttachment.HasFile)
                {
                    dr["attachment"] = attachmentFileNa;
                }
                ds.Tables["news"].Rows.Add(dr);

                SqlCommandBuilder ocb = new SqlCommandBuilder(ods);
                ods.Update(ds,"news");

                fupPicture.SaveAs(Server.MapPath(pictureFileName));

                fupAttachment.SaveAs(Server.MapPath(attachmentFileNa));
                labMsg.Text = "新闻发布成功！";

            }
            catch (Exception)
            {

                labMsg.Text = "新闻发布失败！";
            }
        }
    }
}
