using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_11
{
    internal class ListaTarea
    {
        List<Tarea> listaTareas;

        // Crear funciones de agregar, eliminar y buscar
        public void Agregar(Tarea tarea)
        {
            listaTareas.Add(tarea);
        }

        public bool Eliminar(Tarea tarea)
        {
            return listaTareas.Remove(tarea);
        }

        public Tarea Buscar(string nombre)
        {
            foreach (Tarea t in listaTareas)
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
            foreach (Tarea t in listaTareas)
            {
                if (t.Estado == estado)
                {
                    lista.Add(t);
                }
            }

            return lista;
        }
    }
}
