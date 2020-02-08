using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Interfaces;

namespace Setup.Builders
{
    public class FamiliaBuilder
    {
        public Status _status;
        private static IFamiliaFactory _familiaFactory;

        public static FamiliaBuilder Novo(IFamiliaFactory familiaFactory)
        {
            _familiaFactory = familiaFactory;

            return new FamiliaBuilder
            {
                _status = StatusBuilder.Novo().Build(),
            };
        }

        public Familia Build()
        {
            return _familiaFactory.Criar(_status);
        }
    }
}
