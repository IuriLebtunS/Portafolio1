// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Burro Estudia, Mas!!!");
Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("");

double i = 1;
double SomaTotal = 0;
double IdadeF = 0;
double SomaM = 0;
var Quantidade = 0;
var QuantidadeF = 0;

while (i <= 5)
{
    Console.WriteLine("Digite Sua Idade");
    double Idade = double.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Digite Seu Sexo [F/M]");
    string Sexo = (Console.ReadLine());
    Console.WriteLine("");

    if (Sexo == "M")
    {
        Quantidade = Quantidade + 1;
        SomaM = SomaM + Idade;
    }
    if (Sexo == "F")
    {
        QuantidadeF = QuantidadeF + 1;

        if (Idade > 20)
            IdadeF = IdadeF + 1;
    }
    i++;

    SomaTotal = SomaTotal + Idade;
}
var MediaIdadeM = SomaM / Quantidade;
var MediaIdadeT = SomaTotal / 5;

Console.WriteLine($"A Quantidades de Homens e {Quantidade}");
Console.WriteLine($"A Quantidades de Mulheres e {QuantidadeF}");
Console.WriteLine($"A Media de Idade Total de  eles e {MediaIdadeT}");
Console.WriteLine($"A Media Idade de Homems {MediaIdadeM}");
Console.WriteLine($"A Quantidade de Mulheres Maiores a 20 anos {IdadeF}");

