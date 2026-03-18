// 21. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado
// a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120


while (true)
{
    Console.Clear();
    Console.WriteLine("--- Calculadora de Fatorial (A!) ---");

    Console.Write("Digite um valor inteiro para A: ");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a < 0)
    {
        Console.WriteLine("Erro: Não existe fatorial de número negativo.");
    }
    else
    {
        long fatorial = 1;
        string sequencia = "";

        // Laço que faz a conta de trás para frente
        for (int i = a; i >= 1; i--)
        {
            fatorial *= i;
            
            // Monta a string da sequência (ex: 5 X 4 X 3...)
            sequencia += i + (i > 1 ? " X " : "");
        }

        // Se o número for 0, o fatorial é 1 por definição
        if (a == 0) sequencia = "0";

        Console.WriteLine($"\n{a}! = {sequencia} = {fatorial}");
    }

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja realizar um novo cálculo? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }
}

