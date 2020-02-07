﻿using Sorteio.Domain.Criterios;
using Sorteio.Domain.Familias;
using System.Collections.ObjectModel;

namespace Sorteio.Domain.CalculadoraDePontos
{
    public class CalculadoraDePontosApartirDaQuantidadeDeDependentes : CalculadoraDePontosBase
    {
        public CalculadoraDePontosApartirDaQuantidadeDeDependentes(Familia familia)
        {
            var quantidadeDeDependentes = familia.ObterQuantidadeDeDependentes();

            Criterios = new Collection<ICriterioBase>()
            {
                new CriterioDaFamiliaCom3OuMaisDependentes(quantidadeDeDependentes),
                new CriterioDaFamiliaCom1Ou2Dependentes(quantidadeDeDependentes)
            };
        }
    }
}