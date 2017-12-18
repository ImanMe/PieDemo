using System.Collections.Generic;

namespace DemoApp.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
