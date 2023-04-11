using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Guest : System.Web.UI.Page
{
    protected DataTable LoadDT()
    {
        string strPath = Server.MapPath("~/product.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Select [名稱],[訪客價] From [items]";
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
        DataTable dt = LoadDT();
        this.GridView1.DataSource = dt;
        this.GridView1.DataBind();
        this.Label1.Text = "訪客~您好!!";
    }
}