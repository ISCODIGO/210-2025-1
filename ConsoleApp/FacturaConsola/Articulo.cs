using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaConsola
{
    internal class Articulo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Usado { get; set; }

        public readonly int x = 10;

        public Articulo()
        {
            this.x = 20;
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

    }
}
