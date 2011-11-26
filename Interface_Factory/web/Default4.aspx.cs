using System;

using System.Web;

using System.Web.Caching;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            ShowTime();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ShowTime();
    }

    protected void ShowTime()
    {
        string key = "cache";
        string now = (string)HttpRuntime.Cache[key];
        if (string.IsNullOrEmpty(now))
        {
            now = System.DateTime.Now.ToString();
            CacheDependency cde = new CacheDependency(Server.MapPath("~/HTMLPage.htm"), DateTime.Now);
            Cache.Insert(key, System.DateTime.Now.ToString(), cde);
        }
        Label1.Text = now;
    }
}
