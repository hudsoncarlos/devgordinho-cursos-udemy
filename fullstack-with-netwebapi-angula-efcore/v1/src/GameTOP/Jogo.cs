using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class Jogo
    {
        private readonly IJogador _jogador;

        public Jogo(IJogador jogador)
            => _jogador = jogador;

        public void ComecarOJogo()
        {
            Console.WriteLine(_jogador.Correr());
            Console.WriteLine(_jogador.Driblar());
            Console.WriteLine(_jogador.Cair());
            Console.WriteLine(_jogador.Passar());
            Console.WriteLine(_jogador.Chutar());
        }
    }
}