// 17. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
// contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

while (true)
{
    Console.Clear();

    Console.Write("Digite o valor de A: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o valor de B: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int c;

    if (a == b)
    {
        // Se forem iguais, soma
        c = a + b;
        Console.WriteLine($"\nValores iguais! Somando: {a} + {b}");
    }
    else
    {
        // Se forem diferentes, multiplica
        c = a * b;
        Console.WriteLine($"\nValores diferentes! Multiplicando: {a} * {b}");
    }

    Console.WriteLine($"O resultado final (C) é: {c}");

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja realizar outro cálculo? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}