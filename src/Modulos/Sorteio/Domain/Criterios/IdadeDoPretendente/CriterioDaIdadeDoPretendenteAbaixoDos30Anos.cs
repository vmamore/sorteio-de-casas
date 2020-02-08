using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias.Pessoas;

namespace Sorteio.Domain.Criterios.IdadeDoPretendente
{
    public sealed class CriterioDaIdadeDoPretendenteAbaixoDos30Anos : CriterioDaIdadeDoPretendente
    {
        public override Pontuacao Pontuacao => this.EhAtendido() ? Pontuacao.Um() : Pontuacao.Zero() ;
        public CriterioDaIdadeDoPretendenteAbaixoDos30Anos(Idade idade) : base(idade, idade => idade.Obter() < 30) {}
    }
}
