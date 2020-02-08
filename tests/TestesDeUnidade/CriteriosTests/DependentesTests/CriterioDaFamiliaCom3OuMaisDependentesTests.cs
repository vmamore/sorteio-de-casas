using Sorteio.Domain.Criterios.Dependentes;
using Xunit;

namespace TestesDeUnidade.CriteriosTests.DependentesTests
{
    public sealed class CriterioDaFamiliaCom3OuMaisDependentesTests : IClassFixture<CriterioDependentesFixture>
    {
        private readonly CriterioDependentesFixture _fixture;

        public CriterioDaFamiliaCom3OuMaisDependentesTests(CriterioDependentesFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void CriterioDaFamiliaCom3OuMaisDependentesDeveRetornarPontuacaoZeradaQuandoNaoForAtendido()
        {
            var familiaComDoisDependentesMaioresDeIdade = _fixture.FamiliaComDependentesMaioresDeIdade;

            var quantidadeDeDependentes = familiaComDoisDependentesMaioresDeIdade.ObterQuantidadeDeDependentes();

            var criterioDaFamiliaCom3OuMaisDependentes = new CriterioDaFamiliaCom3OuMaisDependentes(quantidadeDeDependentes);

            Assert.Equal(0, criterioDaFamiliaCom3OuMaisDependentes.Pontuacao.Valor);
        }

        [Fact]
        public void CriterioDaFamiliaCom1Ou2DependentesDeveRetornarPontuacaoQuandoForAtendido()
        {
            var familiaComTresDependentesMenoresDeIdade = _fixture.FamiliaComTresDependentesMenoresDeIdade;

            var quantidadeDeDependentes = familiaComTresDependentesMenoresDeIdade.ObterQuantidadeDeDependentes();

            var criterioDaFamiliaCom3OuMaisDependentes = new CriterioDaFamiliaCom3OuMaisDependentes(quantidadeDeDependentes);

            Assert.Equal(3, criterioDaFamiliaCom3OuMaisDependentes.Pontuacao.Valor);
        }
    }
}
