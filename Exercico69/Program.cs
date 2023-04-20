// See https://aka.ms/new-console-template for more information
Console.WriteLine("Progresion Aritmetica!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine("");

int soma = 0;

Console.WriteLine("Digite o Primeiro termo da PA ");
int primeiroTermo = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a Razao");
int razao = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($" A Progressão Aritmética e {i})- {primeiroTermo + (i - 1) * razao}");

    soma = soma + primeiroTermo + (i - 1) * razao;
}

Console.WriteLine($" A soma dos termos e {soma}");

Console.WriteLine("");
Console.WriteLine("---------------------------------------------------------------------------------");
Console.ReadKey();
