using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaConsola
{
    internal class Inventario
    {
        public Articulo Producto { get; set; }
        public int Cantidad {  get; set; }

        public bool EstaDisponible()
        {
            return Cantidad > 0;
        }

        public bool DisminuirCantidad(int cantidadSolicitada)
        {
            if (Cantidad >= cantidadSolicitada)
            {
                Cantidad -= cantidadSolicitada;
                return true;
            }
            return false;
        }
    }
}
