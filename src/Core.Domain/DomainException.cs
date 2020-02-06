using System;

namespace Core.Domain
{
    public class DomainException : Exception
    {
        public DomainException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
