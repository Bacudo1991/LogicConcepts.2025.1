var numberString = string.Empty;
do
{
    Console.Write("Ingrese un numero o 'S' para salir: ");
    numberString = Console.ReadLine();
    if (numberString == "S" || numberString == "s")
    {
        break;
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


