using Sorteio.Domain.Familias;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class CalculadoraDePontos
    {
        public Familia Familia { get; }

        public CalculadoraDePontos(Familia familia)
        {
            this.Familia = familia;
        }

        public int ObterTotal()
        {
            var calc1 = new CalculadoraDePontosApartirDosDependentes(Familia).Calcular();
            var calc2 = new CalculadoraDePontosApartirDaRendaDaFamilia(Familia).Calcular();
            var calc3 = new CalculadoraDePontosApartirDosDependentes(Familia).Calcular();

            return calc1 + calc2 + calc3;
        }
    }
}
