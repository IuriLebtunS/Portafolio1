// See https://aka.ms/new-console-template for more information
Console.WriteLine("Continua Cabeça dura!!!!");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("");

int maiorIdade = 0;
int totalhomens = 0;
int somaIdadehomens = 0;
int idadeMulherMaisjoven = 500;

bool rodarCodigo = true;

while (rodarCodigo)
{

    Console.WriteLine(" Digite sua Idade ");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine(" Digite seu Sexo [M/F]");
    string sexo = Console.ReadLine();

    Console.WriteLine(" Deseja continuar? SIM [0] / NAO [1] ");
    int continuar = int.Parse(Console.ReadLine());

    if (idade > maiorIdade)
        maiorIdade = idade;

    if (sexo == "M")
    {
        totalhomens++;
        somaIdadehomens = somaIdadehomens + idade;
    }

    if (sexo == "F" && idade < idadeMulherMaisjoven)
    {
      idadeMulherMaisjoven = idade;
    }

    if (continuar == 1)
        rodarCodigo = false;

}

double mediaIdadehomens = somaIdadehomens / totalhomens;
Console.WriteLine($" A Maior idade lida e {maiorIdade}");
Console.WriteLine($" A Quantidade de Homens cadastrados e {totalhomens}");
Console.WriteLine($"A Idade da mulher mais jovem e {idadeMulherMaisjoven}");
Console.WriteLine($"Media de idade entre os homens e {mediaIdadehomens}");
