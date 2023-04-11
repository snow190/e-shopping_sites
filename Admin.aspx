<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

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
    </br>
        
      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="新增商品" />
    </br>
         
      <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="刪除商品" />
              
       </br>
         
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="更新商品" />
          
        </br>
        </div>
         </br>
        <asp:Button ID="Button4" runat="server" Text="新增會員" OnClick="Button4_Click" />
              </br>
        </br>
            <asp:Button ID="Button5" runat="server" Text="刪除會員" OnClick="Button5_Click" />
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="更新會員" />
        </br>
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="訂單管理" />
    </form>
</body>
</html>
