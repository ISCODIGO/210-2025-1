// See https://aka.ms/new-console-template for more information
int[] numeros = new int[6];
numeros[0] = 10;
numeros[1] = 1;
numeros[2] = 100;
numeros[3] = 23;
numeros[4] = 4;
numeros[5] = 15;

for (int i = 0; i < numeros.Length; i++)
{
    if (i % 2 == 0)
    {
        numeros[i] = 0;
        //Console.WriteLine(numeros[i]);
    }
}

foreach (int i in numeros)
{
    Console.WriteLine(i);
}

// arreglo multidimensional 3x3
int[,] matriz1 = new int[3,3];
//matriz1[1, 1] = 100;

// arreglo de arreglos
int[][] tabla = new int[4][];
tabla[0] = new int[3];
tabla[1] = new int[2];
tabla[2] = new int[1];
tabla[3] = new int[3];
tabla[3][1] = 23;