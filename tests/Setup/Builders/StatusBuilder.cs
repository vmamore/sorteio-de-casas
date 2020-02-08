using Sorteio.Domain.Familias;

namespace Setup.Builders
{
    public class StatusBuilder
    {
        private int _id;
        private string _descricao;
        private bool _cadastroValido;

        public static StatusBuilder Novo()
        {
            return new StatusBuilder
            {
                _id = 0,
                _descricao = "TESTE",
                _cadastroValido = true
            };
        }

        public Status Build()
        {
            return new Status(_id, _descricao, _cadastroValido);
        }
    }
}
