using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : IJogador
    {
        private readonly string nome;

        public Jogador3(string nome)
            => this.nome = nome;
        public string Cair()
            => $"{nome} Caiu.";

        public string Chutar()
            => $"{nome} Chutou.";

        public string Correr()
            => $"{nome} Correu.";

        public string Driblar()
            => $"{nome} Driblou.";

        public string Passar()
            => $"{nome} Passou.";
    }
}