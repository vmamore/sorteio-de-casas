using Core.Domain;
using Sorteio.Domain.Familias.Pessoas;
using System.Linq;

namespace Sorteio.Domain.Familias.Validacoes
{
    public sealed class FamiliaDevePossuirUmPretendenteEUmConjuge : IRegraDeNegocio
    {
        private readonly Familia _familia;

        public FamiliaDevePossuirUmPretendenteEUmConjuge(Familia familia)
        {
            _familia = familia;
        }

        public string Mensagem => "Familia deve possuir apenas um único pretendente e um único cônjuge";

        public bool EhValido()
        {
            var pessoas = _familia.Pessoas.Obter();

            return pessoas.Count(p => p.Tipo == Tipo.Pretendente) == 1 &&
                   pessoas.Count(p => p.Tipo == Tipo.Conjuge) == 1;
        }
    }
}
