string mensagemDeBoasVindas = "Bem-vindo ao Zynk Music";

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
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
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
    Console.WriteLine("Registri de Bandas");
    Console.WriteLine("Digite o nome da banda para registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();