// See https://aka.ms/new-console-template for more information
Console.WriteLine("Burro Comprando Produtos!!!!");
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("");

double Menor = 0;
double i = 1;
double Maior = 0;
while (i <= 8)
{
    double input = double.Parse(Console.ReadLine());
    // double input = new Random().Next(20);
    i++;

    if (Maior < input)
        Maior = input;

    if (Menor > input || Menor == 0)
        Menor = input;
}
Console.WriteLine($"O valor Maior e {Maior}");
Console.WriteLine($"O valor Menor e {Menor}");
