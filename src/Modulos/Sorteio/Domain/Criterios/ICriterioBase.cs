using Sorteio.Domain.CalculadoraDePontos;

namespace Sorteio.Domain.Criterios
{
    public interface ICriterioBase
    {
        Pontuacao Pontuacao { get; }
        bool EhAtendido();
        string ObterNome();
    }
}
