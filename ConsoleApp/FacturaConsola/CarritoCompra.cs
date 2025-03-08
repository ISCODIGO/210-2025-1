using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaConsola
{
    internal class CarritoCompra
    {
        public string CodigoCompra { get; set; }
        public int Cantidad {  get; set; }
        public Articulo Producto { get; set; }
        private DateTime Instante {  get; set; }
        public Cliente Comprador { get; set; }
    }
}
