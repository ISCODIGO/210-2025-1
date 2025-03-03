using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tareas.Clases;

namespace Tareas.Clases
{
    internal class ListaTarea
    {
        List<Tarea> tareas;

        public ListaTarea()
        {
            tareas = new List<Tarea>();
        }

        // Crear funciones de agregar, eliminar y buscar
        public void Agregar(Tarea tarea)
        {
            tareas.Add(tarea);
        }

        public bool Eliminar(Tarea tarea)
        {
            return tareas.Remove(tarea);
        }

        public Tarea Buscar(string nombre)
        {
            foreach (Tarea t in tareas)
            {
                if (t.Nombre.Contains(nombre))
                {
                    return t;
                }

            }

            return null;
        }

        public List<Tarea> ListaPorEstado(Tarea.EstadoTarea estado)
        {
            List<Tarea> lista = new List<Tarea>();
            foreach (Tarea t in tareas)
            {
                if (t.Estado == estado)
                {
                    lista.Add(t);
                }
            }

            return lista;
        }
        public List<Tarea> ObtenerTodas()
        {
            return tareas;
        }
    }
}
