using Core.Domain;
using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorteio.Domain.Criterios
{
    public class ResultadoDaAvaliacaoDosCriterios : Entidade
    {
        public ResultadoDaAvaliacaoDosCriteriosId Id { get; }
        public FamiliaId FamiliaId { get; }
        public Pontuacao PontuacaoTotal { get; }
        public DateTime DataDeSelecao { get; }
        public Familia Familia { get; }
        public CriteriosAtendidosCollection CriteriosAtendidos { get; }

        protected ResultadoDaAvaliacaoDosCriterios() {}

        public ResultadoDaAvaliacaoDosCriterios(
            FamiliaId familiaId,
            IEnumerable<ICriterioBase> criteriosAtendidos)
        { 
            Id = new ResultadoDaAvaliacaoDosCriteriosId(Guid.NewGuid());
            FamiliaId = familiaId;
            DataDeSelecao = DateTime.UtcNow;
            CriteriosAtendidos = new CriteriosAtendidosCollection(criteriosAtendidos);
            PontuacaoTotal = CriteriosAtendidos.PontuacaoTotal;
        }
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

        public string Obter()
        {
            return string.Join(';',this.CriteriosAtendidos);
        }
    }
}
