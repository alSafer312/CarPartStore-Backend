using CarPartStore.Models.DTOs.Incomig;
using CarPartStore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarPartStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(AuthenticateRequest model)
        {
            var response = await _userService.Register(model);
            if (response == null)
            {
                return BadRequest("This email already exist! Didn't register!");
            }
            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }



    }


}
