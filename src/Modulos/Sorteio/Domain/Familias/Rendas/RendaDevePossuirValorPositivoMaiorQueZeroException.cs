using Core.Domain;

namespace Sorteio.Domain.Familias.Rendas
{
    public sealed class RendaDevePossuirValorPositivoMaiorQueZeroException : DomainException
    {
        public RendaDevePossuirValorPositivoMaiorQueZeroException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
