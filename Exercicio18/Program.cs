// 18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200

while (true)
{
    Console.Clear();
    Console.WriteLine("--- Números ímpares entre 100 e 200 ---");


    Console.WriteLine("\nGerando lista...");

    // Laço que começa em 100 e vai até 200
    for (int i = 100; i <= 200; i++)
    {
        // Se o resto da divisão por 2 for diferente de zero, é ímpar
        if (i % 2 != 0)
        {
            Console.Write(i + " ");
        }
    }

    Console.WriteLine("\n\nFim da lista.");
    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja gerar a lista novamente? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

    Console.WriteLine("\nLimpando e reiniciando...");
    Thread.Sleep(1000);    

}
