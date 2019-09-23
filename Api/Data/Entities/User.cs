using Core.Entities;

namespace Api.Data.Entities
{
    public class User : Entity<int>
    {
        public string Name { get; set; }
    }
}