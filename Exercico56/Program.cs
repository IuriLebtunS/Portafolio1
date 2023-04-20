// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro Estuda!!!");

double i = 1;
int soma = 0;
bool Repetir = true;

while (Repetir)
{

    int input = int.Parse(Console.ReadLine());
    soma = soma + input;
    i++;


    if (input == 1111)
        Repetir = false;
}

Console.WriteLine($"o resultado da soma dos numeros e {soma}");
Console.WriteLine("");
Console.ReadKey();