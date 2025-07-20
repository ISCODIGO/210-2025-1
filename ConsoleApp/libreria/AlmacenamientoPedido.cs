using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace libreria
{
    internal class AlmacenamientoPedido
    {
        public static void empaquetar(string archivo, Pedido pedido)
        {
            string contenido = JsonSerializer.Serialize(pedido);
            using (var sw = new StreamWriter(archivo))
            {
                sw.Write(contenido);
            }
        }

        public static Pedido? desempaquetar(string archivo)
        {
            // leer el contenido y pasarlo a string
            string contenido;
            using (var sr = new StreamReader(archivo)) {
                contenido = sr.ReadToEnd();
            }

            try
            {
                var pedido = JsonSerializer.Deserialize<Pedido>(contenido);
                return pedido;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
