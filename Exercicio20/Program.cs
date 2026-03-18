/*
  20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
  tabuada na forma:
  
  ● 0 x N = 0,
  ● 1 x N = 1N,
  ● 2 x N = 2N,
  .
  .
  .
  ● 10 x N = 10N.

*/


while (true)
{
    Console.Clear();
    Console.WriteLine("--- Gerador de Tabuada ---");
    
    Console.Write("Digite um valor para N (de 1 a 10): ");
    int n = Convert.ToInt32(Console.ReadLine());

    // Verifica se o número está no intervalo permitido
    if (n >= 1 && n <= 10)
    {
        Console.WriteLine($"\nTabuada do {n}:");
        
        // Laço de 0 até 10 para gerar a tabuada
        for (int i = 0; i <= 10; i++)
        {
            int resultado = i * n;
            Console.WriteLine($"{i} x {n} = {resultado}");
        }
    }
    else
    {
        Console.WriteLine("\nErro: Por favor, digite um número entre 1 e 10.");
    }

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja calcular outra tabuada? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }
}
