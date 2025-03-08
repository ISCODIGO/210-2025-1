using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tareas.Clases;

namespace Tareas
{
    public partial class MainForm : Form
    {
        private ListaTarea listaTareas = new ListaTarea();

        public MainForm()
        {
            InitializeComponent();
            listaTareas = new ListaTarea();
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add(Tarea.EstadoTarea.PENDIENTE);
            cmbEstado.Items.Add(Tarea.EstadoTarea.COMPLETADO);
            cmbEstado.Items.Add(Tarea.EstadoTarea.VENCIDO);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaLimite = dtpFechaLimite.Value;
            listaTareas.Agregar(new Tarea(nombre, fechaLimite));
            ActualizarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                Tarea tarea = (Tarea)lstTareas.SelectedItem;
                listaTareas.Eliminar(tarea);
                ActualizarLista();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            Tarea tarea = listaTareas.BuscarPorNombre(nombre);
            if (tarea != null)
            {
                MessageBox.Show($"Tarea encontrada:\nNombre: {tarea.Nombre}\nEstado: {tarea.Estado}\nFecha Límite: {tarea.FechaLimite}");
            }
            else
            {
                MessageBox.Show("Tarea no encontrada.");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedItem != null)
            {
                Tarea.EstadoTarea estado = (Tarea.EstadoTarea)cmbEstado.SelectedItem;
                lstTareas.DataSource = listaTareas.FiltrarListaPorEstado(estado);
            }
        }

        private void ActualizarLista()
        {
            lstTareas.DataSource = null;
            lstTareas.DataSource = listaTareas.ObtenerTodas();
        }
    }
}
