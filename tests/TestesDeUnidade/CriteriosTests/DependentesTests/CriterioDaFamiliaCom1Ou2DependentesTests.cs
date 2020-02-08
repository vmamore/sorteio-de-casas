using Sorteio.Domain.Criterios.Dependentes;
using Xunit;

namespace TestesDeUnidade.CriteriosTests.DependentesTests
{
    public sealed class CriterioDaFamiliaCom1Ou2DependentesTests : IClassFixture<CriterioDependentesFixture>
    {
        private readonly CriterioDependentesFixture _fixture;

        public CriterioDaFamiliaCom1Ou2DependentesTests(CriterioDependentesFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void CriterioDaFamiliaCom1Ou2DependentesDeveRetornarPontuacaoZeradaQuandoNaoForAtendido()
        {
            var familiaComDoisDependentesMaioresDeIdade = _fixture.FamiliaComDependentesMaioresDeIdade;

            var quantidadeDeDependentes = familiaComDoisDependentesMaioresDeIdade.ObterQuantidadeDeDependentes();

            var criterioDaFamiliaCom1Ou2Dependentes = new CriterioDaFamiliaCom1Ou2Dependentes(quantidadeDeDependentes);

            Assert.Equal(0, criterioDaFamiliaCom1Ou2Dependentes.Pontuacao.Valor);
        }

        [Fact]
        public void CriterioDaFamiliaCom1Ou2DependentesDeveRetornarPontuacaoQuandoForAtendido()
        {
            var familiaComDoisDependentesMenoresDeIdade = _fixture.FamiliaComDoisDependentesMenoresDeIdade;

            var quantidadeDeDependentes = familiaComDoisDependentesMenoresDeIdade.ObterQuantidadeDeDependentes();

            var criterioDaFamiliaCom1Ou2Dependentes = new CriterioDaFamiliaCom1Ou2Dependentes(quantidadeDeDependentes);

            Assert.Equal(2, criterioDaFamiliaCom1Ou2Dependentes.Pontuacao.Valor);
        }
    }
}
