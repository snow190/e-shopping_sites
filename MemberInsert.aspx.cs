using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MemberInsert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null) Response.Redirect("AdminLogin.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        InsertDB();
        DataTable dt = LoadDT();
        this.GridView1.DataSource = dt;
        this.GridView1.DataBind();
    }
    protected void InsertDB()
    {
        string strPath = Server.MapPath("~/member.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Insert into [user] ([uName],[uPass]) values (@para1,@para2)";

        OleDbCommand myCmd = new OleDbCommand(strSelect, myConn);
        myCmd.Parameters.Clear();
        myCmd.Parameters.AddWithValue("para1", this.TextBox1.Text);
        myCmd.Parameters.AddWithValue("para2", this.TextBox2.Text);
        

        myCmd.Connection.Open();
        myCmd.ExecuteNonQuery();
        myCmd.Connection.Close();
        myConn.Dispose();
        myCmd.Dispose();
    }
    protected DataTable LoadDT()
    {
        string strPath = Server.MapPath("~/member.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Select [uName],[uPass] From [user]";

        OleDbCommand myCmd = new OleDbCommand(strSelect, myConn);
        myCmd.Connection.Open();
        OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCmd);
        DataTable dt = new DataTable();
        myAdapter.Fill(dt);
        myCmd.ExecuteNonQuery();
        myAdapter.Dispose();
        myCmd.Connection.Close();
        myConn.Dispose();
        myCmd.Dispose();
        return dt;
    }
}