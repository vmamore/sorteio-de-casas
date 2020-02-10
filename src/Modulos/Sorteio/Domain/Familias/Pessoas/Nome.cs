using Core.Domain;

namespace Sorteio.Domain.Familias.Pessoas
{
    public sealed class Nome : ObjetoDeValor
    {
        private readonly string texto;
        private Nome(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                throw new NomeNaoPodeSerVazioException("Nome não pode ser vazio!");
            }
            this.texto = texto;
        }

        public static Nome CriarNovo(string nome)
        {
            return new Nome(nome);
        }

        public override string ToString()
        {
            return this.texto;
        }
    }
}
