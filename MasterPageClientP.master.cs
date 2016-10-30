using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageClientP : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeClientP.aspx");
    }
    protected void LogOff_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("LogInP.aspx");
    }
}
