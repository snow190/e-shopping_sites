using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected DataTable LoadDT()
    {
        string strPath = Server.MapPath("~/admin.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Select * From [userTable]";

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
        DataTable dt = LoadDT();
        string strName = this.TextBox1.Text;
        string strPass = this.TextBox2.Text;
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DataRow dr = dt.Rows[i];
            if ((strName == dr["uName"].ToString()) && (strPass == dr["uPass"].ToString()))
            {
                Session["admin"] = strName;
                Response.Redirect("Admin.aspx");
            }
        }
        Response.Redirect("Fail.aspx");
    }
}