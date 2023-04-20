// See https://aka.ms/new-console-template for more information
Console.WriteLine("Boraaaaaa!!!!! Estuda!!!!!");
Console.WriteLine("");

Console.WriteLine("Digite uma Distancia en Metros");
decimal Distancia = decimal.Parse(Console.ReadLine());

decimal Km = Distancia/1000;
decimal Cm = Distancia*100;
decimal mm = Distancia*1000;

Console.WriteLine($"A Distancia de {Distancia}M, Corresponde a {Km}Km é em CM e{Cm}Cm é em mm{mm}");
Console.WriteLine("");
Console.ReadKey();

