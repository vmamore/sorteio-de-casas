using Sorteio.Domain.Familias;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public class CalculadoraDePontosApartirDosDependentes
    {
        public Familia Familia { get; }

        public CalculadoraDePontosApartirDosDependentes(Familia familia)
        {
            Familia = familia;
        }

        public int Calcular()
        {
            if (Familia.Possui3OuMaisDependentes()) return 3;
            if (Familia.Possui1Ou2Dependentes()) return 2;
            return 0;
        }
    }
}
