using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class Nome : ObjetoDeValor
    {
        public string Valor { get; }
        private Nome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new NomeNaoPodeSerVazioException("Nome não pode ser vazio!");
            }
            Valor = nome;
        }

        public static Nome CriarNovo(string nome)
        {
            return new Nome(nome);
        }
    }
}
