using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias;
using System.Threading.Tasks;

namespace Application.CasosDeUso.ValidacaoDosCriterios
{
    public class AvaliadorDosCriterios
    {
        private readonly IFamiliaRepository _familiaRepository;

        public AvaliadorDosCriterios(IFamiliaRepository familiaRepository)
        {
            _familiaRepository = familiaRepository;
        }

        public async Task Executar()
        {
            var familias = await _familiaRepository.ObterFamiliasParaAvaliacao();

            foreach(var familia in familias)
            {
                var calculadoraDePontos = new CalculadoraDePontos(familia);

                calculadoraDePontos.ObterTotal();
            }
        }
    }
}
