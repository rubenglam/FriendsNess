using FriendsNess.Server.Services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FriendsNess.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class RootController : ControllerBase
    {
        private readonly IUnitOfRepositories _unitOfRepositories;
        private readonly ILogger _logger;
        
        public RootController(IUnitOfRepositories unitOfRepositories, ILogger logger)
        {
            _unitOfRepositories = unitOfRepositories;
            _logger = logger;
        }

        protected IUnitOfRepositories UnitOfRepositories
        {
            get => _unitOfRepositories;
        }

        protected ILogger Logger
        {
            get => _logger;
        }
    }
}
