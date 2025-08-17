using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

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
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o ?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");
