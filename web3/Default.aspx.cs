using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web3
{
    public partial class _Default : Page
    {








        private string connectionString = "Data Source=Matuz;Initial Catalog=CRUD10;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand comm = new SqlCommand("Insert into Employer values(@Matricula, @Nombre, @Carrera)", con);

                comm.Parameters.AddWithValue("@Matricula", int.Parse(textmatricula.Text));
                comm.Parameters.AddWithValue("@Nombre", textnombre.Text);
                comm.Parameters.AddWithValue("@Carrera", textcarrera.Text);

                comm.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Registro insertado exitosamente');", true);
                LoadRecord();
            }
        }

        void LoadRecord()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand comm = new SqlCommand("SELECT Matricula, Nombre, Carrera FROM Employer", con);
                SqlDataAdapter d = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                d.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textmatricula.Text))
            {
                string matricula = textmatricula.Text.Trim();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("SELECT Matricula, Nombre, Carrera FROM Employer WHERE Matricula = @Matricula", con);
                    comm.Parameters.AddWithValue("@Matricula", matricula);

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textnombre.Text = reader["Nombre"].ToString();
                            textcarrera.Text = reader["Carrera"].ToString();
                        }
                        else
                        {
                            textnombre.Text = "";
                            textcarrera.Text = "";

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('No se encontraron registros');", true);
                        }
                    }

                    con.Close();
                }
            }
            else
            {
                LoadRecord();
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textmatricula.Text))
            {
                string matricula = textmatricula.Text.Trim();
                string updatedValue2 = textnombre.Text;
                string updatedValue3 = textcarrera.Text;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("UPDATE Employer SET Nombre = @Nombre, Carrera = @Carrera WHERE Matricula = @Matricula", con);

                    comm.Parameters.AddWithValue("@Nombre", updatedValue2);
                    comm.Parameters.AddWithValue("@Carrera", updatedValue3);
                    comm.Parameters.AddWithValue("@Matricula", matricula);

                    comm.ExecuteNonQuery();
                    con.Close();

                    textmatricula.Text = "";
                    textnombre.Text = "";
                    textcarrera.Text = "";

                    LoadRecord();

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Registro actualizado exitosamente');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Por favor, seleccione un registro para actualizar');", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textmatricula.Text))
            {
                string matricula = textmatricula.Text.Trim();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("DELETE FROM Employer WHERE Matricula = @Matricula", con);
                    comm.Parameters.AddWithValue("@Matricula", matricula);

                    comm.ExecuteNonQuery();
                    con.Close();

                    textmatricula.Text = "";
                    textnombre.Text = "";
                    textcarrera.Text = "";

                    GridView1.SelectedIndex = -1;

                    LoadRecord();

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Registro eliminado exitosamente');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Por favor, seleccione un registro para eliminar');", true);
            }
        }

        protected void profileTabButton_Click(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 1;
        }






        protected void multiView_ActiveViewChanged(object sender, EventArgs e)
        {


        }
    }
}