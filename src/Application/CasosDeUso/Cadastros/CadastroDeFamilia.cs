using Application.CasosDeUso.Cadastros.Dtos;
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

        public CadastroDeFamilia(
            IFamiliaRepository familiaRepository,
            IFamiliaFactory familiaFactory)
        {
            _familiaRepository = familiaRepository;
            _familiaFactory = familiaFactory;
        }

        public async Task<Resultado> Cadastrar(FamiliaDto familiaDto)
        {
            var status = await _familiaRepository.ObterStatusPorId(familiaDto.Status);

            var familia = _familiaFactory.Criar(status);

            foreach (var pessoa in familiaDto.Pessoas)
            {
                familia.CriarPessoa(
                    Nome.CriarNovo(pessoa.Nome),
                    Idade.CriarNovo(pessoa.DataDeNascimento),
                    pessoa.Tipo,
                    Renda.CriarNovo(pessoa.Renda));
            }

            var familiaPossuiUmUnicoPretendenteEUmUnicoConjuge = new FamiliaDevePossuirUmPretendenteEUmConjuge(familia);

            if (!familiaPossuiUmUnicoPretendenteEUmUnicoConjuge.EhValido())
                return Resultado.Erro(familiaPossuiUmUnicoPretendenteEUmUnicoConjuge.Mensagem);

            await _familiaRepository.Adicionar(familia);

            return Resultado.OK();
        }
    }
}
