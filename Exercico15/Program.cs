// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!!! Boss!!");
Console.WriteLine("");
Console.WriteLine("---------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite seu Nome");
string Nome = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite quantidade de Dias Trabalhados");
float DiasTrabalhados = float.Parse(Console.ReadLine());
Console.WriteLine("");

float Dia = 8;
double Hora = 25;

var valorXDia = Dia * Hora;
var Salario = valorXDia * DiasTrabalhados;

Console.WriteLine($"Os dias Trabalhados no mes de Dezembro Por {Nome}, São {DiasTrabalhados}, e seu Salario Mensual e de R${Salario}");
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------");
Console.ReadKey();

