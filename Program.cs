string mensagemDeBoasVindas = "Bem-vindo ao Zynk Music";
//List<string> listaDasBandas = new List<string> {"Linkin Park" , "Iron Maiden" , "Ramnstein"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"    
█░▄▄░▄█▄─█─▄█▄─▀█▄─▄█▄─█─▄███▄─▀█▀─▄█▄─██─▄█─▄▄▄▄█▄─▄█─▄▄▄─█
██▀▄█▀██▄─▄███─█▄▀─███─▄▀█████─█▄█─███─██─██▄▄▄▄─██─██─███▀█
▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▀▀▀▄▄▄▀▄▄▄▀▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀
");
    Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nSelecione uma opção:");
    Console.WriteLine("Digite 1 para resgistrar uma banda ou individual");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar as avaliações da banda");
    Console.WriteLine("\nSAÍDA");
    Console.WriteLine("Digite -1 para sair:");

    Console.Write("\nDigite a sua opção: ");
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
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Saindo do programa...");
            Environment.Exit(0);
            break;
        default: Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            ExibirMenu();
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda para registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas Registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
       Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quanidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quanidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
}

ExibirMenu();