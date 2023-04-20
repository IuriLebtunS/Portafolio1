// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro!!!!! Bora trabalhar!!!");
Console.WriteLine("");
Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite Seu Nome");
string Nome = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite Seu Sexo");
string SexoTrabalhador = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite seu Salario Atual");
double SalarioAtual = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite Anos Trabalhados na Empresa");
float AnosTrabalhados = float.Parse(Console.ReadLine());
Console.WriteLine("");

var Porcentagem = 0;
var Aumento = SalarioAtual / 100;
var SalarioAumentado = SalarioAtual + Aumento * Porcentagem;

bool AumentoMulher = SexoTrabalhador == "Mulher";

if (AumentoMulher)
{
    if (AnosTrabalhados < 15)
        Porcentagem = 5;

    if (AnosTrabalhados >= 15 && AnosTrabalhados <= 20)
        Porcentagem = 12;

    if (AnosTrabalhados >= 20)
        Porcentagem = 23;
}
bool AumentoHomem = SexoTrabalhador == "Homem";

if (AumentoHomem)
{
    if (AnosTrabalhados < 20)
        Porcentagem = 3;

    if (AnosTrabalhados >= 20 && AnosTrabalhados <= 30)
        Porcentagem = 13;

    if (AnosTrabalhados >= 30)
        Porcentagem = 25;
}

Console.WriteLine($"Ola {Nome},se Fizeram reajuste nos salarios e Seu Novo Salario e de R${SalarioAumentado}");
