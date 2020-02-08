using Sorteio.Domain.CalculadoraDePontos;

namespace Sorteio.Domain.Criterios.Dependentes
{
    public sealed class CriterioDaFamiliaCom1Ou2Dependentes : CriterioDaQuantidadeDeDependentesNaFamilia
    {
        public override Pontuacao Pontuacao => this.EhAtendido() ? Pontuacao.Dois() : Pontuacao.Zero();
        public CriterioDaFamiliaCom1Ou2Dependentes(int quantidadeDeDependentes) 
            : base(quantidadeDeDependentes, qtdDeDependentes => qtdDeDependentes == 1 || qtdDeDependentes == 2) {}
    }
}
