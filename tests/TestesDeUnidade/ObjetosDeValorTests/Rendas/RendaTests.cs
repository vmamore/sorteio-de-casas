using Sorteio.Domain.Familias.Rendas;
using Xunit;

namespace TestesDeUnidade.ObjetosDeValorTests.Rendas
{
    public sealed class RendaTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void DeveRetornarExceptionQuandoValorForInvalido(decimal valorInvalido)
        {
            var exception = Record.Exception(() => Renda.CriarNovo(valorInvalido));

            Assert.NotNull(exception);
            Assert.IsType<RendaDevePossuirValorPositivoMaiorQueZeroException>(exception);
        }
    }
}
