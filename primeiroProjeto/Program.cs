// screen sound
using System.Net.Http.Headers;

string mensagemDeBoasVindas = " Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "u2","calypso","theBeatles"};
Dictionary<string,List<int>>bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("Linkn Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("the beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            
            break;
        case 2:MostrarBandasRegistradas();
            break;
        case 3:AvaliarUmaBanda();
            break;
        case 4: MediaBandas();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
        }
    }
void RegistrarBanda()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloDaOpcao("Registro Das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar : \n");
    string nomeDaBanda= Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso ");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();

}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //  Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();

}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()

{
    //digitar qual banda deseja avaliar
    // se a banda existir no dicionario>> atribuir uma nota
    // se nao volta ao menu principal
    Console.Clear();
    ExibirLogo();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite  o nome da banda que deseja avaliar : ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"qual a nota que a banda {nomeDaBanda} merece ? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"a nota fo {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("digite uma tecla para voltar ao menu principal");
        Console.ReadKey(true);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
}
void MediaBandas()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloDaOpcao("Media da Banda");
    Console.Write("Digite  o nome da banda que deseja ver o resultado da média : ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notaDaBAnda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é { notaDaBAnda.Average()} .");
        Console.WriteLine("Digite alguma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();




    }
    else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite ma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
}

ExibirLogo();
ExibirOpcoesDoMenu();

