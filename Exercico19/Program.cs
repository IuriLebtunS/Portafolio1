// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora!!!!!, Burro");
Console.WriteLine("");
Console.WriteLine("-------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o Nome Do Alumno");
string NomeAlumno = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite sua Primera Nota");
double Nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite sua Segunda Nota");
double Nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("");

var MediaNotas = (Nota1 + Nota2) / 2;
var MediaAceita = 70;

bool Aprovado = MediaNotas >= MediaAceita;
if (Aprovado)
    Console.WriteLine($"{NomeAlumno} A sua Media de Notas e {MediaNotas}, Voce Aproveito Muito bem as Aulas e foi Aprovado, Parabens!!!! Pelo Esforço");
else
    Console.WriteLine($"{NomeAlumno} A sua Media de Notas e {MediaNotas}, Voce Esta Reprobado!!!");


Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("");
Console.ReadKey();




