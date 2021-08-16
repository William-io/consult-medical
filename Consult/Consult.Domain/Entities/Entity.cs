using System;

namespace Consult.Domain.Entities
{
    //Class base dont instance, Type Comparison of IEquatable to return ID

    public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; protected set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }

}