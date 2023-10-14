using Microsoft.Data.SqlClient;
using System.Data.SqlClient;


namespace basededatos
{

    public partial class Form1 : Form
    {

        SqlConnection conexion = new SqlConnection();


        SqlCommand comando = new SqlCommand();


        public Form1()
        {

            InitializeComponent();


            conexion.ConnectionString = @"Data Source=.;Initial Catalog=examen;" + "Integrated Security=True;TrustServerCertificate=true";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)



        {
            try

            {

                comando.Connection = conexion;


                comando.CommandText = "insert Into alumno(id,nombre) values(@txtId,@txtNombre)";


                conexion.Open();

                

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("txtId", txtId.Text);
                comando.Parameters.AddWithValue("txtNombre", txtNombre.Text);


                int NFilas = comando.ExecuteNonQuery();


                if (NFilas > 0)

                {

                    MessageBox.Show("Lo logramos");
                   

                }
                

            }
            catch (Exception ex)


            {
                MessageBox.Show("CREEME, HICISTE UN DISPARATE :" + ex);

            }


            {




            }
            

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}