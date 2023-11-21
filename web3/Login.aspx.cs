using System;
using System.Data.SqlClient;

namespace web3
{
    public partial class Login : System.Web.UI.Page
    {
      
        private string connectionString = "Data Source=Matuz;Initial Catalog=CRUD10;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (CheckCredentials(username, password))
            {
              
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                
                Response.Write("<script>alert('Credenciales incorrectas');</script>");
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

               
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Username AND Contraseña = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
