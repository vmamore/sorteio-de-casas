using Sorteio.Domain.Familias.Pessoas;
using Xunit;

namespace TestesDeUnidade.ObjetosDeValorTests.Nomes
{
    public sealed class NomeTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("      ")]
        public void DeveRetornarExceptionQuandoNomeForVazio(string nomeInvalido)
        {
            var exception = Record.Exception(() => Nome.CriarNovo(nomeInvalido));

            Assert.NotNull(exception);
            Assert.IsType<NomeNaoPodeSerVazioException>(exception);
        }
    }
}
