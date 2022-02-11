using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoliziaMunicipale
{
    public partial class ArchivioViolazioni : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();


            SqlDataAdapter sqlDa = new SqlDataAdapter("Select IdViolazione, Descrizione from violazioni" , connection);

            DataTable dbt1 = new DataTable();
            sqlDa.Fill(dbt1);

            GridView1.DataSource = dbt1;
            GridView1.DataBind();

            connection.Close();
        }

        protected void AggiungiViolazione_Click(object sender, EventArgs e)
        {
       
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);

                try
                {
                    connection.Open();
                    SqlCommand comandoSql = new SqlCommand("INSERT INTO Violazioni(Descrizione) VALUES(@Descrizione)", connection);
                    comandoSql.Parameters.AddWithValue("Descrizione", Descrizione.Text);
                    comandoSql.ExecuteNonQuery();
                    connection.Close();
                    Response.Redirect("/Autorizzati/ArchivioViolazioni.aspx");
                }
                catch
                {

                }
        }
        protected void LinkSignOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}