using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class Renda : ObjetoDeValor
    {
        public Dinheiro Valor { get; }

        private Renda(decimal valor)
        {
            if (valor < 0)
            {
                throw new RendaNaoDevePossuirValorNegativoException("Valor da renda não pode ser menor ou igual a zero!");
            }

            Valor = Dinheiro.CriarNovo(valor);
        }

        public Dinheiro Somar(Dinheiro valor)
        {
            return this.Valor.Somar(valor);
        }

        public static Renda CriarNovo(decimal valor)
        {
            return new Renda(valor);
        }
    }
}
