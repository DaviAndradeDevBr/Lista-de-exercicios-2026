// 5. Crie um programa para calcular o salário total de um vendedor
// . Deverá ser informado: 
// . O salário base e o total de vendas
// . A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas

while (true)
{
    Console.Clear();
    
    Console.Write("Digite o salário base: ");
    decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o total de vendas realizadas: ");
    decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o percentual da comissão (ex: 5 para 5%): ");
    decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());

    decimal valorComissao = (totalVendas * percentualComissao) / 100;

    decimal salarioTotal = salarioBase + valorComissao;

    Console.WriteLine($"\nValor da comissão: R$ {valorComissao:N2}");
    Console.WriteLine($"Salário total a receber: R$ {salarioTotal:N2}");

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja calcular outro salário? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}