using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ManejoFicherosWinForms
{
    public partial class Form1 : Form
    {
        private string rutaArchivo = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog1.FileName;
                lblRuta.Text = rutaArchivo;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                MessageBox.Show("Seleccione un archivo primero.");
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    Stopwatch stopwatch = new Stopwatch();
                    sw.Write(txtContenido.Text);
                    stopwatch.Stop();
                    MessageBox.Show($"Escritura usando StreamWriter: {stopwatch.ElapsedMilliseconds} ms");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnLeerLinea_Click(object sender, EventArgs e)
        {
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            Stopwatch sw = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                while (!sr.EndOfStream)
                {
                    sb.AppendLine(sr.ReadLine());
                }
            }

            sw.Stop();
            txtContenido.Text = sb.ToString();
            MessageBox.Show($"ReadLine(): {sw.ElapsedMilliseconds} ms");
        }

        private void btnLeerTodo_Click(object sender, EventArgs e)
        {
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            Stopwatch sw = Stopwatch.StartNew();
            string contenido = File.ReadAllText(rutaArchivo);
            sw.Stop();

            txtContenido.Text = contenido;
            MessageBox.Show($"ReadToEnd(): {sw.ElapsedMilliseconds} ms");
        }

        private void btnLeerCaracter_Click(object sender, EventArgs e)
        {
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            Stopwatch sw = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                while (sr.Peek() != -1)
                {
                    sb.Append((char)sr.Read());
                }
            }

            sw.Stop();
            txtContenido.Text = sb.ToString();
            MessageBox.Show($"Lectura carácter por carácter: {sw.ElapsedMilliseconds} ms");
        }

        private void btnFile_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                MessageBox.Show("Seleccione un archivo primero.");
                return;
            }

            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                File.WriteAllText(rutaArchivo, txtContenido.Text);
                sw.Stop();
                MessageBox.Show($"Escritura usando File: {sw.ElapsedMilliseconds} ms");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }
    }
}
