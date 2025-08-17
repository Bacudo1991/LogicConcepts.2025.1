using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = ConsoleExtension.GetString("Ingrese el nombre......................: ");
    var workedHours = ConsoleExtension.GetFloat("Ingrese el número de horas trabajadas..: ");
    var hourlyRate = ConsoleExtension.GetDecimal("Ingrese el valor por hora..............: ");
    var minimumWage = ConsoleExtension.GetDecimal("Ingrese el salario mínimo mensual......: ");
    
    var salary = (decimal)workedHours * hourlyRate;
    if (salary < minimumWage)
    {
        Console.WriteLine($"Nombre.................................: {name}");
        Console.WriteLine($"Salario...........................: {minimumWage:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre.................................: {name}");
        Console.WriteLine($"Salario................................: {salary:C2}");
    }

    do
    { 
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o ?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("\n:::::: Game Over ::::::");