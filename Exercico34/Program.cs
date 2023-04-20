// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora, Bora!!!!! temos que Trabalhar!!");

Console.WriteLine("");
Console.WriteLine("-------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite a sua Altura");
decimal altura = decimal.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite seu peso");
decimal peso = decimal.Parse(Console.ReadLine());
Console.WriteLine("");

decimal IMC = peso/(altura * altura);

Console.WriteLine("seu IMC e " + IMC+"%");
Console.WriteLine("");
Console.WriteLine("--------------------------------------");
Console.WriteLine("");

bool Saudavel = IMC >= 18.5m && IMC <= 25;

if (Saudavel)
    Console.WriteLine("Perfeito, seu Peso e ideal seu IMC esta entre 18.5 e 25 ");

if (IMC < 18.5m)
    Console.WriteLine("Voce Precisa de ajuda Medica seu IMC esta baixo 18,5 Baixo Peso!!!");

bool SobrePeso = IMC >= 25 && IMC < 30;

if (SobrePeso)
    Console.WriteLine("Cuidado Voce Tem SobrePeso seu IMC esta sobre 25");

bool Obesidade = IMC > 30 && IMC < 40;

if (Obesidade)
    Console.WriteLine("Procure ajuda Medica voce tem Obesidade seu IMC esta Sobre 30");

bool ObesidadeMorbida = IMC > 40;

if (ObesidadeMorbida)
    Console.WriteLine("Procure ajuda Medica Urgente voce tem Obesidade Morbida!! seu IMC esta sobre 40");

Console.WriteLine("");
Console.WriteLine("---------------------------------------------------");
Console.ReadKey();



