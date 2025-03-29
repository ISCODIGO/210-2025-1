// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Escriba dos numeros para dividir: ");
    int valor = Convert.ToInt32(Console.ReadLine());
    int otro = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(valor / otro);

    int[] ints = { 10, 20, 30 };
    Console.Write("Elegir un indice: ");
    int indice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(ints[indice]);

}
catch(FormatException)
{
    Console.WriteLine("Escriba un numero valido");
}
catch(ArithmeticException)
{
    Console.WriteLine("El segundo numero debe ser distinto a cero");
}
catch (Exception e)
{
    Console.WriteLine(e);
}




Console.WriteLine("Programa terminado");