// 7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

while (true)
{
   Console.Clear();
   
   
   // Prova 1
   Console.Write("Digite a nota da 1ª prova: ");
   decimal nota1 = Convert.ToDecimal(Console.ReadLine());
   Console.Write("Digite o peso da 1ª prova: ");
   decimal peso1 = Convert.ToDecimal(Console.ReadLine());

   // Prova 2
   Console.Write("Digite a nota da 2ª prova: ");
   decimal nota2 = Convert.ToDecimal(Console.ReadLine());
   Console.Write("Digite o peso da 2ª prova: ");
   decimal peso2 = Convert.ToDecimal(Console.ReadLine());

   // Cálculo da média ponderada
   decimal somaPesos = peso1 + peso2;

   if (somaPesos == 0)
    {
        Console.WriteLine("\nErro: A soma dos pesos não pode ser zero.");
    }
    else
    {
        decimal mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / somaPesos;
        Console.WriteLine($"\nA média ponderada do aluno é: {mediaPonderada:N2}");
    } 

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja realizar outro cálculo? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}