// 19. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se 
// encontram no conjunto dos números de 1 até 500.


while (true)
{
    Console.Clear();
    Console.WriteLine("--- Soma de Ímpares Múltiplos de 3 (1 até 500) ---");

    int soma = 0; // Variável para acumular o resultado

    // Laço de 1 até 500
    for (int i = 1; i <= 500; i++)
    {
        // Verifica se é ímpar E se é múltiplo de 3
        if (i % 2 != 0 && i % 3 == 0)
        {
            soma += i; // Adiciona o número ao total
        }
    }

    Console.WriteLine($"\nA soma de todos os números encontrados é: {soma}");

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja calcular novamente? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

    Console.WriteLine("\nLimpando e reiniciando...");
    Thread.Sleep(1000);

}

