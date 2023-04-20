Console.WriteLine("Esfuerzate Burro!!!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("");

void Fibonacci(int n)
{
    int a = 1, b = 2, c;
    Console.Write($"{a} {b}");
    for (int i = 2; i < n; i++)
    {
        c = a + b;
        Console.Write($" {c}");
        a = b;
        b = c;
    }
}

Console.WriteLine("Sequência de Fibonacci: ");
Console.WriteLine("");

Fibonacci(5);
Console.WriteLine(", FIM ");
Fibonacci(9);
Console.WriteLine(", FIM ");

Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("");

Console.ReadKey();
