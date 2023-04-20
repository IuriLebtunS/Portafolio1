Console.WriteLine("Apurate Burro!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());
ParOuImpar(numero);


void ParOuImpar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("O número é PAR.");
    }
    else
    {
        Console.WriteLine("O número é ÍMPAR.");
    }
}

Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("");

Console.ReadKey();
