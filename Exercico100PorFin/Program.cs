Console.WriteLine("Por fim!!!!! aaaaaaaahhh!!");
Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine("");


Console.WriteLine("Digite as duas notas do aluno:");
double nota1 = double.Parse(Console.ReadLine());
double nota2 = double.Parse(Console.ReadLine());

double media = Media(nota1, nota2);
Console.WriteLine($"A média do aluno é {media}");

string situacao = Situacao(media);
Console.WriteLine($"Situação do aluno: {situacao}");

double Media(double nota1, double nota2)
{
 return (nota1 + nota2) / 2;
}

string Situacao(double media)
{
    if (media >= 7.0)
    {
     return "Aprovado";
    }
    else if (media >= 5.0)
    {
     return "Recuperação";
    }
    else
    {
     return "Reprovado";
    }
}

Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine("");

Console.ReadKey();