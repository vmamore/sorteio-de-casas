using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class DataDeNascimentoNaoPodeSerNoFuturo : ExcecaoDeDominio
    {
        public DataDeNascimentoNaoPodeSerNoFuturo(string businessMessage) : base(businessMessage)
        {
        }
    }
}
