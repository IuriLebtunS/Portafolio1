// See https://aka.ms/new-console-template for more information
Console.WriteLine("Yapo Estudia Cabeza Dura!!!!!!");
Console.WriteLine("");
Console.WriteLine("-----------------------------------");
Console.WriteLine("");


Console.WriteLine("Digite o Preço do Notebook");
float Preço = float.Parse(Console.ReadLine());
Console.WriteLine("");

float Desconto = Preço/100*5;
var PreçoFinal = Preço-Desconto;
Console.WriteLine("");

Console.WriteLine($"O Preço do NoteBook ASUS G470-S é de R${Preço} e seu Preço Com um 5% de Descontoe de R${PreçoFinal}");
Console.WriteLine("");
Console.WriteLine("-------------------------------------");
Console.ReadKey();








