namespace Core.Models
{
    public abstract class ViewModel<TId> : IViewModel<TId>
    {
        public virtual TId Id { get; set; }
    }
}