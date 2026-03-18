// 23. Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
// . múltiplos de 3 pela palavra "Fizz" e os múltiplos de 5 pela palavra "Buzz". 
// . Para números que são múltiplos de ambos, use "FizzBuzz".


while (true)
{
    Console.Clear();
    Console.WriteLine("--- Desafio FizzBuzz (1 a 100) ---");
    Console.WriteLine("Regras: Múltiplo de 3 = Fizz | Múltiplo de 5 = Buzz | Ambos = FizzBuzz\n");

    for (int i = 1; i <= 100; i++)
    {
        // 1º: Verifica se é múltiplo de ambos (3 e 5)
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        // 2º: Verifica apenas múltiplo de 3
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        // 3º: Verifica apenas múltiplo de 5
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        // Se não for nenhum, imprime o número
        else
        {
            Console.WriteLine(i);
        }
    }

    Console.WriteLine("\n--- Fim do FizzBuzz ---");
    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja rodar o desafio novamente? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

    Console.WriteLine("\nLimpando e reiniciando...");
    Thread.Sleep(1000);

}
