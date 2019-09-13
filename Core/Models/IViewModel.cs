namespace Core.Models
{
    public interface IViewModel<TId> where TId : class
    {
        TId Id { get; set; }
    }
}