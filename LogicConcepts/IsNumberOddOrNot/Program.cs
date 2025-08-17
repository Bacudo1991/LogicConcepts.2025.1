using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var number = ConsoleExtension.GetInt("Ingrese un número entero: ");
    if (number % 2 == 0)
    {
        Console.WriteLine($"El número {number}, es par.\n");
    }
    else
    {
        Console.WriteLine($"El número {number}, es impar.\n");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o ?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("\n:::::: Game Over ::::::\n");
