using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SP_AND_GP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListBox1.Visible = false;
        ListBox2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox1.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        ListBox2.Visible = true;
    }
}