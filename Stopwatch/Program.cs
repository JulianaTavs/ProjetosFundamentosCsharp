Menu();
static void Menu()
{
    Console.Clear();
    Console.WriteLine("Bem vindo(a) à função cronômetro!");
    Console.WriteLine("Digite uma opção: ");
    Console.WriteLine("1 - Setar cronômetro");
    Console.WriteLine("2 - Sair do cronômetro");
    int opcao;
    string? operador = Console.ReadLine();
    opcao = int.Parse(operador!);
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Quanto tempo você quer setar no cronômetro? ");
            Console.WriteLine("Ex: 1m (1 minuto) / Ex2: 25s (25 segundos)");
            string? time = Console.ReadLine();
            time = time?.ToLower();
            char tipo = char.Parse(time!.Substring(time.Length - 1, 1));
            Console.WriteLine(tipo);


            if (tipo == 's')
            {
                char[] tempo1 = new char[time.Length - 1];
                for (int i = 0; i < time.Length - 1; i++)
                {

                    tempo1[i] = time[i];
                }
                string resultado = new string(tempo1);
                int tempo;
                tempo = int.Parse(tempo1);
                StartSegundo(tempo);
            }
            else if (tipo == 'm')
            {
                char[] tempo2 = new char[time.Length - 1];
                for (int i = 0; i < time.Length - 1; i++)
                {

                    tempo2[i] = time[i];
                }
                string resultado = new string(tempo2);
                int tempo;
                tempo = int.Parse(tempo2);
                StartMinuto(tempo);
            }

            break;

        case 2:
            System.Environment.Exit(0);
            break;
    }

}
static void StartSegundo(int tempo)
{
    int currentTime = 0;

    while (currentTime != tempo)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);

    }
    Console.WriteLine("Cronômetro encerrado!");
    Thread.Sleep(2500);
    Menu();
}
static void StartMinuto(int tempo)
{
    int currentTime = 0;

    while (currentTime != (tempo * 60))
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);

    }
    Console.WriteLine("Cronômetro encerrado!");
    Thread.Sleep(2500);
    Menu();
}
