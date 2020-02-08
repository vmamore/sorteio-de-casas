using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias.Pessoas;

namespace Sorteio.Domain.Criterios.RendaTotalDaFamilia
{
    public sealed class CriterioDaRendaTotalDaFamiliaDe901Ate1500Reais : CriterioDaRendaTotalDaFamilia
    {
        public override Pontuacao Pontuacao => this.EhAtendido() ?  Pontuacao.Tres() : Pontuacao.Zero() ;
        public CriterioDaRendaTotalDaFamiliaDe901Ate1500Reais(Dinheiro dinheiro) : base(dinheiro, dinheiro => dinheiro.ToDecimal() > 900 && 
                                                                                                  dinheiro.ToDecimal() <= 1500) {}
    }
}
