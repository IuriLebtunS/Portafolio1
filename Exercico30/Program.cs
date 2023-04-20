// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Chilenito!! Estudia!!");
Console.WriteLine("");
Console.WriteLine("--------------------------");
Console.WriteLine("");

Console.WriteLine("Fazamos um triangulo!");

int A, B, C;

Console.WriteLine("Digite Tamanho Seg A");
A = int.Parse(Console.ReadLine());

Console.WriteLine("Digite Tamanho Seg B");
B = int.Parse(Console.ReadLine());

Console.WriteLine("Digite Tamanho Seg C");
C = int.Parse(Console.ReadLine());

    if ((A==B)&&(A==C)&&(C==B))
      Console.WriteLine("Triangulo Isoseles");

    if((A==B && A!=C && A!=B) || (B==A && B!=C && B!=A) || (C==A && C!=B && C!=A))
      Console.WriteLine("Triangulo Equilatero");

    if ((A!=B)&&(A!=C)&&(C!=B))
       Console.WriteLine("Triangulo Escaleno"); 


