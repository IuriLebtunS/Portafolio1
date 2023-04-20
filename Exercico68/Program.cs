// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora Burro!!!");
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------------------------------------------");
Console.WriteLine("");


int quantidadeMulheres = 0;
int homensPesoacima100kg = 0;
double somaPesoKgmulheres = 0;
double maiorPesoKghomem = 0;

for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Digite o Sexo da pessoa [M/F] ");
    string sexo = Console.ReadLine();

    Console.WriteLine("Digite o Peso em Kg da pessoa ");
    double pesoKg = double.Parse(Console.ReadLine());

    if (sexo == "F")
    {
        quantidadeMulheres++;
        somaPesoKgmulheres += pesoKg;
    }

    if (sexo == "M")

    {
        if (pesoKg > 100)
            homensPesoacima100kg++;

        if (pesoKg > maiorPesoKghomem)
            maiorPesoKghomem = pesoKg;
    }

}

double mediaPesoEmKgmulheres = somaPesoKgmulheres / quantidadeMulheres;

Console.WriteLine($" A Quantidade de Mulheres cadastradas e {quantidadeMulheres} ");
Console.WriteLine($" A Quantidade de Homens com mais de 100kg e {homensPesoacima100kg}");
Console.WriteLine($" A Media Peso em Kg entre as mulheres e {mediaPesoEmKgmulheres}");
Console.WriteLine($" O Maior Peso dos Homens e {maiorPesoKghomem}");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------------------------------------");
Console.ReadKey();

