using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_ToateOferteleClP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = DbConnection.GetSqlConnection();
        con.Open();
        SqlCommand c;
        c = new SqlCommand("select o.Nume, o.Id from  OfertaP o where o.Valabila != " + -1, con);
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
            LinkButton IdCalificare = new LinkButton();
            IdCalificare.Text = (Int32)r["Id"] + "";
            IdCalificare.Click += new EventHandler(SeeCalificare);
            cell3.Controls.Add(IdCalificare);
            row.Cells.Add(cell3);

            Clasament.Rows.Add(row);
        }
        con.Close();
    }
    public void SeeCalificare(object sender, EventArgs e)
    {
        LinkButton IdCalificare = (LinkButton)sender;

        Response.Redirect("/WebForms/DetaliOfertaDisP.aspx?Oferta=" + IdCalificare.Text);
    }
}