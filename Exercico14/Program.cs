// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Loco!!!Trabalha!!!!");
Console.WriteLine("");
Console.WriteLine("------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite os KM Percorridos Pelo Carro");
double KMPercorridos = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite a Quantidade de Dias Alugados");
int Dias = int.Parse(Console.ReadLine());
Console.WriteLine("");

var Diaria = 90;
var KMRodado = 0.20;
var valorKM = KMPercorridos*KMRodado;
var valorxDias = Diaria*Dias;
var PreçoFinal = valorxDias+valorKM;

Console.WriteLine($"O Preço Final a Pagar e de R${PreçoFinal}");
Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.ReadKey();




