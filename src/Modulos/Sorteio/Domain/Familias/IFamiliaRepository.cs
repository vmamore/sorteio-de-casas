using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sorteio.Domain.Familias
{
    public interface IFamiliaRepository
    {
        Task Adicionar(Familia familia);

        Task<IEnumerable<Familia>> ObterFamiliasParaAvaliacao();
    }
}
