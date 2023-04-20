// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ahora de 6 a 100 XD!!!");

float ValorInicial = 6;
Console.WriteLine("");

float ValorFinal = 100;
Console.WriteLine("");

float Incremento = 2;
Console.WriteLine("");

float Resultado = 0;


for (float valor = ValorInicial; valor <= ValorFinal; valor = valor + Incremento)
{
    Resultado = Resultado + valor;
    Console.WriteLine(Resultado);
}

Console.WriteLine("Acabou!!");
