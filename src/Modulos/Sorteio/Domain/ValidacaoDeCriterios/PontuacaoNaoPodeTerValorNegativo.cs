using Core.Domain;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class PontuacaoNaoPodeTerValorNegativo : ExcecaoDeDominio
    {
        public PontuacaoNaoPodeTerValorNegativo(string businessMessage) : base(businessMessage)
        {
        }
    }
}
