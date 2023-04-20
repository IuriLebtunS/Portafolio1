// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro!!!! otro dia mas!!");
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite Diastancia en KM a Percorrer!");
double KMDistancia = double.Parse(Console.ReadLine());
Console.WriteLine("");

double ValorPassagem = 0;

bool LimiteKM200 = KMDistancia<=200;
bool KmViagemLonga = KMDistancia>200;

if (LimiteKM200)
    ValorPassagem = (0.50);

if (KmViagemLonga)  
    ValorPassagem = (0.45);

var TotalAPagarPassagem = KMDistancia*ValorPassagem;

Console.WriteLine($"O Valor a Pagar na Passagem e de R${TotalAPagarPassagem}");
Console.WriteLine("");

Console.WriteLine("--------------------------------------------------------------------------------");
Console.ReadKey();





