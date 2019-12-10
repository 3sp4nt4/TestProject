using AutoMapper;
using System.Collections.Generic;
using TestProject.Application.Interfaces;
using TestProject.Application.ViewModels;
using TestProject.Domain.Interfaces;

namespace TestProject.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductAppService(IMapper mapper,
            IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(_productRepository.GetAll());
        }
    }
}
