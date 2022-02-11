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
    public partial class ArchivioTrasgressori : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();


            SqlDataAdapter sqlDa = new SqlDataAdapter("Select IdTrasgressore,Cognome,Nome,Citta from Trasgressori", connection);

            DataTable dbt1 = new DataTable();
            sqlDa.Fill(dbt1);

            GridView1.DataSource = dbt1;
            GridView1.DataBind();

            connection.Close();
        }

        protected void ConfermaTrasgressore_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                SqlCommand comandoSql = new SqlCommand("INSERT INTO Trasgressori(Cognome, Nome, Indirizzo, Citta, CAP, CodiceFiscale)" +
                    " VALUES(@Cognome, @Nome, @Indirizzo, @Citta, @CAP, @CodiceFiscale)", connection);
                comandoSql.Parameters.AddWithValue("Cognome", Cognome.Text);
                comandoSql.Parameters.AddWithValue("Nome", Nome.Text);
                comandoSql.Parameters.AddWithValue("Indirizzo", Indirizzo.Text);
                comandoSql.Parameters.AddWithValue("Citta", Citta.Text);
                comandoSql.Parameters.AddWithValue("CAP", CAP.Text);
                comandoSql.Parameters.AddWithValue("CodiceFiscale", CodiceFiscale.Text);
                comandoSql.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("/Autorizzati/ArchivioTrasgressori.aspx");
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

        protected void CercaTrasgressorebtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            if (NomeTrasgressore.Text=="")
            {

                SqlCommand command = new SqlCommand("Select IdTrasgressore,Cognome,Nome,Citta from Trasgressori where Cognome like @Cognome ", connection);
                command.Parameters.AddWithValue("Nome", NomeTrasgressore.Text);
                command.Parameters.AddWithValue("Cognome", CognomeTrasgressore.Text);

                SqlDataReader reader2 = command.ExecuteReader();

                List<Trasgressore> listTrasgressori = new List<Trasgressore>();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        Trasgressore t = new Trasgressore();
                        t.Nome = Convert.ToString(reader2["Nome"]);
                        t.Cognome = Convert.ToString(reader2["Cognome"]);
                        t.Citta = Convert.ToString(reader2["Citta"]);
                        t.IdTrasgressore = Convert.ToInt32(reader2["IdTrasgressore"]);
                        listTrasgressori.Add(t);
                    }
                }

                GridView1.DataSource = listTrasgressori;
                GridView1.DataBind();
            }
            else if(CognomeTrasgressore.Text == "")
            {

                SqlCommand command = new SqlCommand("Select IdTrasgressore,Cognome,Nome,Citta from Trasgressori where Nome like @Nome", connection);
                command.Parameters.AddWithValue("Nome", NomeTrasgressore.Text);
                command.Parameters.AddWithValue("Cognome", CognomeTrasgressore.Text);

                SqlDataReader reader2 = command.ExecuteReader();

                List<Trasgressore> listTrasgressori = new List<Trasgressore>();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        Trasgressore t = new Trasgressore();
                        t.Nome = Convert.ToString(reader2["Nome"]);
                        t.Cognome = Convert.ToString(reader2["Cognome"]);
                        t.Citta = Convert.ToString(reader2["Citta"]);
                        t.IdTrasgressore = Convert.ToInt32(reader2["IdTrasgressore"]);
                        listTrasgressori.Add(t);
                    }
                }

                GridView1.DataSource = listTrasgressori;
                GridView1.DataBind();
            }
            else
            {

                SqlCommand command = new SqlCommand("Select IdTrasgressore,Cognome,Nome,Citta from Trasgressori where Nome like @Nome and Cognome like @Cognome", connection);
                command.Parameters.AddWithValue("Nome", NomeTrasgressore.Text);
                command.Parameters.AddWithValue("Cognome", CognomeTrasgressore.Text);

                SqlDataReader reader2 = command.ExecuteReader();

                List<Trasgressore> listTrasgressori = new List<Trasgressore>();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        Trasgressore t = new Trasgressore();
                        t.Nome = Convert.ToString(reader2["Nome"]);
                        t.Cognome = Convert.ToString(reader2["Cognome"]);
                        t.Citta = Convert.ToString(reader2["Citta"]);
                        t.IdTrasgressore = Convert.ToInt32(reader2["IdTrasgressore"]);
                        listTrasgressori.Add(t);
                    }
                }

                GridView1.DataSource = listTrasgressori;
                GridView1.DataBind();
            }
            


           
        }
    }
}

