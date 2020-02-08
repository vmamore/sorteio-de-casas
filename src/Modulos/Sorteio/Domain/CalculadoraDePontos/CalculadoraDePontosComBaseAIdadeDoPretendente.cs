using Sorteio.Domain.Criterios;
using Sorteio.Domain.Criterios.IdadeDoPretendente;
using Sorteio.Domain.Familias;
using System.Collections.ObjectModel;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public class CalculadoraDePontosComBaseAIdadeDoPretendente : CalculadoraDePontosBase
    {
        public CalculadoraDePontosComBaseAIdadeDoPretendente(Familia familia)
        {
            var idadeDoPretendente = familia.ObterPretendente().Idade;

            Criterios = new Collection<ICriterioBase>()
            {
                new CriterioDaIdadeDoPretendenteIgualOuAcimaDe45Anos(idadeDoPretendente),
                new CriterioDaIdadeDoPretendenteDe30A44Anos(idadeDoPretendente),
                new CriterioDaIdadeDoPretendenteAbaixoDos30Anos(idadeDoPretendente)
            };
        }
    }
}
