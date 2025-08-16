do 
{
    Console.WriteLine("Ingrese 3 números para saber cual es el mayor (CTRL + C para salir)\n");

    Console.Write("Ingrese el primer número: ");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.Write("Ingrese el segundo número: ");
    int n2 = int.Parse(Console.ReadLine()!);
    Console.Write("Ingrese el tercer número: ");
    int n3 = int.Parse(Console.ReadLine()!);


    if (n1 > n2 && n1 > n3)
    {
        Console.WriteLine($"El número mayor es: {n1}");
    }
    else if (n2 > n1 && n2 > n3)
    {
        Console.WriteLine($"El número mayor es: {n2}");
    }
    else if (n3 > n1 && n3 > n2)
    {
        Console.WriteLine($"El número mayor es: {n3}");
    }
    else if (n1 == n2 && n2 == n3)
    {
        Console.WriteLine("Los tres números son iguales, no se puede determinar un número mayor");
    }
    else if (n1 == n2 || n2 == n3 || n1 == n3)
    {
        Console.WriteLine("Hay al menos dos números iguales, no se puede determinar un número mayor.");
    }
} while (true);



