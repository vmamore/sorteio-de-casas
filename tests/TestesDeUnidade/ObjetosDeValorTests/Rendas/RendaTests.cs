using Sorteio.Domain.Familias.Pessoas;
using Xunit;

namespace TestesDeUnidade.ObjetosDeValorTests.Rendas
{
    public sealed class RendaTests
    {
        [Theory]
        [InlineData(-1)]
        public void DeveRetornarExceptionQuandoValorForInvalido(decimal valorInvalido)
        {
            var exception = Record.Exception(() => Renda.CriarNovo(valorInvalido));

            Assert.NotNull(exception);
            Assert.IsType<RendaNaoDevePossuirValorNegativoException>(exception);
        }
    }
}
