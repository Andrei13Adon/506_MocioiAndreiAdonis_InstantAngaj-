using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_SeeDetaliuClientP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack && Session["login"] != null)
        {
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("Select cl.Id, cl.Mail, cl.Nume, cl.Obiectiv, cl.Telefon From ClientP cl where cl.Id = " + Request.QueryString["Client"], conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();
            LabelId.Text = (Int32)r["Id"]+"";
            LabelMail.Text = (String)r["Mail"];
            LabelNume.Text = (String)r["Nume"];
            LabelTelefon.Text = (String)r["Telefon"];
            LabelObiectiv.Text = (String)r["Obiectiv"];
            conn.Close();
        }
    }
    protected void ButtonInapoi_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebForms/SeeAllClients.aspx?Oferta=" + Request.QueryString["Oferta"]);
    }
}