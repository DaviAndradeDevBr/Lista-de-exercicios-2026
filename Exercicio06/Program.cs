// 6. Crie um programa para calcular a média harmônica das notas de um Aluno

while (true)
{
    Console.Clear();

    Console.Write("Digite a 1ª nota: ");
    decimal nota1 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a 2ª nota: ");
    decimal nota2 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a 3ª nota: ");
    decimal nota3 = Convert.ToDecimal(Console.ReadLine());

    if (nota1 == 0 || nota2 == 0 || nota3 == 0)
    {
       Console.WriteLine("\nErro: As notas devem ser maiores que zero para média harmônica.");
    }
    else
    {
        decimal mediaHarmonica = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));
        
        Console.WriteLine($"\nA média harmônica do aluno é: {mediaHarmonica:N2}");
    }

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja calcular outra média? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}
