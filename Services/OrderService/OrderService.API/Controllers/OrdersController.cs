using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Require JWT token
    public class OrdersController : ControllerBase
    {
        [HttpGet("secure-order")]
        public IActionResult GetSecureOrder()
        {
            var username = User.Identity?.Name;
            return Ok($"Welcome {username}, this is protected data from Order service.");
        }
    }
}
