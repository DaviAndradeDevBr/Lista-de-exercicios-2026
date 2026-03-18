// 13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.


while (true)
{
    Console.Clear();
    
    Console.Write("Digite o valor de A: ");
    decimal a = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o valor de B: ");
    decimal b = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o valor de C: ");
    decimal c = Convert.ToDecimal(Console.ReadLine());

    decimal soma = a + b;

    Console.WriteLine($"\nA soma de A + B é: {soma}");

    if (soma < c)
    {
        Console.WriteLine($"SIM! A soma ({soma}) é MENOR que C ({c}).");
    }
    else
    {
        Console.WriteLine($"NÃO! A soma ({soma}) NÃO é menor que C ({c}).");
    }

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja continuar? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }
    
}
