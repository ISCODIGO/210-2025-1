const string ARCHIVO = "prueba.txt";
bool prueba = File.Exists(ARCHIVO);
Console.WriteLine(prueba);

//File.Create("prueba.txt");  // bin/Debug/net8.0/


/*byte[] bs = File.ReadAllBytes(ARCHIVO);

foreach (byte b in bs )
{
    Console.Write(b);
    Console.Write(" ");
}*/

/*
File.WriteAllText(ARCHIVO, "Esto es contenido\ndesde el programa\n");

for (int i = 0; i < 10; i++)
{
    File.AppendAllText(ARCHIVO, $"{i}\n");
}

string s = File.ReadAllText(ARCHIVO);
Console.WriteLine(s);
*/

const string ARCHIVO_GRANDE = "C:\\Users\\enrique\\Downloads\\mbox.txt";

// Lee todo el contenido de una sola vez
// Esto significa un uso significativo de la memoria principal.

//var contenido = File.ReadAllText(ARCHIVO_GRANDE);
//Console.WriteLine(contenido);

StreamReader sr = new StreamReader(ARCHIVO_GRANDE);

/*string line;
while ((line = sr.ReadLine()) != null)
{
    Console.WriteLine(line);
}*/

int caracter;
int conteo = 0;
char[] buffer = new char[4096];
int inicio = 0;
int fin = buffer.Length;
do
{
    caracter = sr.Read(buffer, inicio, fin);
    conteo++;
    Console.WriteLine(conteo);
    if (caracter < 0)
    {
        Console.WriteLine("FINAL DE LINEA -------------------------");
    }
    inicio = fin + 1;
    fin += buffer.Length; 
} while (caracter < 0);

Console.WriteLine($"Hay {conteo} caracteres");
