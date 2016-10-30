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
        if (Session["login"] != null)
        {
            SqlConnection conn = DbConnection.GetSqlConnection();
            conn.Open();
          //  SqlCommand c = new SqlCommand("Select '1' FROM Useri WHERE UPPER(Nume)=UPPER(@User) AND UPPER(Parola)=UPPER(@parola)", conn);



            conn.Close();
        }
    }
}