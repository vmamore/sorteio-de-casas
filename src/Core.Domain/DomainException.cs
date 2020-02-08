using System;

namespace Core.Domain
{
    public abstract class DomainException : Exception
    {
        public DomainException(string businessMessage) : base(businessMessage)
        {
        }

        protected string ObterNome()
        {
            return this.GetType().Name;
        }
    }
}
