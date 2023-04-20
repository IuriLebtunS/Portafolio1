// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora Continuar, Estudiando!!!!!");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite seu Ano de Nacimento!!");
float AnoDNacimento = float.Parse(Console.ReadLine());
Console.WriteLine("");

var AnoAtual = 2022;
var Idade = AnoAtual - AnoDNacimento;
var Marioridade = 18;
var DeMenor = Idade < Marioridade;

bool AprovadoMilitar = (Idade == Marioridade);
if (AprovadoMilitar)
    Console.WriteLine($"A sua idade e {Idade}Anos, Voce debe realizar seu serviço Militar.");

if (Idade>Marioridade)
     Console.WriteLine($"A sua Idade e {Idade}Anos, Paso O Limite de Idade Para Realizar Seu Serviço Militar.");
    
if (Idade<Marioridade)
    Console.WriteLine($"A sua idade e {Idade}Anos, Voce e Menor de Idade, Volte uma Vez Cumprida a sua Maioridade 18Años.");

Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------");
Console.ReadKey();

