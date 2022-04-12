using System;

namespace JogoAula1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char resp = 's';
            while (resp == 's'){

                int sorteio = new Random().Next(1, 5);

                Console.Write("Digite um número entre 1 e 5: ");
                int chute = int.Parse(Console.ReadLine());

                if (chute == sorteio)
                {
                    Console.WriteLine($"O número: {sorteio}");
                    Console.WriteLine("Parabéns, você acertou!");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Quer tentar novamente? s/n");
                    resp = char.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Quaseeeee :( , o número era: {sorteio}");
                    Console.WriteLine("Você erroouuu!");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Quer tentar novamente? s/n");
                    resp = char.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("O Jogo acabou! Até maiss :)");
        }
    }
}
