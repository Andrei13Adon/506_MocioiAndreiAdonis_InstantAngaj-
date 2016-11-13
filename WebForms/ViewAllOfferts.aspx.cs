using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_ViewAllOfferts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            SqlConnection con = DbConnection.GetSqlConnection();
            con.Open();
            SqlCommand c;
            c = new SqlCommand("select o.Id, o.Nume, o.Valabila from OfertaP o where o.Id_FirmaP = " + ((LogData)Session["login"]).getId(), con);
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
                int tip = (Int32)r["Valabila"];
                if(tip==1)
                    cell3.Text = "Da";
                else
                    cell3.Text = "Nu";
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                LinkButton IdOferta = new LinkButton();
                IdOferta.Text = (Int32)r["Id"] + "";
                IdOferta.Click += new EventHandler(ViewOferta);
                cell4.Controls.Add(IdOferta);
                row.Cells.Add(cell4);

                Clasament.Rows.Add(row);
            }
            con.Close();
        }
    }
    public void ViewOferta(object sender, EventArgs e)
    {
        LinkButton IdCalificare = (LinkButton)sender;
        Response.Redirect("/WebForms/OfertaDetaliataFP.aspx?Oferta=" + IdCalificare.Text);
    }
}