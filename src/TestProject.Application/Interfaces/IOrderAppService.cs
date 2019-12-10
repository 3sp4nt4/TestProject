using System.Collections.Generic;
using TestProject.Application.ViewModels;

namespace TestProject.Application.Interfaces
{
    public interface IOrderAppService
    {
        OrderViewModel Add(IEnumerable<ProductOrderViewModel> productsOrder);

        IEnumerable<OrderViewModel> GetAll();
    }
}
