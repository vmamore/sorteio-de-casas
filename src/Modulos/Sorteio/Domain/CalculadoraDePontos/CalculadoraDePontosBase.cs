using Sorteio.Domain.Criterios;
using System.Collections.Generic;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public abstract class CalculadoraDePontosBase
    {
        protected ICollection<ICriterioBase> Criterios { get; set; }

        public (Pontuacao pontuacao, string nomeDoCriterio) Calcular()
        {
            foreach (var criteiro in Criterios)
            {
                if(criteiro.EhAtendido())
                    return (criteiro.Pontuacao, criteiro.ObterNome());
            }

            return (Pontuacao.Zero(), string.Empty);
        }
    }
}
