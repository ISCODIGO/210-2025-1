using System.Text.Json;
using libreria;

Libro libro = new Libro
{
    Nombre = "El Quijote de la Mancha",
    Autor = "Cervantes",
};



Console.WriteLine(libro);

string fulano = "Victor Ruiz";
Pedido pedido = new Pedido(fulano);

pedido.Solicitar(libro, 4);

Console.WriteLine(pedido);

string contenido = JsonSerializer.Serialize(pedido);
using (var sw = new StreamWriter("pedido.json"))
{
    sw.Write(contenido);
}