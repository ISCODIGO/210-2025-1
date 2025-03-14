using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaConsola
{
    internal class CarritoCompra
    {
        public enum Estado
        {
            CREADO, FACTURADO, NO_FACTURADO
        }
        
        public string CodigoCompra { get; set; }
        public List<Articulo> Productos { get; set; }
        private DateTime InstanteCreacion {  get; set; }
        private DateTime InstanteCompra { get; set; }
        private decimal Total {  get; set; }
        private decimal SubTotal { get; set; }
        private decimal Impuesto { get; set; }



        public CarritoCompra()
        {
            Productos = new List<Articulo>();
            InstanteCreacion = DateTime.Now;
        }

        public bool AgregarProducto(Articulo articulo, int cantidad)
        {
            if (articulo == null) return false;
            if (cantidad <= 0) return false;

            for (int i = 0; i < cantidad; i++)
            {
                Productos.Add(articulo);
                SubTotal += articulo.Precio;
                Impuesto += articulo.GetImpuesto();
                Total += SubTotal + Impuesto;
            }

            return true;
        }

        public bool EliminarProducto(Articulo articulo)
        {
            return Productos.Remove(articulo);
        }

        public void Comprar()
        {

        }
    }
}
