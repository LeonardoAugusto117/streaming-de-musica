// Scren Sound
string mensagemDeBoaVindas = "Boas vindas ao Scren Sound";
List<string> listaDeBandas = new List<string> { "Kiss", "Iron Maiden"};

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
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica)
    {

        case 1:
            registrarBanda();
            break;
        case 2:
            mostrarBanda();
            break;
        case 3:
            Console.WriteLine("Opção escolhida foi: " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Opção escolhida foi: " + opcaoEscolhida);
            break;
    }

}

void registrarBanda()
{
    Console.Clear();
    Console.WriteLine("*****************");
    Console.WriteLine("Registrar bandas");
    Console.WriteLine("*****************");

    string opcao = "1";

    while (opcao == "1")
    {
        Console.Write("Informe a banda: ");
        string nomeBanda = Console.ReadLine()!;
        listaDeBandas.Add(nomeBanda);

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


void mostrarBanda(){
    Console.Clear();
    Console.WriteLine("*****************");
    Console.WriteLine("Lista de Bandas");
    Console.WriteLine("*****************");

    //for (int i = 0; i < listaDeBandas.Count; i++){
    // Console.WriteLine($"Banda: {listaDeBandas[i]}");
    // }

    foreach (string banda in listaDeBandas) {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nAperte a tecla X para sair");
    Console.ReadKey();

    Console.Clear();
    exibirMenu();
}


exibirMenu();