 void f()
{
    Console.Write("Escriba una palabra: ");
    string w = Console.ReadLine();

    if (w == "malo")
    {
        throw new Exception("Palabra invalida");
    }

}

try
{
    f();
} catch(Exception e)
{
    Console.WriteLine(e.ToString());
}