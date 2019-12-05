<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="regist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户登录</title>
</head>
<body style="width: 372px; height: 141px">
<h2 style="color:Blue">用户登录</h2>
    <form id="form1" runat="server">
    <div>
       <table>
        <tr>
            <td> <asp:Label ID="Label1" runat="server" Text="用户名:"></asp:Label> </td>
            <td> <asp:TextBox ID="username" runat="server"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入用户名称！"
                        ControlToValidate="userName" ForeColor="red"></asp:RequiredFieldValidator></td>
        </tr>
          <tr>
            <td> <asp:Label ID="Label2" runat="server" Text="密码:"></asp:Label> </td>
            <td> <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码！"
                        ControlToValidate="password" ForeColor="red"></asp:RequiredFieldValidator></td>
        </tr>
         <tr>
            <td><asp:Button ID="denglu" runat="server" Text="登录" onclick="login_Click" /> </asp:Label> </td>
            <td colspan="2">  <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/regist.aspx">去注册</asp:HyperLink>  </td>
            
        </tr>
       </table>
    </div>
    </form>
</body>
</html>
