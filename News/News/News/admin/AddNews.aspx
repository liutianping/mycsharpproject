<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="News.admin.AddNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="标题"></asp:Label>
<asp:TextBox ID="txtTitle" runat="server" MaxLength="50" Width="410px"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
    ControlToValidate="txtTitle">标题不能为空</asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="内容"></asp:Label>
    <asp:TextBox ID="txtContent" runat="server" Height="207px" MaxLength="2550" 
        TextMode="MultiLine" Width="404px"></asp:TextBox>
    <br />
    <br />
    图片：<asp:FileUpload ID="fupPicture" runat="server" Width="385px" />
    <br />
    <br />
    附件：<asp:FileUpload ID="fupAttachment" runat="server" Width="438px" />
    <br />
    <br />
    <br />
    <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="添加" />
&nbsp;&nbsp;&nbsp;
    <br />
    <asp:Label ID="labMsg" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <br />
</asp:Content>
