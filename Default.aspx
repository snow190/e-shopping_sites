<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
        <asp:Button ID="Button1" runat="server" Text="會員區" OnClick="Button1_Click" />
    </div>
        <p>
            <asp:Button ID="Button2" runat="server" Text="訪客區" OnClick="BtnGuest_Click" />
        </p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="管理區" />
    </form>
</body>
</html>
