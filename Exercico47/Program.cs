// See https://aka.ms/new-console-template for more information
Console.WriteLine("Agora de 500 a 0 Bora!!!! Burro!!!");

float ValorInicial = 500;
Console.WriteLine("");

float ValorFinal = 0;
Console.WriteLine("");

float Incremento = 50;
Console.WriteLine("");

float Resultado = 0;

for (float valor = ValorInicial; valor > ValorFinal; valor = valor - Incremento)
{
    Resultado = Resultado + valor;
    Console.WriteLine(Resultado);
}

Console.WriteLine("Acabou!!!");

