using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

// Define el espacio de nombres "basededatos".

namespace basededatos
{


    // Define una clase parcial llamada "Form1" que hereda de "Form".

    public partial class Form1 : Form
    {
        // Define una conexión a SQL Server.

        SqlConnection conexion = new SqlConnection();

        // Define un comando SQL.

        SqlCommand comando = new SqlCommand();

        // Constructor de la clase.

        public Form1()
        {
            // Inicializa los componentes del formulario.

            InitializeComponent();

            // Establece la cadena de conexión para SQL Server.

            conexion.ConnectionString = @"Data Source=.;Initial Catalog=programacion01;" + "Integrated Security=True;TrustServerCertificate=true";
        }
        // Evento que se dispara cuando se carga el formulario.

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Evento que se dispara cuando se hace clic en el botón "btnInsertar".

        private void btnInsertar_Click(object sender, EventArgs e)

        

        {
            try

            {
                // Establece la conexión al comando.

                comando.Connection = conexion;

                // Establece el texto del comando SQL para insertar un alumno en la base de datos.

                comando.CommandText = "insert Into alumno(id,nombre) values(@txtId,@txtNombre)";

                // Abre la conexión a la base de datos.

                conexion.Open();

                // Limpia cualquier parámetro previo del comando.

                comando.Parameters.Clear();

                // Agrega los parámetros necesarios para el comando SQL.

                comando.Parameters.AddWithValue("txtId", txtId.Text);
                comando.Parameters.AddWithValue("txtNombre", txtNombre.Text);

                // Ejecuta el comando y devuelve el número de filas afectadas.

                int NFilas = comando.ExecuteNonQuery();

                // Si se afectaron filas, muestra un mensaje de éxito.

                if (NFilas > 0)

                {
                    //limpiar campos

                    MessageBox.Show("Lo logramos");
                    txtId.Clear();
                    txtNombre.Clear();

                }
                // Captura cualquier excepción que pueda ocurrir durante la ejecución.

            }
            catch (Exception ex)


            {
                MessageBox.Show("FALLÓ LA CONSULTA :" + ex);

            }
            

            { 
            
            
            
            
            }
            // Cierra la conexión y libera los recursos.

            conexion.Close();
            //conexion.Dispose();

            
        }
    }
}