using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_LogInP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonLogIn_Click(object sender, EventArgs e)
    {
        if (TextBoxEmail.Text.Equals(""))
        {
            Label1.Text = "Campul cu Email utilizatorului nu poate fii gol";
            return;
        }
        if (TextBoxParola.Text.Equals(""))
        {
            Label1.Text = "Campul cu parola nu poate fii gol";
            return;
        }
        SqlConnection conn = DbConnection.GetSqlConnection();
        conn.Open();
        if (!this.CheckBoxFirma.Checked)
        {
         SqlCommand c = new SqlCommand("Select Id FROM ClientP WHERE UPPER(Mail)=UPPER('" + TextBoxEmail.Text + "') AND UPPER(Parola)=UPPER('" + TextBoxParola.Text + "')", conn);
         SqlDataReader r = c.ExecuteReader();
         bool logatCuSucces = false;
         while (r.Read())
            {
                logatCuSucces = true;
                Session["login"] = new LogData((Int32)r["Id"], false);

                Response.Redirect("HomeClientP.aspx");
            }
            //conn.Close();
         if (logatCuSucces == false) Label1.Text = "Numele de utilizator sau parola sunt incorecte";
            conn.Close();
         }
         else
         {
             SqlCommand c = new SqlCommand("Select Id FROM FirmaP WHERE UPPER(Mail)=UPPER('" + TextBoxEmail.Text + "') AND UPPER(Parola)=UPPER('" + TextBoxParola.Text + "')", conn);
             SqlDataReader r = c.ExecuteReader();
             bool logatCuSucces = false;
             while (r.Read())
                {
                    logatCuSucces = true;
                    Session["login"] = new LogData((Int32)r["Id"], true);

                    Response.Redirect("HomeF.aspx");
                }
             //conn.Close();
             if (logatCuSucces == false) Label1.Text = "Numele de utilizator sau parola sunt incorecte";
             conn.Close();
        }

    }
}