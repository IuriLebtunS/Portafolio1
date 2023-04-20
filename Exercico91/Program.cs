Console.WriteLine("Estuda Burro!!!");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Digite o primeiro valor:");
int valor1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo valor:");
int valor2 = Convert.ToInt32(Console.ReadLine());

Maior(valor1, valor2);

Console.ReadKey();


void Maior(int valor1, int valor2)
{
    if (valor1 > valor2)
    {
        Console.WriteLine($"O Valor Maior é: {valor1}");
    }
    else if (valor2 > valor1)
    {
        Console.WriteLine($"O Valor Maior é: {valor2}");
    }
    else
    {
        Console.WriteLine("Os dois valores são iguais.");
    }
}
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();
