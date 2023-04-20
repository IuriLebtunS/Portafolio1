// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("bora trabalhar Burro!!!!");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("");

int[] numeros = new int[15];

for (int i = 0; i < 15; i++)
{
    Console.Write("Digite um número ");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("");

Console.WriteLine("Array de inteiros");
for (int i = 0; i < 15; i++)
{
    Console.Write(numeros[i] + " ");
}
Console.WriteLine();
Console.WriteLine();

Console.Write("Posições com múltiplos de 10: ");
for (int i = 0; i < 15; i++)
{
    if (numeros[i] % 10 == 0)
    {
        Console.Write(i + " ");
    }
}

Console.WriteLine();
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine();
Console.ReadKey();
