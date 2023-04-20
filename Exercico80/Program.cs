// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bora Burro!!!");
Console.WriteLine("");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("");

 int[] numaleatorio = new int[30];
        Random rand = new Random();

        for (int i = 0; i < 30; i++) {
            numaleatorio[i] = rand.Next(1, 16);
        }

        Console.Write("Digite um número entre 1 e 15: ");
        int chave = int.Parse(Console.ReadLine());

        int contador = 0;
        for (int i = 0; i < 30; i++) {
            if (numaleatorio[i] == chave) {
                Console.WriteLine($"O número {chave} foi encontrado na posição {i}");
                contador++;
            }
        }

        Console.WriteLine($"O número {chave} foi sorteado {contador} vezes.");
        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("");
        Console.ReadKey();
    