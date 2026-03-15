// 9. A imobiliária Imóbilis vende apenas terrenos retangulares. 
// . Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.

while (true)
{
    Console.Clear();

    Console.Write("Digite a largura da frente do terreno (metros): ");
    decimal frente = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o comprimento lateral do terreno (metros): ");
    decimal lateral = Convert.ToDecimal(Console.ReadLine());

    // Cálculo da área: Base x Altura
    decimal areaTotal = frente * lateral;

    Console.WriteLine($"\nA área total do terreno é: {areaTotal:N2} m²");

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja continuar? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}