// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vamos Burro!");
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------");

Console.WriteLine("");


int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Números pares e sua posição");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
    Console.WriteLine($"Número {numeros[i]} encontrado na posição {i}");
    }
}

Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();



