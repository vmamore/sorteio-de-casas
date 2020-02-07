using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class RendaDevePossuirValorPositivoMaiorQueZeroException : DomainException
    {
        public RendaDevePossuirValorPositivoMaiorQueZeroException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
