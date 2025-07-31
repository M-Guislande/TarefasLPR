/*
Suponha que você está desenvolvendo um jogo
de RPG. Você é responsável por implementar a
mecânica de habilidades especiais para
diferentes classes de personagens. Cada classe
tem suas próprias habilidades especiais.
Crie um programa que permita ao jogador
escolher uma classe de personagem e, em
seguida, exiba suas habilidades especiais
correspondentes.
classes: 
Guerreiro, 
Mago, 
Arqueiro.
Habilidades: 
Ataque Pesado, Defesa Total;
Bola de Fogo, Escudo de Gelo;
Flecha Precisa, Disparo Triplo;
*/
internal class Rpg
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma classe de personagem:");
        Console.WriteLine("1. Guerreiro");
        Console.WriteLine("2. Mago");
        Console.WriteLine("3. Arqueiro");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Você escolheu a classe Guerreiro.");
                Console.WriteLine("Habilidades do Guerreiro:");
                Console.WriteLine("- Ataque Pesado");
                Console.WriteLine("- Defesa Total");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Você escolheu a classe Mago.");
                Console.WriteLine("Habilidades do Mago:");
                Console.WriteLine("- Bola de Fogo");
                Console.WriteLine("- Escudo de Gelo");
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você escolheu a classe Arqueiro.");
                Console.WriteLine("Habilidades do Arqueiro:");
                Console.WriteLine("- Flecha Precisa");
                Console.WriteLine("- Disparo Triplo");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Classe inválida.");
                break;
        }
        Console.ResetColor();
    }
}