using Core.Domain;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class PontuacaoNaoPodeTerValorNegativo : DomainException
    {
        public PontuacaoNaoPodeTerValorNegativo(string businessMessage) : base(businessMessage)
        {
        }
    }
}
