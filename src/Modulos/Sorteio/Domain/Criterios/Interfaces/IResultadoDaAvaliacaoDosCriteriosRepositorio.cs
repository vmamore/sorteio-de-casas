using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sorteio.Domain.Criterios.Interfaces
{
    public interface IResultadoDaAvaliacaoDosCriteriosRepository
    {
        Task Salvar(ResultadoDaAvaliacaoDosCriterios resultado);

        Task<IEnumerable<ResultadoDaAvaliacaoDosCriterios>> ObterFamiliasOrdenadasPorPontuacao();
    }
}
