using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TestProject.Application.AutoMapper;
using TestProject.Application.Interfaces;
using TestProject.Application.Services;
using TestProject.Domain.Interfaces;
using TestsProject.Infra.Data.DbAbstraction;
using TestsProject.Infra.Data.Repository;

namespace TestProject.Infra.CrossCutting.IoC
{
    public class InjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<IOrderAppService, OrderAppService>();
            services.AddScoped<IProductAppService, ProductAppService>();

            // Infra - Data
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }

        public static void ConfigureMappings(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }

        public static void InitMemoryDb()
        {
            MemoryDb.Init();
        }
    }
}
