// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro!!! Vamos Trabalha!!");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("");

for (int valor = 30; valor >= 1; valor--)
{

    if (valor % 4 == 0)
    {
       Console.WriteLine($"[{valor}]");
    }
    
    else
      Console.WriteLine(valor);

}
Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();