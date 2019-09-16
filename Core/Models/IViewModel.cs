namespace Core.Models
{
    public interface IViewModel<TId>
    {
        TId Id { get; set; }
    }
}