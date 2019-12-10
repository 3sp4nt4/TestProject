using Microsoft.AspNetCore.Mvc;

namespace TestProject.API.Controllers
{
    public abstract class ApiController : ControllerBase
    {
        protected new IActionResult Response(object result = null)
        {
            //TO-DO: Add support for error response

            return Ok(new
            {
                success = true,
                data = result
            });
        }
    }
}
