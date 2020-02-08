using Core.Domain;
using Sorteio.Domain.CalculadoraDePontos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorteio.Domain.Familias
{
    public class ResultadoDaAvaliacaoDosCriterios : Entidade
    {
        public FamiliaId FamiliaId { get; }
        public Pontuacao PontuacaoTotal { get; }
        public DateTime DataDeSelecao { get; }
        public CriteriosAtendidosCollection CriteriosAtendidos { get; }

        public ResultadoDaAvaliacaoDosCriterios(
            FamiliaId familiaId,
            Pontuacao pontos,
            IEnumerable<string> criteriosAtendidos)
        {
            FamiliaId = familiaId;
            PontuacaoTotal = pontos;
            DataDeSelecao = DateTime.UtcNow;
            CriteriosAtendidos = new CriteriosAtendidosCollection(criteriosAtendidos);
        }

        public class CriteriosAtendidosCollection : ObjetoDeValor
        {
            public int Total
            {
                get
                {
                    return CriteriosAtendidos.Count();
                }
            }
            public IEnumerable<string> CriteriosAtendidos { get; set; }

            public CriteriosAtendidosCollection(IEnumerable<string> criteriosAtendidos)
            {
                CriteriosAtendidos = CriteriosAtendidos;
            }
        }
    }
}
