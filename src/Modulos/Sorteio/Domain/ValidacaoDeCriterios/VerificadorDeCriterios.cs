using Sorteio.Domain.Criterios;
using System.Collections.Generic;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public abstract class VerificadorDeCriterios
    {
        protected ICollection<ICriterioBase> Criterios { get; set; }

        public ICriterioBase ObterCriterio()
        {
            foreach (var criteiro in Criterios)
            {
                if (criteiro.EhAtendido())
                    return criteiro;
            }

            return default;
        }
    }
}
