// Scren Sound
using System;

string mensagemDeBoaVindas = "Boas vindas ao Scren Sound";
//List<string> listaDeBandas = new List<string> { "Kiss", "Iron Maiden" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

void exibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoaVindas);
}

void exibirMenu()
{


    exibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.WriteLine("\nInforme a Opção desejada");

    int opcaoEscolhidaNumerica = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhidaNumerica)
    {

        case 1:
            registrarBanda();
            break;
        case 2:
            mostrarBanda();
            break;
        case 3:
            avaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("Opção escolhida foi: " + opcaoEscolhidaNumerica);
            break;
        case 0:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

void registrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");

    string opcao = "1";

    while (opcao == "1")
    {
        Console.Write("Informe a banda: ");
        string nomeBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeBanda, new List<int>());

        Console.WriteLine($"A banda {nomeBanda} foi cadastrada com sucesso!!!");
        Console.WriteLine();
        Console.WriteLine("Deseja informar outra banda?");
        Console.WriteLine("Digite 1 para sim ou 2 para sair");

        opcao = Console.ReadLine()!;
        Console.Clear();
    }

    Thread.Sleep(1000);
    exibirMenu();
}


void mostrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de Bandas");
    

    //for (int i = 0; i < listaDeBandas.Count; i++){
    // Console.WriteLine($"Banda: {listaDeBandas[i]}");
    // }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nAperte a tecla X para sair");
    Console.ReadKey();

    Console.Clear();
    exibirMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    // Colocar o asteriscos do tamanho da frase
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void avaliarUmaBanda() {
    
    Console.Clear();
    // Digite qual banda deseja avaliar
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Informe a banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

    }
    else
    {
        Console.WriteLine($"\n Essa Banda {nomeDaBanda}, não foi encontrada");
        Console.WriteLine("Aperte a tecla X para sair");
        Console.ReadKey();
        Console.Clear();
        exibirMenu();

    }

    // Se a banda existir no dicionario >> atribuir uma nota

    // Senão, volta ao menu principal
}




exibirMenu();