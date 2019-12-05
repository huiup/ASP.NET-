<%@ Page Language="C#" AutoEventWireup="true" CodeFile="speak.aspx.cs" Inherits="speak" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/Style.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:TextBox ID="TextBoxContent" Style="z-index: 101; left: 16px; position: absolute;
            top: 16px" runat="server" TextMode="MultiLine" Height="64px" Width="416px" EnableViewState="False"></asp:TextBox>
        <asp:Button ID="ButtonSpeak" Style="z-index: 102; left: 184px; position: absolute;
            top: 96px" runat="server" Text="发言" Width="72px" OnClick="ButtonSpeak_Click"></asp:Button>
        <asp:DropDownList ID="DropDownListEmotion" Style="z-index: 103; left: 88px; position: absolute;
            top: 96px" runat="server">
            <asp:ListItem Value="微笑着">微笑着</asp:ListItem>
            <asp:ListItem Value="无奈地">无奈地</asp:ListItem>
            <asp:ListItem Value="哭丧着脸">哭丧着脸</asp:ListItem>
            <asp:ListItem Value="骂骂咧咧地">骂骂咧咧地</asp:ListItem>
            <asp:ListItem Value="气急败坏地">气急败坏地</asp:ListItem>
            <asp:ListItem Value="高兴地">骂骂咧咧地</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownListColor" Style="z-index: 104; left: 24px; position: absolute;
            top: 96px" runat="server">
            <asp:ListItem Value="black" Selected="True">黑色</asp:ListItem>
            <asp:ListItem Value="red">红色</asp:ListItem>
            <asp:ListItem Value="blue">蓝色</asp:ListItem>
            <asp:ListItem Value="green">绿色</asp:ListItem>
            <asp:ListItem Value="gray">灰色</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="ButtonExit" Style="z-index: 105; left: 272px; position: absolute;
            top: 96px" runat="server" Text="离开" Width="64px" OnClick="ButtonExit_Click"></asp:Button>
    </form>
</body>
</html>
