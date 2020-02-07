namespace Sorteio.Domain.Criterios.Dependentes
{
    public sealed class CriterioDaFamiliaCom1Ou2Dependentes : CriterioDaQuantidadeDeDependentesNaFamilia
    {
        public override int Pontuacao => 2;
        public CriterioDaFamiliaCom1Ou2Dependentes(int quantidadeDeDependentes) 
            : base(quantidadeDeDependentes, qtdDeDependentes => qtdDeDependentes == 1 || qtdDeDependentes == 2) {}
    }
}
