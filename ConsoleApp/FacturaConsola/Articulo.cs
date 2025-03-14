using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaConsola
{
    internal class Articulo
    {
        public const decimal ISV = 15m;
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Usado { get; set; }
        public bool EsGravable { get; set; }

        public Articulo()
        {

        }

        private decimal _precio;
        public decimal Precio { 
            get
            {
                return _precio;
            } 
            set
            {
                if (value <= 0) value = 1m;
                _precio = value;
            }
        }

        public decimal GetImpuesto()
        {
            if (EsGravable)
            {
                return Precio * ISV / 100;
            }
            else
            {
                return 0m;
            }
        }

    }
}
