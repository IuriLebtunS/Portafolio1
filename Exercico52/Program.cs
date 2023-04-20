// See https://aka.ms/new-console-template for more information
Console.WriteLine("Idade de Pessoas / Media Idade");
Console.WriteLine("");
double Menor5 = 0;
double i = 1;
double Maior18 =0;
double Maior = 0;
double Idade = 0;
double Soma = 0;

while (i <= 10)
{

    double input = double.Parse(Console.ReadLine());
    i++;
      Idade = input;

      Soma = Soma+Idade;


    if (input>=18)
        Maior18 = Maior18+1;

    if (input<=5)
        Menor5 = Menor5+1;

    if (Maior < input)
        Maior = input;    
} 
 var MediaIdade = Soma/10;
    
Console.WriteLine($"A quantidade de pessoas Maiores de 18 anos e {Maior18}");
Console.WriteLine($"A quantidade de Pessoas menores de 5 anos e {Menor5}");
Console.WriteLine($"A Idade Maior do Grupo e de {Maior}");
Console.WriteLine($"A Media de Idade das Pessoas e {MediaIdade}");
