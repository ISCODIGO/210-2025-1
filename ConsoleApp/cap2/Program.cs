// See https://aka.ms/new-console-template for more information
//Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Hello, World!");
//Console.ForegroundColor = ConsoleColor.Black;
//Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Clase de Programacion II");
//Console.ReadKey();

int x = int.MaxValue;
++x;
Console.WriteLine(x);
Console.WriteLine(int.MinValue);
int  y = int.MinValue;
--y;
Console.WriteLine(y);
Console.WriteLine(int.MaxValue);

Console.WriteLine(uint.MaxValue);

Console.WriteLine(0.1m + 0.2m);

float altura = 10.3f;
double anchura = 5.636564566566556;

float area = (float)(altura * anchura);
Console.WriteLine("El area es: " + area);
Console.WriteLine(altura * anchura);

Console.WriteLine((int)area);
int z = -10;
Console.WriteLine((uint)z);

Console.WriteLine((int)'a');
Console.WriteLine((int)'A');
Console.WriteLine((char)100);

Console.WriteLine(z.CompareTo(10));
Console.WriteLine(z.CompareTo(-20));
Console.WriteLine(z.CompareTo(-10));
// Convertir un entero a string
Console.WriteLine("" + 1);
Console.WriteLine((1).ToString());

// Convertir un string a entero
Console.WriteLine(int.Parse("100") + 3);
int numero;
int.TryParse("abc", out numero);
numero++;
Console.WriteLine(numero);

// Conversion implicita (widening)
byte b = 10;
int entero = b;

// Conversion explicita (narrowing): perdida de datos
long longVar = (long)int.MaxValue + 1;
float floatVar = longVar;  // float (32b), long (64b)

longVar = (long)floatVar;

