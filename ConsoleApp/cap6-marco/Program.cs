// See https://aka.ms/new-console-template for more information
Console.Write("Escriba una frase: ");
string frase = Console.ReadLine();

// Linea 1
Console.Write("+");
for (int i = 0; i < frase.Length + 2; i++)
{
    Console.Write("-");
}
Console.WriteLine("+");

// Linea 2
Console.WriteLine("| " + frase + " |");

// Linea 3
Console.Write("+");
for (int i = 0; i < frase.Length + 2; i++)
{
    Console.Write("-");
}
Console.WriteLine("+");