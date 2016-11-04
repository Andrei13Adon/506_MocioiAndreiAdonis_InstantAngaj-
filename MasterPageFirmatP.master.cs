using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageFirmatP : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeFirmaP.aspx");
    }
    protected void LogOff_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("LogInP.aspx");
    }
    protected void AddOferta_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddOfertaP.aspx");
    }
}
