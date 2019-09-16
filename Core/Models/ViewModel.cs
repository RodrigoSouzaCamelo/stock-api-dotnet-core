namespace Core.Models
{
    public abstract class ViewModel<TId> : IViewModel<TId> where TId : class
    {
        public virtual TId Id { get; set; }
    }
}