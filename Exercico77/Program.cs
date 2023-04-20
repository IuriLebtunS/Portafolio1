// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escribe 7 Nombres Burro!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------");
Console.WriteLine("");


string[] nomes = new string[7];

for (int i = 0; i < 7; i++)
{
    Console.Write("Digite um nome: ");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine("Nomes na ordem inversa:");
for (int i = 6; i >= 0; i--)
{
    Console.WriteLine(nomes[i]);
}

Console.WriteLine("");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();

