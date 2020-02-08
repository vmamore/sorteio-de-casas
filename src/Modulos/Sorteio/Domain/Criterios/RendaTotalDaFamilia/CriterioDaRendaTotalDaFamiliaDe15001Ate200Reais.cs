using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias.Pessoas;

namespace Sorteio.Domain.Criterios.RendaTotalDaFamilia
{
    public sealed class CriterioDaRendaTotalDaFamiliaDe15001Ate200Reais : CriterioDaRendaTotalDaFamilia
    {
        public override Pontuacao Pontuacao => Pontuacao.Um();
        public CriterioDaRendaTotalDaFamiliaDe15001Ate200Reais(Dinheiro dinheiro) : base(dinheiro, dinheiro => dinheiro.ToDecimal() > 1500 && 
                                                                                                   dinheiro.ToDecimal() <= 2000) {}
    }
}
