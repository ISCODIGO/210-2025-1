using System.Text.Json;
using libreria;

Libro libro = new Libro
{
    Nombre = "El Quijote de la Mancha",
    Autor = "Cervantes",
};

string fulano = "Victor Ruiz";
string archivo_json = $"{fulano}.json";
/*Pedido pedido = new Pedido(fulano);
pedido.Solicitar(libro, 4);

AlmacenamientoPedido.empaquetar(archivo_json, pedido);
*/

var pedidoAlmacenado = AlmacenamientoPedido.desempaquetar(archivo_json);

Console.WriteLine(pedidoAlmacenado);


