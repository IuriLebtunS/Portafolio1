// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vamos Levantate Cabeza Dura!!!!!");
Console.WriteLine("");
Console.WriteLine("--------------------------------");
Console.WriteLine("");

Console.WriteLine("Jaime e um funcionario da empresa.");
Console.WriteLine("");

Console.WriteLine("Digite O Salario de Jaime ");
float Salario = float.Parse(Console.ReadLine());
Console.WriteLine("");

float Aumento = Salario/100*15;
float NovoSalario =Salario+Aumento;

Console.WriteLine($"O Salario de Jaime e de R${Salario} e a Contar de Janeiro seu Novo Salario vai ser de R${NovoSalario}");
Console.WriteLine("");
Console.WriteLine("----------------------------------");
Console.ReadKey();

