using System;

namespace Sorteio.Domain.Criterios.IdadeDoPretendente
{
    public abstract class CriterioDaIdadeDoPretendente : ICriterioBase
    {
        public abstract int Pontuacao { get; }
        protected int Idade { get; }
        protected Func<int, bool> Condicao { get; }

        protected CriterioDaIdadeDoPretendente(int idade, Func<int, bool> condicao)
        {
            Idade = idade;
            Condicao = condicao;
        }
        public bool EhAtendido()
        {
            return Condicao.Invoke(Idade);
        }
    }
}
