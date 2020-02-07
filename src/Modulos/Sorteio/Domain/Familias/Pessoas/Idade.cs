using Core.Domain;
using System;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class Idade : ObjetoDeValor
    {
        public DateTime DataDeNascimento { get; }

        private Idade(DateTime dataDeNascimento)
        {
            if (dataDeNascimento == DateTime.MinValue)
            {
                throw new DataDeNascimentoNaoPodeTerValorMinimoException("Data de nascimento deve possuir valor diferente de mínimo!");
            }

            if (dataDeNascimento > DateTime.Today)
            {
                throw new DataDeNascimentoNaoPodeSerNoFuturo("Data de nascimento não pode ser no futuro.");
            }

            DataDeNascimento = dataDeNascimento;
        }

        public int Obter()
        {
            var idadeAtual = DateTime.Now.Year - DataDeNascimento.Year;

            if (DataDeNascimento.Date.Month > DateTime.Now.Date.Month)
                idadeAtual--;
            else if (DataDeNascimento.Date.Month >= DateTime.Now.Date.Month &&
                     DataDeNascimento.Date.Day > DateTime.Now.Date.Day)
                idadeAtual--;

            return idadeAtual;
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
