<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

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
    
        <asp:TextBox ID="TextBox1" runat="server" placeholder="帳號" ></asp:TextBox>
    
    </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="密碼" ></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
    </form>
</body>
</html>
