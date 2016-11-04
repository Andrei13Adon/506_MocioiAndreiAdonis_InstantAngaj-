using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_HomeFirmaP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack && Session["login"] != null)
        {
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("Select Mail, Nume, IsNull(Telefon,'') as 'Telefon', IsNull(Descriere,'') as 'Descriere', IsNull(Nume_Firma,'') as 'Nume_Firma', IsNull(Adresa,'') as 'Adresa' from FirmaP where Id = " + ((LogData)Session["login"]).getId(), conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();
            LabelMail.Text = (String)r["Mail"];
            LabelNume.Text = (String)r["Nume"];
            TextBoxTelefon.Text = (String)r["Telefon"];
            TextBoxObiectiv.Text = (String)r["Descriere"];
            TextBoxNumeFirma.Text = (String)r["Nume_Firma"];
            TextBoxAdresa.Text = (String)r["Adresa"];
            conn.Close();
        }
    }
    protected void ButtonModify_Click(object sender, EventArgs e)
    {
        if(TextBoxTelefon.Text == null)
        {
            TextBoxTelefon.Text = "";
        }
        if (TextBoxNumeFirma.Text == null)
        {
            TextBoxNumeFirma.Text = "";
        }
        if (TextBoxAdresa.Text == null)
        {
            TextBoxAdresa.Text = "";
        }
        if (TextBoxObiectiv.Text == null)
        {
            TextBoxObiectiv.Text = "";
        }

        SqlConnection conn = DbConnection.GetSqlConnection();
        SqlCommand command = conn.CreateCommand();
        SqlTransaction transaction =null;

        conn.Open();
        transaction = conn.BeginTransaction("SampleTransaction");
        command.Transaction = transaction;
        command.Connection = conn; 
        String comand = "update FirmaP set Telefon = '" + TextBoxTelefon.Text + "', Nume_Firma = '" + TextBoxNumeFirma.Text + "', Adresa = '" + TextBoxAdresa.Text + "', Descriere = '" + TextBoxObiectiv.Text + "' where Id= " + ((LogData)Session["login"]).getId();
        command.CommandText = comand;
        command.ExecuteNonQuery();
        transaction.Commit();
        conn.Close();
        /* c.ExecuteReader();
        c = new SqlCommand("Commit", conn);
        c.ExecuteNonQuery();
        */
        
        // Label1.Text = comand;
       // Response.Redirect("HomeClientP.aspx");
    
    }
}