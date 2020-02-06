using Sorteio.Domain.Familias.Pessoas;
using System;

namespace Sorteio.Domain.Familias
{
    public sealed class Familia
    {
        public FamiliaId Id { get; }
        public Status Status { get; }
        public PessoasCollection Pessoas { get; }

        public Familia()
        {
            Id = new FamiliaId(Guid.NewGuid());
        }

        public decimal ObterRendaTotal()
        {
            return this.Pessoas.ObterValorTotalDaRenda().ToDecimal();
        }

        public Pessoa ObterPretendente()
        {
            return this.Pessoas.ObterPretendente();
        }
        
        public bool Possui3OuMaisDependentes()
        {
            return this.Pessoas.Possui3OuMaisDependentes();
        }

        public bool Possui1Ou2Dependentes()
        {
            return this.Pessoas.Possui1Ou2Dependentes();
        }
    }
}
