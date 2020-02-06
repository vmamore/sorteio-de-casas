using Core.Domain;
using System;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class Idade : ObjetoDeValor
    {
        public DateTime DataDeNascimento { get; }

        public Idade(DateTime dataDeNascimento)
        {
            if(dataDeNascimento == DateTime.MinValue)
            {
                throw new DataDeNascimentoNaoPodeTerValorMinimoException("Data de nascimento deve possuir valor diferente de mínimo!");
            }

            DataDeNascimento = dataDeNascimento;
        }

        public int Obter()
        {
            return 0;
        }

        public static Idade CriarNovo(DateTime dataDeNascimento)
        {
            return new Idade(dataDeNascimento);
        }

        internal bool MaiorQueDezoito()
        {
            return this.Obter() > 18;
        }
    }
}
