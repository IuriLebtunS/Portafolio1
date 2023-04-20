// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora burro Estudaaaaa!!!!");
Console.WriteLine("-------------------------------");
Console.WriteLine("");


var totalSalarioFemenino = 0;
var totalSalarioMasculino = 0;
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Digite Seu Sexo!");
    string sexo = Console.ReadLine();

    Console.WriteLine("Digite seu Salario!");
    Console.ReadLine();

    if (sexo == "Masculino")
    {
        totalSalarioMasculino = totalSalarioMasculino+1;
    }

    if (sexo == "Femenino")
    {
        totalSalarioFemenino = totalSalarioFemenino+1;
    }

    Console.WriteLine("Deseja Continuar ? Dgite S = si / N = No");
    string resposta = Console.ReadLine();

    if (resposta == "S")
        continuar = true;

    if (resposta == "N")
        continuar = false;

}

Console.WriteLine($"O Total de Salario pagos en Homens e {totalSalarioMasculino} e o total de Salarios Pagos em Mulheres e {totalSalarioFemenino}");
Console.WriteLine("");

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();





