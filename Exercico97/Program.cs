Console.WriteLine("Hola Burro!!!!!");
Console.WriteLine("");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o primeiro valor:");
double valor1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor:");
double valor2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o Tercero Valor");
double valor3 = double.Parse(Console.ReadLine());

double Maior(double valor1, double valor2, double valor3)
{
    double maior = valor1;
    if (valor2 > maior)
    {
        maior = valor2;
    }
    if (valor3 > maior)
    {
        maior = valor3;
    }
    return maior;
}

Console.WriteLine($"O valor Maior e {Maior(valor1, valor2, valor3)}");

Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("");

Console.ReadKey();
