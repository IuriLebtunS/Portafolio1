// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola!!! Burro Continua Estudando!!!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite a Primeira Nota!!!");
float Nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite a Segunda Nota!!!");
float Nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("");

var Media = Nota1+Nota2/2;

// descubrir a situacao do aluno
var SituacaoAluno = "";

if (Media>=7.0)
   SituacaoAluno = "Aprovado";

if (Media>=5.0 && Media<6.9)
   SituacaoAluno = "Recuperação";

if(Media<4.99)
   SituacaoAluno = "Reprovado";

Console.WriteLine($"A sua Media e {Media}, sua situação e {SituacaoAluno}");



  
   




