using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class DataDeNascimentoNaoPodeTerValorMinimoException : DomainException
    {
        public DataDeNascimentoNaoPodeTerValorMinimoException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
