namespace Sorteio.Domain.Criterios.RendaTotalDaFamilia
{
    public sealed class CriterioDaRendaTotalDaFamiliaDe901Ate1500Reais : CriterioDaRendaTotalDaFamilia
    {
        public override int Pontuacao => 3;
        public CriterioDaRendaTotalDaFamiliaDe901Ate1500Reais(decimal renda) : base(renda, renda => renda > 900 && renda <= 1500) {}
    }
}
