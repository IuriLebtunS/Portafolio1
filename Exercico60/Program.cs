// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro Continua!!!!");

var nome = "";
var pessoaMaisVelha = "";
var mulherMaisNova = "";

int quantidadePessoas = 0;
int maiorIdade = 0;
int somaIdades = 0;
int QuantidadehomensAcimade30 = 0;
int quantidadeMulheresAbaixo18 = 0;
int idadeMulhermaisJovem = 500;

bool rodarCodigo = true;

while (rodarCodigo)
{
    Console.WriteLine("Digite seu Nome");
    nome = Console.ReadLine();

    Console.WriteLine("Digite sua Idade");
    int idade = int.Parse(Console.ReadLine());

    if (idade > maiorIdade)
    {
        maiorIdade = idade;
        pessoaMaisVelha = nome;
    }

    Console.WriteLine("Digite seu Sexo [M/F]: ");
    string sexo = Console.ReadLine();

    Console.WriteLine("Deseja continuar? Digite.... SIM[0] ou NAO[1]");
    int continuar = int.Parse(Console.ReadLine());

    somaIdades = somaIdades + idade;
    quantidadePessoas++;

    if (sexo == "F" && idade < idadeMulhermaisJovem)
    {
        idadeMulhermaisJovem = idade;
        mulherMaisNova = nome;
    }

    if (sexo == "M" && idade > 30)
    {
        QuantidadehomensAcimade30++;
    }

    if (sexo == "F" && idade < 18)
    {
        quantidadeMulheresAbaixo18++;
    }

    if (continuar == 1)
        rodarCodigo = false;
}

double media = somaIdades / quantidadePessoas;

Console.WriteLine($"A Pessoa mais velha e {pessoaMaisVelha}");
Console.WriteLine($"A Mulher mais jovem e {mulherMaisNova}");
Console.WriteLine($"Media das idades: {media}");
Console.WriteLine($"Homens acima de 30 anos {QuantidadehomensAcimade30}");
Console.WriteLine($"A quantidade de Mulheres abaixo de 18 anos e {quantidadeMulheresAbaixo18}");