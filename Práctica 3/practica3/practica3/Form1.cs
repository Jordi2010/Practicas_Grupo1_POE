/*Práctica 3 - Grupo 1
  Asignatura: Programación orientada a eventos.    Sección: "A".
  Estudiante: Jordi Haziel Amaya Martínez.*/

//extensiones utilizadas (algunas).
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//nombre del proyecto.
namespace practica3
{
    public partial class Form1 : Form
    {
        //inicializando formulario.
        public Form1()
        {
            InitializeComponent();
        }

        //"PROBLEMA 1"
        //private bool img = true;
        private void button1_Click(object sender, EventArgs e)
        {
            //utilizar la clase OpenFileDialog para visualizar la ventana.
            OpenFileDialog abrir = new OpenFileDialog();
            //filtro para abrir imagenes jpg y bmp (son las terminaciones las que se filtran y buscan).
            abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP) |*.BMP ";
            /*validar ventana y mostrarla.
            showDialog abre una ventana, el if valida nuestra respuesta en la ventana.*/
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                /*validaciones sobre ventana img.
                obteniendo la ruta de la imagen y el nombre del archivo.*/
                pictureBox1.Image = Image.FromFile(abrir.FileName);
            }
        }

        //"PROBLEMA 2"
        //inicializar el estado de la imagen.
        private bool isImg = true;
        /*¡ ¡ ¡ NOTA ! ! ! -> cambiar las rutas de ubicación del PROBLEMA 2 y 3 a las del usuario que
        tenga este archivo para que funcione (la 1ra ruta "comentada" es de la carpeta agregada a la
        solución, la 2da ruta es de la carpeta del archivo del proyecto)*/
        private void button2_Click(object sender, EventArgs e)
        {
            if (isImg)
            {
                //cambia el pictureBox a la imagen 1
                //pictureBox2.Image = Image.FromFile("C:\\Users\\CDS2\\Downloads\\img1.jpg");
                pictureBox2.Image = Image.FromFile("C:\\Users\\jordi\\OneDrive\\Escritorio\\practica3\\practica3\\img\\img1.jpg");
                isImg = false;
            }
            else
            {
                //cambia el pictureBox a la imagen 2
                //pictureBox2.Image = Image.FromFile("C:\\Users\\CDS2\\Downloads\\img2.jpg");
                pictureBox2.Image = Image.FromFile("C:\\Users\\jordi\\OneDrive\\Escritorio\\practica3\\practica3\\img\\img2.jpg");
                isImg = true;
            }
        }

        //"PROBLEMA 3" - Ejercicio de la práctica
        //creando una variable que controla el cambio de imágenes del ejercicio.
        private bool changeImg = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (changeImg)
            {
                //después de 2 segundo cambia el pictureBox a la imagen 1
                pictureBox3.Image = Image.FromFile("C:\\Users\\jordi\\OneDrive\\Escritorio\\practica3\\practica3\\img\\img1.jpg");
                changeImg = false;
            }
            else
            {
                //después de 2 segundo cambia el pictureBox a la imagen 2
                pictureBox3.Image = Image.FromFile("C:\\Users\\jordi\\OneDrive\\Escritorio\\practica3\\practica3\\img\\img2.jpg");
                changeImg = true;
            }
        }
    }
}
