<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="News._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView runat="server" AutoGenerateColumns="False" ID="GridView1">
            <Columns>
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
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ShowMoreNews.aspx">更多...</asp:HyperLink>
    </form>
</body>
</html>
