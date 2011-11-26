using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSXPL_wushuaxinpinglun.DataSetPostsDataTableAdapters;
using System.Text;

namespace WSXPL_wushuaxinpinglun
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class GetComment : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //T_PostsTableAdapter s
            StringBuilder db = new StringBuilder();
            var comments = new T_PostsTableAdapter().GetData();
            foreach (var comment in comments)
            {
                db.Append(comment.ipAddress).Append("|").Append(comment.time).Append("|").Append(comment.msg).Append("$");
            }
            context.Response.Write(db.ToString().Trim('$'));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
