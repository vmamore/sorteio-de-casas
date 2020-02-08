using Sorteio.Domain.Familias.Pessoas;

namespace Sorteio.Domain.Familias.Interfaces
{
    public interface IFamiliaFactory
    {
        Familia Criar(Status status);

        Pessoa CriarPessoa(Familia familia, Nome nome, Idade idade, Tipo tipo, Renda renda = null);
    }
}
