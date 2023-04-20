// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora Burro Continua!!!!!");
Console.WriteLine("-------------------------------");
Console.WriteLine("");

int somaIdades = 0;
int quantidadeAlunos = 0;
bool continuar = true; 

while (continuar)
{
    Console.WriteLine("digite a Idade do aluno ");
    int idade = int.Parse(Console.ReadLine());

    if (idade == 999)
    {
       continuar = false;
    }
    somaIdades = somaIdades + idade;
    quantidadeAlunos++;

}

double media = somaIdades / quantidadeAlunos;
Console.WriteLine($"Total de alunos: {quantidadeAlunos}");
Console.WriteLine($"Media das idades: {media}");

Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("");
Console.ReadKey();
