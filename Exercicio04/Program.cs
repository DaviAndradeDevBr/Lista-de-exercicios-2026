// 4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
// F= (C * 1.8) + 32

while (true)
{
    Console.Clear();

    Console.Write("Digite a temperatura em Celsius: ");
    decimal Celsius = Convert.ToDecimal(Console.ReadLine());

    // Formula: (C * 1.8) + 32
    decimal fahrenheit = (Celsius * 1.8m) + 32;

    Console.WriteLine($"A temperatura de {Celsius}°C equivale a: {fahrenheit}°F");

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja continuar? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }
}


