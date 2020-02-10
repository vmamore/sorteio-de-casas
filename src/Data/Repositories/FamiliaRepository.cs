using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public sealed class FamiliaRepository : IFamiliaRepository
    {
        public Task Adicionar(Familia familia)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Familia>> ObterFamiliasParaAvaliacao()
        {
            throw new NotImplementedException();
        }

        public Task<Status> ObterStatus(int id)
        {
            throw new NotImplementedException();
        }
    }
}
