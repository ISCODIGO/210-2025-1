using System.Diagnostics;

void saludar(string nombre, int hora)
{

    // 6 a 11 Buenos dias
    if (hora >= 6 && hora <= 11)
    {
        Console.Write("Buenos dias ");
    }
    // 12 a 18 Buenas tardes
    else if (hora >= 12 && hora <= 18)
    {
        Console.Write("Buenas tardes ");
    }
    // 19 a 5 Buenas noches
    else if ((hora >= 19 && hora <= 23) || (hora >= 0 && hora <= 5))
    {
        Console.Write("Buenas noches");
    }
    else
    {
        Console.WriteLine("ERROR");
        return;
    }

    Console.WriteLine(nombre);
}


saludar("Jose", 8);
saludar("Ana", 12);
saludar("Pedro", 15);
saludar("Beatriz", 20);
saludar("Tomas", 3);


bool esBisiesto(int anio) {
    if (anio % 400 == 0)
    { 
        return true;
    } else if (anio % 100 == 0)
    {
        return false;
    } else if (anio % 4 == 0)
    {
        return true;
    }

    return false;
}

Console.WriteLine(esBisiesto(2004));
Console.WriteLine(esBisiesto(2000));
Console.WriteLine(esBisiesto(1900));
Console.WriteLine(esBisiesto(2024));
Console.WriteLine(esBisiesto(2023));
Console.WriteLine(esBisiesto(2025));
