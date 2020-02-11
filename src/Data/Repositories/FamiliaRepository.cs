using Microsoft.EntityFrameworkCore;
using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public sealed class FamiliaRepository : IFamiliaRepository
    {
        private readonly SorteioContext _sorteioContext;
        public FamiliaRepository(SorteioContext sorteioContext)
        {
            _sorteioContext = sorteioContext;
        }

        public async Task Adicionar(Familia familia)
        {
            await _sorteioContext.Familias.AddAsync(familia);

            await _sorteioContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Familia>> ObterFamiliasParaAvaliacao()
        {
            return await _sorteioContext.Familias
                .Where(f => f.Status.CadastroValido)
                .ToListAsync();
        }

        public async Task<Status> ObterStatus(int id)
        {
            return await _sorteioContext.Status
                .SingleOrDefaultAsync(s => s.Id == id);
        }
    }
}
