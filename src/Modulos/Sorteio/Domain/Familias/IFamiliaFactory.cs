using Sorteio.Domain.Familias.Pessoas;

namespace Sorteio.Domain.Familias
{
    public interface IFamiliaFactory
    {
        Familia Criar(Status status);

        Pessoa CriarPessoa(Familia familia, Nome nome, Idade idade, Renda renda, Tipo tipo);
    }
}
