// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

//List < string > listaDasBandas = new List < string > ();

Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("U2", new List<int> {10,8,6});
bandasRegistradas.Add("Pink Floyd", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 exibir todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua escolha: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMediaDaBanda();
            break;
        case -1: Console.WriteLine("Tchau tchau :)");
            break;
        default: Console.WriteLine("Opção inválida!");Thread.Sleep(2000);ExibirOpcoesDoMenu();
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar uma banda");
    Console.Write("Digite o nome da banda a ser registrada: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda,new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas(){
    Console.Clear();
    Thread.Sleep(500);
    ExibirTituloDaOpcao("Lista de bandas registradas");

    //for (int i = 0; i <listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //    Thread.Sleep(500);
    //}

    foreach (string banda in bandasRegistradas.Keys) 
    { 
        Console.WriteLine($"Banda: {banda}");
        Thread.Sleep(500);
    }

    Thread.Sleep(500);
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal:");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;

    string hashtags = string.Empty.PadLeft(quantidadeDeLetras,'#');
    Console.WriteLine(hashtags);
    Console.WriteLine(titulo);
    Console.WriteLine(hashtags+"\n");
}

void AvaliarUmaBanda()
{
    // Digite qual banda deseja avaliar
    // Se a banda existir, atribuir uma nota
    // Se a banda não existir, retornar ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada, deseja cadastrar agora? S/N");
        string opcaoSelecionada = Console.ReadLine()!;
            if (opcaoSelecionada == "S") 
                {
                    Console.Clear();
                    RegistrarBandas();
                } else
        {
            Thread.Sleep(500);
            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(3000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

    }
}

void ExibirMediaDaBanda(){
    Console.Clear();
    ExibirTituloDaOpcao("Média da banda");
    Console.Write("Digite o nome da banda que deseja saber a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        bool existeNota = bandasRegistradas[nomeDaBanda].Any();
        if (existeNota)
        {
            double notaMediaBanda = bandasRegistradas[nomeDaBanda].Average();
            Console.Write($"A nota média da banda {nomeDaBanda} é {notaMediaBanda}");
            Thread.Sleep(3000);
            Console.Clear();
        } else
        {
            Console.Write($"Não existem notas registradas para a banda {nomeDaBanda}. Deseja avaliar essa banda agora? S/N");
            string opcaoSelecionada = Console.ReadLine()!;
            if (opcaoSelecionada == "S")
            {
                Console.Clear();
                AvaliarUmaBanda();
            }
            else
            {
                Thread.Sleep(500);
                Console.WriteLine("Retornando ao menu principal...");
                Thread.Sleep(3000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
        }
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada, deseja cadastrar agora? S/N");
        string opcaoSelecionada = Console.ReadLine()!;
        if (opcaoSelecionada == "S")
        {
            Console.Clear();
            RegistrarBandas();
        }
        else
        {
            Thread.Sleep(500);
            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(3000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

    }
}

ExibirOpcoesDoMenu();
