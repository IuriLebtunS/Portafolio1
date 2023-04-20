// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro!!!");
Console.WriteLine("");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite um ano");
int Ano = int.Parse(Console.ReadLine());
Console.WriteLine("");

bool bissexto = (Ano % 4 == 0);
if (bissexto)
   Console.WriteLine(Ano + " é ano bissexto");
else 
   Console.WriteLine(Ano + " não é ano bissexto");

Console.WriteLine("");
Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine("");

Console.ReadKey();
