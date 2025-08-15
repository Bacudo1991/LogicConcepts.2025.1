var numberString = string.Empty;
do
{
    Console.Write("Ingrese un numero o 'S' para salir: ");
    numberString = Console.ReadLine();
    if (numberString == "S" || numberString == "s")
    {
        break;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numberInt}, es par"); // El simbolo de interpolación $ permite incluir variables directamente en la cadena.
        }
        else
        {
            Console.WriteLine($"El numero {numberInt}, es impar");
        }
    }
    else
    {
        Console.WriteLine($"El valor ingresado: {numberString} no es un numero entero."); 
    }
} while (numberString != "S" && numberString != "s");
Console.WriteLine(":::::: GAME OVER ::::::");


