using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_OfertaDetaliataFP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null && Request.QueryString["Oferta"] != null)//&& !Page.IsPostBack
        {
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("select o.Id, o.Nume, o.Valabila, o.Descriere from OfertaP o where o.Id = " + Request.QueryString["Oferta"], conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();
            LabelIdOferta.Text = (Int32)r["Id"] + "";
            LabelNume.Text = (String)r["Nume"];
            LabelDescriere.Text = (String)r["Descriere"];
            int tip = (Int32)r["Valabila"];
            if (tip == 1)
                LabelValabila.Text = "Da";
            else
                LabelValabila.Text = "Nu";
            conn.Close();
        }
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewAllOfferts.aspx");
    }
    protected void ButtonVal_Click(object sender, EventArgs e)
    {
        SqlConnection conn = DbConnection.GetSqlConnection();
        SqlCommand command = conn.CreateCommand();
        SqlTransaction transaction = null;

        conn.Open();
        transaction = conn.BeginTransaction("SampleTransaction");
        command.Transaction = transaction;
        command.Connection = conn;
        String comand = "update OfertaP set Valabila = " + 1 + " where Id = " + Request.QueryString["Oferta"];
        command.CommandText = comand;
        command.ExecuteNonQuery();
        transaction.Commit();
        conn.Close();
        Response.Redirect(Request.RawUrl);
    }
    protected void ButtonInVal_Click(object sender, EventArgs e)
    {
        SqlConnection conn = DbConnection.GetSqlConnection();
        SqlCommand command = conn.CreateCommand();
        SqlTransaction transaction = null;

        conn.Open();
        transaction = conn.BeginTransaction("SampleTransaction");
        command.Transaction = transaction;
        command.Connection = conn;
        String comand = "update OfertaP set Valabila = " + -1 + " where Id = " + Request.QueryString["Oferta"];
        command.CommandText = comand;
        command.ExecuteNonQuery();
        transaction.Commit();
        conn.Close();
        Response.Redirect(Request.RawUrl);
    }
    protected void ButtonModifica_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebForms/AddOfertaP.aspx?Oferta=" + Request.QueryString["Oferta"]);
    }
    protected void ButtonVezCl_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebForms/SeeAllClients.aspx?Oferta=" + Request.QueryString["Oferta"]);
    }
}