using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImportarCSV
{
    public partial class formImpCSV : Form
    {
        public formImpCSV()
        {
            InitializeComponent();
        }

        private void btImportarCSV_Click(object sender, EventArgs e)
        {
            string separador = txtSeparador.Text;
            if(separador == "")
            {
                MessageBox.Show("Debe indicar el separador de columna " + "CSC. Se separa por comas o puntos y comas ", "Fichero CSV Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSeparador.Focus();
            }
            else
            {
                OpenFileDialog selCSV = new OpenFileDialog();
                selCSV.InitialDirectory = "C:\\";
                selCSV.Filter = "CSV (*.csv)|*.csv| Todos los archivos (*.*)|*.*";
                selCSV.FilterIndex = 1;
                selCSV.RestoreDirectory = true;
                if (selCSV.ShowDialog() == DialogResult.OK)
                {
                    string ficheroCSV = selCSV.FileName;
                    //Establecer las propiedades de listView
                    lsCSV.View = View.Details;
                    lsCSV.GridLines = true;
                    lsCSV.FullRowSelect = true;
                    lsCSV.Items.Clear();

                    try
                    {
                        //Obtener la codificación de nuestro fichero
                        Encoding codificacion = Encoding.UTF8;
                        if (lsCodificacion.Text == "UTF-8")
                            codificacion = Encoding.UTF8;

                        //Recorremos todas las filas del fichero CSV
                        var lineasCSV = File.ReadLines(ficheroCSV, codificacion);

                        //Comprobamos que el fichero no esté vacío
                        if (lineasCSV.Count() == 0)
                            MessageBox.Show($"El fichero CSV seleccionado [{ficheroCSV}] está vacío", "Intente con otro archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            string valorActual = "";

                            //Si tomamos la primera fila como título
                            if (opTitulos.Checked)
                            {
                                var lineaTitulo = File.ReadLines(ficheroCSV, codificacion).First();

                                string[] columnasTitulos = lineaTitulo.Split(Convert.ToChar(separador));

                                //Añadimos las columnas a nuestro ListView
                                for (int i = 0; i<columnasTitulos.Count(); i++)
                                {
                                    if (opComillas.Checked)
                                        valorActual = columnasTitulos[i].Trim(Convert.ToChar(lsComillas.Text));
                                    else
                                        valorActual = columnasTitulos[i];
                                    lsCSV.Columns.Add(valorActual);
                                }
                            }

                            int numLinea = 0;
                            foreach(string lineaActual in lineasCSV)
                            {
                                numLinea++;
                                if (opTitulos.Checked && numLinea == 1)
                                    continue;

                                string[] columnasLineasCSV = lineaActual.Split(Convert.ToChar(separador));
                                if (opComillas.Checked)
                                    valorActual = columnasLineasCSV[0].Trim(Convert.ToChar(lsComillas.Text));
                                else
                                    valorActual = columnasLineasCSV[0];
                                ListViewItem filasListView = new ListViewItem(valorActual);
                                for(int i = 1; i<columnasLineasCSV.Count(); i++)
                                {
                                    if (opComillas.Checked)
                                        filasListView.SubItems.Add(columnasLineasCSV[i].Trim(Convert.ToChar(lsComillas.Text)));
                                    else
                                        filasListView.SubItems.Add(columnasLineasCSV[i]);
                                }
                                lsCSV.Items.Add(filasListView);
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Error al leer nuestro fichero CSV: {error.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
