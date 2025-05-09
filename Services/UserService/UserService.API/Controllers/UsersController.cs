using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserService.Application.Users.Events;
using UserService.Application.Users.DTOs;

namespace UserService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Require JWT token
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("secure-data")]
        public IActionResult GetSecureData()
        {
            var username = User.Identity?.Name;
            return Ok($"Welcome {username}, this is protected data.");
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            // Simulate user creation
            var emailId = request.EmailID;
            var userName = request.UserName;

            // Publish the UserCreatedEvent
            await _mediator.Publish(new UserCreatedEvent(emailId, userName));

            return Ok(new { EmailID = emailId, UserName = userName });
        }
    }
}
