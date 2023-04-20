Console.WriteLine("Estamos casi Burro!!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite um numero Base!");
double baseNumero = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o Expoente!");
int expoenteNumero = int.Parse(Console.ReadLine());
double resultado = Potencia(baseNumero, expoenteNumero);

 double Potencia(double baseNumero, int expoenteNumero)
{
    double resultado = 1;

    for (int i = 1; i <= expoenteNumero; i++)
    {
        resultado *= baseNumero;
    }

    return resultado;
}
Console.WriteLine("");

Console.WriteLine($"{baseNumero} elevado a {expoenteNumero} é igual a {resultado}");

Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("");

Console.ReadKey();

