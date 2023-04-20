// See https://aka.ms/new-console-template for more information
Console.WriteLine("Terreno Nuevo!!!!Calcular Area!!!");
Console.WriteLine("");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite a Largura do Terreno");
double Largura = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite o Comprimento do Terreno");
double Comprimento = double.Parse(Console.ReadLine());
Console.WriteLine("");

var AreaMTS = Largura * Comprimento;

var ClasificaçãoTerreno = "";

if (AreaMTS <= 100)
    ClasificaçãoTerreno = "Popular";

if (AreaMTS > 100 && AreaMTS <= 500)
    ClasificaçãoTerreno = "Terreno Master";

if (AreaMTS > 500)
    ClasificaçãoTerreno = "Terreno Vip";

Console.WriteLine($"A Area em Mts cuadrados e de {AreaMTS}Mts Cuadrados, é ele esta Clasificado Como um Terreno{ClasificaçãoTerreno} ");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();
