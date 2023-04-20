// See https://aka.ms/new-console-template for more information
Console.WriteLine("Burro Hagamos un Listado (Array) Vectores!!!!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("");


var meuListado = new int [8]{ 0, 1, 2, 3, 4, 5, 6, 7 };

 
foreach (var item in meuListado)
{
    Console.Write($"{item} ");
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("------------------------------------------------");
Console.ReadKey();
