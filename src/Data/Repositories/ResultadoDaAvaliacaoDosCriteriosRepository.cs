using Microsoft.EntityFrameworkCore;
using Sorteio.Domain.Criterios;
using Sorteio.Domain.Criterios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ResultadoDaAvaliacaoDosCriteriosRepository : IResultadoDaAvaliacaoDosCriteriosRepository
    {
        private readonly SorteioContext _sorteioContext;
        public ResultadoDaAvaliacaoDosCriteriosRepository(SorteioContext sorteioContext)
        {
            _sorteioContext = sorteioContext;
        }

        public async Task Salvar(ResultadoDaAvaliacaoDosCriterios resultado)
        {
            await _sorteioContext.Resultados.AddAsync(resultado);

            await _sorteioContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ResultadoDaAvaliacaoDosCriterios>> ObterFamiliasOrdenadasPorPontuacao()
        {
            return await _sorteioContext.Resultados
                .OrderBy(r => r.PontuacaoTotal)
                .ToListAsync();
        }
    }
}
