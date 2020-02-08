using Core.Domain;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class Pontuacao : ObjetoDeValor
    {
        public int Valor { get; }

        private Pontuacao(int valor)
        {
            if (valor < 0)
            {
                throw new PontuacaoNaoPodeTerValorNegativo($"{nameof(valor)} não pode ser negativo.");
            }

            Valor = valor;
        }

        public Pontuacao Somar(Pontuacao pontuacao)
        {
            return new Pontuacao(this.Valor + pontuacao.Valor);
        }

        public static Pontuacao Zero()
        {
            return new Pontuacao(0);
        }

        public static Pontuacao Um()
        {
            return new Pontuacao(1);
        }

        public static Pontuacao Dois()
        {
            return new Pontuacao(2);
        }
        public static Pontuacao Tres()
        {
            return new Pontuacao(3);
        }

        public static Pontuacao Cinco()
        {
            return new Pontuacao(5);
        }

        public static Pontuacao operator +(Pontuacao p1, Pontuacao p2)
        {
            return new Pontuacao(p1.Valor + p2.Valor);
        }
    }
}
