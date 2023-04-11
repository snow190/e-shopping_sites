using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null) Response.Redirect("AdminLogin.aspx");
        if (!IsPostBack)
            LoadDT();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(this.DropDownList1.Text);
        DeleteFromDB(id);
        LoadDT();
    }
    protected void DeleteFromDB(int id)
    {
        string strPath = Server.MapPath("~/product.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Delete from [items] where id=@para1";
        OleDbCommand myCmd = new OleDbCommand(strSelect, myConn);
        myCmd.Parameters.Clear();
        
        myCmd.Parameters.AddWithValue("para1", id);
        myCmd.Connection.Open();
        myCmd.ExecuteNonQuery();
        myCmd.Connection.Close();
        myConn.Dispose();
        myCmd.Dispose();
    }
    protected void LoadDT()
    {
        string strPath = Server.MapPath("~/product.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Select [id],[名稱],[會員價],[訪客價] From [items]";

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

}