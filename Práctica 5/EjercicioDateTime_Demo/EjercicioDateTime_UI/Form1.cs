/* Pr�ctica 5.
   Asignatura: programaci�n orientada a eventos (pr�ctica - grupo 1).
   Estudiante: Jordi Haziel Amaya Mart�nez.*/

namespace EjercicioDateTime_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void validarFecha()
        {
            DateTime hoy = DateTime.Today;

            if (dateTimePicker1.Value.Date > hoy)
            {
                MessageBox.Show("Fecha inv�lida", " Error de ingreso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lblResultado.Text = ("No puedes seleccionar futura");
            }
            else if (dateTimePicker1.Value.Date.AddYears(18) <= hoy)
            {
                MessageBox.Show("Eres mayor de edad", "Confirmaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = ("Eres mayor de edad");
            }
            else
            {
                MessageBox.Show("Eres menor de edad", "Confirmaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblResultado.Text = ("Eres menor de edad");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarFecha();
        }
    }
}