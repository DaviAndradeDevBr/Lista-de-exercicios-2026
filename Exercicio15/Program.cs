/*
   15. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.
   
   ● Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
   
   ● IMC em adultos Condição
   ● Abaixo de 18,5
   ● Abaixo do peso
   ● Entre 18,5 e 25 Peso normal
   ● Entre 25 e 30
   ● Acima do peso
   ● Acima de 30 obeso

*/

while (true)
{
    Console.Clear();

    Console.Write("Digite o seu peso (kg): ");
    decimal peso = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a sua altura (m): ");
    decimal altura = Convert.ToDecimal(Console.ReadLine());

    // Cálculo do IMC: Peso / (Altura * Altura)
    decimal imc = peso / (altura * altura);

    string condicao = "";

    // Lógica das faixas de peso
    if (imc < 18.5m)
    {
        condicao = "Abaixo do peso";
    }
    else if (imc >= 18.5m && imc <= 25m)
    {
        condicao = "Peso normal";
    }
    else if (imc > 25m && imc <= 30m)
    {
        condicao = "Acima do peso";
    }
    else
    {
        condicao = "Obeso";
    }

    Console.WriteLine($"\nSeu IMC é: {imc:N2}");
    Console.WriteLine($"Sua condição: {condicao}");

    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("Deseja continuar? (S/N): ");
    string? resposta = Console.ReadLine();

    if (resposta == "n" || resposta == "N")
    {
        break;
    }

}
