using System.Collections.Generic;
using TestProject.Application.ViewModels;

namespace TestProject.Application.Interfaces
{
    public interface IProductAppService
    {
        IEnumerable<ProductViewModel> GetAll();
    }
}
