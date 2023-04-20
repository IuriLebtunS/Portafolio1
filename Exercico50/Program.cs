// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora Burro!!!!");
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("");

var Numerosorteado = new Random(0).Next(10);

float contNum = 1;
float Quantidadeacimade5 = 0;
float Quantidadedivisiveispor3 = 0;


while (contNum <= 20)
{
    Numerosorteado = (new Random().Next(10));

    Console.WriteLine($"O Numero Ganhador e {Numerosorteado}");

    if (Numerosorteado >= 5)
    {
        Quantidadeacimade5++;
    }

    if (Numerosorteado % 3 == 0)
    {
        Quantidadedivisiveispor3++;
    }
    contNum++;
}

Console.WriteLine($"Quantidade de números acima de 5  : {Quantidadeacimade5}");
Console.WriteLine($"Quantidade de números divisíveis por 3: {Quantidadedivisiveispor3}");