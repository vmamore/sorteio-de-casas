using System;

namespace Sorteio.Domain.Criterios.Dependentes
{
    public abstract class CriterioDaQuantidadeDeDependentesNaFamilia : ICriterioBase
    {
        public abstract int Pontuacao { get; }
        protected int QuantidadeDeDependentes { get; }
        protected Func<int, bool> Condicao { get; }

        protected CriterioDaQuantidadeDeDependentesNaFamilia(int quantidadeDeDependentes, Func<int, bool> condicao)
        {
            QuantidadeDeDependentes = quantidadeDeDependentes;
            Condicao = condicao;
        }
        public bool EhAtendido()
        {
            return Condicao.Invoke(QuantidadeDeDependentes);
        }
    }
}
