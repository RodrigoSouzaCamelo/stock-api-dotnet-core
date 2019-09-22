namespace Core.Models.Interfaces
{
    public interface IViewModel<TId>
        where TId : struct
    {
        TId Id { get; set; }
    }
}