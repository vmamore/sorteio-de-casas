using Sorteio.Domain.Familias;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public class CalculadoraDePontosComBaseAIdadeDoPretendente
    {
        public Familia Familia { get; }

        public CalculadoraDePontosComBaseAIdadeDoPretendente(Familia familia)
        {
            this.Familia = familia;
        }

        public int Calcular()
        {
            var pretendenteDaFamilia = Familia.ObterPretendente();

            var idadeDoPretendente = pretendenteDaFamilia.Idade.Obter();

            if (idadeDoPretendente >= 45) return 3;

            if (idadeDoPretendente >= 30 && idadeDoPretendente < 45) return 2;

            return 1;
        }
    }
}
