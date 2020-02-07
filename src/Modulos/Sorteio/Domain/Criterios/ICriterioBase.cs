namespace Sorteio.Domain.Criterios
{
    public interface ICriterioBase
    {
        int Pontuacao { get; }
        bool EhAtendido();
    }
}
