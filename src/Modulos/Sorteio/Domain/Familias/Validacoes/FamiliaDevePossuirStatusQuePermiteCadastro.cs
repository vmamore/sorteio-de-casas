using Core.Domain;

namespace Sorteio.Domain.Familias.Validacoes
{
    public sealed class FamiliaDevePossuirStatusQuePermiteCadastro : IRegraDeNegocio
    {
        private readonly Status _status;

        public FamiliaDevePossuirStatusQuePermiteCadastro(Status status)
        {
            this._status = status;
        }
        public string Mensagem => _status.Descricao;

        public bool EhValido()
        {
            return _status.CadastroValido;
        }
    }
}
