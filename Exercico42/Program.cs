// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro!!! Numero Entero y Positivo Ja!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite um numero entero e Positivo Qualquer!!");
float Numero = float.Parse(Console.ReadLine());
Console.WriteLine("");

// float valor = Numero;
// while (valor >= 0)
// {
//     Console.WriteLine(valor);
//     valor--;
// }
for (float valor = Numero; valor >= 0; valor--)
{
    Console.WriteLine(valor);
}

Console.WriteLine("");
Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();
