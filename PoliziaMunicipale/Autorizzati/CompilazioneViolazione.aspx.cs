using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoliziaMunicipale
{
    public partial class CompilazioneViolazione : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand comandoSql = new SqlCommand("SELECT * FROM Trasgressori", connection);
            SqlDataReader reader = comandoSql.ExecuteReader();

            ListItem itemVuoto = new ListItem();
            itemVuoto.Text = "Seleziona Trasgressore";
            itemVuoto.Value = Convert.ToString(0);
            DropDownListTrasgressori.Items.Add(itemVuoto);

            if (IsPostBack != true)
            {
                while (reader.Read())
                {
                    ListItem item = new ListItem();
                    item.Value = reader["IdTrasgressore"].ToString();
                    item.Text = $"{reader["Nome"]}, {reader["Cognome"]}";
                    DropDownListTrasgressori.Items.Add(item);
                }
            }

            reader.Close();
            SqlCommand comandoSql2 = new SqlCommand("SELECT * FROM Violazioni", connection);
            SqlDataReader reader2 = comandoSql2.ExecuteReader();

            ListItem itemVuoto2 = new ListItem();
            itemVuoto2.Text = "Seleziona Violazione";
            itemVuoto2.Value = Convert.ToString(0);
            DropDownListViolazioni.Items.Add(itemVuoto2);

            if (IsPostBack != true)
            {
                while (reader2.Read())
                {
                    ListItem item = new ListItem();
                    item.Value = reader2["IdViolazione"].ToString();
                    item.Text = reader2["Descrizione"].ToString();
                    DropDownListViolazioni.Items.Add(item);
                }
            }
                    connection.Close();
        }

        protected void ConfermaMulta_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                SqlCommand comandoSql = new SqlCommand("INSERT INTO Verbale(IdTrasgressore, IdViolazione, IndirizzoViolazione, NominativoAgente, DataViolazione, DataTrascrizioneVerbale, ImportoVerbale, DecurtamentoPunti, Citta) " +
                    "VALUES(@IdTrasgressore, @IdViolazione, @IndirizzoViolazione, @NominativoAgente, @DataViolazione, @DataTrascrizioneVerbale, @ImportoVerbale, @DecurtamentoPunti, @Citta)", connection);
                comandoSql.Parameters.AddWithValue("IdTrasgressore", DropDownListTrasgressori.SelectedValue);
                comandoSql.Parameters.AddWithValue("IdViolazione", DropDownListViolazioni.SelectedValue);
                comandoSql.Parameters.AddWithValue("IndirizzoViolazione",IndirizzoViolazione.Text);
                comandoSql.Parameters.AddWithValue("NominativoAgente",NominativoAgente.Text);
                comandoSql.Parameters.AddWithValue("DataViolazione",DataViolazione.Text);
                comandoSql.Parameters.AddWithValue("DataTrascrizioneVerbale", DataTrascrizione.Text);
                comandoSql.Parameters.AddWithValue("ImportoVerbale",ImportoVerbale.Text);
                comandoSql.Parameters.AddWithValue("DecurtamentoPunti", DecurtamentoPunti.Text);
                comandoSql.Parameters.AddWithValue("Citta", Citta.Text);

                comandoSql.ExecuteNonQuery();
                connection.Close();
                
                Response.Redirect("/Autorizzati/CompilazioneViolazione.aspx");
                
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