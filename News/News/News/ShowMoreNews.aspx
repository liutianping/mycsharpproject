<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowMoreNews.aspx.cs" Inherits="News.ShowMoreNews" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" onpageindexchanging="GridView1_PageIndexChanging" 
            PageSize="20">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="编号" Visible="False" />
                <asp:HyperLinkField DataNavigateUrlFields="ID" 
                    DataNavigateUrlFormatString="NewsDetail.aspx?id={0}" DataTextField="title" 
                    HeaderText="标题">
                <ItemStyle Width="300px" />
                </asp:HyperLinkField>
                <asp:BoundField DataField="submitDate" HeaderText="发布日期">
                <ItemStyle Width="150px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
