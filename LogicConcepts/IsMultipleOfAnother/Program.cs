do
{

    Console.WriteLine("Ingrese dos números para saber si son múltiplos entre sí\n");
    Console.Write("Ingrese el primer número: ");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.Write("Ingrese el segundo número: ");
    int n2 = int.Parse(Console.ReadLine()!);

    if (n2 % n1 == 0)
    { 
        Console.WriteLine($"{n1} es múltiplo de {n2}\n");
    }
    else
    {
        Console.WriteLine($"{n1} no es múltiplo de {n2}.\n");
    }
    Console.WriteLine("Si desea salir presione CTRL + C\n");
} while (true);
