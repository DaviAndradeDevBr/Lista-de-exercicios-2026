// 11. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
// . Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
// de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

while (true)
{
   Console.Clear();

   Console.Write("Digite o seu nome: ");
   string? nome = Console.ReadLine();

   Console.Write("Digite a sua idade: ");
   int idade = Convert.ToInt32(Console.ReadLine());

   // Cálculo: idade * 365 dias
   int diasDeVida = idade * 365;

   // Exibição formatada (Nome em maiúsculo) 
   Console.WriteLine($"\n{nome?.ToUpper()}, VOCÊ JÁ VIVEU {diasDeVida} DIAS!");

   Console.WriteLine("\nPressione ENTER para continuar...");
   Console.ReadLine();

   Console.Write("Deseja continuar? (S/N): ");
   string? resposta = Console.ReadLine();

   if (resposta == "n" || resposta == "N")
    {
        break;
    }

}
