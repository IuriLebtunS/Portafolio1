// See https://aka.ms/new-console-template for more information
Console.WriteLine("Burro Verifica si el Numero es Par o impar!!");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite um Numero");
Console.WriteLine("");
int Numero = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (Numero / 2 == 0)
   Console.WriteLine("Numero es Par");
else
   Console.WriteLine("Numero Impar");

Console.WriteLine("");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();

