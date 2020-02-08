using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias.Pessoas;

namespace Sorteio.Domain.Criterios.IdadeDoPretendente
{
    public sealed class CriterioDaIdadeDoPretendenteIgualOuAcimaDe45Anos : CriterioDaIdadeDoPretendente
    {
        public override Pontuacao Pontuacao => this.EhAtendido() ? Pontuacao.Tres() : Pontuacao.Zero();
        public CriterioDaIdadeDoPretendenteIgualOuAcimaDe45Anos(Idade idade) : base(idade, idade => idade.Obter() >= 45) { }
    }
}
