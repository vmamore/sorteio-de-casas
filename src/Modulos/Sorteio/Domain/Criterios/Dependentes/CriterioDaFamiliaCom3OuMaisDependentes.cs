namespace Sorteio.Domain.Criterios.Dependentes
{
    public sealed class CriterioDaFamiliaCom3OuMaisDependentes : CriterioDaQuantidadeDeDependentesNaFamilia
    {
        public override int Pontuacao { get => 3; }
        public CriterioDaFamiliaCom3OuMaisDependentes(int quantidadeDeDependentes)
            : base(quantidadeDeDependentes, qtdDeDependentes => qtdDeDependentes >= 3) { }
    }
}
