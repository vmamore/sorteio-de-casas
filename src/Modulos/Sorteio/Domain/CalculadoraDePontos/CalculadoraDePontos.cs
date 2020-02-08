using Sorteio.Domain.Familias;
using System.Collections.Generic;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class CalculadoraDePontos
    {
        private Familia Familia { get; }

        public CalculadoraDePontos(Familia familia)
        {
            this.Familia = familia;
        }

        public (Pontuacao pontos, IEnumerable<string> criteriosAtendidos) ObterTotal()
        {
            var criteroQuantidadeDeDependentes = new CalculadoraDePontosApartirDaQuantidadeDeDependentes(Familia).Calcular();
            var criterioRendaTotalDaFamilia = new CalculadoraDePontosApartirDaRendaDaFamilia(Familia).Calcular();
            var criterioIdadeDoPretendente = new CalculadoraDePontosComBaseAIdadeDoPretendente(Familia).Calcular();

            return (
                   criteroQuantidadeDeDependentes.pontuacao +
                   criterioRendaTotalDaFamilia.pontuacao +
                   criterioIdadeDoPretendente.pontuacao,
                   new List<string>(){
                       criteroQuantidadeDeDependentes.nomeDoCriterio +
                       criterioRendaTotalDaFamilia.nomeDoCriterio +
                       criterioIdadeDoPretendente.nomeDoCriterio,
                   });
        }
    }
}
