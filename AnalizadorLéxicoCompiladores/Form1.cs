using AnalizadorLéxicoCompiladores.AnalisisSintactico;
using AnalizadorLéxicoCompiladores.Transversal;
using System;
using System.IO;
using System.Windows.Forms;

namespace AnalizadorLéxicoCompiladores
{
    public partial class Form1 : Form
    {
        public Form1()
        {          
            InitializeComponent();
            groupBoxConsola.Hide();            
        }

        private void radioButtonArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConsola.Focused)
            {
                groupBoxArchivo.Hide();
                groupBoxConsola.Show();
            }
            if (radioButtonArchivo.Focused)
            {
                groupBoxConsola.Hide();
                groupBoxArchivo.Show();  
            }
        }

        private void LabelSeleccionarArchivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {                     
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Cursor Files|*.txt";
            openFileDialog.Title = "Select a cursor file";            
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Archivo archivo = Archivo.obtenerInstancia();
                archivo.LimpiarLineas();
                TablaSimbolos.ObtenerInstancia().limpiar();
                string ruta = openFileDialog.FileName;
                textBoxSeleccionArchivo.Text = ruta;
                StreamReader streamReader = new StreamReader(ruta, false);                
                string linea = "";
                int nroLinea = 0;
                Linea line;
                while (linea != null)
                {
                    linea = streamReader.ReadLine();
                    nroLinea++;
                    if (linea != null)
                    {                        
                        line=new Linea();
                        line.contenido = linea;
                        line.numeroLinea = nroLinea;
                        archivo.agregarLinea(line);
                    }
                }
                cargarSalida(archivo);
                streamReader.Close();
            }            
        }
        private void cargarSalida(Archivo archivo)
        {
            string contenido = "";
            int i = 1;
            while(archivo.obtenerLinea(i).contenido!="@EOF@")
            {
                contenido = contenido + "Linea " +i + " --> " + archivo.obtenerLinea(i).contenido + Environment.NewLine;
                i = i + 1;
            }
            textBoxCarga.Text = contenido;
        }

        private void buttonCargarConsola_Click(object sender, EventArgs e)
        {
            Archivo archivo = Archivo.obtenerInstancia();
            archivo.LimpiarLineas();
            TablaSimbolos.ObtenerInstancia().limpiar();
            ManejadorDeErrores.obtenerManejadorDeErrores().limpiarManejador();
            string[] lineas = textBoxConsola.Text.Split('\n');
            String cadena = "";
            foreach (String var in lineas)
            {
                cadena += var;
            }
            lineas = null;
            lineas = cadena.Split('\r');  //cambio que le hicmos 
            Linea line;

            int i = 1;
            foreach(string linea in lineas)
            {
                line = new Linea();
                line.contenido = linea;
                line.numeroLinea = i;
                i++;
                archivo.agregarLinea(line);
            }
            cargarSalida(archivo);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           /* AnalisisLexico.analizadorLexico analex = new AnalisisLexico.analizadorLexico();
            ComponenteLexico comp = analex.analizar();
            if (comp != null)
            {
                while (!"FIN DE ARCHIVO".Equals(comp.Categoria))
                {
                    comp = analex.analizar();
                }
            }
            simbolosTabla tabla = new simbolosTabla();
            tabla.Show();*/
            AnalizadorSintactico anasin = new AnalizadorSintactico();
            anasin.analizar();
            simbolosTabla tabla = new simbolosTabla();
            tabla.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            simbolosTabla tabla = new simbolosTabla();
            tabla.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTablaErrores tablaError = new FormTablaErrores();
            tablaError.Show();
        }
    }
}
