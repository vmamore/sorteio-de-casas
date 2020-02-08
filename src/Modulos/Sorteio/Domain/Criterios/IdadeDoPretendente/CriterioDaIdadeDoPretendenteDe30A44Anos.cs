using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias.Pessoas;

namespace Sorteio.Domain.Criterios.IdadeDoPretendente
{
    public sealed class CriterioDaIdadeDoPretendenteDe30A44Anos : CriterioDaIdadeDoPretendente
    {
        public override Pontuacao Pontuacao => Pontuacao.Dois();
        public CriterioDaIdadeDoPretendenteDe30A44Anos(Idade idade) : base(idade, idade => idade.Obter() >= 30 && idade.Obter() <= 44) {}
    }
}
