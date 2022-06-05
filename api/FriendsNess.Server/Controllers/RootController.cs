using FriendsNess.Core.Dtos;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FriendsNess.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class RootController : ControllerBase
    {
        private readonly ILogger _logger;
        
        public RootController(ILogger logger)
        {
            _logger = logger;
        }

        protected ILogger Logger
        {
            get => _logger;
        }

        protected ActionResult Success()
        {
            return Ok();
        }

        protected ActionResult Success<T>(T response)
        {
            return Ok(response);
        }

        protected ActionResult Error(ApiException apiException)
        {
            var response = new ErrorResponse(apiException.Errors);
            return BadRequest(response);
        }

        protected ActionResult Error(Exception exception)
        {
            var errorResponse = new ErrorResponse(exception.Message);
            return BadRequest(errorResponse);
        }
    }
}
