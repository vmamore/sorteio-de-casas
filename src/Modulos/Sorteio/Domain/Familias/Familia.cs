﻿using Sorteio.Domain.Familias.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorteio.Domain.Familias
{
    public sealed class Familia
    {
        public FamiliaId Id { get; }
        public Status Status { get; }
        public IList<Pessoa> Pessoas { get; }

        protected Familia() { }
        public Familia(Status status)
        {
            Id = new FamiliaId(Guid.NewGuid());
            Status = status;
            Pessoas = new List<Pessoa>();
        }

        public bool Validar()
        {
            return Pessoas.Count(p => p.Tipo == Tipo.Pretendente) == 1 &&
                   Pessoas.Count(p => p.Tipo == Tipo.Conjuge) == 1;
        }

        public Pessoa CriarPessoa(Nome nome, Idade idade, Tipo tipo, Renda renda = null)
        {
            var pessoa = new Pessoa(this.Id, nome, idade, tipo, renda);
            this.Pessoas.Add(pessoa);
            return pessoa;
        }

        public Dinheiro ObterRendaTotal()
        {
            var dinheiroTotal = Dinheiro.CriarNovo(0);

            foreach (var pessoa in Pessoas)
            {
                if (!pessoa.PossuiRenda())
                    continue;

                dinheiroTotal = pessoa.Renda.Somar(dinheiroTotal);
            }

            return dinheiroTotal;
        }

        public Pessoa ObterPretendente()
        {
            return Pessoas.SingleOrDefault(
                pessoa => pessoa.EhPretendente());
        }

        public int ObterQuantidadeDeDependentes()
        {
            return Pessoas.Count(pessoa => pessoa.EhDependente() &&
                                          !pessoa.EhMaiorDeIdade());
        }
    }
}
