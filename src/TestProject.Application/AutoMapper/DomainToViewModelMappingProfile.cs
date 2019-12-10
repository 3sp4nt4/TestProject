using AutoMapper;
using TestProject.Application.ViewModels;
using TestProject.Domain.Models;

namespace TestProject.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Order, OrderViewModel>()
                .ForMember(dest => dest.OrderId, o => o.MapFrom(s => s.Id.ToString()));

            CreateMap<Product, ProductViewModel>();
        }
    }
}
