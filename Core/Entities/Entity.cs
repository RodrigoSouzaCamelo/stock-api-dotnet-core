namespace Core.Entities
{
    public class Entity<TId> : IEntity<TId> 
    {
        public virtual TId Id { get; set; }
    }
}