// 10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia
// . Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos), 
// e quanto deve guardar numa conta de poupança (10% do total arrecadado).
// . Com base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular os dados solicitados.

while (true)
{
    
  Console.Clear();

  Console.Write("Quantidade de pães vendidos: ");
  int qtdPaes = Convert.ToInt32(Console.ReadLine());

  Console.Write("Quantidade de broas vendidas: ");
  int qtdBroas = Convert.ToInt32(Console.ReadLine());

  // Cálculos dos valores totais
  decimal totalPaes = qtdPaes * 0.12m;
  decimal totalBroas = qtdBroas * 1.50m;
  decimal totalArrecadado = totalPaes + totalBroas;

  // Cálculo da poupança (10%)
  decimal poupança = totalArrecadado * 0.10m;

  Console.WriteLine($"\nFaturamento com pães:  R$ {totalPaes:N2}");
  Console.WriteLine($"Faturamento com broas:  R$ {totalBroas:N2}");
  Console.WriteLine("-----------------------------------");
  Console.WriteLine($"Total arrecadado:       R$ {totalArrecadado:N2}");
  Console.WriteLine($"Valor para poupança:    R$ {poupança:N2}");

  Console.WriteLine("\nPressione ENTER para continuar...");
  Console.ReadLine();

  Console.Write("Deseja continuar? (S/N): ");
  string? resposta = Console.ReadLine();

  if (resposta == "n" || resposta == "N")
    {
        break;
    }
        
}
