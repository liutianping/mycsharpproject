<%@ WebHandler Language="C#" Class="GetDate" %>

using System;
using System.Web;

public class GetDate : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write(DateTime.Now.ToLongTimeString());
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}