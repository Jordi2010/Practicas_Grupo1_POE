using System.Data;
using System.Data.SqlClient;

namespace practica8_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creamos nuestra conexi�n a nuestra base de datos
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-N32N0PT\\SQLEXPRESS;Integrated Security=True; TrustServerCertificate=True");

        //creamos un m�todo para completar nuestras tablas
        public void completarTabla()
        {
            //creamos
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Abrimos la conexi�n
            conexion.Open();

            /*Vamos a crear las consultas de los txt que tenemos en nuestra ventana
             
            -Utilizaremos comillas dobles cuando es dato entero

            
            */
            string consulta = "INSERT INTO Empleados VALUES"+
                "("+txtId.Text+", '"+txtNombre.Text+"', '"+txtApellido.Text+"', '"+txtDireccion.Text+"')";

            //Creamos un objeto
            SqlCommand comando=new SqlCommand(consulta, conexion);

            //Para ejecutar nuestro comando
            comando.ExecuteNonQuery();

            //Mostramos un mensaje
            MessageBox.Show("Registro agregado");

            //Utilizamos los m�todos
            completarTabla();
            limpiarTabla();

            //Cerramos nuestra conexi�n
            conexion.Close();
        }
    }
}