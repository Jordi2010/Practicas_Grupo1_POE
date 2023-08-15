/*Práctica 2 - Grupo 1
  Asignatura: Programación orientada a eventos.    Sección: "A".
  Estudiante: Jordi Haziel Amaya Martínez.*/

//extensiones utilizadas (algunas).
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//nombre del proyecto.
namespace Practica2UI
{
    public partial class Form1 : Form
    {
        //inicializando formulario.
        public Form1()
        {
            InitializeComponent();
        }

        //"PROBLEMA 1"
        private void button1_Click(object sender, EventArgs e)
        {
            /*tomar etiqueta y asignarle un cambio en el contenido mediante el evento click del botón.
            (El label siempre es .Text)*/
            label1.Text = "Antes del evento";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //tomar etiqueta y asignarle un cambio en el contenido mediante el evento click del botón.
            label1.Text = "Después del evento";
        }

        //"PROBLEMA 2"
        private void button3_Click(object sender, EventArgs e)
        {
            /*modificando el panel para que cambie de color aleatoriamente con backColor y propiedad
            Color.FromArgb cambiamos de color y con new random le generamos un color aleatorio.
            .Next asignamos valor siguiente.*/
            Random random = new Random();
            panel1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256), random.Next(256));
        }

        //"PROBLEMA 3" - Ejercicio de la práctica
        //creando e inicializando un contador en 0 para controlar las imágenes (posición) a mostrar.
        int contador = 0;
        //añadiendo el evento del botón "Siguiente" al presionarlo.
        private void button5_Click(object sender, EventArgs e)
        {
            //evalúa si puede pasar a las imágenes siguientes (por su número de posición).
            if (contador < 2)
            {
                //cuenta y suma el número de posición de las imagénes.
                contador++;
            }
            //muestra en el pictureBox la imagen de la posición que tiene el contador.
            pictureBox1.Image = imageList1.Images[contador];
        }
        //añadiendo el evento del botón "Anterior" al presionarlo.
        private void button4_Click(object sender, EventArgs e)
        {
            //evalúa si puede retroceder a las imágenes anteriores (por su número de posición).
            if (contador > 0)
            {
                //cuenta y resta el número de posición de las imagénes.
                contador--;
            }
            //muestra en el pictureBox la imagen de la posición que tiene el contador.
            pictureBox1.Image = imageList1.Images[contador];
        }
    }
}
