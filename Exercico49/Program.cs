// See https://aka.ms/new-console-template for more information
Console.WriteLine("Animate Burro!!!!!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------");
Console.WriteLine("");

double par = 0;
double impar = 0;

double i = 1;
while (i <= 7)
{
    double input = double.Parse(Console.ReadLine());
    i++;

    if (input % 2 == 0)
        par = par + 1;
    else
        impar = impar + 1;
}
Console.WriteLine($"A Quantidade de Numeros Par Sao {par} e De Numero Impar sao {impar}");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------------");
