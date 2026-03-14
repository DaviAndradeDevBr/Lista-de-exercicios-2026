// 3. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem
// O programa deve solicitar ao usuário:
// ● A quilometragem inicial do veículo no início da viagem
// ● A quilometragem final ao término da viagem
// ● A quantidade de combustível consumida durante a viagem (em litros)

while (true)
{
    Console.Clear();
    
    Console.Write("Digite a quilometragem inicial do veículo: ");
    decimal kmInicial = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a quilometragem final do veículo ");
    decimal kmFinal = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a quantidade de combustível consumida (litros): ");
    decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

    decimal distanciaPercorrida = kmFinal - kmInicial;

    decimal consumoLitrosPorKm = distanciaPercorrida / combustivelConsumido;

    Console.WriteLine($"O consumo de combustível durante o percurso foi de ~: {consumoLitrosPorKm} km/1");

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();
    
    Console.Write("Deseja continuar? (S/N): ");
    string? resposta = Console.ReadLine();


    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}

