do
{
    
    Console.WriteLine(":::::: Ingrese 3 números diferentes ::::::\n");
    
    
    Console.Write("Ingrese el primer número : ");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.Write("Ingrese el segundo número: ");
    int n2 = int.Parse(Console.ReadLine()!);
    Console.Write("Ingrese el tercer número : ");
    int n3 = int.Parse(Console.ReadLine()!);

    if (n1 == n2 || n2 == n3 || n1 == n3)
    {
        Console.WriteLine("Los números deben ser diferentes. Intente de nuevo.\n");
        continue;
    }else if (n1 > n2 && n1 > n3)
    {
        if (n2 > n3)
        {
            Console.WriteLine($"El mayor es {n1}, el medio es {n2}, el menor es {n3}\n");
        }
        else
        {
            Console.WriteLine($"El mayor es {n1}, el medio es {n3}, el menor es {n2}\n");
        }
    }
    else if (n2 > n1 && n2 > n3)
    {
        if (n1 > n3)
        {
            Console.WriteLine($"El mayor es {n2}, el medio es {n1}, el menor es {n3}\n");
        }
        else
        {
            Console.WriteLine($"El mayor es {n2}, el medio es {n3}, el menor es {n1}\n");
        }
    }
    else
    {
        if (n1 > n2)
        {
            Console.WriteLine($"El mayor es {n3}, el medio es {n1}, el menor es {n2}\n");
        }
        else
        {
            Console.WriteLine($"El mayor es {n3}, el medio es {n2}, el menor es {n1}\n");
        }
    }
    Console.WriteLine("Si desea salir presione CTRL + C\n");
} while (true);


