// See https://aka.ms/new-console-template for more information
Console.WriteLine("Porfin Burro!!!");


int numerosDigitados = 0;
double soma = 0;
int numeroMenor = 10000;
int numerosPares = 0;
bool rodarCodigo = true;

do
{
    Console.WriteLine(" Digite um Numero ");
    int numero = int.Parse(Console.ReadLine());

    soma = soma + numero;
    numerosDigitados++;

    if (numero < numeroMenor)
    {
        numeroMenor = numero;
    }
    if (numero % 2 == 0)
    {
        numerosPares++;
    }
    Console.WriteLine(" Deseja Continuar? SIM = [0] / NAO = [1]: ");
    int continuar = int.Parse(Console.ReadLine());
    
    if (continuar == 1)
      rodarCodigo = false;

} while (rodarCodigo);

double media = soma / numerosDigitados;
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------------------------------------------");
Console.WriteLine($"A Somatoria entre todos os Numeros e {soma}");
Console.WriteLine($"O Numero Menor digitado e {numeroMenor}");
Console.WriteLine($" A Media entre todos os Numeros e {media}");
Console.WriteLine($" A Quantidade de Numeros pares e {numerosPares}");
Console.WriteLine("-----------------------------------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();