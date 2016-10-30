using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_SignUpP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonSingUp_Click(object sender, EventArgs e)
    {
        if (TextBoxMail.Text.Equals(""))
        {
            Label1.Text = "Campul cu Mail nu poate fii gol!";
            return;
        }
        if (TextBoxTelefon.Text.Equals(""))
        {
            Label1.Text = "Campul cu Telefon nu poate fii gol!";
            return;
        }
        if (TextBoxNume.Text.Equals(""))
        {
            Label1.Text = "Campul cu Nume nu poate fii gol!";
            return;
        }
        if (TextBoxParola.Text.Equals(""))
        {
            Label1.Text = "Campul cu Parola nu poate fii gol!";
            return;
        }
        if (!TextBoxParola.Text.Equals(TextBoxConParola.Text))
        {
            Label1.Text = "Parolele nu se potrivesc";
            return;
        }

        SqlConnection conn = DbConnection.GetSqlConnection();
        conn.Open();
        int newId=-1;

        if (!CheckBoxFirma.Checked)
        {
            //ClientP
            SqlCommand c = new SqlCommand("Select 1 FROM ClientP WHERE UPPER(Mail)=UPPER('" + TextBoxMail.Text + "')", conn);
            SqlDataReader r = c.ExecuteReader();
            if (r.Read())
            {
                Label1.Text = "Acest Mail este deja utilizat!";
                return;
            }
            c = new SqlCommand("Select Max(Id)+1 as 'Id' FROM ClientP", conn);
            r = c.ExecuteReader();
            r.Read();
            newId = (Int32)r["Id"];

            c = new SqlCommand("Insert into ClientP (Id,Mail,Parola,Nume,Telefon) Values (" + newId + ",'" + TextBoxMail.Text + "','" + TextBoxParola.Text + "','" + TextBoxNume.Text + "','" + TextBoxTelefon.Text + "')", conn);
            c.ExecuteReader();

            Label1.Text = "Contul Tau a fost creat!";
            TextBoxMail.Text = "";
            TextBoxTelefon.Text = "";
            TextBoxNume.Text = "";
        }
        else
        {
            //FirmaP
            SqlCommand c = new SqlCommand("Select 1 FROM FirmaP WHERE UPPER(Mail)=UPPER('" + TextBoxMail.Text + "')", conn);
            SqlDataReader r = c.ExecuteReader();
            if (r.Read())
            {
                Label1.Text = "Acest Mail este deja utilizat!";
                return;
            }
            c = new SqlCommand("Select Max(Id)+1 as 'Id' FROM FirmaP", conn);
            r = c.ExecuteReader();
            r.Read();
            newId = (Int32)r["Id"];

            c = new SqlCommand("Insert into FirmaP (Id,Mail,Parola,Nume,Telefon) Values (" + newId + ",'" + TextBoxMail.Text + "','" + TextBoxParola.Text + "','" + TextBoxNume.Text + "','" + TextBoxTelefon.Text + "')", conn);
            c.ExecuteReader();

            Label1.Text = "Contul Tau a fost creat!";
            TextBoxMail.Text = "";
            TextBoxTelefon.Text = "";
            TextBoxNume.Text = "";
        }
        conn.Close();
    }
}