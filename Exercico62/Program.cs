// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora Burroooooo!");
Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("");

int quantidadesdeidadesdigitadas = 0;
double somaIdades = 0;
int pessoasAcimaoIgual21 = 0;
bool rodarCodigo = true;

do
{
    Console.WriteLine("Digite a Idade");
    int idade = int.Parse(Console.ReadLine());

    somaIdades = somaIdades + idade;
    quantidadesdeidadesdigitadas++;

    if (idade >= 21)
    {
        pessoasAcimaoIgual21++;
    }

    Console.WriteLine(" Deseja Continuar SIM[0] ou NAO[1] ");
    int continuar = int.Parse(Console.ReadLine());
    
   if (continuar == 1)
        rodarCodigo = false;
      
}
while(rodarCodigo);

double media = somaIdades / quantidadesdeidadesdigitadas;
Console.WriteLine("---------------------------------------------------------------------------------");
Console.WriteLine($" Quantidade de idades digitadas e {quantidadesdeidadesdigitadas}");
Console.WriteLine($" A Media entre as idades e {media}");
Console.WriteLine($" A Quantidade de Pessoas Acima o igual a 21 anos e {pessoasAcimaoIgual21}");
Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();
