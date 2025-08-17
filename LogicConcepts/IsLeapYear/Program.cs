do
{
    Console.WriteLine("Ingrese un año para saber si es bisiesto\n");
    Console.Write("Ingrese el año: ");
    int year = int.Parse(Console.ReadLine()!);
    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    {
        Console.WriteLine($"{year} es un año bisiesto.\n");
    }
    else
    {
        Console.WriteLine($"{year} no es un año bisiesto.\n");
    }
    Console.WriteLine("Si desea salir presione CTRL + C\n");
} while (true);