﻿using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class NomeNaoPodeSerVazioException : ExcecaoDeDominio
    {
        public NomeNaoPodeSerVazioException(string businessMessage) 
            : base(businessMessage)
        {
        }
    }
}
