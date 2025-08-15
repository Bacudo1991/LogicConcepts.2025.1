do
{
    int n1, n2, n3;
    Console.WriteLine(":::: Ingrese tres numeros ::::");
    Console.Write("Ingrese el primer numero: ");
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese el segundo numero: ");
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese el tercer numero: ");
    n3 = Convert.ToInt32(Console.ReadLine());

    if (n1 > n2 && n1 > n3)
    {
        Console.WriteLine("El numero mayor es: " + n1);
    }
    else if (n2 > n1 && n2 > n3)
    {
        Console.WriteLine("El numero mayor es: " + n2);
    }
    else if (n3 > n1 && n3 > n2)
    {
        Console.WriteLine("El numero mayor es: " + n3);
    }
    else
    {
        Console.WriteLine("Hay numeros iguales");
    }
}while (true);


