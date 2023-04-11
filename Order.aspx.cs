using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
        if(Session["dtOrder"]==null) return;
        DataTable dtOrder = (DataTable)Session["dtOrder"];
        int num = dtOrder.Rows.Count;
        int nTotal = 0;
        this.Literal1.Text = "<table border=1>";
        for (int i = 0; i < num; i++)
        {
            DataRow dr = dtOrder.Rows[i];
            this.Literal1.Text += "<tr>";
            this.Literal1.Text += "<td>";
            this.Literal1.Text += dr["Name"].ToString() ;
            this.Literal1.Text += "</td>";

            this.Literal1.Text += "<td>";
            this.Literal1.Text += dr["Price"].ToString();
            int nPrice = Convert.ToInt32(dr["Price"]);
            this.Literal1.Text += "</td>";

            this.Literal1.Text += "<td>";
            this.Literal1.Text += dr["Number"].ToString();
            int nNumber = Convert.ToInt32(dr["Number"]);
            this.Literal1.Text += "</td>";
            nTotal = nTotal + nPrice * nNumber;
            this.Literal1.Text += "</td>";

        }
        this.Literal1.Text += "</table>";
        this.Literal1.Text += "<b>Total=" + nTotal.ToString()+"</b>";
    }
}