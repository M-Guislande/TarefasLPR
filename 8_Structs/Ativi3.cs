/*
Desenvolva um programa em C# que
simule um sistema de seleção de heróis da
Marvel para uma equipe. O programa deve
ter as seguintes funcionalidades:
a) Cadastro de Heróis:
Crie uma função chamada cadastrarHeroi que permita ao usuário
inserir o nome, poder e pontuação de um herói da Marvel. A função deve
solicitar essas informações ao usuário e armazená-las em UM STRUCT. O
programa deve permitir o cadastro de até 5 heróis.

b) Seleção de Equipe:
Crie uma função chamada selecionarEquipe que permita ao usuário
selecionar heróis para formar sua equipe. A função deve exibir os heróis
cadastrados e permitir que o usuário selecione quais heróis deseja incluir
em sua equipe. O usuário deve ser capaz de selecionar três heróis para
sua equipe.

c) Pontuação Total da Equipe:
Crie uma função chamada calcularPontuacaoTotal que calcule a
pontuação total da equipe com base nos heróis selecionados. A
pontuação total da equipe deve ser a soma das pontuações individuais de
cada herói selecionado.

d) Exibição da Equipe:
Crie uma função chamada exibirEquipe que exiba os heróis
selecionados para a equipe, seu poder e a pontuação total da equipe.

e) Menu:
Crie uma função chamada menuPrincipal que exiba um menu com as
opções disponíveis para o usuário (cadastro de heróis, seleção de equipe,
exibição da equipe e sair do programa). O usuário deve poder escolher
uma das opções do menu e o programa deve executar a funcionalidade
correspondente.

Requisitos Adicionais:
● O programa deve continuar em execução até que o usuário escolha
a opção de sair.
● Utilize STRUCTS para armazenar as informações dos heróis e da
equipe.
● Não utilize classes ou listas! Pode (ou será que deve) utilizar vetores
*/
using System;

struct Heroi
{
    public string nome;
    public string poder;
    public int pontuacao;
}

class Program
{
    static Heroi[] herois = new Heroi[5];
    static Heroi[] equipe = new Heroi[3];
    static int totalHerois = 0;
    static int totalEquipe = 0;

    static void Main()
    {
        menuPrincipal();
    }

    static void cadastrarHeroi()
    {
        if (totalHerois >= 5)
        {
            Console.WriteLine("Limite de heróis cadastrados atingido!\n");
            return;
        }

        Console.WriteLine($"\nCadastro do Herói #{totalHerois + 1}:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Poder: ");
        string poder = Console.ReadLine();

        int pontuacao;
        while (true)
        {
            Console.Write("Pontuação (número inteiro positivo): ");
            if (int.TryParse(Console.ReadLine(), out pontuacao) && pontuacao >= 0)
                break;
            Console.WriteLine("Entrada inválida. Tente novamente.");
        }

        herois[totalHerois].nome = nome;
        herois[totalHerois].poder = poder;
        herois[totalHerois].pontuacao = pontuacao;
        totalHerois++;

        Console.WriteLine("Herói cadastrado com sucesso!\n");
    }

    static void selecionarEquipe()
    {
        if (totalHerois < 3)
        {
            Console.WriteLine("\nVocê precisa cadastrar pelo menos 3 heróis antes de formar uma equipe.\n");
            return;
        }

        Console.WriteLine("\n=== Heróis Disponíveis ===");
        for (int i = 0; i < totalHerois; i++)
        {
            Console.WriteLine($"{i + 1}. {herois[i].nome} - {herois[i].poder} - {herois[i].pontuacao} pontos");
        }

        totalEquipe = 0;
        for (int i = 0; i < 3; i++)
        {
            int escolha;
            while (true)
            {
                Console.Write($"\nEscolha o índice do {i + 1}º herói para a equipe: ");
                if (int.TryParse(Console.ReadLine(), out escolha) &&
                    escolha >= 1 && escolha <= totalHerois)
                {
                    bool jaEscolhido = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (equipe[j].nome == herois[escolha - 1].nome)
                        {
                            jaEscolhido = true;
                            break;
                        }
                    }

                    if (!jaEscolhido)
                    {
                        equipe[i] = herois[escolha - 1];
                        totalEquipe++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Herói já selecionado. Escolha outro.");
                    }
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                }
            }
        }

        Console.WriteLine("\nEquipe selecionada com sucesso!\n");
    }

    static int calcularPontuacaoTotal()
    {
        int total = 0;
        for (int i = 0; i < totalEquipe; i++)
        {
            total += equipe[i].pontuacao;
        }
        return total;
    }

    static void exibirEquipe()
    {
        if (totalEquipe == 0)
        {
            Console.WriteLine("\nNenhuma equipe foi selecionada ainda.\n");
            return;
        }

        Console.WriteLine("\n=== Equipe Selecionada ===");
        for (int i = 0; i < totalEquipe; i++)
        {
            Console.WriteLine($"{i + 1}. {equipe[i].nome} - {equipe[i].poder} - {equipe[i].pontuacao} pontos");
        }

        int total = calcularPontuacaoTotal();
        Console.WriteLine($"\nPontuação Total da Equipe: {total} pontos\n");
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("====== MENU ======");
            Console.WriteLine("1. Cadastrar Herói");
            Console.WriteLine("2. Selecionar Equipe");
            Console.WriteLine("3. Exibir Equipe");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        cadastrarHeroi();
                        break;
                    case 2:
                        selecionarEquipe();
                        break;
                    case 3:
                        exibirEquipe();
                        break;
                    case 4:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida!\n");
            }

        } while (opcao != 4);
    }
}
