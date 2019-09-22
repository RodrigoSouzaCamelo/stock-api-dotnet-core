namespace Core.Entities.Interfaces
{
    public interface IEntity<TId>
        where TId : struct
    {
        TId Id { get; set; }
    }
}