// 12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
// . Após o aumento, desconte 8% de impostos. 
// . Imprima o salário inicial, o salário com o aumento e o salário final.

while (true)
{
    Console.Clear();

    Console.Write("Digite o salário inicial do funcionário: ");
    decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

    // 1. Aumento de 15% (Salário * 1.15)
    decimal salarioComAumento = salarioInicial * 1.15m;

    // 2. Desconto de 8% de impostos sobre o novo salário
    decimal imposto = salarioComAumento * 0.08m;
    decimal salarioFinal = salarioComAumento - imposto;

    Console.WriteLine("\n--- RESUMO DO CONTRACHEQUE ---");
    Console.WriteLine($"Salário inicial:       R$ {salarioInicial:N2}");
    Console.WriteLine($"Salário com (+15%):    R$ {salarioComAumento:N2}");
    Console.WriteLine($"Imposto retido (-8%):  R$ {imposto:N2}");
    Console.WriteLine("------------------------------");
    Console.WriteLine($"SALÁRIO FINAL:         R$ {salarioFinal:N2}");

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja continuar? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}