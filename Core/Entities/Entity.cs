namespace Core.Entities
{
    public class Entity<TId> : IEntity<TId> where TId : class
    {
        public virtual TId Id { get; set; }
    }
}