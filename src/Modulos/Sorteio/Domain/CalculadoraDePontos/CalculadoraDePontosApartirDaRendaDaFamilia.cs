using Sorteio.Domain.Familias;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class CalculadoraDePontosApartirDaRendaDaFamilia
    {
        public Familia Familia { get; }

        public CalculadoraDePontosApartirDaRendaDaFamilia(Familia familia)
        {
            this.Familia = familia;
        }

        public int Calcular()
        {
            var valorDaRendaDaFamilia = Familia.ObterRendaTotal();

            if (valorDaRendaDaFamilia <= 900) return 5;
            if (valorDaRendaDaFamilia <= 1500) return 3;
            if (valorDaRendaDaFamilia <= 200) return 1;

            return 0;
        }
    }
}
