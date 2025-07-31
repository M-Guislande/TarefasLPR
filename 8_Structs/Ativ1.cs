/*
Defina uma struct Produto que contenha
os seguintes campos: Nome, Codigo,
Preco e Quantidade. Crie um programa
que permita ao usuário inserir dados de 3
produtos e, em seguida, exiba o valor
total em estoque (considerando o preço e
a quantidade de cada produto).
*/
using System;

class Estoque
{
    private struct Produto
    {
        public String? Nome;
        public int Codigo;
        public float Preco;
        public int Quantidade;
    }
    private static void Main()
    {
        Produto[] estoque = new Produto[3]; // array de Struct
        float soma = 0;

        //Cadastros dos produtos

        for (int i = 0; i < estoque.Length; i++)
        {
            Console.WriteLine($"Cadastro do Produto {i + 1}");

            Console.Write("Nome: ");
            do
            {
                estoque[i].Nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(estoque[i].Nome))
                    Console.Write("Nome inválido. Digite novamente: ");

            } while (string.IsNullOrWhiteSpace(estoque[i].Nome));            

            Console.Write("Código: ");
            while (!int.TryParse(Console.ReadLine(), out estoque[i].Codigo))
                Console.Write("Código inválido. Digite novamente: ");

            Console.Write("Preço: ");
            while (!float.TryParse(Console.ReadLine(), out estoque[i].Preco))
                Console.Write("Preço inválido. Digite novamente: ");

            Console.Write("Quantidade: ");
            while (!int.TryParse(Console.ReadLine(), out estoque[i].Quantidade))
                Console.Write("Quantidade inválida. Digite novamente: ");

            Console.WriteLine();
        }

        //Calculo para descobrir o valor do estoque

        for (int i = 0; i < estoque.Length; i++)
            soma += estoque[i].Preco * estoque[i].Quantidade;
            
        //mostra o valor do estoque

        Console.Write($"O valor total do estoque: {soma:F2}");
    }
}