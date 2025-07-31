/*
DO WHILE: Construa um algoritmo de adivinhação
de números. Com as linhas abaixo, o algoritmo
gerará um número inteiro aleatório de 1a 100:

(C#)
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);

O seu trabalho é elaborar um algoritmo em que o
usuário possa digitar números no console até
acertar o número inteiro aleatório valorInteiro, de 1 a
100. A cada chute, o programa deve responder com
“chutou alto”, “chutou baixo” ou “acertou”. Após
acertar, deve ser mostrado quantas tentativas foram
usadas para descobrir o número.
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-------------------------");
        Console.WriteLine("  Adivinhação de Números ");
        Console.WriteLine("-------------------------");

        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 100);
        int palpite;
        int tentativas = 0;

        do
        {
            Console.WriteLine("Digite um número entre 1 e 100:");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite > valorInteiro)
            {
                Console.WriteLine("Chutou alto!");
            }
            else if (palpite < valorInteiro)
            {
                Console.WriteLine("Chutou baixo!");
            }
            else
            {
                Console.WriteLine("Acertou!");
            }

        } while (palpite != valorInteiro);

        Console.WriteLine($"Você acertou o número {valorInteiro} em {tentativas} tentativas.");
        Console.WriteLine("Obrigado por jogar!");
        Console.ResetColor();
    }
}