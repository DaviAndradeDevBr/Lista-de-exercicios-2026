// 22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.


while (true)
{
    Console.Clear();
    Console.WriteLine("--- Gerador de Sequência de Fibonacci ---");

    Console.Write("Digite um número limite para a sequência: ");
    int limite = Convert.ToInt32(Console.ReadLine());

    int anterior = 0;
    int atual = 1;

    Console.WriteLine($"\nSequência de Fibonacci até {limite}:");
    
    // Imprime o primeiro número
    if (limite >= 0) Console.Write(anterior);

    // Gera os próximos números enquanto o 'atual' não ultrapassar o limite
    while (atual <= limite)
    {
        Console.Write(" - " + atual);
        
        int proximo = anterior + atual;
        anterior = atual;
        atual = proximo;
    }

    Console.WriteLine("\n\nFim da sequência.");
    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja gerar outra sequência? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }
}

