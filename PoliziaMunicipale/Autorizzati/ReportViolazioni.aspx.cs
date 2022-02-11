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
    public partial class ReportViolazioni : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();


            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Trasgressori.Cognome, Trasgressori.Nome, Verbale.Citta, Verbale.IndirizzoViolazione, Verbale.NominativoAgente, Verbale.DataViolazione, Verbale.ImportoVerbale, Verbale.DecurtamentoPunti FROM Trasgressori INNER JOIN Verbale ON Trasgressori.IdTrasgressore = Verbale.IdTrasgressore", connection);

            DataTable dbt1 = new DataTable();
            sqlDa.Fill(dbt1);

            GridView1.DataSource = dbt1;
            GridView1.DataBind();

            connection.Close();

        }

        protected void ScegliSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ScegliSelect.SelectedValue) == 1)
            {

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();


                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT COUNT(*) AS TotaleVerbali FROM Verbale", connection);

                DataTable dbt1 = new DataTable();
                sqlDa.Fill(dbt1);

                GridView1.DataSource = dbt1;
                GridView1.DataBind();

                connection.Close();


            }
            else if (Convert.ToInt32(ScegliSelect.SelectedValue) == 2)
            {

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();


                SqlDataAdapter sqlDa= new SqlDataAdapter("SELECT Cognome, Nome, COUNT(*) AS TotVerbali FROM Verbale INNER JOIN Trasgressori ON Verbale.IdTrasgressore = Trasgressori.IdTrasgressore GROUP BY Trasgressori.Cognome, Trasgressori.Nome", connection);

                DataTable dbt1 = new DataTable();
                sqlDa.Fill(dbt1);

                GridView1.DataSource = dbt1;
                GridView1.DataBind();
                
                connection.Close();
            }
            else if (Convert.ToInt32(ScegliSelect.SelectedValue) == 3)
            {

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();


                SqlDataAdapter sqlDa = new SqlDataAdapter("Select Verbale.IdTrasgressore,Nome,Cognome, Sum( DecurtamentoPunti) As TotalePtiDecurtati from Verbale Inner Join Trasgressori on Trasgressori.IdTrasgressore=Verbale.IdTrasgressore group by Verbale.IdTrasgressore,Nome,Cognome", connection);

                DataTable dbt1 = new DataTable();
                sqlDa.Fill(dbt1);

                GridView1.DataSource = dbt1;
                GridView1.DataBind();

                connection.Close();
            }
            else if (Convert.ToInt32(ScegliSelect.SelectedValue) == 4)
            {

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("Select Verbale.IdTrasgressore, Nome, Cognome,DataViolazione, ImportoVerbale,DecurtamentoPunti from Verbale Inner Join  Trasgressori on Verbale.IdTrasgressore=Trasgressori.IdTrasgressore where Verbale.Citta=@Citta", connection);
                sqlDa.SelectCommand.Parameters.AddWithValue("Citta", Citta.Text);
                try
                {
                    DataTable dbt1 = new DataTable();
                    sqlDa.Fill(dbt1);
                    
                    GridView1.DataSource = dbt1;
                    GridView1.DataBind();
                }
                catch
                {
                    
                }
                connection.Close();
            }
            else if (Convert.ToInt32(ScegliSelect.SelectedValue) == 5)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();


                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Trasgressori.Cognome, Trasgressori.Nome, Verbale.DataViolazione, Verbale.ImportoVerbale, Verbale.DecurtamentoPunti FROM Trasgressori INNER JOIN Verbale ON Trasgressori.IdTrasgressore = Verbale.IdTrasgressore WHERE(Verbale.ImportoVerbale > 5)", connection);

                DataTable dbt1 = new DataTable();
                sqlDa.Fill(dbt1);

                GridView1.DataSource = dbt1;
                GridView1.DataBind();

                connection.Close();
            }
            else if (Convert.ToInt32(ScegliSelect.SelectedValue) == 6)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);
               
                connection.Open();


                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Trasgressori.Cognome, Trasgressori.Nome, Verbale.DataViolazione, Verbale.ImportoVerbale, Verbale.DecurtamentoPunti FROM Trasgressori INNER JOIN Verbale ON Trasgressori.IdTrasgressore = Verbale.IdTrasgressore WHERE(Verbale.ImportoVerbale > 400)", connection);
                
               DataTable dbt1 = new DataTable();
                sqlDa.Fill(dbt1);

                GridView1.DataSource = dbt1;
                GridView1.DataBind();

                connection.Close();
            }
        }

       
        protected void DropDownListCitta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("Select Verbale.IdTrasgressore, Nome, Cognome,DataViolazione, ImportoVerbale,DecurtamentoPunti from Verbale Inner Join  Trasgressori on Verbale.IdTrasgressore=Trasgressori.IdTrasgressore where Verbale.Citta=@Citta", connection);
            sqlDa.SelectCommand.Parameters.AddWithValue("Citta", Citta.Text);
            try
            {
                DataTable dbt1 = new DataTable();
                sqlDa.Fill(dbt1);

                GridView1.DataSource = dbt1;
                GridView1.DataBind();
            }
            catch
            {

            }
            connection.Close();


            //string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            //SqlConnection connection = new SqlConnection(connectionString);

            //connection.Open();

            //SqlCommand command = new SqlCommand("Select Verbale.IdTrasgressore, Nome, Cognome,DataViolazione, ImportoVerbale,DecurtamentoPunti from Verbale Inner Join  Trasgressori on Verbale.IdTrasgressore=Trasgressori.IdTrasgressore where Verbale.Citta=@Citta", connection);
            //command.Parameters.AddWithValue("Citta", Citta.Text);

            //SqlDataReader reader2 = command.ExecuteReader();

            //List<Griglia> countverbali = new List<Griglia>();

            //if (reader2.HasRows)
            //{
            //    while (reader2.Read())
            //    {
            //        Griglia g = new Griglia();
            //        g.Nome = Convert.ToString(reader2["Nome"]);
            //        g.Cognome = Convert.ToString(reader2["Cognome"]);
            //        g.DataViolazione = Convert.ToDateTime(reader2["DataViolazione"]);
            //        g.Importo = Convert.ToDecimal(reader2["ImportoVerbale"]);
            //        g.Punti = Convert.ToInt32(reader2["DecurtamentoPunti"]);
            //        countverbali.Add(g);
            //    }
            //}

            //GridView1.DataSource = countverbali;
            //GridView1.DataBind();


        }

        protected void LinkSignOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
} 
