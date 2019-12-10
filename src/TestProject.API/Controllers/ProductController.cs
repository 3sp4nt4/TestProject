using Microsoft.AspNetCore.Mvc;
using TestProject.Application.Interfaces;

namespace TestProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ApiController
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Response(_productAppService.GetAll());
        }
    }
}