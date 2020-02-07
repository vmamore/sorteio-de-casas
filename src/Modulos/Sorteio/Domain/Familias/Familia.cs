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

        public Pessoa CriarPessoa(IFamiliaFactory factory, Nome nome, Idade idade, Renda renda, Tipo tipo)
        {
            var pessoa = factory.CriarPessoa(this, nome, idade, renda, tipo);
            this.Pessoas.Add(pessoa);
            return pessoa;
        }

        public decimal ObterRendaTotal()
        {
            return this.Pessoas.ObterValorTotalDaRenda().ToDecimal();
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
