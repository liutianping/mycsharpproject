<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NewsDetail.aspx.cs" Inherits="News.NewsDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FormView1" runat="server">
        <ItemTemplate>
            <asp:Label ID="labTitle" runat="server" Text='<%# Bind("title") %>'></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" Height="172px" 
                ImageUrl='<%# Bind("picture") %>' Width="505px" />
            <br />
            <asp:TextBox ID="txtContent" runat="server" Height="237px" MaxLength="2550" 
                Text='<%# Bind("content") %>' TextMode="MultiLine" Width="499px"></asp:TextBox>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
