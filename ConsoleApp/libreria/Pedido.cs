using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    internal class Pedido
    {
        public Libro LibroPedido { get; set; }
        public string Cliente { get; set; }
        public DateTime InstantePrestamo { get; set; }
        public int Dias {  get; set; }

        public Pedido(string cliente)
        {
            Cliente = cliente;
        }

        public override string ToString()
        {
            return $"Libro: {LibroPedido}\nCliente: {Cliente}\nSolicitado por {Dias} dias";
        }

        public void Solicitar(Libro libro, int dias)
        {
            LibroPedido = libro;
            Dias = dias;
            InstantePrestamo = DateTime.Now;
        }
    }
}
