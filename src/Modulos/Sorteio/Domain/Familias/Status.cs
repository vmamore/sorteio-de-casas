﻿using Core.Domain;

namespace Sorteio.Domain.Familias
{
    public sealed class Status : Entidade
    {
        public int Id { get; }
        public string Descricao { get; set; }
        public bool CadastroValido { get; }

        public Status(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
