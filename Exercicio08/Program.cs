// 8. Crie um programa para verificar se um número é primo

while (true)
{
    Console.Clear();
    
    Console.Write("Digite um número inteiro positivo: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    bool ehPrimo = true;

    if (numero <= 1)
    {
        ehPrimo = false; // 0 e 1 não são primos
    }
    else
    {
        // testa se o número é divisível por qualquer outro entre 2 e ele mesmo
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                ehPrimo = false;
                break; // se achou um divisor, já sabe que não é primo
            }
        }
    }

    if (ehPrimo)
    {
        Console.WriteLine($"\nO número {numero} É PRIMO!");
    }
    else
    {
        Console.WriteLine($"\nO número {numero} NÃO é primo.");
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
