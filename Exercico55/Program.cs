// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double i = 1;
var numerosorteado = new Random(1).Next(10);

Console.WriteLine("-------------------------------------");
Console.WriteLine("");

while (i <= 4)
{
    Console.WriteLine("adivinha que numero foi sorteado");

    int numero = int.Parse(Console.ReadLine());

    bool acerto = (numero == numerosorteado);

    if (acerto){
        Console.WriteLine($"Voce Acerto!!! Parabens!! O Numero sorteado era {numerosorteado}");
        break;
    }
    
    else
        Console.WriteLine("Voce Perdeu,tenta novamente");
    i++;
}
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();
