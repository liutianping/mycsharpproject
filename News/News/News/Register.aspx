<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="News.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellspacing="1" class="style1">
            <tr>
                <td colspan="2" style="text-align: center">
                    新用户注册</td>
            </tr>
            <tr>
                <td>
                    用户姓名：</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="检查用户名是否存在" />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="恭喜！此用户不存在"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="很遗憾，此用户已经存在"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    用户密码：</td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" ontextchanged="TextBox3_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    电子邮箱</td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    安全提示问题：</td>
                <td>
                    <asp:TextBox ID="txtquestion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    答案：</td>
                <td>
                    <asp:TextBox ID="txtanswer" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="注册" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
