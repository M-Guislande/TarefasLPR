/*
Fazer um programa para ler um número
inteiro, e depois dizer se este número é par
ou não.
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Digite um numero intero e o programa dira se é par ou impar");
        Console.WriteLine("-----------------");
        Console.WriteLine("Digite um numero");
        Console.WriteLine("-----------------");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Numero é par");
        }
        else
        {
            Console.WriteLine("Numero é impar");
        }
        Console.ResetColor();
    }
}