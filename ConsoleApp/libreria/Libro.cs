using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    internal class Libro
    {
        public string Nombre { get; set; }
        public string Autor {  get; set; }

        public int Paginas { get; set; }

        public Libro()
        {

        }

        public Libro(string nombre, string autor)
        {
            Nombre = nombre;
            Autor = autor;

            Random random = new Random();
            Paginas = random.Next(100, 501);  // 100 y 500
        }

        public override string ToString()
        {
            return $"{Nombre} - {Autor} ({Paginas})";
        }
    }
}
