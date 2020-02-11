using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Interfaces;
using Sorteio.Domain.Familias.Pessoas;

namespace Data.Factories
{
    public sealed class FamiliaFactory : IFamiliaFactory
    {
        public Familia Criar(Status status)
        {
            return new Familia(status);
        }

        public Pessoa CriarPessoa(Familia familia, Nome nome, Idade idade, Tipo tipo, Renda renda = null)
        {
            return familia.CriarPessoa(nome, idade, tipo, renda);
        }
    }
}
