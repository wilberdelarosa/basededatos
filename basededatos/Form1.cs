using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
//using System.Data.SqlClient;
//using System.Linq.Expressions;
//using System.Linq.Expressions;

namespace basededatos
{



    public partial class Form1 : Form
    {

        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            conexion.ConnectionString = @"Data Source=LAPTOP-7GVN0B6N\SQLEXPRESS;Initial Catalog=programacion;Integrated Security=True";
        }


        

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try

            {
                comando.Connection = conexion;
                comando.CommandText = "insert Into alumno(id, nombre) values(@txtId, @txtNombre)";
                conexion.Open();
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("txtId", txtId.Text);
                comando.Parameters.AddWithValue("txtNombre", txtNombre.Text);


                int NFilas = comando.ExecuteNonQuery();
                if (NFilas > 0)

                {

                    MessageBox.Show(" Lo logramos");

                }

            }   catch (Exception ex)

            {
                MessageBox.Show("FALLÓ LA CONSULTA :" + ex);

            }


            conexion.Close();
            conexion.Dispose();

            
        }
    }
}