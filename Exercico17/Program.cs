// See https://aka.ms/new-console-template for more information
Console.WriteLine("Despiertaaaaa!!!!! Cabeza Dura!!");
Console.WriteLine("");
Console.WriteLine("---------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite a Velocidade do seu Carro");
double Velocidade = double.Parse(Console.ReadLine());
Console.WriteLine("");

var Multa = 5;
var KMLimite = 80;
var velocidadeMulta = Velocidade - KMLimite;
double MultaExcesoVelocidade = Multa * velocidadeMulta;

bool Permitido = (Velocidade <= KMLimite);
if (Permitido)
    Console.WriteLine("Pode Continuar de Boa!!");

else
    Console.WriteLine($"Multa por Execeso de Velocidade!!!!! Voce tem que pagar o monto de R${MultaExcesoVelocidade}");

Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------------------------");
Console.ReadKey();
