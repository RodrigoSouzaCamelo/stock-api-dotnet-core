namespace Core.Models
{
    public class ViewModel<TId> : IViewModel<TId> where TId : class
    {
        public virtual TId Id { get; set; }
    }
}