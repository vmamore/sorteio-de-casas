using System.Threading.Tasks;
using Application.CasosDeUso.Cadastros;
using Application.CasosDeUso.Cadastros.Dtos;
using Microsoft.AspNetCore.Mvc;
using Sorteio.Domain.Criterios.Interfaces;

namespace SorteioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliaController : ControllerBase
    {
        private readonly CadastroDeFamilia _cadastroDeFamilia;
        private readonly IResultadoDaAvaliacaoDosCriteriosRepository _resultadoDaAvaliacaoDosCriteriosRepository; 

        public FamiliaController(CadastroDeFamilia cadastroDeFamilia,
            IResultadoDaAvaliacaoDosCriteriosRepository resultadoDaAvaliacaoDosCriteriosRepository)
        {
            _cadastroDeFamilia = cadastroDeFamilia;
            _resultadoDaAvaliacaoDosCriteriosRepository = resultadoDaAvaliacaoDosCriteriosRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(FamiliaDto familiaDto) 
        {
            var resultado = await _cadastroDeFamilia.Cadastrar(familiaDto);

            if (resultado.Falhou) return BadRequest(resultado.MensagemDeErro);

            return Ok();
        }

        [HttpGet("resultado-sorteio")]
        public async Task<IActionResult> ObterFamiliasParaSorteio()
        {
            var resultados = await _resultadoDaAvaliacaoDosCriteriosRepository.ObterFamiliasOrdenadasPorPontuacao();

            return Ok(resultados);
        }
    }
}