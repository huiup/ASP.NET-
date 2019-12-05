<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>聊天页面</title>
    <link href="../Styles/Site.css" type="text/css" rel="stylesheet"/>
</head>
<body>
    <h2 style="color:Orange">**欢迎来到聊天室**</h2>
    <span style="color:Green;font-size:large">当前在线人数：</span><% =num %>    &nbsp&nbsp&nbsp&nbsp&nbsp &nbsp&nbsp&nbsp&nbsp&nbsp

    <span style="color:Green;font-size:large">当前用户为：</span>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <form id="form1" runat="server">
    *在线列表：
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <table >
		<tr>
			<td style="width: 500px"><iframe src="show.aspx" width="100%" height="100%"></iframe>
				</td>
		</tr>
		<tr>
			<td style="width: 500px"><iframe src="speak.aspx" width="100%" height="100%"></iframe>
			    </td>
		</tr>
	</table>
    </form>
</body>
</html>
