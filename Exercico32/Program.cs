// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Cabeza Dura!!! Estudia!");
Console.WriteLine("");
var numerosorteado = new Random().Next(5);

Console.WriteLine("-------------------------------------");
Console.WriteLine("");

Console.WriteLine("adivinha que numero foi sorteado");

int numero = int.Parse(Console.ReadLine());

bool acerto = (numero == numerosorteado);

if (acerto)
    Console.WriteLine("Voce Acerto!!! Parabens!!");

else
    Console.WriteLine("Voce Perdeu, O numero era " + numerosorteado);

Console.ReadKey();
