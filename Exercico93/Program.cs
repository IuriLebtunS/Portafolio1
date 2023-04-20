Console.WriteLine("Animo Cabeza Dura falta um pouco!");

Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("");


Console.WriteLine("Digite o valor inicial da contagem: ");
int inicio = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor final da contagem: ");
int fim = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do incremento da contagem: ");
int incremento = int.Parse(Console.ReadLine());

Contador(inicio, fim, incremento);

void Contador(int inicio, int fim, int incremento)

{
    Console.Write(" Contagem:  ");

    for (int i = inicio; i <= fim; i += incremento)
    {
        Console.Write(i + ", ");
    }

    Console.Write("FIM");
}

Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("Nos vimos Pollo!!!");

Console.WriteLine("");
Console.ReadKey();

