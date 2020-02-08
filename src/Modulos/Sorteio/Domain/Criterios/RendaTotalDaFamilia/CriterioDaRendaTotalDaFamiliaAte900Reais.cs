using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias.Pessoas;

namespace Sorteio.Domain.Criterios.RendaTotalDaFamilia
{
    public sealed class CriterioDaRendaTotalDaFamiliaAte900Reais : CriterioDaRendaTotalDaFamilia
    {
        public override Pontuacao Pontuacao => Pontuacao.Cinco();
        public CriterioDaRendaTotalDaFamiliaAte900Reais(Dinheiro dinheiro) : base(dinheiro, dinheiro => dinheiro.ToDecimal() <= 900) {}
    }
}
