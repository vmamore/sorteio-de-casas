using Sorteio.Domain.Familias.Pessoas;
using System;
using Xunit;

namespace TestesDeUnidade.ObjetosDeValorTests.Idades
{
    public sealed class IdadeTests
    {
        [Theory]
        [ClassData(typeof(DatasSetup))]
        public void DeveRetornarIdade(int anoDeNascimento, int mes, int dia, int idadeEsperada)
        {
            var idadeVO = Idade.CriarNovo(new DateTime(anoDeNascimento, mes, dia));

            var idadeCalculada = idadeVO.Obter();

            Assert.Equal(idadeEsperada, idadeCalculada);
        }

        [Fact]
        public void DeveRetornarExceptionQuandoDataDeNascimentoInforamadaForMinima()
        {
            var exception = Record.Exception(() => Idade.CriarNovo(DateTime.MinValue));

            Assert.NotNull(exception);
            Assert.IsType<DataDeNascimentoNaoPodeTerValorMinimoException>(exception);
        }

        [Fact]
        public void DeveRetornarExceptionQuandoDataDeNascimentoForNoFuturo()
        {
            var exception = Record.Exception(() => Idade.CriarNovo(DateTime.Today.AddDays(1)));

            Assert.NotNull(exception);
            Assert.IsType<DataDeNascimentoNaoPodeSerNoFuturo>(exception);
        }
    }
}
