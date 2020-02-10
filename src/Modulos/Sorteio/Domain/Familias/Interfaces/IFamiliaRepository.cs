using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sorteio.Domain.Familias.Interfaces
{
    public interface IFamiliaRepository
    {
        Task Adicionar(Familia familia);

        Task<IEnumerable<Familia>> ObterFamiliasParaAvaliacao();

        Task<Status> ObterStatus(int id);
    }
}
