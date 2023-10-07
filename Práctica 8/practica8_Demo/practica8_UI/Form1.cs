//Utilizamos nuestras extensiones
using System.Data;
using System.Data.SqlClient;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;

namespace practica8_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creamos nuestra conexión a nuestra base de datos
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-N32N0PT\SQLEXPRESS;Initial Catalog=Empresa;Integrated Security=True;TrustServerCertificate=True");

        //creamos un método para completar nuestras tablas
        public void completarTabla()
        {
            //Creamos la consulta
            string consulta = "SELECT * FROM Empleados";
            //Creamos el adaptador
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
            //Creamos nuestra tabla virtual
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDato.DataSource = dt;
        }

        //Creamos un método que limpie las tablas cada vez que realicemos un evento
        public void limpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            //
            txtId.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creamos la consulta
            string consulta = "SELECT * FROM Empleados";
            //Creamos el adaptador
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
            //Creamos la tabla virtual
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDato.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Abrimos la conexión
            conexion.Open();

            /*Vamos a crear las consultas de los txt que tenemos en nuestra ventana
             
            -Utilizaremos comillas dobles cuando es dato entero
            -comillas enteras cuando es string*/
            string consulta = "INSERT INTO Empleados VALUES " +
                "(" + txtId.Text + ", '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "')";

            //Creamos un objeto de SQL command que nos permitirá ejecutar consultas de la base de datos
            SqlCommand comando = new SqlCommand(consulta, conexion);

            //Para ejecutar nuestro comando
            comando.ExecuteNonQuery();

            //Mostramos un mensaje
            MessageBox.Show("Registro agregado");

            //Utilizamos los métodos
            completarTabla();
            limpiarCampos();

            //Cerramos nuestra conexión
            conexion.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Abrimos conexión
            conexion.Open();
            //Implementamos la consulta
            string consulta = "UPDATE Empleados " +
                "SET Nombre='" + txtNombre.Text + "', Apellido='" + txtApellido.Text + "', Direccion='" + txtDireccion.Text + "' WHERE idEmpleado=" + txtId.Text + "";
            //Ejecutamos la consulta
            SqlCommand comando = new SqlCommand(consulta, conexion);
            //Creamos la condicional
            int cantidad;
            cantidad = comando.ExecuteNonQuery();
            if (cantidad > 0)
            {
                MessageBox.Show("Registro Actualizado");
            }
            //Llamamos los métodos
            completarTabla();
            limpiarCampos();
            //cerramos la conexión
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Abrimo la conexión
            conexion.Open();

            //Creamos un objeto de SQL command que nos permitirá ejecutar consultas de la base de datos pa
            string consulta = "DELETE FROM Empleados WHERE idEmpleado =" + txtId.Text + "";
            //Para ejecutar nuestro comando
            SqlCommand comando = new SqlCommand(consulta, conexion);
            //Para ejecutar nuestro comando
            comando.ExecuteNonQuery();
            //Mostramos un mensaje
            MessageBox.Show("Registro Eliminado");
            //Mandamos a llamar los métodos
            completarTabla();
            limpiarCampos();
            //Cerramos conexión
            conexion.Close();
        }

        private void dataGridViewDato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento que nos selecciona todas las casillas
            txtId.Text = dataGridViewDato.SelectedCells[0].Value.ToString();
            txtNombre.Text = dataGridViewDato.SelectedCells[1].Value.ToString();
            txtApellido.Text = dataGridViewDato.SelectedCells[2].Value.ToString();
            txtDireccion.Text = dataGridViewDato.SelectedCells[3].Value.ToString();
        }
    }
}