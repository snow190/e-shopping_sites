﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManager.aspx.cs" Inherits="OrderManager" %>

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
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="時間搜尋" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="訂購人搜尋" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="處理狀況-訂單申請搜尋" />
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="處理狀況-更新" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
