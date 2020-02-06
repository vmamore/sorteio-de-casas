using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class NomeNaoPodeSerVazioException : DomainException
    {
        public NomeNaoPodeSerVazioException(string businessMessage) 
            : base(businessMessage)
        {
        }
    }
}
