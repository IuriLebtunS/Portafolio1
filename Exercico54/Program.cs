// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Burro Pesemos a la gente!!! y controlemos la obesidad XD!");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("");

double somaAltura = 0;
double acimaNoventa = 0;
double Menos50kgYMenos160cm = 0;
double Mais190cmYmais100kg = 0;
double i = 1;

while (i <= 7)
{
    Console.WriteLine("Digite Seu Peso");
    double Peso = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua Altura");
    double altura = double.Parse(Console.ReadLine());

    somaAltura = altura + altura;

    if (Peso > 90)
    {
        acimaNoventa++;
    }
    if (Peso < 50 && altura < 1.6)
    {
        Menos50kgYMenos160cm++;
    }
    if (Peso > 100 && altura > 1.9)
    {
        Mais190cmYmais100kg++;
    }

    i++;
}
double mediaAltura = somaAltura / 7;

Console.WriteLine($"A média de altura do grupo e {mediaAltura}");
Console.WriteLine($"As Pessoas que pesam mais de 90Kg são {acimaNoventa}");
Console.WriteLine($"As Pessoas que pesam menos de 50Kg tem menos de 1.60m {Menos50kgYMenos160cm}");
Console.WriteLine($"As Pessoas que Miden mais de 1.90m pesam mais de 100Kg são {Mais190cmYmais100kg}");

Console.WriteLine("");
Console.WriteLine("---------------------------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();
