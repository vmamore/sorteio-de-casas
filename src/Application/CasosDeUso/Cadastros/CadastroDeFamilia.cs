﻿using Application.CasosDeUso.Cadastros.Dtos;
using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Pessoas;
using Sorteio.Domain.Familias.Validacoes;
using System.Threading.Tasks;

namespace Application.CasosDeUso.Cadastros
{
    public class CadastroDeFamilia
    {
        private readonly IStatusRepository _statusRepository;
        private readonly IFamiliaRepository _familiaRepository;
        private readonly IFamiliaFactory _familiaFactory;

        public CadastroDeFamilia(
            IFamiliaRepository familiaRepository,
            IFamiliaFactory familiaFactory)
        {
            _familiaRepository = familiaRepository;
            _familiaFactory = familiaFactory;
        }

        public async Task Cadastrar(FamiliaDto familiaDto)
        {
            var status = await _statusRepository.ObterStatusPorId(familiaDto.Status);

            var familia = _familiaFactory.Criar(status);

            foreach (var pessoa in familiaDto.Pessoas)
            {
                familia.CriarPessoa(
                    _familiaFactory,
                    Nome.CriarNovo(pessoa.Nome),
                    Idade.CriarNovo(pessoa.DataDeNascimento),
                    Renda.CriarNovo(pessoa.Renda),
                    pessoa.Tipo);
            }

            var familiaPossuiUmUnicoPretendenteEUmUnicoConjuge = new FamiliaDevePossuirUmPretendenteEUmConjuge(familia);

            if (familiaPossuiUmUnicoPretendenteEUmUnicoConjuge.EhValido())
                await _familiaRepository.Adicionar(familia);

            //else
            //    familiaPossuiUmUnicoPretendenteEUmUnicoConjuge.Mensagem;
        }
    }

    public interface IStatusRepository
    {
        Task<Status> ObterStatusPorId(int id);
    }
}
