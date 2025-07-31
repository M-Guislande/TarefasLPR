/*
Fazer um programa para ler
quatro valores inteiros A, B, C e D. A seguir,
calcule e mostre a diferença do produto de
A e B pelo produto de C e D
*/
using System;

internal class Programa
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com os valor de A, B, C e D: ");
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        Console.WriteLine($"Diferença: {(A*B)-(C*D)}");
    }
}