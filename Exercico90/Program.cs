
Console.Write("Digite o primeiro valor: ");
int valor1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int valor2 = int.Parse(Console.ReadLine());

int resultado = Somador(valor1, valor2);

Console.WriteLine($"A soma de {valor1} e {valor2} é igual a {resultado}");


int Somador(int valor1, int valor2)
{
    return valor1 + valor2;
}


