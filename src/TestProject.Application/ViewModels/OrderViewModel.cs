using System.Collections.Generic;

namespace TestProject.Application.ViewModels
{
    public class OrderViewModel
    {
        public string OrderId { get; set; }

        public double Price { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
