using Sorteio.Domain.Familias.Pessoas;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.CasosDeUso.Cadastros.Dtos
{
    public class PessoaDto
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        public decimal Renda { get; set; }

        [Required]
        public Tipo Tipo { get; set; }
    }
}
