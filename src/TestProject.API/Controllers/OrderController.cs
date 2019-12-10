using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestProject.Application.Interfaces;
using TestProject.Application.ViewModels;

namespace TestProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ApiController
    {
        IOrderAppService _orderAppService;

        public OrderController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Response(_orderAppService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody]IEnumerable<ProductOrderViewModel> productsOrder)
        {
            return Response(_orderAppService.Add(productsOrder));
        }
    }
}