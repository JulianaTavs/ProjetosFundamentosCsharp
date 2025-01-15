Menu();
static void Menu()
{
    Console.WriteLine("Qual operação você deseja fazer?");
    Console.WriteLine("Digite 1 para SOMA");
    Console.WriteLine("Digite 2 para SUBTRAÇÃO");
    Console.WriteLine("Digite 3 para MULTIPLICAÇÃO");
    Console.WriteLine("Digite 4 para DIVISÃO");
    Console.WriteLine("Digite 5 para SAIR");
    string? opcao = Console.ReadLine();
    int operacao;

    // Lê a operação escolhida pelo usuário
    operacao = int.Parse(opcao!);

    switch (operacao)
    {
        case 1:
            Soma();
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Multiplicacao();
            break;
        case 4:
            Divisao();
            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Essa opção não existe. Escolha novamente: ");
            Menu();
            break;
    }
}
static void Soma()
{
    Console.Clear();


    float n1 = ObterNumeroValido("Digite o primeiro número: ");


    float n2 = ObterNumeroValido("Digite o segundo número: ");


    float resultado = n1 + n2;


    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.WriteLine("");

    // Chama o Menu novamente
    Menu();
}
static void Subtracao()
{
    Console.Clear();


    float n1 = ObterNumeroValido("Digite o primeiro número: ");


    float n2 = ObterNumeroValido("Digite o segundo número: ");


    float resultado = n1 - n2;


    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.WriteLine("");

    // Chama o Menu novamente
    Menu();
}
static void Multiplicacao()
{
    Console.Clear();


    float n1 = ObterNumeroValido("Digite o primeiro número: ");


    float n2 = ObterNumeroValido("Digite o segundo número: ");


    float resultado = n1 * n2;


    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.WriteLine("");

    // Chama o Menu novamente
    Menu();
}
static void Divisao()
{
    Console.Clear();


    float n1 = ObterNumeroValido("Digite o primeiro número: ");


    float n2 = ObterNumeroValido("Digite o segundo número: ");


    float resultado = n1 / n2;


    Console.WriteLine($"O resultado da divisão é: {resultado}");
    Console.WriteLine("");

    // Chama o Menu novamente
    Menu();
}

static float ObterNumeroValido(string mensagem)
{
    float numero;
    string? input; // Declara que input pode ser null

    while (true)
    {
        Console.WriteLine(mensagem);
        input = Console.ReadLine();

        // Verifica se a entrada não é nula ou vazia
        if (!string.IsNullOrEmpty(input))
        {
            try
            {
                // Tenta converter o input para float
                numero = float.Parse(input);
                return numero;
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Você deve digitar um número.");
        }

        // Continua pedindo a entrada até ser válida
        Console.WriteLine("Tente novamente: ");
    }
}



