// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Burro Escribe Las tablas!!!!");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("");


Console.WriteLine("Digite um Numero Para Ter a sua Tabuada!!!");
int numero = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++) 
{
var resultado = numero*i;

Console.WriteLine( $" {numero}  X  {i}  = {(resultado)} ");

}
Console.WriteLine("");
Console.WriteLine("Acabou!");
Console.WriteLine("----------------------------------------------------");
Console.ReadKey();