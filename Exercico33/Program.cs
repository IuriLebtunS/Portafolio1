// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Cabeza Dura!! Estudia!!");
Console.WriteLine("");
Console.WriteLine("---------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite seu Nome");
string nome = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite o valor da casa a Comprar");
double valorcasa = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite seu Salario");
double salario = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite anos a Pagar o Credito ");
int anos = int.Parse(Console.ReadLine());

Console.WriteLine("");

double prestaçaoMensual = valorcasa / (anos * 12);
Console.WriteLine("A sua Prestaçao Mensual e de " + prestaçaoMensual);

Console.WriteLine("");

bool aprovado = prestaçaoMensual < (salario / 100 * 30);

if (aprovado)
    Console.WriteLine("Seu Credito habitacional foi Aprovado");

else
    Console.WriteLine("Nao Aprovado Prestaçao mensual Fora do Limite Max.");


Console.WriteLine("---------------------------------------------------");
Console.ReadKey();
