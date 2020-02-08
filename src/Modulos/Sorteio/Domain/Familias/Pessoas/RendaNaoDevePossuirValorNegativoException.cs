using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class RendaNaoDevePossuirValorNegativoException : DomainException
    {
        public RendaNaoDevePossuirValorNegativoException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
