// 14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.


using System.Collections.Generic;
using System.Linq;

while (true)
{
    Console.Clear();
    
    // Criamos uma lista para guardar os números
    List<int> numeros = new List<int>();

    Console.Write("Digite o 1º valor inteiro: ");
    numeros.Add(Convert.ToInt32(Console.ReadLine()));

    Console.Write("Digite o 2º valor inteiro: ");
    numeros.Add(Convert.ToInt32(Console.ReadLine()));

    Console.Write("Digite o 3º valor inteiro: ");
    numeros.Add(Convert.ToInt32(Console.ReadLine()));

    // Ordena a lista (Crescente) e depois inverte para ficar Decrescente
    numeros.Sort();
    numeros.Reverse();

    Console.WriteLine("\nOs números em ordem decrescente são: ");
    Console.WriteLine(string.Join(" - ", numeros));

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja continuar? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}
