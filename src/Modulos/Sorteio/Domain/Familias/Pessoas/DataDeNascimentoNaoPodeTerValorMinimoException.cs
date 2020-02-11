using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class DataDeNascimentoNaoPodeTerValorMinimoException : ExcecaoDeDominio
    {
        public DataDeNascimentoNaoPodeTerValorMinimoException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
