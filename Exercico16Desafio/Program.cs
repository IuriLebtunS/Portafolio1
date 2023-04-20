// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora!!!! Bora!!!!!");
Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");


Console.WriteLine("Digite Nome");
string Nome = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite a Quantidade de Anos Fumando");
int AnosFumando = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite quantos Cigarros Consume Diariamente");
int CigarrosDiarios = int.Parse(Console.ReadLine());
Console.WriteLine("");


// 1. descobrir quantos cigarros ele fumo!
var DiasXano = 365;
var CigarrosFumados = CigarrosDiarios * DiasXano * AnosFumando;

// 2. descubrir quanto tempo ele perdeu!
var TempoPerdidoMinuto = CigarrosFumados * 10;
var TempoPerdidoHora = TempoPerdidoMinuto / 60;
var TempoPerdidoDia = TempoPerdidoHora / 24;

Console.WriteLine($"A quantidade de dias Perdidos por {Nome}, ser um fumante. São de  {TempoPerdidoDia} Dias, ja que a cada cigarro ele Perde 10 Min de Vida.");


