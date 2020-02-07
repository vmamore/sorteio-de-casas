using System;

namespace Sorteio.Domain.Criterios.RendaTotalDaFamilia
{
    public abstract class CriterioDaRendaTotalDaFamilia : ICriterioBase
    {
        public abstract int Pontuacao { get; }
        protected decimal Renda { get; }
        protected Func<decimal, bool> Condicao { get; }

        protected CriterioDaRendaTotalDaFamilia(decimal renda, Func<decimal, bool> condicao)
        {
            Renda = renda;
            Condicao = condicao;
        }
        public bool EhAtendido()
        {
            return Condicao.Invoke(Renda);
        }
    }
}
