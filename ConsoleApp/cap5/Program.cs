// See https://aka.ms/new-console-template for more information

/*
 * Si el numero es par se suma un 1.
 * Si el numero es impar se multiplica por 3 y se suma 1.
 */

using System.Numerics;

int numero = 101;
int resultado;

if (numero % 2 == 0)
{
    resultado = numero + 1;
}
else
{
    resultado = 3 * numero + 1;
}

Console.WriteLine(resultado);
Console.WriteLine(numero);

// AND
bool v1  = true;
bool v2 = true;
bool salida;

if (v1)
{
    if (v2)
    {
        salida = true;
    } else
    {
        salida = false;
    }
} else
{
    salida = false;
}

Console.WriteLine(salida);


int nota = (int)Math.Round(33.0, 0);
string etiqueta;


if (nota < 0 || nota > 100)
{
    etiqueta = "ERR";
}
else if (nota ==  0)
{
    etiqueta = "NSP";
} 
else if (nota >= 1 && nota <= 20)
{
    etiqueta = "ABD";
} 
else if (nota < 65)
{
    etiqueta = "RPB";
}
else
{
    etiqueta = "APB";
}
Console.WriteLine(etiqueta);