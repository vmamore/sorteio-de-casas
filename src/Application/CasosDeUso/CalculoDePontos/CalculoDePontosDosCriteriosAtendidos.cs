using Sorteio.Domain.CalculadoraDePontos.Interfaces;
using Sorteio.Domain.Criterios;
using Sorteio.Domain.Criterios.Interfaces;
using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Application.CasosDeUso.ValidacaoDosCriterios
{
    public sealed class CalculoDePontosDosCriteriosAtendidos
    {
        private readonly IFamiliaRepository _familiaRepository;
        private readonly IAvaliacaoDeCriterios _avaliacaoDeCriterios;
        private readonly IResultadoDaAvaliacaoDosCriteriosRepositorio _resultadoDaAvaliacaoDosCriteriosRepositorio;

        public CalculoDePontosDosCriteriosAtendidos(
            IFamiliaRepository familiaRepository,
            IAvaliacaoDeCriterios avaliacaoDeCriterios,
            IResultadoDaAvaliacaoDosCriteriosRepositorio resultadoDaAvaliacaoDosCriteriosRepositorio)
        {
            _familiaRepository = familiaRepository;
            _avaliacaoDeCriterios = avaliacaoDeCriterios;
            _resultadoDaAvaliacaoDosCriteriosRepositorio = resultadoDaAvaliacaoDosCriteriosRepositorio;
        }

        public async Task Executar(Familia familia)
        {
            var criteriosAtendidos = _avaliacaoDeCriterios.ObterCriteriosAtendidos(familia);

            var resultadoDaAvaliacaoDosCriterios = new ResultadoDaAvaliacaoDosCriterios(
                familia.Id,
                criteriosAtendidos);

            await _resultadoDaAvaliacaoDosCriteriosRepositorio.Salvar(resultadoDaAvaliacaoDosCriterios);
        }
    }
}
