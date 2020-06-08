<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet2.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="menu">
        <h1>SIGN IN</h1>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="USERNAME" CssClass="login_un"></asp:TextBox>
        <br /><br /><br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="PASSWORD" TextMode="Password" CssClass="login_pw"></asp:TextBox>
        <br /><br /><br />
        <asp:Label ID="Label1" runat="server" Text="Check your 'USERNAME' or 'PASSWORD'" Visible="false" class="warning"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Height="27px" Text="LOGIN" OnClick="Button1_Click" class="button_login"/>
            <asp:Label ID="Label2" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
