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
            c = new SqlCommand("select cp.Id, cp.Nume from CalificareP cp where cp.Id NOT IN ( select c.Id from CalificareP_OferteP co, CalificareP c where co.Id_CalificareP = c.Id and co.Id_OferteP = " + Request.QueryString["Oferta"] + " )", con);
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
                //IdCalificare.Click += new EventHandler(AddCalificare);
                cell3.Controls.Add(IdCalificare);
                row.Cells.Add(cell3);

                Clasament.Rows.Add(row);
            }
            con.Close();
        }
    }
}