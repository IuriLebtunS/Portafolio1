// See https://aka.ms/new-console-template for more information
Console.WriteLine("Secuencia Fibonacci!!");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("");


int valor2 = 1;
int valor1 = 0;
string sequencia = "";

for (int i = 1; i <= 10; i++)

{
    int valor3 = valor1 + valor2;
    sequencia = $"{sequencia}{valor3},";

    //   Console.Write($"{valor3},");

    valor1 = valor2;
    valor2 = valor3;
}
Console.WriteLine(sequencia);
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------------------------------------");
Console.ReadKey();
