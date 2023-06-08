using FPT_Exchange_API.Configurations.Middleware;
using FPT_Exchange_Data.DTO.Internal;
using FPT_Exchange_Data.DTO.Request.Post;
using FPT_Exchange_Service.Implementations;
using FPT_Exchange_Utility.Constants;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FPT_Exchange_API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        public AuthController(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> AuthenticatedUser([FromBody][Required] AuthRequest auth)
        {
            var customer = await _authService.AuthenticatedUser(auth);
            if (customer != null)
            {
                return Ok(customer);
            }
            else
            {
                return NotFound("Not Found This User");
            }
        }

        [HttpGet]
        [Authorize(UserRole.Admin, UserRole.Staff, UserRole.Customer)]
        public async Task<IActionResult> GetCurrentUser()
        {
            var user = (AuthModel)HttpContext.Items["User"]!;
            if (user != null)
            {
                var result = await _userService.GetUser(user.Id);
                if (result is JsonResult jsonResult)
                {
                    return Ok(jsonResult.Value);
                }
            }
            return Unauthorized("Unauthorized");
        }
    }
}
