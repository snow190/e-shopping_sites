<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:testConnectionString %>" SelectCommand="SELECT student_test.*, student_class.student_year, student_class.student_class, student_department.student_department, student_department.department_leader FROM student_class INNER JOIN student_department ON student_class.sd_id = student_department.sd_id INNER JOIN student_test ON student_class.student_id = student_test.student_id"></asp:SqlDataSource>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="student_id" HeaderText="student_id" SortExpression="student_id" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="chinese" HeaderText="chinese" SortExpression="chinese" />
                <asp:BoundField DataField="math" HeaderText="math" SortExpression="math" />
                <asp:BoundField DataField="student_year" HeaderText="student_year" SortExpression="student_year" />
                <asp:BoundField DataField="student_class" HeaderText="student_class" SortExpression="student_class" />
                <asp:BoundField DataField="student_department" HeaderText="student_department" SortExpression="student_department" />
                <asp:BoundField DataField="department_leader" HeaderText="department_leader" SortExpression="department_leader" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
