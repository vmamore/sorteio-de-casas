using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class PessoasCollection
    {
        private readonly IList<Pessoa> _pessoas;

        public PessoasCollection()
        {
            this._pessoas = new List<Pessoa>();
        }

        public void Add(Pessoa pessoa) => this._pessoas.Add(pessoa);

        public IReadOnlyCollection<Pessoa> Obter()
        {
            var pessoas = new ReadOnlyCollection<Pessoa>(this._pessoas);
            return pessoas;
        }

        public Dinheiro ObterValorTotalDaRenda()
        {
            var dinheiroTotal = Dinheiro.CriarNovo(0);

            foreach (var pessoa in _pessoas)
            {
                dinheiroTotal = pessoa.Renda.Somar(dinheiroTotal);
            }

            return dinheiroTotal;
        }

        public Pessoa ObterPretendente()
        {
            return _pessoas.SingleOrDefault(
                pessoa => pessoa.EhPretendente());
        }

        public int ObterQuantidadeDeDependentes()
        {
            return _pessoas.Count(pessoa => pessoa.EhDependente() &&
                                           !pessoa.EhMaiorDeIdade());
        }
    }
}
