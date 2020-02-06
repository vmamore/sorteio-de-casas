using Core.Domain;
using System;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class PessoaId : IdTipadoBase
    {
        public PessoaId(Guid valor) : base(valor)
        {
        }
    }
}
