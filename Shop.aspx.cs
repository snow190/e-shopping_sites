using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shop : System.Web.UI.Page
{
    ArrayList aryCtrName;
    ArrayList aryCtrPrice;
    ArrayList aryCtrNumber;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_Init(object sender, EventArgs e)
    {
        aryCtrName = new ArrayList();
        aryCtrPrice = new ArrayList();
        aryCtrNumber = new ArrayList();
        DataTable dt =LoadDT();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DataRow dr = dt.Rows[i];
            Label LBName = new Label();
            Label LBPrice = new Label();
            DropDownList DDNumber = new DropDownList();
            LBName.Text = dr["名稱"].ToString();
            LBName.Width = 200;
            LBPrice.Text = dr["會員價"].ToString();
            LBPrice.Width = 200;
            for (int n = 0; n < 10; n++)
            {
                DDNumber.Items.Add(n.ToString());
            }
            this.Panel1.Controls.Add(LBName);
            this.Panel1.Controls.Add(LBPrice);
            this.Panel1.Controls.Add(DDNumber);
            Literal LT = new Literal();
            LT.Text = "<br/>";
            this.Panel1.Controls.Add(LT);
            aryCtrName.Add(LBName);
            aryCtrPrice.Add(LBPrice);
            aryCtrNumber.Add(DDNumber);
            LT.Text = "<hr/>";
            this.Panel1.Controls.Add(LT);
        }
    }
    protected DataTable LoadDT()
    {
        string strPath = Server.MapPath("~/product.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strSelect = "Select [id],[名稱],[會員價] From [items]";

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
        DataTable dtOrder = new DataTable();
        dtOrder.Columns.Add("Name");
        dtOrder.Columns.Add("Price");
        dtOrder.Columns.Add("Number");

        string strContent = "";
        for (int i = 0; i < aryCtrName.Count; i++)
        {
            DataRow drOrder = dtOrder.NewRow();
            string strName = ((Label)aryCtrName[i]).Text;
            string strPrice = ((Label)aryCtrPrice[i]).Text;
            string strNumber = ((DropDownList)aryCtrNumber[i]).Text;
            drOrder["Name"] = strName;
            drOrder["Price"] = strPrice;
            drOrder["Number"] = strNumber;

            dtOrder.Rows.Add(drOrder);
            if (strNumber != "0")
            {
                strContent += "{" + strName + ":price=" + strPrice + ",number=" + strNumber + "}";
            }
        }
        InsertDB(strContent);
        Session["dtOrder"] = dtOrder;
        Response.Redirect("Order.aspx");
        //GridView gv = new GridView();
        //gv.DataSource = dtOrder;
        //gv.DataBind();
        //this.Panel1.Controls.Add(gv);
    }

    protected void InsertDB(string strContent)
    {
        string strPath = Server.MapPath("~/order.mdb");
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath;
        OleDbConnection myConn = null;
        myConn = new OleDbConnection(strConn);
        string strInsert = "Insert into [list] ([時間],[訂購人],[內容],[處理狀況] )" + "values(@para1,@para2,@para3,@para4)";

        OleDbCommand myCmd = new OleDbCommand(strInsert, myConn);
        myCmd.Parameters.Clear();
        string strDTime = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        string strUser = Session["user"].ToString();
        string strStatus = "訂單申請";
        myCmd.Parameters.AddWithValue("para1", strDTime);
        myCmd.Parameters.AddWithValue("para2", strUser);
        myCmd.Parameters.AddWithValue("para3", strContent);
        myCmd.Parameters.AddWithValue("para4", strStatus);
        myCmd.Connection.Open();
        myCmd.ExecuteNonQuery();
        myCmd.Connection.Close();
        myConn.Dispose();
        myCmd.Dispose();
        
    }
}