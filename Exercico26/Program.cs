// See https://aka.ms/new-console-template for more information
Console.WriteLine("Procurando O Numero Maior, Bora Burro!!!!!!!");
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite um Valor Qualquer!");
int Valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite outro Valor Qualquer!");
int Valor2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (Valor1>Valor2)
 Console.WriteLine("O Primeiro Valor e o Maior");

if (Valor1<Valor2)
 Console.WriteLine("O Segundo Valor e o Maior");

if (Valor1==Valor2)
  Console.WriteLine("Nao Existe Valor Maior, Os Dois Numeros o Valores São Iguais");
  
  
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();

