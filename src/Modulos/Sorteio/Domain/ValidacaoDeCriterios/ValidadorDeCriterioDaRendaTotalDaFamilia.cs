using Sorteio.Domain.Criterios;
using Sorteio.Domain.Criterios.RendaTotalDaFamilia;
using Sorteio.Domain.Familias;
using System.Collections.ObjectModel;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class ValidadorDeCriterioDaRendaTotalDaFamilia : VerificadorDeCriterios
    {
        public ValidadorDeCriterioDaRendaTotalDaFamilia(Familia familia)
        {
            var rendaTotalDaFamilia = familia.ObterRendaTotal();

            Criterios = new Collection<ICriterioBase>()
            {
                new CriterioDaRendaTotalDaFamiliaAte900Reais(rendaTotalDaFamilia),
                new CriterioDaRendaTotalDaFamiliaDe901Ate1500Reais(rendaTotalDaFamilia),
                new CriterioDaRendaTotalDaFamiliaDe15001Ate200Reais(rendaTotalDaFamilia)
            };
        }
    }
}
