<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WSXPL_wushuaxinpinglun._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">

    <script src="js/jquery-1.4.2.js" type="text/javascript"></script>
    
    <title></title>
     <script type="text/javascript">
         $(function() {
             $("#Button1").click(function() {
                 var msg = $("#txtMsg").val();
                 $.post("wsxpl.ashx", { "msg": msg }, function(data, status) {
                     if (status != "success") {
                         alert("发表评论失败，请重试！");
                         return;
                     }
                     if (data == "ok") {
                         var newComment = $("<li>评论日期:"+new Date()+",IP:内容:"+$("#txtMsg").val()+"</li>");
                         $("#ulComment").append(newComment);

                         alert("发表评论成功");
                     }
                     else {
                         alert("发表评论失败");
                     }
                 });
             });
         });
       
    </script>
    <style type="text/css">
        #txtMsg
        {
            width: 278px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <p>
        <textarea id="txtMsg" name="S1" rows="5" cols="5"></textarea></p>
    <p>
        <input id="Button1" type="button" value="评论" /></p>
    </div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="WSXPL_wushuaxinpinglun.DataSetPostsDataTableAdapters.T_PostsTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_id" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="ipAddress" Type="String" />
            <asp:Parameter Name="time" Type="DateTime" />
            <asp:Parameter Name="Original_id" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="ipAddress" Type="String" />
            <asp:Parameter Name="time" Type="DateTime" />
        </InsertParameters>
    </asp:ObjectDataSource>
   <ul id="ulComment">
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
    <ItemTemplate>
    <li> 评论日期:<%# Eval("time")%>,IP：<%# Eval("ipAddress") %>,内容:<%# Eval("msg") %></ li>
    </ItemTemplate>
    </asp:Repeater>
    </ul>
    </form>
</body>
</html>
