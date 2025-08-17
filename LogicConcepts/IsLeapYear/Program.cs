do
{    
    Console.WriteLine("Ingrese un año para saber si es bisiesto\n");
    Console.Write("Ingrese el año: ");
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    int year = int.Parse(Console.ReadLine()!);
    if (year == currentYear)
    {
        message = "es";
    }
    else if (year < currentYear)
    {
        message = "fue";
    }
    else
    {
        message = "será";
    }
    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    {
        Console.WriteLine($"El año {year}, {message} un año bisiesto.\n");
    }
    else
    {
        Console.WriteLine($"El año {year}, no {message} un año bisiesto.\n");
    }
    Console.WriteLine("Si desea salir presione CTRL + C\n");
} while (true);