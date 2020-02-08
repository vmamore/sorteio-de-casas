using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Application.CasosDeUso.ValidacaoDosCriterios
{
    public sealed class AvaliadorDeCriterios
    {
        private readonly IFamiliaRepository _familiaRepository;
        private ICollection<ResultadoDaAvaliacaoDosCriterios> _resultadoDaAvaliacaoDosCriterios;

        public AvaliadorDeCriterios(IFamiliaRepository familiaRepository)
        {
            _familiaRepository = familiaRepository;
            _resultadoDaAvaliacaoDosCriterios = new Collection<ResultadoDaAvaliacaoDosCriterios>();
        }

        public async Task Executar()
        {
            var familias = await _familiaRepository.ObterFamiliasParaAvaliacao();

            foreach (var familia in familias)
            {
                var calculadoraDePontos = new CalculadoraDePontos(familia);

                var criteriosAvaliados = calculadoraDePontos.ObterTotal();

                var resultadoDaAvaliacaoDosCriterios = new ResultadoDaAvaliacaoDosCriterios(
                    familia.Id,
                    criteriosAvaliados.pontos,
                    criteriosAvaliados.criteriosAtendidos);

                _resultadoDaAvaliacaoDosCriterios.Add(resultadoDaAvaliacaoDosCriterios);
            }


        }
    }
}
