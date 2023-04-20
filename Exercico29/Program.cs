// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite Nome de Funcionario!!");
string NomeFuncionario = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite Seu Salario");
double Salario = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Anos Trabalhados Na Empresa");
double Anos = double.Parse(Console.ReadLine());
Console.WriteLine("");

var AumentoSalarial = Salario/100;

var Porcentagem = 0;

if (Anos<=3)
  Porcentagem = 3;

if (Anos>3 && Anos<=10)
  Porcentagem = 13;

if (Anos>=10)
  Porcentagem = 20;

var SalarioFinal = Salario+(AumentoSalarial*Porcentagem);

Console.WriteLine($"Don {NomeFuncionario} vai receber um novo Salario de {SalarioFinal}");