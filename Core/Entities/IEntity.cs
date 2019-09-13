namespace Core.Entities
{
    public interface IEntity<TId> where TId : class
    {
        TId Id { get; set; }
    }
}