using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class PessoasCollection
    {
        public IList<Pessoa> Pessoas { get; }

        public PessoasCollection()
        {
            this.Pessoas = new List<Pessoa>();
        }

        public void Add(Pessoa pessoa) => this.Pessoas.Add(pessoa);

        public IReadOnlyCollection<Pessoa> Obter()
        {
            var pessoas = new ReadOnlyCollection<Pessoa>(this.Pessoas);
            return pessoas;
        }

        public Dinheiro ObterValorTotalDaRenda()
        {
            var dinheiroTotal = Dinheiro.CriarNovo(0);

            foreach (var pessoa in Pessoas)
            {
                dinheiroTotal = pessoa.Renda.Somar(dinheiroTotal);
            }

            return dinheiroTotal;
        }

        public Pessoa ObterPretendente()
        {
            return Pessoas.SingleOrDefault(
                pessoa => pessoa.EhPretendente());
        }

        public int ObterQuantidadeDeDependentes()
        {
            return Pessoas.Count(pessoa => pessoa.EhDependente() &&
                                           !pessoa.EhMaiorDeIdade());
        }
    }
}
