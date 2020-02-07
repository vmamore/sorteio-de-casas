using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.CasosDeUso.Cadastros.Dtos
{
    public class FamiliaDto
    {
        [Required]
        public int Status { get; set; }
        [Required]
        public IEnumerable<PessoaDto> Pessoas { get; set; }
    }
}
