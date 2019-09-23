using Core.Models;

namespace Api.Data.Models
{
    public class UserVM : ViewModel<int>
    {
      public string Name { get; set; }  
    }
}