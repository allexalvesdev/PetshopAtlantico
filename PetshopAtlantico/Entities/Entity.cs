using System;

namespace PetshopAtlantico.Entities
{
    public abstract class Entity
    {

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
