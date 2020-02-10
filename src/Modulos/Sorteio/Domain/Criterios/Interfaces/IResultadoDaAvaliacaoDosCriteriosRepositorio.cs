using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sorteio.Domain.Criterios.Interfaces
{
    public interface IResultadoDaAvaliacaoDosCriteriosRepositorio
    {
        Task Salvar(IEnumerable<ResultadoDaAvaliacaoDosCriterios> resultados);
    }
}
