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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void Loginbtn_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connection);

            sqlConn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users Where Username=@user AND Password=@password", sqlConn);
            sqlCommand.Parameters.AddWithValue("user", TextUser.Text);
            sqlCommand.Parameters.AddWithValue("password", TextPass.Text);

            SqlDataReader reader = sqlCommand.ExecuteReader();

       
                if (reader.HasRows)
                {
                    FormsAuthentication.SetAuthCookie(TextUser.Text, false);
                    Response.Redirect("/Autorizzati/ArchivioTrasgressori.aspx");
                }
                else
                {
                LabelNonAutorizzato.ForeColor = System.Drawing.Color.Red;
                LabelNonAutorizzato.Text = "Password/User sbagliata! Riprova.";
                TextUser.Text = "";
                TextPass.Text = "";
                }
            
        }
       
    }
}