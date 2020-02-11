using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class RendaNaoDevePossuirValorNegativoException : ExcecaoDeDominio
    {
        public RendaNaoDevePossuirValorNegativoException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
