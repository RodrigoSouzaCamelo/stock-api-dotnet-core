namespace Core.Models
{
    public abstract class ViewModel<TId> : IViewModel<TId>
        where TId : struct
    {
        public virtual TId Id { get; set; }
    }
}