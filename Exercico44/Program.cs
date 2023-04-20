// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro Dale nomas!!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");
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

// for (float valor = ValorInicial ; valor < ValorFinal ; valor = valor + Incremento)
// {
//     Console.WriteLine(valor);
// }
float valor = ValorInicial;
while (valor < ValorFinal)
{
    Console.WriteLine(valor);
    valor = valor + Incremento;
}

Console.WriteLine("Acaboou!");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();
