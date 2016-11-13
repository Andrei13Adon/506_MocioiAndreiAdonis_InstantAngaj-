using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_SeeAllClients : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         if (Session["login"] != null && Request.QueryString["Oferta"] != null)//&& !Page.IsPostBack
         {
             SqlConnection con = DbConnection.GetSqlConnection();
             con.Open();
             SqlCommand c;
             c = new SqlCommand("Select cl.Id, cl.Nume, cl.Telefon From ClientP cl, ClientP_OfertaP clof Where cl.Id = clof.Id_ClientP and clof.Id_OfertaP = " + Request.QueryString["Oferta"], con);
             SqlDataReader r = c.ExecuteReader();
             TableRow row1 = Clasament.Rows[0];
             Clasament.Rows.Clear();
             Clasament.Rows.Add(row1);
             int nrRezultate = 0;
             while (r.Read() && nrRezultate < 10)
             {
                 nrRezultate++;
                 TableRow row = new TableRow();

                 TableCell cell1 = new TableCell();
                 cell1.Text = nrRezultate + "";
                 row.Cells.Add(cell1);

                 TableCell cell2 = new TableCell();
                 cell2.Text = (string)r["Nume"];
                 row.Cells.Add(cell2);

                 TableCell cell3 = new TableCell();
                 cell3.Text = (string)r["Telefon"];
                 row.Cells.Add(cell3);

                 TableCell cell4 = new TableCell();
                 LinkButton IdClient = new LinkButton();
                 IdClient.Text = (Int32)r["Id"] + "";
                 IdClient.Click += new EventHandler(ViewClient);
                 cell4.Controls.Add(IdClient);
                 row.Cells.Add(cell4);

                 Clasament.Rows.Add(row);
             }
             con.Close();
         }
    }
    public void ViewClient(object sender, EventArgs e)
    {
        LinkButton IdClient = (LinkButton)sender;
        Response.Redirect("/WebForms/SeeDetaliuClientP.aspx?Oferta=" + Request.QueryString["Oferta"] + "&Client=" + IdClient.Text);
    }
    protected void ButtonInapoi_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebForms/OfertaDetaliataFP.aspx?Oferta=" + Request.QueryString["Oferta"]);
    }
}