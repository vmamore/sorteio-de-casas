using Sorteio.Domain.Familias.Interfaces;
using Sorteio.Domain.Familias.Pessoas;
using System;

namespace Sorteio.Domain.Familias
{
    public sealed class Familia
    {
        public FamiliaId Id { get; }
        public Status Status { get; }
        public PessoasCollection Pessoas { get; }

        public Familia(Status status)
        {
            Id = new FamiliaId(Guid.NewGuid());
            Status = status;
            Pessoas = new PessoasCollection();
        }

        public Pessoa CriarPessoa(Nome nome, Idade idade, Tipo tipo, Renda renda)
        {
            var pessoa = new Pessoa(this.Id, nome, idade, tipo, renda);
            this.Pessoas.Add(pessoa);
            return pessoa;
        }

        public Dinheiro ObterRendaTotal()
        {
            return this.Pessoas.ObterValorTotalDaRenda();
        }

        public Pessoa ObterPretendente()
        {
            return this.Pessoas.ObterPretendente();
        }

        public int ObterQuantidadeDeDependentes()
        {
            return this.Pessoas.ObterQuantidadeDeDependentes();
        }
    }
}
