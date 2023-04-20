// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mismo Exercico44 pero Con Modificacion!!");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("");


Console.WriteLine("Digite O Primeiro Valor!");
float ValorInicial = float.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite O Ultimo Valor!!");
float ValorFinal = float.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite o Incremento!");
float Incremento = float.Parse(Console.ReadLine());
Console.WriteLine("");

float valor = ValorInicial;

if (ValorInicial > ValorFinal)
{
    while (valor > ValorFinal)
    {
        Console.WriteLine(valor);
        valor = valor - Incremento;
    }

}
else
{
    while (valor < ValorFinal)
    {
        Console.WriteLine(valor);
        valor = valor + Incremento;
    }

}


