using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias.Pessoas;
using System;

namespace Sorteio.Domain.Criterios.RendaTotalDaFamilia
{
    public abstract class CriterioDaRendaTotalDaFamilia : ICriterioBase
    {
        public abstract Pontuacao Pontuacao { get; }
        protected Dinheiro Dinheiro { get; }
        protected Func<Dinheiro, bool> Condicao { get; }

        protected CriterioDaRendaTotalDaFamilia(Dinheiro renda, Func<Dinheiro, bool> condicao)
        {
            Dinheiro = renda;
            Condicao = condicao;
        }
        public bool EhAtendido()
        {
            return Condicao.Invoke(Dinheiro);
        }

        public string ObterNome()
        {
            return this.GetType().Name;
        }
    }
}
