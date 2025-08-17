using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{

    Console.WriteLine("Ingrese dos números para saber si son múltiplos entre sí\n");
    Console.Write("Ingrese el primer número: ");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.Write("Ingrese el segundo número: ");
    int n2 = int.Parse(Console.ReadLine()!);

    if (n2 % n1 == 0)
    { 
        Console.WriteLine($"El número {n1}, es múltiplo de {n2}\n");
    }
    else
    {
        Console.WriteLine($"El número {n1}, no es múltiplo de {n2}.\n");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o ?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("\n:::::: Game Over ::::::");
