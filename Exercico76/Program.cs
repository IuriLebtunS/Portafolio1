// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("Esfuerzate Buerro!!!");
Console.WriteLine("");
Console.WriteLine("-------------------------------------");
Console.WriteLine("");

int[] numeros = new int[7];

Random rnd = new Random();
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = rnd.Next(1, 101);
}
Console.WriteLine("Números aleatorios dentro de meu array!!");

Console.WriteLine("");
foreach (int numero in numeros)
{
    Console.Write(numero + " ");
}

Console.WriteLine("");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");
Console.ReadKey();