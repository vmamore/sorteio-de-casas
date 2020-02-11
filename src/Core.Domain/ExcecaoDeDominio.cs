using System;

namespace Core.Domain
{
    public abstract class ExcecaoDeDominio : Exception
    {
        public ExcecaoDeDominio(string businessMessage) : base(businessMessage)
        {
        }

        protected string ObterNome()
        {
            return this.GetType().Name;
        }
    }
}
