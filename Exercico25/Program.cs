// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro!!!! Bora Trabalhar!!!");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite Medida do Seg A");
double SegA = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite Medida do Seg B");
double SegB = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite Medida do Seg C");
double SegC = double.Parse(Console.ReadLine());
Console.WriteLine("");

bool Triangulo = (SegA < SegB+SegC) && (SegB < SegA+SegC) && (SegC < SegA+SegB);

if (Triangulo)
   Console.WriteLine("Podemos Formar um Triangulo Perfeito Com os Seg. Digitados");

else
   Console.WriteLine("Recuerde Regla Matematica para Formar um Triangulo, Teste Novamente!!!!");

Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();



   