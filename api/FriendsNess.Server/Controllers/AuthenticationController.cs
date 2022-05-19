using FriendsNess.Server.Services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FriendsNess.Server.Controllers
{
    public class AuthenticationController : RootController
    {
        public AuthenticationController(IUnitOfRepositories unitOfRepositories, ILogger<AuthenticationController> logger) : base(unitOfRepositories, logger)
        {
        }

        //[HttpGet]
        //public ActionResult<> Login()
        //{

        //}

        //public ActionResult Register()
        //{

        //}
    }
}
