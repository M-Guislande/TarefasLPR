/*
ESCOLHA A MELHOR ESTRUTURA DE
REPETIÇÃO: Solicite ao usuário para inserir
um número e calcule a soma dos dígitos do
quadrado desse número. Por exemplo, se o
número fornecido for 123, calcule 123² =
15129 e então a soma dos seus dígitos: 1 +
5 + 1 + 2 + 9 = 18.
*/
internal class Tarefa4
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------");
        Console.WriteLine(" ATIVIDADE 4  ");
        Console.WriteLine("--------------\n");
        Console.WriteLine("Digite um número e o sistema calcula a soma dos dígitos do quadrado desse número");
        int num = int.Parse(Console.ReadLine());
        int num_quadrado = num * num;
        int resultado = 0;
        for (int i = num_quadrado; i > 0; i /= 10)
        {
            resultado += i % 10;
        }
        Console.WriteLine($"A soma de digitos é de: {resultado}");
        Console.ResetColor();
    }
}