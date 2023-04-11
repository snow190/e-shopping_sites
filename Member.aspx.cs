using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Member : System.Web.UI.Page
{
    protected DataTable LoadDT()
    {
        string strPath = Server.MapPath("~/product.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Select [名稱],[會員價] From [items]";

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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("Login.aspx");

        string strUser = Session["user"].ToString();
        this.Label1.Text += " 您好~親愛的" + strUser;

        DataTable dt = LoadDT();
        this.GridView1.DataSource = dt;
        this.GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Shop.aspx");
    }
}