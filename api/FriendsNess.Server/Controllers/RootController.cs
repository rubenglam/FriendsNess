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
    }
}
