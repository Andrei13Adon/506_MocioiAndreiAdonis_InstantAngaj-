using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_AddNewCalificare : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonCrNew_Click(object sender, EventArgs e)
    {
        // De modifcat
           int newId = -1;
           SqlConnection con = DbConnection.GetSqlConnection();
           con.Open();
           SqlCommand c = new SqlCommand("Select Max(CalificareP.Id)+1 as 'Id' From CalificareP", con);
           SqlDataReader r = c.ExecuteReader();
           r.Read();
           newId = (Int32)r["Id"];
           con.Close();

           con = DbConnection.GetSqlConnection();
           con.Open();
           c = new SqlCommand("Insert into CalificareP(Id, Nume) Values(" + newId + ",'" + TextBoxNume.Text + "')", con);
           c.ExecuteReader();
           con.Close();
           
        Response.Redirect("/WebForms/AddCalificariOfertaP.aspx?Oferta=" + Request.QueryString["Oferta"]);
    }
    protected void ButtonRenunta_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebForms/AddCalificariOfertaP.aspx?Oferta=" + Request.QueryString["Oferta"]);
    }
}