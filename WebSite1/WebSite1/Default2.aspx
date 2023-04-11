<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:testConnectionString %>" DeleteCommand="DELETE FROM [db_user] WHERE [id] = @original_id AND (([real_name] = @original_real_name) OR ([real_name] IS NULL AND @original_real_name IS NULL)) AND [name] = @original_name AND [password] = @original_password AND (([sex] = @original_sex) OR ([sex] IS NULL AND @original_sex IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND [rank] = @original_rank AND [UpdateRight] = @original_UpdateRight AND [DeleteRight] = @original_DeleteRight" InsertCommand="INSERT INTO [db_user] ([real_name], [name], [password], [sex], [email], [rank], [UpdateRight], [DeleteRight]) VALUES (@real_name, @name, @password, @sex, @email, @rank, @UpdateRight, @DeleteRight)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [db_user]" UpdateCommand="UPDATE [db_user] SET [real_name] = @real_name, [name] = @name, [password] = @password, [sex] = @sex, [email] = @email, [rank] = @rank, [UpdateRight] = @UpdateRight, [DeleteRight] = @DeleteRight WHERE [id] = @original_id AND (([real_name] = @original_real_name) OR ([real_name] IS NULL AND @original_real_name IS NULL)) AND [name] = @original_name AND [password] = @original_password AND (([sex] = @original_sex) OR ([sex] IS NULL AND @original_sex IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND [rank] = @original_rank AND [UpdateRight] = @original_UpdateRight AND [DeleteRight] = @original_DeleteRight">
            <DeleteParameters>
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_real_name" Type="String" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_password" Type="String" />
                <asp:Parameter Name="original_sex" Type="String" />
                <asp:Parameter Name="original_email" Type="String" />
                <asp:Parameter Name="original_rank" Type="Int32" />
                <asp:Parameter Name="original_UpdateRight" Type="String" />
                <asp:Parameter Name="original_DeleteRight" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="real_name" Type="String" />
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="sex" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="rank" Type="Int32" />
                <asp:Parameter Name="UpdateRight" Type="String" />
                <asp:Parameter Name="DeleteRight" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="real_name" Type="String" />
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="sex" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="rank" Type="Int32" />
                <asp:Parameter Name="UpdateRight" Type="String" />
                <asp:Parameter Name="DeleteRight" Type="String" />
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_real_name" Type="String" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_password" Type="String" />
                <asp:Parameter Name="original_sex" Type="String" />
                <asp:Parameter Name="original_email" Type="String" />
                <asp:Parameter Name="original_rank" Type="Int32" />
                <asp:Parameter Name="original_UpdateRight" Type="String" />
                <asp:Parameter Name="original_DeleteRight" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="real_name" HeaderText="real_name" SortExpression="real_name" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                <asp:BoundField DataField="sex" HeaderText="sex" SortExpression="sex" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="rank" HeaderText="rank" SortExpression="rank" />
                <asp:BoundField DataField="UpdateRight" HeaderText="UpdateRight" SortExpression="UpdateRight" />
                <asp:BoundField DataField="DeleteRight" HeaderText="DeleteRight" SortExpression="DeleteRight" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:testConnectionString %>" DeleteCommand="DELETE FROM [db_user] WHERE [id] = @original_id AND (([real_name] = @original_real_name) OR ([real_name] IS NULL AND @original_real_name IS NULL)) AND [name] = @original_name AND [password] = @original_password AND (([sex] = @original_sex) OR ([sex] IS NULL AND @original_sex IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND [rank] = @original_rank AND [UpdateRight] = @original_UpdateRight AND [DeleteRight] = @original_DeleteRight" InsertCommand="INSERT INTO [db_user] ([real_name], [name], [password], [sex], [email], [rank], [UpdateRight], [DeleteRight]) VALUES (@real_name, @name, @password, @sex, @email, @rank, @UpdateRight, @DeleteRight)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [db_user] WHERE ([id] = @id)" UpdateCommand="UPDATE [db_user] SET [real_name] = @real_name, [name] = @name, [password] = @password, [sex] = @sex, [email] = @email, [rank] = @rank, [UpdateRight] = @UpdateRight, [DeleteRight] = @DeleteRight WHERE [id] = @original_id AND (([real_name] = @original_real_name) OR ([real_name] IS NULL AND @original_real_name IS NULL)) AND [name] = @original_name AND [password] = @original_password AND (([sex] = @original_sex) OR ([sex] IS NULL AND @original_sex IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND [rank] = @original_rank AND [UpdateRight] = @original_UpdateRight AND [DeleteRight] = @original_DeleteRight">
            <DeleteParameters>
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_real_name" Type="String" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_password" Type="String" />
                <asp:Parameter Name="original_sex" Type="String" />
                <asp:Parameter Name="original_email" Type="String" />
                <asp:Parameter Name="original_rank" Type="Int32" />
                <asp:Parameter Name="original_UpdateRight" Type="String" />
                <asp:Parameter Name="original_DeleteRight" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="real_name" Type="String" />
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="sex" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="rank" Type="Int32" />
                <asp:Parameter Name="UpdateRight" Type="String" />
                <asp:Parameter Name="DeleteRight" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="real_name" Type="String" />
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="sex" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="rank" Type="Int32" />
                <asp:Parameter Name="UpdateRight" Type="String" />
                <asp:Parameter Name="DeleteRight" Type="String" />
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_real_name" Type="String" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_password" Type="String" />
                <asp:Parameter Name="original_sex" Type="String" />
                <asp:Parameter Name="original_email" Type="String" />
                <asp:Parameter Name="original_rank" Type="Int32" />
                <asp:Parameter Name="original_UpdateRight" Type="String" />
                <asp:Parameter Name="original_DeleteRight" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="id" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="real_name" HeaderText="real_name" SortExpression="real_name" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                <asp:TemplateField HeaderText="性別" SortExpression="sex">
                    <EditItemTemplate>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="sex" DataValueField="sex" SelectedValue='<%# Bind("sex") %>'>
                        </asp:RadioButtonList>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("sex") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("sex") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="rank" HeaderText="rank" SortExpression="rank" />
                <asp:BoundField DataField="UpdateRight" HeaderText="UpdateRight" SortExpression="UpdateRight" />
                <asp:BoundField DataField="DeleteRight" HeaderText="DeleteRight" SortExpression="DeleteRight" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:testConnectionString %>" SelectCommand="SELECT DISTINCT [sex] FROM [db_user]"></asp:SqlDataSource>
    </form>
</body>
</html>
