Console.WriteLine("Adios Mundo Cruel!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite los Numeros a Somar!");
Console.WriteLine("");

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int SuperSomador(int num1, int num2)
{
    int soma = 0;

    for (int i = num1; i <= num2; i++)
    {
        soma += i;
    }

    return soma;
}

Console.WriteLine("");

Console.WriteLine($"SuperSomador({num1}, {num2}) = {SuperSomador(num1, num2)}");

Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("");

Console.ReadKey();

