using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Familias.Pessoas;
using System;

namespace Sorteio.Domain.Criterios.IdadeDoPretendente
{
    public abstract class CriterioDaIdadeDoPretendente : ICriterioBase
    {
        public abstract Pontuacao Pontuacao { get; }
        protected Idade Idade { get; }
        protected Func<Idade, bool> Condicao { get; }

        protected CriterioDaIdadeDoPretendente(Idade idade, Func<Idade, bool> condicao)
        {
            Idade = idade;
            Condicao = condicao;
        }
        public bool EhAtendido()
        {
            return Condicao.Invoke(Idade);
        }
        public string ObterNome()
        {
            return this.GetType().Name;
        }
    }
}
