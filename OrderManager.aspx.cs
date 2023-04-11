using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null) Response.Redirect("AdminLogin.aspx");
    }
    protected DataTable LoadDT()
    {
        string strPath = Server.MapPath("~/order.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Select * From [list]";

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

    protected void Button1_Click(object sender, EventArgs e)
    {
        string key = this.TextBox1.Text;
        string exp = "[時間] like '*" + key + "*'";
        DataTable dt = LoadDT();
        DataRow[] drs = dt.Select(exp);
        DataTable dtNew = dt.Clone();
        for (int i = 0; i < drs.Length; i++)
        {
            dtNew.ImportRow(drs[i]);
        }
        this.GridView1.DataSource = dtNew;
        this.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string key = this.TextBox1.Text;
        string exp = "[訂購人] = '" + key + "'";
        DataTable dt = LoadDT();
        DataRow[] drs = dt.Select(exp);
        DataTable dtNew = dt.Clone();
        for (int i = 0; i < drs.Length; i++)
        {
            dtNew.ImportRow(drs[i]);
        }
        this.GridView1.DataSource = dtNew;
        this.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string key = this.TextBox1.Text;
        string exp = "[處理狀況] = '" + key + "'";
        DataTable dt = LoadDT();
        DataRow[] drs = dt.Select(exp);
        DataTable dtNew = dt.Clone();
        for (int i = 0; i < drs.Length; i++)
        {
            dtNew.ImportRow(drs[i]);
        }
        this.GridView1.DataSource = dtNew;
        this.DataBind();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string strPath = Server.MapPath("~/order.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strUpdate = "Update [list] Set [處理狀況]=@para1 where [id]=@para2 ";

        OleDbCommand myCmd = new OleDbCommand(strUpdate, myConn);
        myCmd.Parameters.Clear();
        myCmd.Parameters.AddWithValue("para1", this.DropDownList1.Text);
        myCmd.Parameters.AddWithValue("para2", this.TextBox2.Text);
        

        myCmd.Connection.Open();
        myCmd.ExecuteNonQuery();
        myCmd.Connection.Close();
        myConn.Dispose();
        myCmd.Dispose();

        string key = this.TextBox2.Text;
        string exp = "[id]=" + key;
        DataTable dt = LoadDT();
        DataRow[] drs = dt.Select(exp);
        DataTable dtNew = dt.Clone();
        for (int i = 0; i < drs.Length; i++)
        {
            dtNew.ImportRow(drs[i]);
        }
        this.GridView1.DataSource = dtNew;
        this.DataBind();
    }
}