using Sorteio.Domain.Criterios;
using Sorteio.Domain.Criterios.Dependentes;
using Sorteio.Domain.Familias;
using System.Collections.ObjectModel;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class ValidadorDeCriterioDaQuantidadeDeDependentes : VerificadorDeCriterios
    {
        public ValidadorDeCriterioDaQuantidadeDeDependentes(Familia familia)
        {
            var quantidadeDeDependentes = familia.ObterQuantidadeDeDependentes();

            Criterios = new Collection<ICriterioBase>()
            {
                new CriterioDaFamiliaCom3OuMaisDependentes(quantidadeDeDependentes),
                new CriterioDaFamiliaCom1Ou2Dependentes(quantidadeDeDependentes)
            };
        }
    }
}
