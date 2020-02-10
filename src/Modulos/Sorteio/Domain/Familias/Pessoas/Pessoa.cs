using Core.Domain;
using System;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class Pessoa : Entidade
    {
        public FamiliaId FamiliaId { get; }
        public PessoaId Id { get; }
        public Nome Nome { get; }
        public Idade Idade { get; }
        public Renda Renda { get; }
        public Tipo Tipo { get; }

        public Familia Familia { get; }

        public Pessoa(FamiliaId familiaId, Nome nome, Idade idade, Tipo tipo, Renda renda = null)
        {
            Id = new PessoaId(Guid.NewGuid());
            FamiliaId = familiaId;
            Nome = nome;
            Idade = idade;
            Tipo = tipo;
            Renda = renda;
        }

        public bool EhPretendente()
        {
            return this.Tipo == Tipo.Pretendente;
        }

        public bool EhDependente()
        {
            return this.Tipo == Tipo.Dependente;
        }

        public int ObterIdade()
        {
            return this.Idade.Obter();
        }

        public bool EhMaiorDeIdade()
        {
            return this.Idade.MaiorQueDezoito();
        }
    }
}
