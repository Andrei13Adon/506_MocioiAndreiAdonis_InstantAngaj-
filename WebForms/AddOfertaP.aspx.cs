using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_AddOfertaP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Oferta"] != null && !Page.IsPostBack && Session["login"] != null)
        {
            ButtonNullOferta.Text = "Sterge Oferta";

            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("SELECT Nume, Descriere FROM OfertaP WHERE Id = " + Request.QueryString["Oferta"], conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();
            TextBoxNume.Text = (String)r["Nume"];
            TextBoxDesc.Text = (String)r["Descriere"];
            
            string strCal = "";
            c = new SqlCommand("select c.Nume from CalificareP_OferteP CO, CalificareP C where co.Id_CalificareP = c.Id and co.Id_OferteP = " + Request.QueryString["Oferta"], conn);
            r = c.ExecuteReader();
            while(r.Read()){
                strCal = strCal + (String)r["Nume"] + " ";
            }
            LabelCal.Text = strCal;
            conn.Close();
        }
    }
    protected void ButtonAddCal_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["Oferta"] != null)
        {
            Response.Redirect("/WebForms/AddCalificariOfertaP.aspx?Oferta=" + Request.QueryString["Oferta"]);
        }
        else
        {
            string maxId;
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("select MAX(O.Id)+1 as MId from OfertaP O", conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();
            maxId = (Int32)r["MId"]+"";

            c = new SqlCommand("Insert into OfertaP (Id,Nume,Descriere,Valabila,Id_FirmaP) Values (" + maxId + ",'" + TextBoxNume.Text + "','" + TextBoxDesc.Text + "',"+-1+"," + ((LogData)Session["login"]).getId() + " )", conn);
            c.ExecuteReader();
            conn.Close();
            Response.Redirect("/WebForms/AddCalificariOfertaP.aspx?Oferta=" + maxId);
        }
    }
    protected void ButtonDelCal_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["Oferta"] != null)
        {
            Response.Redirect("/WebForms/DellCalificareP.aspx?Oferta=" + Request.QueryString["Oferta"]);
        }
    }
    protected void ButtonConOferta_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["Oferta"] != null)
        {
            SqlConnection conn = DbConnection.GetSqlConnection();
            SqlCommand command = conn.CreateCommand();
            SqlTransaction transaction = null;

            conn.Open();
            transaction = conn.BeginTransaction("SampleTransaction");
            command.Transaction = transaction;
            command.Connection = conn;
            String comand = "update OfertaP set Nume = '" + TextBoxNume.Text + "', Descriere = '" + TextBoxDesc.Text + "', Valabila = " + 1 + " where Id= " + Request.QueryString["Oferta"];
            command.CommandText = comand;
            command.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();
            Response.Redirect("HomeFirmaP.aspx");
        }
        else
        {
            string maxId;
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("select MAX(O.Id)+1 as MId from OfertaP O", conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();
            maxId = (Int32)r["MId"] + "";

            c = new SqlCommand("Insert into OfertaP (Id,Nume,Descriere,Valabila,Id_FirmaP) Values (" + maxId + ",'" + TextBoxNume.Text + "','" + TextBoxDesc.Text + "'," + 1 + "," + ((LogData)Session["login"]).getId() + " )", conn);
            c.ExecuteReader();
            conn.Close();
            Response.Redirect("HomeFirmaP.aspx");
        }
    }
    protected void ButtonNullOferta_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["Oferta"] != null)
        {
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("DELETE FROM CalificareP_OferteP WHERE Id_OferteP = " + Request.QueryString["Oferta"], conn);
            c.ExecuteReader();

            c = new SqlCommand("DELETE FROM OfertaP WHERE Id = " + Request.QueryString["Oferta"], conn);
            c.ExecuteReader();

            conn.Close();

            Response.Redirect("HomeFirmaP.aspx");
        }
        else
        {
            Response.Redirect("HomeFirmaP.aspx");
        }
    }
}