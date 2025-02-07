public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Escriba N: ");
        string linea = Console.ReadLine();
        int N; 
        int.TryParse(linea, out N);

        Console.WriteLine("Ejercicio 1");
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Ejercicio 2");
        int j = 1;
        while (j <= N)
        {
            if (j % 21 != 0)
            {
                Console.WriteLine(j);
            }
            j++;
        }

        Console.WriteLine("Ejercicio 5");
        int penultimo = 0;
        int ultimo = 1;
        int total = 1;

        for (int i = 2; i <= N; i++)
        {
            int fibo = penultimo + ultimo;
            penultimo = ultimo;
            ultimo = fibo;
            total += fibo;
        }

        Console.WriteLine("El valor " + N + " de fibonacci es " + total);
    }
}