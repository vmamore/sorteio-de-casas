using Sorteio.Domain.Familias;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public sealed class CalculadoraDePontos
    {
        private Familia Familia { get; }

        public CalculadoraDePontos(Familia familia)
        {
            this.Familia = familia;
        }

        public int ObterTotal()
        {
            var pontuacaoPelaQuantidadeDeDependentesNaFamilia = new CalculadoraDePontosApartirDaQuantidadeDeDependentes(Familia).Calcular();
            var pontuacaoAPartirDaRendaTotalDaFamilia = new CalculadoraDePontosApartirDaRendaDaFamilia(Familia).Calcular();
            var pontuacaoPelaQuantidadeDeDependentesDaFamilia = new CalculadoraDePontosApartirDaQuantidadeDeDependentes(Familia).Calcular();

            return pontuacaoPelaQuantidadeDeDependentesNaFamilia + 
                   pontuacaoAPartirDaRendaTotalDaFamilia + 
                   pontuacaoPelaQuantidadeDeDependentesDaFamilia;
        }
    }
}
