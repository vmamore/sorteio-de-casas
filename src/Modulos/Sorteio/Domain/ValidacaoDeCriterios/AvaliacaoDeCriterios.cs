using Sorteio.Domain.CalculadoraDePontos.Interfaces;
using Sorteio.Domain.Criterios;
using Sorteio.Domain.Familias;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class AvaliacaoDeCriterios : IAvaliacaoDeCriterios
    {
        public ICollection<ICriterioBase> CriteriosAtendidos { get; set; }

        public AvaliacaoDeCriterios()
        {
            CriteriosAtendidos = new Collection<ICriterioBase>();
        }
        public IEnumerable<ICriterioBase> ObterCriteriosAtendidos(Familia familia)
        {
            var criterioDaQuantidadeDeDependentes = new ValidadorDeCriterioDaQuantidadeDeDependentes(familia).ObterCriterio();
            AdicionarCriterio(criterioDaQuantidadeDeDependentes);

            var criterioRendaTotalDaFamilia = new ValidadorDeCriterioDaRendaTotalDaFamilia(familia).ObterCriterio();
            AdicionarCriterio(criterioRendaTotalDaFamilia);

            var criterioIdadeDoPretendente = new ValidadorDeCriterioDaIdadeDoPretendente(familia).ObterCriterio();
            AdicionarCriterio(criterioIdadeDoPretendente);

            return CriteriosAtendidos;
        }

        private void AdicionarCriterio(ICriterioBase criterioBase)
        {
            if (criterioBase != null)
                CriteriosAtendidos.Add(criterioBase);
        }
    }
}
