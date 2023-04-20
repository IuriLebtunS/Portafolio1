// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Burro!!!!");
Console.WriteLine("");

Console.WriteLine("Digite Quanto Dinheiro Vc Tem");
int Dinheiro = int.Parse(Console.ReadLine());
Console.WriteLine("");

var PreçoDolar = 3.45;
double TotalDolar = Dinheiro/3.45;

Console.WriteLine($"Na sua carteira voce tem R${Dinheiro} e pode Comprar US${TotalDolar}");

Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------");

Console.ReadKey();