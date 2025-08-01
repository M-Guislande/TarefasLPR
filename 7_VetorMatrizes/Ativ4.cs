/*
MATRIZ Crie um algoritmo que
leia duas matrizes A e B, de tamanho 3x3, e
calcule A*B. Dica abaixo:
*/
using System;
class Program
{
    static void Main()
    {
        int[,] matriz_A = new int[3, 3];
        int[,] matriz_B = new int[3, 3];
        int[,] resultado = new int[3, 3];
        int soma = 0;
        //Cria a matriz A com numeros definido pelo usuario
        for (int i = 0; i < matriz_A.GetLength(0); i++)
        {
            for (int j = 0; j < matriz_A.GetLength(1); j++)
            {
                Console.Write($"Digite a matriz A({i + 1},{j + 1}): ");
                matriz_A[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        //Cria a matriz B com numeros definido pelo usuario
        for (int i = 0; i < matriz_B.GetLength(0); i++)
        {
            for (int j = 0; j < matriz_B.GetLength(1); j++)
            {
                Console.Write($"Digite a matriz B({i + 1},{j + 1}): ");
                matriz_B[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //coluna da matriz resultado
        for (int i = 0; i < 3; i++) // linha de A
        {
            for (int j = 0; j < 3; j++) // coluna de B
            {
                soma = 0;
                for (int k = 0; k < 3; k++) // percorre elementos da linha de A e coluna de B
                {
                    soma += matriz_A[i, k] * matriz_B[k, j];
                }
                resultado[i, j] = soma;
            }
        }

        
        //mostra de forma bonitinha
        Console.WriteLine("O resultado da multiplicação é: ");
        for (int i = 0; i < resultado.GetLength(0); i++)
        {
            Console.WriteLine();

            for (int j = 0; j < resultado.GetLength(1); j++) Console.Write($" {resultado[i, j]}");

        }
    }
}