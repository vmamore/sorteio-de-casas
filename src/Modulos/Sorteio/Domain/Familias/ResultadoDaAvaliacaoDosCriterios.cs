using Core.Domain;
using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Criterios;
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
            IEnumerable<ICriterioBase> criteriosAtendidos)
        {
            FamiliaId = familiaId;
            DataDeSelecao = DateTime.UtcNow;
            CriteriosAtendidos = new CriteriosAtendidosCollection(criteriosAtendidos);
            PontuacaoTotal = CriteriosAtendidos.PontuacaoTotal;
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
            public Pontuacao PontuacaoTotal { get; }
            public IEnumerable<string> CriteriosAtendidos { get; set; }

            public CriteriosAtendidosCollection(IEnumerable<ICriterioBase> criteriosAtendidos)
            {
                CriteriosAtendidos = criteriosAtendidos.Select(criterio => criterio.ObterNome());
                PontuacaoTotal = criteriosAtendidos.Select(criterio => criterio.Pontuacao)
                    .Aggregate((pontuacaoTotal, pontuacaoAtual) => pontuacaoTotal + pontuacaoAtual);
            }
        }
    }
}
