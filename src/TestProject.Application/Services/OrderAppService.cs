using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using TestProject.Application.Interfaces;
using TestProject.Application.ViewModels;
using TestProject.Domain.Interfaces;
using TestProject.Domain.Models;

namespace TestProject.Application.Services
{
    public class OrderAppService : IOrderAppService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderAppService(IMapper mapper,
            IOrderRepository orderRepository,
            IProductRepository productRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public OrderViewModel Add(IEnumerable<ProductOrderViewModel> productsOrder)
        {
            var products = new List<Product>();

            //TO-DO: Improve logic
            foreach (var i in productsOrder)
            {
                var pd = _productRepository.GetById(i.ProductId);

                if (pd != null)
                {
                    pd.Quantity = i.Quantity;
                    products.Add(pd);
                }
            }

            //TO-DO: Add validation for empty or invalid order
            var order = new Order()
            {
                Price = products.Sum(o => o.Value * o.Quantity),
                Products = _mapper.Map<IEnumerable<Product>>(products)
            };

            _orderRepository.Add(order);

            return _mapper.Map<OrderViewModel>(order);
        }

        public IEnumerable<OrderViewModel> GetAll()
        {
            var orders = _orderRepository.GetAll();
            return _mapper.Map<IEnumerable<OrderViewModel>>(orders);
        }
    }
}
