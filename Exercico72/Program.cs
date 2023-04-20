// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Burro!!");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("");

int[] vetor = new int[10];
int valorInicial = 5;
int valorIncremento = 5;

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = valorInicial + (i * valorIncremento);
    Console.Write(vetor[i]+ " " );
}


Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Excelente Burro!!!");
Console.ReadKey();



