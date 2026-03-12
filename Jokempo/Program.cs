class Program
{
    static List<string> jogadores = new();
    static List<int> vitorias = new();
    static List<int> derrotas = new();
    static List<int> empates = new();

    static int jogadorAtual = 0;
    static Random random = new();
    static char continuar;

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("😀 Bem-vindo ao Jokempo!");
        Console.Write("\nDigite o nome do jogador: ");
        jogadores.Add(Console.ReadLine());

        vitorias.Add(0);
        derrotas.Add(0);
        empates.Add(0);

        jogadorAtual = jogadores.Count - 1;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"=== JOKEMPO - {jogadores[jogadorAtual]} ===");
            Console.WriteLine("\n1 - Jogar");
            Console.WriteLine("2 - Estatísticas");
            Console.WriteLine("3 - Trocar Jogador");
            Console.WriteLine("4 - Novo Jogador");
            Console.WriteLine("5 - Sair");

            switch (LerNumero("\nEscolha: "))
            {
                case 1: Jogar(); break;
                case 2: MostrarEstatisticas(); break;
                case 3: TrocarJogador(); break;
                case 4: NovoJogador(); break;
                case 5: return;
            }
        }
    }

    static void NovoJogador()
    {
        Console.Clear();
        Console.WriteLine("=== NOVO JOGADOR ===");

        Console.Write("\nCaso queira voltar aperte a tecla ENTER");
        Console.Write("\n\nDigite o nome do novo jogador: ");

        jogadores.Add(Console.ReadLine());
        vitorias.Add(0);
        derrotas.Add(0);
        empates.Add(0);

        jogadorAtual = jogadores.Count - 1;
    }

    static void TrocarJogador()
    {
        Console.Clear();
        Console.WriteLine("=== TROCAR JOGADOR ===");

        for (int i = 0; i < jogadores.Count; i++)
            Console.WriteLine($"\n{i} - {jogadores[i]}");

        Console.Write("\nCaso queira voltar aperte qualquer tecla que nao seja o numero do jogador");

        int escolha = LerNumero("\n\nDigite o número do jogador: ");

        if (escolha >= 0 && escolha < jogadores.Count)
            jogadorAtual = escolha;
    }

    static void Jogar()
    {
        do
        {
            Console.Clear();

            int jogador;

            do
            {
                Console.WriteLine($"=== DESAFIO ACEITO - {jogadores[jogadorAtual]} ===");

                jogador = LerNumero(
                    "\n0- Pedra ✊" +
                    "\n1- Papel ✋" +
                    "\n2- Tesoura ✌" +
                    "\n\nDigite a opção: "
                );

            } while (jogador < 0 || jogador > 2);

            int pc = random.Next(3);

            Console.WriteLine();
            Console.WriteLine($"\nVocê: {Opcao(jogador)}");
            Console.WriteLine($"PC: {Opcao(pc)}");

            bool venceu;
            bool empate;

            VerificarResultado(jogador, pc, out venceu, out empate);

            if (empate)
            {
                Console.WriteLine("Empate!");
                int temp = empates[jogadorAtual];
                AtualizarEmpate(ref temp);
                empates[jogadorAtual] = temp;
            }
            else if (venceu)
            {
                Console.WriteLine("Você venceu!");
                int temp = vitorias[jogadorAtual];
                AtualizarVitoria(ref temp);
                vitorias[jogadorAtual] = temp;
            }
            else
            {
                Console.WriteLine("PC venceu!");
                int temp = derrotas[jogadorAtual];
                AtualizarDerrota(ref temp);
                derrotas[jogadorAtual] = temp;
            }

            do
            {
                Console.WriteLine("\nQuer jogar de novo?");
                Console.WriteLine("1 - Sim | 0 - Não");

                continuar = Console.ReadKey(true).KeyChar;

            } while (continuar != '0' && continuar != '1');

        } while (continuar == '1');
    }
    static void AtualizarVitoria(ref int v)
    {
        v++;
    }

    static void AtualizarDerrota(ref int d)
    {
        d++;
    }

    static void AtualizarEmpate(ref int e)
    {
        e++;
    }

    static void VerificarResultado(int jogador, int pc, out bool venceu, out bool empate)
    {
        empate = jogador == pc;

        venceu =
            (jogador == 0 && pc == 2) ||
            (jogador == 1 && pc == 0) ||
            (jogador == 2 && pc == 1);
    }

    static string Opcao(int op) =>
        op switch
        {
            0 => "Pedra ✊",
            1 => "Papel ✋",
            2 => "Tesoura ✌",
            _ => "?"
        };

    static void MostrarEstatisticas()
    {
        Console.Clear();
        Console.WriteLine("=== ESTATÍSTICAS ===");

        MostrarInfos(
            $"\nJogador: {jogadores[jogadorAtual]}",
            $"Vitórias: {vitorias[jogadorAtual]}",
            $"Derrotas: {derrotas[jogadorAtual]}",
            $"Empates: {empates[jogadorAtual]}"
        );

        Console.Write("\nAperte qualquer tecla para voltar...");
        Console.ReadKey();
    }

    static void MostrarInfos(params string[] infos)
    {
        foreach (var info in infos)
            Console.WriteLine(info);
    }

    static int LerNumero(string msg)
    {
        Console.Write(msg);

        var tecla = Console.ReadKey(true).KeyChar;

        Console.WriteLine(tecla);

        if (char.IsDigit(tecla))
            return tecla - '0';

        return -1;
    }
}