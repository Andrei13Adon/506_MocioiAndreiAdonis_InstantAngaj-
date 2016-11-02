using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_QualificationClientP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            SqlConnection con = DbConnection.GetSqlConnection();
            con.Open();
            SqlCommand c;
            c = new SqlCommand("Select  ClientP_CalificareP.Id, CalificareP.Nume From CalificareP,ClientP_CalificareP Where CalificareP.Id = ClientP_CalificareP.Id_CalificareP And ClientP_CalificareP.Id_ClientP = " + ((LogData)Session["login"]).getId() + " Order by CalificareP.Nume", con);
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
                cell3.Text = (Int32)r["Id"] + "";
                row.Cells.Add(cell3);

                Clasament.Rows.Add(row);
            }
            con.Close();
        }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddQualificationP.aspx");
    }
    protected void ButtonDell_Click(object sender, EventArgs e)
    {
        Response.Redirect("DellQualificationP.aspx");
    }
}