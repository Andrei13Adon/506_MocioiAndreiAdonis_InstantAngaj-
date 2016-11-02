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
        if (Session["login"] != null)//!Page.IsPostBack && 
        {
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("Select Mail, Nume, IsNull(Telefon,'') as 'Telefon', IsNull(Descriere,'') as 'Descriere', IsNull(Nume_Firma,'') as 'Nume_Firma', IsNull(Adresea,'') as 'Adresea' from ClientP where Id = " + ((LogData)Session["login"]).getId(), conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();
            LabelMail.Text = (String)r["Mail"];
            LabelNume.Text = (String)r["Nume"];
            TextBoxTelefon.Text = (String)r["Telefon"];
            TextBoxObiectiv.Text = (String)r["Descriere"];
            TextBoxNumeFirma.Text = (String)r["Nume_Firma"];
            TextBoxAdresa.Text = (String)r["Adresea"];
            conn.Close();
        }
    }
    protected void ButtonModify_Click(object sender, EventArgs e)
    {

    }
}