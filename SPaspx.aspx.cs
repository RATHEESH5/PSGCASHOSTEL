using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




public partial class SPaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Calendar1.Visible = false;
        Calendar2.Visible = false;
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Calendar1.SelectedDate.ToShortDateString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        TextBox3.Text = Calendar2.SelectedDate.ToShortDateString();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Calendar2.Visible = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('Permission Applied successfully')</script>");
        
    }

}