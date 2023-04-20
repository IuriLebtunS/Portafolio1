// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ascurrete!!!!! Wueta!!!!!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o seu ano de Nacimento!");
double AnoNacimento = double.Parse(Console.ReadLine());
Console.WriteLine("");

var Maioridade = 18;
var AnoAtual = 2022;
var idade = AnoAtual - AnoNacimento;

bool MaiordeIdade = (idade >= Maioridade);
if (MaiordeIdade)
    Console.WriteLine($"Voce tem {idade} Anos. Ja e Maior, Pode Votar");

else
    Console.WriteLine($"Voce tem {idade} Anos!!!. Voce e Menor de Idade, Volte pra casa Moleque!!");

Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();



