using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_HomeClientP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["login"] != null)//!Page.IsPostBack && 
        {
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
            SqlCommand c = new SqlCommand("Select Mail, Nume, IsNull(Telefon,'') as 'Telefon', IsNull(Obiectiv,'') as 'Obiectiv' from ClientP where Id = " + ((LogData)Session["login"]).getId(), conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();
            LabelMail.Text = (String)r["Mail"];
            LabelNume.Text = (String)r["Nume"];
            TextBoxTelefon.Text = (String)r["Telefon"];
            TextBoxObiectiv.Text = (String)r["Obiectiv"];
            conn.Close();
        }
    }
    protected void ButtonModify_Click(object sender, EventArgs e)
    {
        if(TextBoxTelefon.Text == null)
        {
            TextBoxTelefon.Text = "";
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
        String comand = "update ClientP set Telefon = '" + TextBoxTelefon.Text + "', Obiectiv = '" + TextBoxObiectiv.Text + "' where Id= " + ((LogData)Session["login"]).getId();
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