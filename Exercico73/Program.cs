// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("Apurate Burro!!!");
Console.WriteLine("");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("");


int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = array.Length - i - 1;
}
    Console.WriteLine(string.Join(" ", array));

Console.WriteLine("");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("");
Console.ReadKey();

