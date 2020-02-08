using InMemoryDataAccess;
using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Pessoas;
using System;

namespace TestesDeUnidade.CriteriosTests.DependentesTests
{
    public sealed class CriterioDependentesFixture
    {
        public CriterioDependentesFixture()
        {
            FamiliaFactory = new FamiliaFactory();

            Status = new Status(
                1,
                "Status Teste",
                true);
        }

        public FamiliaFactory FamiliaFactory { get; }
        public Status Status { get; set; }
        public Familia FamiliaComDependentesMaioresDeIdade
        {
            get
            {
                return CriarCenarioComDependentesMaioresDeIdade();
            }
        }
        private Familia CriarCenarioComDependentesMaioresDeIdade()
        {
            var familiaComDoisDependentesMaioresDeIdade = FamiliaFactory.Criar(
                   Status);

            FamiliaFactory.CriarPessoa(
                familiaComDoisDependentesMaioresDeIdade,
                Nome.CriarNovo("Pretendente"),
                Idade.CriarNovo(new DateTime(1997, 10, 25)),
                Tipo.Pretendente,
                Renda.CriarNovo(1000));

            FamiliaFactory.CriarPessoa(
                familiaComDoisDependentesMaioresDeIdade,
                Nome.CriarNovo("Conjugue"),
                Idade.CriarNovo(new DateTime(1997, 01, 01)),
                Tipo.Conjuge,
                Renda.CriarNovo(500));

            FamiliaFactory.CriarPessoa(
               familiaComDoisDependentesMaioresDeIdade,
               Nome.CriarNovo("Dependente 1"),
               Idade.CriarNovo(new DateTime(1997, 01, 01)),
               Tipo.Dependente);

            FamiliaFactory.CriarPessoa(
               familiaComDoisDependentesMaioresDeIdade,
               Nome.CriarNovo("Dependente 2"),
               Idade.CriarNovo(new DateTime(1997, 01, 01)),
               Tipo.Dependente);

            return familiaComDoisDependentesMaioresDeIdade;
        }

        public Familia FamiliaComDoisDependentesMenoresDeIdade
        {
            get
            {
                return CriarCenarioComDependentesMenoresDeIdade();
            }
        }

        private Familia CriarCenarioComDependentesMenoresDeIdade()
        {
            var familiaComDoisDependentesMenoresDeIdade = FamiliaFactory.Criar(
                   Status);

            FamiliaFactory.CriarPessoa(
                 familiaComDoisDependentesMenoresDeIdade,
                 Nome.CriarNovo("Pretendente"),
                 Idade.CriarNovo(new DateTime(1997, 10, 25)),
                 Tipo.Pretendente,
                 Renda.CriarNovo(1000));

            FamiliaFactory.CriarPessoa(
                familiaComDoisDependentesMenoresDeIdade,
                Nome.CriarNovo("Conjugue"),
                Idade.CriarNovo(new DateTime(1997, 01, 01)),
                Tipo.Conjuge,
                Renda.CriarNovo(500));

            FamiliaFactory.CriarPessoa(
               familiaComDoisDependentesMenoresDeIdade,
               Nome.CriarNovo("Dependente 1"),
               Idade.CriarNovo(new DateTime(2010, 01, 01)),
               Tipo.Dependente);

            FamiliaFactory.CriarPessoa(
               familiaComDoisDependentesMenoresDeIdade,
               Nome.CriarNovo("Dependente 2"),
               Idade.CriarNovo(new DateTime(2010, 01, 01)),
               Tipo.Dependente);

            return familiaComDoisDependentesMenoresDeIdade;
        }

        public Familia FamiliaComTresDependentesMenoresDeIdade
        {
            get
            {

                return CriarCenarioComTresDependentesMenoresDeIdade();
            }
        }

        private Familia CriarCenarioComTresDependentesMenoresDeIdade()
        {
            var familiaComTresDependentesMenoresDeIdade = FamiliaFactory.Criar(
                Status);

            FamiliaFactory.CriarPessoa(
                familiaComTresDependentesMenoresDeIdade,
                Nome.CriarNovo("Pretendente"),
                Idade.CriarNovo(new DateTime(1997, 10, 25)),
                Tipo.Pretendente,
                Renda.CriarNovo(1000));

            FamiliaFactory.CriarPessoa(
                familiaComTresDependentesMenoresDeIdade,
                Nome.CriarNovo("Conjugue"),
                Idade.CriarNovo(new DateTime(1997, 01, 01)),
                Tipo.Conjuge,
                Renda.CriarNovo(500));

            FamiliaFactory.CriarPessoa(
               familiaComTresDependentesMenoresDeIdade,
               Nome.CriarNovo("Dependente 1"),
               Idade.CriarNovo(new DateTime(2010, 01, 01)),
               Tipo.Dependente);

            FamiliaFactory.CriarPessoa(
               familiaComTresDependentesMenoresDeIdade,
               Nome.CriarNovo("Dependente 2"),
               Idade.CriarNovo(new DateTime(2010, 01, 01)),
               Tipo.Dependente);

            FamiliaFactory.CriarPessoa(
               familiaComTresDependentesMenoresDeIdade,
               Nome.CriarNovo("Dependente 3"),
               Idade.CriarNovo(new DateTime(2010, 01, 01)),
               Tipo.Dependente);

            return familiaComTresDependentesMenoresDeIdade;
        }
    }
}
