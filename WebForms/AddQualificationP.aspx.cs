using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_AddQualificationP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     if (Session["login"] != null) 
        {
        SqlConnection con = DbConnection.GetSqlConnection();
        con.Open();
        SqlCommand c;
        c = new SqlCommand("Select CalificareP.Id, CalificareP.Nume From CalificareP Where CalificareP.Id NOT IN (Select CalificareP.Id From CalificareP,ClientP_CalificareP Where CalificareP.Id = ClientP_CalificareP.Id_CalificareP And ClientP_CalificareP.Id_ClientP = " + ((LogData)Session["login"]).getId() + " )  Order by CalificareP.Nume", con);
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
            IdCalificare.Click += new EventHandler(AddCalificare);
            cell3.Controls.Add(IdCalificare);
            row.Cells.Add(cell3);

            Clasament.Rows.Add(row);
        }
        con.Close();
    }
    }
    public void AddCalificare(object sender, EventArgs e)
    {
        LinkButton IdCalificare = (LinkButton)sender;
        
        int newId = -1;
        SqlConnection con = DbConnection.GetSqlConnection();
        con.Open();
        SqlCommand c = new SqlCommand("Select Max(ClientP_CalificareP.Id)+1 as 'Id' From ClientP_CalificareP", con);
        SqlDataReader r = c.ExecuteReader();
        r.Read();
        newId = (Int32)r["Id"];
        con.Close();

        con = DbConnection.GetSqlConnection();
        con.Open();
        c = new SqlCommand("Insert into ClientP_CalificareP(Id, Id_ClientP, Id_CalificareP) Values (" + newId + "," + ((LogData)Session["login"]).getId() + "," + IdCalificare.Text + ")", con);
        c.ExecuteReader();
        con.Close();
         
        Response.Redirect("QualificationClientP.aspx");
    }
}