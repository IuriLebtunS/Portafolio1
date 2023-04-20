// See https://aka.ms/new-console-template for more information
Console.WriteLine("Descontos para Mulher!!!");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite Seu Nome");
string Nome = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite seu Sexo");
string Sexo = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite o Valor da sua Compra");
int ValorCompra = int.Parse(Console.ReadLine());
Console.WriteLine("");

var desconto = 0;

bool DescontoMulher = (Sexo == "Mulher");
bool DescontoHomem = (Sexo == "Homem");

if (DescontoMulher)
    desconto = (13);

if (DescontoHomem)
    desconto = (5);

var resultado = ValorCompra / 100 * desconto;

Console.WriteLine($"Parabens!! Voce e {Sexo} e acaba de receber um desconto, O Preço final de sua Compra e de R${ValorCompra - resultado}");

Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
Console.ReadKey();
