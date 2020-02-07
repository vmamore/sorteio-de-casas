using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class Dinheiro : ObjetoDeValor
    {
        public decimal Valor { get; }

        private Dinheiro(decimal valor)
        {
            Valor = valor;
        }

        public decimal ToDecimal() => this.Valor;

        public bool EhZero()
        {
            return this.Valor == 0;
        }

        public static Dinheiro CriarNovo(decimal valor)
        {
            return new Dinheiro(valor);
        }

        public Dinheiro Somar(Dinheiro dinheiro)
        {
            return new Dinheiro(this.Valor + dinheiro.Valor);
        }
    }
}
