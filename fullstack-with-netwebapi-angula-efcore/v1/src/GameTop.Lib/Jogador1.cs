using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        private readonly string nome;

        public Jogador1(string nome)
            => this.nome = nome;
            
        public string Cair()
            => $"O jogador {nome} caiu!";

        public string Chutar()
            => $"O jogador {nome} chutou!";

        public string Correr()
            => $"O jogador {nome} correu!";

        public string Driblar()
            => $"O jogador {nome} driblou!";

        public string Passar()
            => $"O jogador {nome} tocou!";
    }
}