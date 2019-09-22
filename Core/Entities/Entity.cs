using Core.Entities.Interfaces;

namespace Core.Entities
{
    public abstract class Entity<TId> : IEntity<TId> 
        where TId : struct
    {
        public virtual TId Id { get; set; }
    }
}