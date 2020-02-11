using Sorteio.Domain.CalculadoraDePontos.Interfaces;
using Sorteio.Domain.Criterios;
using Sorteio.Domain.Criterios.Interfaces;
using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Interfaces;
using System.Threading.Tasks;

namespace Application.CasosDeUso.CalculoDePontos
{
    public sealed class CalculoDePontosDosCriteriosAtendidos
    {
        private readonly IFamiliaRepository _familiaRepository;
        private readonly IAvaliacaoDeCriterios _avaliacaoDeCriterios;
        private readonly IResultadoDaAvaliacaoDosCriteriosRepository _resultadoDaAvaliacaoDosCriteriosRepository;

        public CalculoDePontosDosCriteriosAtendidos(
            IFamiliaRepository familiaRepository,
            IAvaliacaoDeCriterios avaliacaoDeCriterios,
            IResultadoDaAvaliacaoDosCriteriosRepository resultadoDaAvaliacaoDosCriteriosRepository)
        {
            _familiaRepository = familiaRepository;
            _avaliacaoDeCriterios = avaliacaoDeCriterios;
            _resultadoDaAvaliacaoDosCriteriosRepository = resultadoDaAvaliacaoDosCriteriosRepository;
        }

        public async Task Executar(Familia familia)
        {
            var criteriosAtendidos = _avaliacaoDeCriterios.ObterCriteriosAtendidos(familia);

            var resultadoDaAvaliacaoDosCriterios = new ResultadoDaAvaliacaoDosCriterios(
                familia.Id,
                criteriosAtendidos);

            await _resultadoDaAvaliacaoDosCriteriosRepository.Salvar(resultadoDaAvaliacaoDosCriterios);
        }
    }
}
