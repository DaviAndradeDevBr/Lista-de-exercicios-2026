// 1. Crie um programa para calcular o volume de uma caixa retangular
// 2. Multiplique o comprimento X Largura X altura (ou profundidade)

using System;

while (true)
{
    Console.Clear();

    Console.Write("Digite o comprimento da caixa: ");
    decimal comprimento = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a largura da caixa: ");
    decimal largura = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a altura da caixa: ");
    decimal altura = Convert.ToDecimal(Console.ReadLine());

    decimal volume = comprimento * largura * altura;

    Console.WriteLine($"O volume da caixa retangular é: {volume} cm³");

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja continuar? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}

