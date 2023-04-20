// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora Burro!!! XD...estudia!!");
Console.WriteLine("");
Console.WriteLine("----------------------------");

Console.WriteLine("Juguemos Jokenpo" + "(piedra,papel y tijeras)");
Console.WriteLine("");
Console.WriteLine("----------------------------");

Console.WriteLine("");

Console.WriteLine("Jugador1 Digite Opcion");
var Jugador1 = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Jugador 1 digito " + Jugador1);

Console.WriteLine("");

Console.WriteLine("Jugador2 Digite Opcion");
var Jugador2 = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Jugador 2 digito " + Jugador2);
Console.WriteLine("----------------------------");
Console.WriteLine("");


if ((Jugador1 == "tesoura" && Jugador2 == "papel") || (Jugador1 == "pedra" && Jugador2 == "tesoura") || (Jugador1 == "papel" && Jugador2 == "pedra"))
    Console.WriteLine("Jugador 1 venceu!");


if ((Jugador1 == "papel" && Jugador2 == "papel") || (Jugador1 == "tesoura" && Jugador2 == "tesoura") || (Jugador1 == "pedra" && Jugador2 == "pedra"))
    Console.WriteLine("Empate, Nehum Ganha!");


if ((Jugador2 == "tesoura" && Jugador1 == "papel") || (Jugador2 == "pedra" && Jugador1 == "tesoura") || (Jugador2 == "papel" && Jugador1 == "pedra"))
    Console.WriteLine("Jugador 2 venceu!");

Console.WriteLine("");

Console.WriteLine("Obrigado Por Usar Este Joginho!!");
Console.ReadKey();

















