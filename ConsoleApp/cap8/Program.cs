// See https://aka.ms/new-console-template for more information

// declaracion de funcion
void saludar()
{
    // entrada -> mensaje
    // salida -> void (ninguna)

    string mensaje = "hola";

    Console.WriteLine(mensaje);
}

int sumar(int a, int b, out int total)
{
    total = a + b;
    return total;
}


// Llamado de la funcion
saludar();

int x = 10;
int y = 11;
int z = 100;

Console.WriteLine(sumar(x, y, out z));
Console.WriteLine(z);
