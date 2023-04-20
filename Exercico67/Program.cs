// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Burro Vamos de Nuevo!!!");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite un Numero para Iniciar");
int numero = int.Parse(Console.ReadLine());
 
for (int i = 0; i <= numero; i++)
{
 Console.WriteLine($"{i}");
}
Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------------------------");
Console.ReadKey();
