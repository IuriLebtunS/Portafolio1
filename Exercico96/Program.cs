// See https://aka.ms/new-console-template for more information
Console.WriteLine("Promedia tus Notas Burro!!!!");
Console.WriteLine("");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("");



Console.WriteLine("Digite a 1ra. Nota:");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Digite a 2da. Nota:");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("");

double media = Media(nota1, nota2);

Console.WriteLine($"A média do aluno é {media}");


double Media(double nota1, double nota2)
{
    return (nota1 + nota2) / 2;
}

Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("");

Console.ReadKey();
