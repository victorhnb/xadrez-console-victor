using System;
using tabuleiro;

namespace xadrez_console_victor
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);
        }
    }
}
