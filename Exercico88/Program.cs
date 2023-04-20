void Gerador(string mensagem, int quantidade)
{

    Console.WriteLine("+-------=======------+");
    for (int i = 0; i < quantidade; i++)
    {
        Console.WriteLine($" {mensagem} ");
    }
    Console.WriteLine("+-------=======------+");
}

string mensagem = "aprendendo C#";
int quantidade = 4;

 Gerador(mensagem,quantidade);


