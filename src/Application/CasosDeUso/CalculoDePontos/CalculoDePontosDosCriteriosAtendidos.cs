using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.CalculadoraDePontos.Interfaces;
using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Application.CasosDeUso.ValidacaoDosCriterios
{
    public sealed class CalculoDePontosDosCriteriosAtendidos
    {
        private readonly IFamiliaRepository _familiaRepository;
        private readonly IAvaliacaoDeCriterios _avaliacaoDeCriterios;
        private ICollection<ResultadoDaAvaliacaoDosCriterios> _resultadoDaAvaliacaoDosCriterios;

        public CalculoDePontosDosCriteriosAtendidos(
            IFamiliaRepository familiaRepository,
            IAvaliacaoDeCriterios avaliacaoDeCriterios)
        {
            _familiaRepository = familiaRepository;
            _avaliacaoDeCriterios = avaliacaoDeCriterios;
            _resultadoDaAvaliacaoDosCriterios = new Collection<ResultadoDaAvaliacaoDosCriterios>();
        }

        public async Task Executar()
        {
            var familias = await _familiaRepository.ObterFamiliasParaAvaliacao();

            foreach (var familia in familias)
            {
                var criteriosAtendidos = _avaliacaoDeCriterios.ObterCriteriosAtendidos(familia);

                var resultadoDaAvaliacaoDosCriterios = new ResultadoDaAvaliacaoDosCriterios(
                    familia.Id,
                    criteriosAtendidos);

                _resultadoDaAvaliacaoDosCriterios.Add(resultadoDaAvaliacaoDosCriterios);
            }


        }
    }
}
