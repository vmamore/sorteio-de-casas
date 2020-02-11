using Application.CasosDeUso.Cadastros.Dtos;
using Application.CasosDeUso.CalculoDePontos;
using Core.Domain;
using Sorteio.Domain.Familias.Interfaces;
using Sorteio.Domain.Familias.Pessoas;
using Sorteio.Domain.Familias.Validacoes;
using System.Threading.Tasks;

namespace Application.CasosDeUso.Cadastros
{
    public class CadastroDeFamilia
    {
        private readonly IFamiliaRepository _familiaRepository;
        private readonly IFamiliaFactory _familiaFactory;

        private readonly CalculoDePontosDosCriteriosAtendidos _calculoDePontosDosCriteriosAtendidos;

        public CadastroDeFamilia(
            IFamiliaRepository familiaRepository,
            IFamiliaFactory familiaFactory,
            CalculoDePontosDosCriteriosAtendidos calculoDePontosDosCriteriosAtendidos)
        {
            _familiaRepository = familiaRepository;
            _familiaFactory = familiaFactory;
            _calculoDePontosDosCriteriosAtendidos = calculoDePontosDosCriteriosAtendidos;
        }

        public async Task<Resultado> Cadastrar(FamiliaDto familiaDto)
        {
            var status = await _familiaRepository.ObterStatus(familiaDto.StatusId);

            var familia = _familiaFactory.Criar(status);

            foreach (var pessoa in familiaDto.Pessoas)
            {
                familia.CriarPessoa(
                    Nome.CriarNovo(pessoa.Nome),
                    Idade.CriarNovo(pessoa.DataDeNascimento),
                    pessoa.Tipo,
                    pessoa.Renda.HasValue ? Renda.CriarNovo(pessoa.Renda.Value) : null);
            }

            var familiaPossuiUmUnicoPretendenteEUmUnicoConjuge = new FamiliaDevePossuirUmPretendenteEUmConjuge(familia);

            if (!familiaPossuiUmUnicoPretendenteEUmUnicoConjuge.EhValido())
                return Resultado.Erro(familiaPossuiUmUnicoPretendenteEUmUnicoConjuge.Mensagem);

            await _familiaRepository.Adicionar(familia);

            if(familia.Status.CadastroValido)
                await _calculoDePontosDosCriteriosAtendidos.Executar(familia);

            return Resultado.OK();
        }
    }
}
