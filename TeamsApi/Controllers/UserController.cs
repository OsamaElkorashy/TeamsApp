using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApi.Entities;
using TeamsApi.Service.Implementation;
using TeamsApi.Service.Interfaces;
using TeamsApi.Services.Interfaces;
using TeamsApi.ViewModels;

namespace TeamsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserBussiness _userBussiness;
        public UserController(IUserBussiness userBussiness)
        {
            _userBussiness = userBussiness;
        }
        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterUserViewModel model)
        {
            var result = await _userBussiness.RegisterAsync(model);
            return Ok(result);
        }
        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync(TokenRequestViewModel model)
        {
            var result = await _userBussiness.GetTokenAsync(model);
            return Ok(result);
        }
    }
}
