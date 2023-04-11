using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RWD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button btn = new Button();
        btn.Text = "Button Test";
        this.Panel1.Controls.Add(btn);

        Literal lt = new Literal();
        lt.Text = "<br />";
        this.Panel1.Controls.Add(lt);

        Label lb = new Label();
        lb.Text = "Label Test";
        this.Panel1.Controls.Add(lb);

        lt.Text = "<br />";
        this.Panel1.Controls.Add(lt);

        TextBox tb = new TextBox();
        tb.Text = "Test";
        this.Panel1.Controls.Add(tb);

        DataTable dT = new DataTable();
        dT.Columns.Add("c1");
        dT.Columns.Add("c2");
        dT.Columns.Add("c3");
        dT.Columns.Add("c4");
        DataRow dR1 = dT.NewRow();
        dR1["c1"] = "A";
        dR1["c2"] = "B";
        dR1["c3"] = "C";
        dR1["c4"] = "D";
        dT.Rows.Add(dR1);
        DataRow dR2 = dT.NewRow();
        dR2["c1"] = "E";
        dR2["c2"] = "F";
        dR2["c3"] = "G";
        dR2["c4"] = "H";
        dT.Rows.Add(dR2);

        GridView gv = new GridView();
        gv.DataSource = dT;
        gv.DataBind();
        this.Panel1.Controls.Add(gv);
    }
}