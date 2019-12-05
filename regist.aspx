<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regist.aspx.cs" Inherits="regist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户注册</title>
</head>
<body>
<h2 style="color:red">用户注册</h2>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="用户名:"></asp:Label> </td>
            <td> <asp:TextBox ID="username" runat="server"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入用户名称！"
                        ControlToValidate="userName" ForeColor="red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="密码:"></asp:Label> </td>
            <td><asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码！"
                        ControlToValidate="password" ForeColor="red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td> <asp:Button ID="Button1" runat="server" Text="注册" onclick="regist_Click" /> </td>
            <td colspan="2"> <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/login.aspx">去登录</asp:HyperLink> </td>
        </tr>
    </table> 
    </div>
    </form>
</body>
</html>
