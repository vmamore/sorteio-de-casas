using Sorteio.Domain.Criterios;
using System.Collections.Generic;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public abstract class CalculadoraDePontosBase
    {
        private int ZeroPontos = 0;
        protected ICollection<ICriterioBase> Criterios { get; set; }

        public int Calcular()
        {
            foreach (var criteiro in Criterios)
            {
                if (criteiro.EhAtendido())
                    return criteiro.Pontuacao;
            }

            return ZeroPontos;
        }
    }
}
