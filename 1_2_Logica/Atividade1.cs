/*
Faça um programa para ler o
valor do raio de um círculo, e depois
mostrar o valor da área deste círculo com
quatro casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159
*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        const float Pi = 3.14159f;
        Console.Write("Digite o raio: ");
        uint Raio = uint.Parse(Console.ReadLine());
        Console.WriteLine($"O valor da area é: {Raio * Raio * Pi:F4} metros^2 ola");
    }
}