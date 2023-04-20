// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("Vamos Burro tu Puedes!!!");
Console.WriteLine("");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("");

int[] fibonacci = new int[16];
fibonacci[0] = 1;
fibonacci[1] = 1;

for (int i = 2; i < fibonacci.Length; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}

Console.WriteLine("Sequência de Fibonacci:");

for (int i = 0; i < fibonacci.Length; i++)
{
    Console.Write(fibonacci[i] + " ");
}

Console.WriteLine("");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("");
Console.ReadKey();






