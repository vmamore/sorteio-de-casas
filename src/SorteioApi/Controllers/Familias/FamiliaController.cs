using System.Threading.Tasks;
using Application.CasosDeUso.Cadastros;
using Application.CasosDeUso.Cadastros.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace SorteioApi.Controllers.Familias
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliaController : ControllerBase
    {
        private readonly CadastroDeFamilia _cadastroDeFamilia;

        public FamiliaController(CadastroDeFamilia cadastroDeFamilia)
        {
            _cadastroDeFamilia = cadastroDeFamilia;
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
            return Ok();
        }
    }
}