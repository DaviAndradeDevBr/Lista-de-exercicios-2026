// 16. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.


while (true)
{
    Console.Clear();

    Console.Write("Digite um número inteiro: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    // Se o resto da divisão por 2 for zero, é par
    if (numero % 2 == 0)
    {
        Console.WriteLine($"\nO número {numero} é PAR!");
    }
    else
    {
        Console.WriteLine($"\nO número {numero} é ÍMPAR!");
    }

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja verificar outro número? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }
    
}
