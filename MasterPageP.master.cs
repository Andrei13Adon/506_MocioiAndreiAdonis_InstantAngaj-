using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageP : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LogInBut_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebForms/LogInP.aspx");
    }
    protected void SignUpBut_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebForms/SignUpP.aspx");
    }
}
