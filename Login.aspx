<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
		<link rel="stylesheet" href="assets/css/main.css?V125802" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="帳號"></asp:TextBox>
        </div>
        <asp:TextBox ID="TextBox2" runat="server" placeholder="密碼"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="確認" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
