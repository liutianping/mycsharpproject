﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            ShowTime();
    }

    protected void ShowTime()
    {
        this.Label1.Text = System.DateTime.Now.ToString() ;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/default3.aspx?id="+this.TextBox1.Text);
    }
}
