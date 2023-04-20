// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola de Novo!! Burro!!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------");
Console.WriteLine("");


Console.WriteLine("Digite Horas de Actividade");
int Horas = int.Parse(Console.ReadLine());
Console.WriteLine("");


var valorDoPonto = 0;

if (Horas <= 10)
    valorDoPonto = 2;

if (Horas > 10 && Horas < 20)
    valorDoPonto = 5;

if (Horas > 20)
    valorDoPonto = 10;

var pontos = Horas * valorDoPonto;
var valor = pontos * 0.05;

Console.WriteLine("Voce Consigiu " + pontos + " Pontos ");

Console.WriteLine("Voce Ganho " + valor + "R$");




