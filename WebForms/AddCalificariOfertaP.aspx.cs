using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_AddCalificariOfertaP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Oferta"] != null  && Session["login"] != null)//&& !Page.IsPostBack
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
        SqlCommand c = new SqlCommand("Select Max(CalificareP_OferteP.Id)+1 as 'Id' From CalificareP_OferteP", con);
        SqlDataReader r = c.ExecuteReader();
        r.Read();
        newId = (Int32)r["Id"];
        con.Close();

        con = DbConnection.GetSqlConnection();
        con.Open();
        c = new SqlCommand("Insert into CalificareP_OferteP(Id, Id_CalificareP, Id_OferteP) Values (" + newId + "," + IdCalificare.Text + "," + Request.QueryString["Oferta"] + ")", con);
        c.ExecuteReader();
        con.Close();
        
        Response.Redirect("/WebForms/AddOfertaP.aspx?Oferta=" + Request.QueryString["Oferta"]);
    }
    protected void ButtonCalN_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebForms/AddNewCalificare.aspx?Oferta=" + Request.QueryString["Oferta"]);
    }
    protected void ButtonRenunta_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebForms/AddOfertaP.aspx?Oferta=" + Request.QueryString["Oferta"]);
    }
}
