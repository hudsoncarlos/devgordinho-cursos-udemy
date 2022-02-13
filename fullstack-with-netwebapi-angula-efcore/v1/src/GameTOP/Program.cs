using System;
using GameTop.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogador1 = new Jogador1("Hudson");
            var jogador2 = new Jogador2("Ronaldo");
            var jogador3 = new Jogador3("Pelé");

            new Jogo(jogador1).ComecarOJogo();
            Console.WriteLine("");
            new Jogo(jogador2).ComecarOJogo();
            Console.WriteLine("");
            new Jogo(jogador3).ComecarOJogo();
        }
    }
}
