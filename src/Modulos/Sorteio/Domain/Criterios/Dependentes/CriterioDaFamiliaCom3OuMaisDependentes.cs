using Sorteio.Domain.CalculadoraDePontos;

namespace Sorteio.Domain.Criterios.Dependentes
{
    public sealed class CriterioDaFamiliaCom3OuMaisDependentes : CriterioDaQuantidadeDeDependentesNaFamilia
    {
        public override Pontuacao Pontuacao => Pontuacao.Tres();
        public CriterioDaFamiliaCom3OuMaisDependentes(int quantidadeDeDependentes)
            : base(quantidadeDeDependentes, qtdDeDependentes => qtdDeDependentes >= 3) { }
    }
}
