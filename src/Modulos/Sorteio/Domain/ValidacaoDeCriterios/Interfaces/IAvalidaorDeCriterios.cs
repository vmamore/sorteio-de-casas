using Sorteio.Domain.Criterios;
using Sorteio.Domain.Familias;
using System.Collections.Generic;

namespace Sorteio.Domain.CalculadoraDePontos.Interfaces
{
    public interface IAvaliacaoDeCriterios
    {
        IEnumerable<ICriterioBase> ObterCriteriosAtendidos(Familia familia);
    }
}