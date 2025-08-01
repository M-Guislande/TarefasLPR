/*
A tabela a seguir
mostra a distância de quatro cidades entre
si. Por exemplo, a distância entre Vitória e
Belo Horizonte é de 524 km.

Crie um programa
que leia essa matriz e informe ao usuário a
distância entre duas cidades por ele
fornecidas.
O programa deve ficar repetindo até que o
usuário informe a mesma cidade como
origem e destino.
*/
using System;

class Program
{
    static int conversao(string local)
    {
        // local.Tolower deixa todas as letras da entrada minusculas 
        // local.trim retira os espaços do inicio e do fim do codigo
        local = local.ToLower().Trim();
        switch (local)
        {
            case "vitória": return 0;
            case "belo horizonte": return 1;
            case "rio de janeiro": return 2;
            case "são paulo": return 3;
            default: return -1;
        }
    }

    static void Main()
    {
        string local;
        int destino = -1, atual = -2;

        int[,] distancia =
        {
            {0,524,521,882},
            {524,0,434,586},
            {521,434,0,429},
            {882,586,429,0}
        };
        int[,] matriz = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

        //Verifica se o usuario chegou no destino
        while (atual != destino)
        {
            // verifica se ele escreveu uma cidade que existe
            do
            {
                Console.WriteLine("Onde vc esta? ");
                local = Console.ReadLine();

                // converte o nome da cidade para um numero para colocar na matriz
                atual = conversao(local);
                if (atual == -1) Console.WriteLine("Essa cidade não existe no contexto atual");
            } while (atual == -1);

            do
            {
                Console.WriteLine("Onde vc quer ir? ");
                local = Console.ReadLine();
                destino = conversao(local);
                if (destino == -1) Console.WriteLine("Essa cidade não existe no contexto atual");
            } while (destino == -1);

            //diz a distancia que o usuario esta do local onde ele quer chegar
            if (atual != destino)
                Console.WriteLine($"Voce esta a {distancia[atual, destino]} km de {local}.");
            else
                Console.WriteLine("Você já está no seu destino. Programa encerrado.");
        }
    }
}