int[] arreglo1 = { 4, 1, 1, 4, 2, 3, 4, 4, 4, 4, 1, 2, 4, 9, 3, 1, 1, 1, 2, 1, 3, 1 };

int MasRepetido(int[] arr)
{
    int numeroRepetido = arr[0];
    int cantidadRepeticiones = 0;
    int maxRepeticiones = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                cantidadRepeticiones++;
            }

            // Se valor si es el mas repeticion hasta el momento o no
            if (cantidadRepeticiones > maxRepeticiones)
            {
                numeroRepetido = arr[i];
                maxRepeticiones = cantidadRepeticiones;
            }
        }
    }
    return numeroRepetido;
}

int[] SecuenciaMasLarga(int[] arr)
{
    int maxRepeticiones = 0;
    int inicio = 0;
    int fin = 0;
    int maxInicio = 0;
    int maxFin = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        inicio = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                fin = j;
            }
            else
            {
                break;
            }
        }

        int repeticionActual = fin - inicio + 1;
        if (repeticionActual > maxRepeticiones)
        {
            maxInicio = inicio;
            maxFin = fin;
            maxRepeticiones = repeticionActual;
        }

     
    }

    int[] resultado = new int[maxRepeticiones];
    int pos = 0;
    for (int k = maxInicio; k <= maxFin; k++)
    {
        resultado[pos++] = arr[k];
    }

    return resultado;
}



Console.WriteLine(MasRepetido(arreglo1));
int[] ints = SecuenciaMasLarga(arreglo1);
string res = String.Join(", ", ints);
Console.WriteLine(res);