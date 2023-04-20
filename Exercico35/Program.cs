// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Bora Iuri ta muito mais dificil!!");
Console.WriteLine("");
Console.WriteLine("----------------------");
Console.WriteLine("");


Console.WriteLine("Digite a Cantidade de Dias Alugados ");
float Dias = float.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite que tipo de Carro quer");
string TipodeCarro = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite KM percorridos com o Carro");
double Km = double.Parse(Console.ReadLine());
Console.WriteLine("");


int valordiarialuxo = 150;
int valordiariaPopular = 90;

bool ehCarroLuxo = TipodeCarro == "luxo";

if (ehCarroLuxo)
{
    var valorKmextra = 0.30;

    if (Km < 200)
        valorKmextra = 0.25;

    var valortotal = Dias * valordiarialuxo + (Km * valorKmextra);

    Console.WriteLine("O Monto a Pagar por ser Carro de Luxo e " + valortotal);
}
 
bool ehCarroPopular = TipodeCarro == "popular";

if (ehCarroPopular)
{
    var valorKmextra = 0.20;

    if(Km<100)
       valorKmextra = 0.10;
     var valortotal = Dias * valordiariaPopular + (Km * valorKmextra);

    Console.WriteLine("O Monto a Pagar por ser Carro Popular e " + valortotal);
}
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");

Console.ReadKey();











