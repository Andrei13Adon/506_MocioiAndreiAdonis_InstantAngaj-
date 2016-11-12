using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_DetaliOfertaDisP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null && Request.QueryString["Oferta"] != null && !Page.IsPostBack)
        {
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("Select f.Nume as 'Firma' , o.Id, o.Nume, o.Descriere From OfertaP o, FirmaP f Where o.Id_FirmaP = f.Id And o.Id = " + Request.QueryString["Oferta"], conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();
            LabelIdOferta.Text = (Int32)r["Id"]+"";
            LabelNume.Text = (String)r["Nume"];
            LabelDescriere.Text = (String)r["Descriere"];
            LabelFirma.Text = (String)r["Firma"];

            c = new SqlCommand("select 1 from ClientP_OfertaP co where co.Id_ClientP = " + ((LogData)Session["login"]).getId() + " And co.Id_OfertaP = " + Request.QueryString["Oferta"], conn);
            r = c.ExecuteReader();
            if (r.Read())
            {
                ButtonAppOf.Visible = false;
                LabelAccept.Text = "Esti deja inscris la acesta oferta!";
            }

            conn.Close();
        }
    }
    protected void ButtonAppOf_Click(object sender, EventArgs e)
    {
        SqlConnection conn = DbConnection.GetSqlConnection();
        int MaxId = -1;
        conn.Open();
        SqlCommand c = new SqlCommand("select MAX(co.Id)+1 as 'Id' From ClientP_OfertaP co", conn);
        SqlDataReader r = c.ExecuteReader();
        r.Read();
        MaxId = (Int32)r["Id"];

        c = new SqlCommand("Insert into ClientP_OfertaP (Id,Id_ClientP,Id_OfertaP) Values (" + MaxId + "," + ((LogData)Session["login"]).getId() + "," + Request.QueryString["Oferta"] + ")", conn);
        c.ExecuteReader();

        conn.Close();

        Response.Redirect("SeeAllOferte.aspx");
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("SeeAllOferte.aspx");
    }
}