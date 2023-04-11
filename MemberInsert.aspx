<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberInsert.aspx.cs" Inherits="MemberInsert" %>

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
    
        <asp:TextBox ID="TextBox1" runat="server" placeholder="會員名稱"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="會員密碼"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="新增" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
