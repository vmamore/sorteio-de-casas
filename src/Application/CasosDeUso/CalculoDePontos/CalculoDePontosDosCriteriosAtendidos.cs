using Sorteio.Domain.CalculadoraDePontos.Interfaces;
using Sorteio.Domain.Criterios;
using Sorteio.Domain.Criterios.Interfaces;
using Sorteio.Domain.Familias;
using System.Threading.Tasks;

namespace Application.CasosDeUso.CalculoDePontos
{
    public sealed class CalculoDePontosDosCriteriosAtendidos
    {
        private readonly IAvaliacaoDeCriterios _avaliacaoDeCriterios;
        private readonly IResultadoDaAvaliacaoDosCriteriosRepository _resultadoDaAvaliacaoDosCriteriosRepository;

        public CalculoDePontosDosCriteriosAtendidos(
            IAvaliacaoDeCriterios avaliacaoDeCriterios,
            IResultadoDaAvaliacaoDosCriteriosRepository resultadoDaAvaliacaoDosCriteriosRepository)
        {
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
