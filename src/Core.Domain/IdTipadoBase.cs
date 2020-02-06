using System;

namespace Core.Domain
{
    public abstract class IdTipadoBase : IEquatable<IdTipadoBase>
    {
        public Guid Valor { get; }

        public IdTipadoBase(Guid valor)
        {
            if(valor == Guid.Empty)
            {
                throw new InvalidOperationException("Valor do Id não pode ser vazio!");
            }

            Valor = valor;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is IdTipadoBase outro && Equals(outro);
        }

        public bool Equals(IdTipadoBase outroId)
        {
            return this.Valor == outroId.Valor;
        }

        public static bool operator ==(IdTipadoBase obj1, IdTipadoBase obj2)
        {
            if(object.Equals(obj1, null))
            {
                if(object.Equals(obj2, null))
                {
                    return true;
                }

                return false;
            }

            return obj1.Equals(obj2);
        }

        public static bool operator !=(IdTipadoBase obj1, IdTipadoBase obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
