using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null) Response.Redirect("AdminLogin.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductInsert.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductDelete.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductUpdate.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberInsert.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberDelete.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberUpdate.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderManager.aspx");
    }
}