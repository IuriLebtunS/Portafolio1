void Gerador(string mensagem, int quantidade, int borda) {
        string borda1 = "+-------=======------+";
        string borda2 = "~~~~~~~~:::::::::~~~~~~~~";
        string borda3 = "<<<<<<<<------->>>>>>>";
        string bordaSelecionada = "";

        switch (borda) {
            case 1:
                bordaSelecionada = borda1;
                break;
            case 2:
                bordaSelecionada = borda2;
                break;
            case 3:
                bordaSelecionada = borda3;
                break;
            default:
                Console.WriteLine("Borda inválida!");
                return;
        }

        Console.WriteLine(bordaSelecionada);
        for (int i = 0; i < quantidade; i++) {
            Console.WriteLine("  " + mensagem);
        }
        Console.WriteLine(bordaSelecionada);
    }

        Gerador("Aprendendo C#", 4, 2);
