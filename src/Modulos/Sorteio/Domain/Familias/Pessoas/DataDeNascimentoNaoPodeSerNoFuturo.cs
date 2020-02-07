using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class DataDeNascimentoNaoPodeSerNoFuturo : DomainException
    {
        public DataDeNascimentoNaoPodeSerNoFuturo(string businessMessage) : base(businessMessage)
        {
        }
    }
}
