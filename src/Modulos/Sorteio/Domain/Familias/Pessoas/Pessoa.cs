using Core.Domain;
using Sorteio.Domain.Familias.Rendas;
using System;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class Pessoa : Entidade
    {
        public PessoaId Id { get; }
        public Nome Nome { get; }
        public Idade Idade { get; }
        public Renda Renda { get;  }
        public Tipo Tipo { get; }

        public Pessoa(string nome, DateTime dataDeNascimento)
        {
            Nome = Nome.CriarNovo(nome);
            Idade = Idade.CriarNovo(dataDeNascimento);
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
