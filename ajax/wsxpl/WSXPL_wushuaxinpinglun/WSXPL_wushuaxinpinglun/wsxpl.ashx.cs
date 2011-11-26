using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSXPL_wushuaxinpinglun.DataSetPostsDataTableAdapters;

namespace WSXPL_wushuaxinpinglun
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class wsxpl : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
           string msg=context.Request["msg"];
           if (msg.Contains("TMD") || msg.Contains("MB"))
           {
               context.Response.Write("forbit");
               return;
           }
           new T_PostsTableAdapter().Insert(context.Request.UserHostAddress, DateTime.Now,msg);
           context.Response.Write("ok");
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
