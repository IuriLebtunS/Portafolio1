// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vamos Cabeza Dura!!!!");
Console.WriteLine("");

Console.WriteLine("Digite Altura da parede a Pintar");
float Altura = float.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite Largura da Parede a Pintar");
float Largura = float.Parse(Console.ReadLine());
Console.WriteLine("");

float Area = Altura*Largura;
var LitroPintura = 2;
float QuantidadePintura = LitroPintura*Area;

Console.WriteLine($"A Area a ser pintada e de {Area}Mts Cuadrados, e a quantidade de Pintura usada vai ser de {QuantidadePintura} Litros ");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------------");
Console.ReadKey();








