using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null) Response.Redirect("AdminLogin.aspx");
        if (!IsPostBack)
            LoadDT();
    }

    protected void LoadDT()
    {
        string strPath = Server.MapPath("~/product.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Select [id] ,[名稱],[會員價],[訪客價] From [items]";

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

        this.GridView1.DataSource = dt;
        this.GridView1.DataBind();
        this.DropDownList1.Items.Clear();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DataRow dr = dt.Rows[i];
            this.DropDownList1.Items.Add(dr["id"].ToString());
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string sel = this.DropDownList1.Text;
        string strPath = Server.MapPath("~/product.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Select [名稱],[會員價],[訪客價] From [items] Where [id]="+sel;

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
        if (dt.Rows.Count != 1) return;
        DataRow dr = dt.Rows[0];
        this.TextBox1.Text = dr["名稱"].ToString();
        this.TextBox2.Text = dr["會員價"].ToString();
        this.TextBox3.Text = dr["訪客價"].ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string strPath = Server.MapPath("~/product.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strUpdate = "Update [items] Set [名稱]=@para1, [會員價]=@para2, [訪客價]=@para3 where [id]=@para4 ";

        OleDbCommand myCmd = new OleDbCommand(strUpdate, myConn);
        myCmd.Parameters.Clear();
        myCmd.Parameters.AddWithValue("para1", this.TextBox1.Text);
        myCmd.Parameters.AddWithValue("para2", this.TextBox2.Text);
        myCmd.Parameters.AddWithValue("para3", this.TextBox3.Text);
        myCmd.Parameters.AddWithValue("para4", this.DropDownList1.Text);

        myCmd.Connection.Open();
        myCmd.ExecuteNonQuery();
        myCmd.Connection.Close();
        myConn.Dispose();
        myCmd.Dispose();

        LoadDT();
    }
}