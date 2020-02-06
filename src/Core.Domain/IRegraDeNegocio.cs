namespace Core.Domain
{
    public interface IRegraDeNegocio
    {
        bool EhValido();

        string Mensagem { get; }
    }
}
