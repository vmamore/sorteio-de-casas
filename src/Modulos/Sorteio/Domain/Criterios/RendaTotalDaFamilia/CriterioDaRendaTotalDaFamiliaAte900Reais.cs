namespace Sorteio.Domain.Criterios.RendaTotalDaFamilia
{
    public sealed class CriterioDaRendaTotalDaFamiliaAte900Reais : CriterioDaRendaTotalDaFamilia
    {
        public override int Pontuacao => 5;
        public CriterioDaRendaTotalDaFamiliaAte900Reais(decimal renda) : base(renda, renda => renda <= 900) {}
    }
}
