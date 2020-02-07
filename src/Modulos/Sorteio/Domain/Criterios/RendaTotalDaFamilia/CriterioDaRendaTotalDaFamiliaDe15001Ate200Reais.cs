namespace Sorteio.Domain.Criterios.RendaTotalDaFamilia
{
    public sealed class CriterioDaRendaTotalDaFamiliaDe15001Ate200Reais : CriterioDaRendaTotalDaFamilia
    {
        public override int Pontuacao => 1;
        public CriterioDaRendaTotalDaFamiliaDe15001Ate200Reais(decimal renda) : base(renda, renda => renda > 1500 && renda <= 2000) {}
    }
}
